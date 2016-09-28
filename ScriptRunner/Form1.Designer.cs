namespace ScriptRunner
{
    partial class ScriptRunner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_dbServer = new System.Windows.Forms.TextBox();
            this.txt_userId = new System.Windows.Forms.TextBox();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dbname = new System.Windows.Forms.TextBox();
            this.DBConnector = new System.Windows.Forms.Button();
            this.dbConStatus = new System.Windows.Forms.TextBox();
            this.folderSelector = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.scriptsResults = new System.Windows.Forms.DataGridView();
            this.Analyzer = new System.Windows.Forms.Button();
            this.Generator = new System.Windows.Forms.Button();
            this.Parser = new System.Windows.Forms.Button();
            this.Executor = new System.Windows.Forms.Button();
            this.txt_tenantNames = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scriptsResults)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_dbServer
            // 
            this.txt_dbServer.Location = new System.Drawing.Point(47, 40);
            this.txt_dbServer.Name = "txt_dbServer";
            this.txt_dbServer.Size = new System.Drawing.Size(100, 20);
            this.txt_dbServer.TabIndex = 4;
            // 
            // txt_userId
            // 
            this.txt_userId.Location = new System.Drawing.Point(218, 40);
            this.txt_userId.Name = "txt_userId";
            this.txt_userId.Size = new System.Drawing.Size(100, 20);
            this.txt_userId.TabIndex = 5;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Location = new System.Drawing.Point(395, 40);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Size = new System.Drawing.Size(100, 20);
            this.txt_Pwd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DB Server";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "UserId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Database Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_dbname
            // 
            this.txt_dbname.Location = new System.Drawing.Point(533, 40);
            this.txt_dbname.Name = "txt_dbname";
            this.txt_dbname.Size = new System.Drawing.Size(100, 20);
            this.txt_dbname.TabIndex = 10;
            this.txt_dbname.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // DBConnector
            // 
            this.DBConnector.Location = new System.Drawing.Point(701, 40);
            this.DBConnector.Name = "DBConnector";
            this.DBConnector.Size = new System.Drawing.Size(75, 23);
            this.DBConnector.TabIndex = 12;
            this.DBConnector.Text = "Connect";
            this.DBConnector.UseVisualStyleBackColor = true;
            this.DBConnector.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbConStatus
            // 
            this.dbConStatus.Enabled = false;
            this.dbConStatus.Location = new System.Drawing.Point(13, 40);
            this.dbConStatus.Name = "dbConStatus";
            this.dbConStatus.Size = new System.Drawing.Size(28, 20);
            this.dbConStatus.TabIndex = 13;
            // 
            // folderSelector
            // 
            this.folderSelector.Location = new System.Drawing.Point(13, 127);
            this.folderSelector.Name = "folderSelector";
            this.folderSelector.Size = new System.Drawing.Size(75, 23);
            this.folderSelector.TabIndex = 14;
            this.folderSelector.Text = "Import Scripts";
            this.folderSelector.UseVisualStyleBackColor = true;
            this.folderSelector.Click += new System.EventHandler(this.folderSelector_Click);
            // 
            // scriptsResults
            // 
            this.scriptsResults.AllowUserToAddRows = false;
            this.scriptsResults.AllowUserToDeleteRows = false;
            this.scriptsResults.AllowUserToOrderColumns = true;
            this.scriptsResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scriptsResults.Location = new System.Drawing.Point(12, 210);
            this.scriptsResults.Name = "scriptsResults";
            this.scriptsResults.ReadOnly = true;
            this.scriptsResults.Size = new System.Drawing.Size(834, 219);
            this.scriptsResults.TabIndex = 15;
            // 
            // Analyzer
            // 
            this.Analyzer.Location = new System.Drawing.Point(171, 127);
            this.Analyzer.Name = "Analyzer";
            this.Analyzer.Size = new System.Drawing.Size(75, 23);
            this.Analyzer.TabIndex = 16;
            this.Analyzer.Text = "Analyze";
            this.Analyzer.UseVisualStyleBackColor = true;
            this.Analyzer.Click += new System.EventHandler(this.Analyzer_Click);
            // 
            // Generator
            // 
            this.Generator.Location = new System.Drawing.Point(344, 127);
            this.Generator.Name = "Generator";
            this.Generator.Size = new System.Drawing.Size(75, 23);
            this.Generator.TabIndex = 17;
            this.Generator.Text = "Generate";
            this.Generator.UseVisualStyleBackColor = true;
            this.Generator.Click += new System.EventHandler(this.Generator_Click);
            // 
            // Parser
            // 
            this.Parser.Location = new System.Drawing.Point(515, 127);
            this.Parser.Name = "Parser";
            this.Parser.Size = new System.Drawing.Size(75, 23);
            this.Parser.TabIndex = 18;
            this.Parser.Text = "Parse";
            this.Parser.UseVisualStyleBackColor = true;
            this.Parser.Click += new System.EventHandler(this.Parser_Click);
            // 
            // Executor
            // 
            this.Executor.Location = new System.Drawing.Point(691, 127);
            this.Executor.Name = "Executor";
            this.Executor.Size = new System.Drawing.Size(75, 23);
            this.Executor.TabIndex = 19;
            this.Executor.Text = "Execute";
            this.Executor.UseVisualStyleBackColor = true;
            this.Executor.Click += new System.EventHandler(this.Executor_Click);
            // 
            // txt_tenantNames
            // 
            this.txt_tenantNames.Location = new System.Drawing.Point(344, 173);
            this.txt_tenantNames.Name = "txt_tenantNames";
            this.txt_tenantNames.Size = new System.Drawing.Size(100, 20);
            this.txt_tenantNames.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Replacement Rules";
            // 
            // ScriptRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tenantNames);
            this.Controls.Add(this.Executor);
            this.Controls.Add(this.Parser);
            this.Controls.Add(this.Generator);
            this.Controls.Add(this.Analyzer);
            this.Controls.Add(this.scriptsResults);
            this.Controls.Add(this.folderSelector);
            this.Controls.Add(this.dbConStatus);
            this.Controls.Add(this.DBConnector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_dbname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.txt_userId);
            this.Controls.Add(this.txt_dbServer);
            this.Name = "ScriptRunner";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.scriptsResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_dbServer;
        private System.Windows.Forms.TextBox txt_userId;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dbname;
        private System.Windows.Forms.Button DBConnector;
        private System.Windows.Forms.TextBox dbConStatus;
        private System.Windows.Forms.Button folderSelector;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.DataGridView scriptsResults;
        private System.Windows.Forms.Button Analyzer;
        private System.Windows.Forms.Button Generator;
        private System.Windows.Forms.Button Parser;
        private System.Windows.Forms.Button Executor;
        private System.Windows.Forms.TextBox txt_tenantNames;
        private System.Windows.Forms.Label label1;
    }
}

