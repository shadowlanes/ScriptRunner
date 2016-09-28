using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScriptRunner
{
    public class DBEngine
    {
        string connectionString { get; set; }
        string folderPath { get; set; }
        List<string> scripts { get; set; }
        public DataTable executionData { get; set; }
        //ctor
        public DBEngine(string dbServerLocation, string userId, string pwd, string defaultDB)
        {
            SqlConnection cnn;
            connectionString = String.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", dbServerLocation, defaultDB, userId, pwd);
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            //TODO log
            cnn.Close();
        }

        public void SetScriptLocations(string folderPath, string[] scriptLocations)
        {
            this.folderPath = folderPath;
            scripts = scriptLocations.ToList();
            PrepareDataTable(scripts);
        }

        public List<string> Analyze()
        {
            List<string> faultyScripts = new List<string>();
            scripts.ForEach(script =>
            {
                var content = File.ReadAllLines(script);
                foreach (var line in content)
                {
                    if (line.IndexOf("DROP TABLE", StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        faultyScripts.Add(GetScriptNameFromPath(script));
                        break;
                    }
                }
            });

            return faultyScripts;
        }


        public void Generate(string tenantNames)
        {
            var tenants = tenantNames.Split(',').ToList();
            tenants.ForEach(tenant =>
            {
                scripts.ForEach(script =>
                {
                    var fileName = GetScriptNameFromPath(script);
                    if (fileName.ToLower().Contains("PFTPH".ToLower()))
                    {
                        //first generate new file name
                        var newFileName = Regex.Replace(fileName, "PFTPH", tenant, RegexOptions.IgnoreCase);
                        var newFilePath = folderPath + @"\\" + newFileName;
                        File.Copy(script, newFilePath);
                        //now replace content also
                        string content = File.ReadAllText(newFilePath);
                        string modifiedContent = Regex.Replace(content, "PFTPH", tenant, RegexOptions.IgnoreCase);
                        File.WriteAllText(newFilePath, modifiedContent);
                    }
                });
            });

            //Reload the result db
            scripts = Directory.GetFiles(folderPath).ToList();
            PrepareDataTable(Directory.GetFiles(folderPath).ToList());
        }

        public void Parse()
        {
            var scriptCounter = 0;
            scripts.ForEach(script =>
            {
                //update datatable
                executionData.Rows[scriptCounter]["Parsed?"] = "No";
                var row = executionData.Rows[scriptCounter];
                scriptCounter++;
            });
            scriptCounter = 0;
            scripts.ForEach(script =>
            {
                //read each script
                var content = File.ReadAllText(script);
                var isParsed = ExecuteScript(content,true);
                //update datatable
                executionData.Rows[scriptCounter]["Parsed?"] = "Yes";
                scriptCounter++;
            });
        }


        public void Execute()
        {
            var scriptCounter = 0;
            scripts.ForEach(script =>
            {
                //update datatable
                executionData.Rows[scriptCounter]["Executed?"] = "No";
                scriptCounter++;
            });
            scriptCounter = 0;
            scripts.ForEach(script =>
            {
                //read each script
                var content = File.ReadAllText(script);
                var isParsed = ExecuteScript(content, false);
                //update datatable
                executionData.Rows[scriptCounter]["Executed?"] = "Yes";
                scriptCounter++;
            });
        }


        private bool ExecuteScript(string scriptContent, bool isParseOnly)
        {
            var isParsed = false;
            var content =  scriptContent;
            if (isParseOnly)
                 content = "SET NOEXEC ON;" + content;
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            try
            {
                using (var command = new SqlCommand(content, cnn))
                {
                    command.ExecuteNonQuery();
                }
                isParsed = true;
            }
            finally
            {
                cnn.Close();
            }
            return isParsed;
        }

        private void PrepareDataTable(List<string> scripts)
        {
            executionData = new DataTable();
            AddColumns(executionData);
            AddValues(executionData);
        }



        private void AddColumns(DataTable dt)
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Parsed?");
            dt.Columns.Add("Executed?");
        }

        private void AddValues(DataTable dt)
        {
            scripts.ForEach(script =>
            {
                var row = executionData.NewRow();
                row["Name"] = GetScriptNameFromPath(script); ;
                dt.Rows.Add(row);
            });
        }

        private string GetScriptNameFromPath(string fullPath)
        {
            return fullPath.Split('\\').ToList().Last();
        }
    }
}
