using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ScriptRunner
{
    public partial class ScriptRunner : Form
    {
        public DBEngine dbEngine { get; set; }
        public ScriptRunner()
        {
            InitializeComponent();
            //disable all buttons
            ToggleButtonEnable(false);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbConStatus.BackColor = Color.Yellow;
            //Conect to DB
            try
            {
                dbEngine = new DBEngine(txt_dbServer.Text, txt_userId.Text, txt_Pwd.Text, txt_dbname.Text);
                dbConStatus.BackColor = Color.Green;
                ToggleButtonEnable(true);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Failed \n" + ex.Message);
                dbConStatus.BackColor = Color.Red;
            }
        }

        private void folderSelector_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                dbEngine.SetScriptLocations(folderBrowserDialog.SelectedPath,files);
                scriptsResults.DataSource = dbEngine.executionData;
                MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
        }

        private void Analyzer_Click(object sender, EventArgs e)
        {
            var res = dbEngine.Analyze();

            //format result 
            StringBuilder result = new StringBuilder();
            res.ForEach(eachScript => {
                result.Append(eachScript);
                result.Append(Environment.NewLine);
            });

            MessageBox.Show(result.ToString());
        }

        private void Generator_Click(object sender, EventArgs e)
        {
            //validate user has entered some values
            if(String.IsNullOrWhiteSpace(txt_tenantNames.Text))
            {
                MessageBox.Show("Unable to proceed: Please enter some text");
                return;
            }
            //generate scripts for new tenants
            dbEngine.Generate(txt_tenantNames.Text);
            //redraw datagrid
            scriptsResults.DataSource = null;
            scriptsResults.DataSource = dbEngine.executionData;
            
        }

        private void Parser_Click(object sender, EventArgs e)
        {
            try
            {
                dbEngine.Parse();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Parse Failed: Error Message:\n" + ex.Message);
            }
            //redraw datagrid
            scriptsResults.DataSource = null;
            scriptsResults.DataSource = dbEngine.executionData;
        }

        private void Executor_Click(object sender, EventArgs e)
        {
            try
            {
                dbEngine.Execute();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Parse Failed: Error Message:\n" + ex.Message);
            }
            //redraw datagrid
            scriptsResults.DataSource = null;
            scriptsResults.DataSource = dbEngine.executionData;
        }
        private void ToggleButtonEnable(bool isEnabled)
        {
            folderSelector.Enabled = isEnabled;
            Analyzer.Enabled = isEnabled;
            Generator.Enabled = isEnabled;
            Parser.Enabled = isEnabled;
            Executor.Enabled = isEnabled;
        }
    }
}
