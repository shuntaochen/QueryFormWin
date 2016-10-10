namespace ServerListQueryFormDll
{
    partial class SrvListQueryFrm
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
            this.saveFilteredResultDialog = new System.Windows.Forms.SaveFileDialog();
            this.gpBoxOpts = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtTbName = new System.Windows.Forms.TextBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.txtDbHost = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblTbName = new System.Windows.Forms.Label();
            this.lblDbName = new System.Windows.Forms.Label();
            this.lblDbHost = new System.Windows.Forms.Label();
            this.txtConStr = new System.Windows.Forms.TextBox();
            this.lblConStr = new System.Windows.Forms.Label();
            this.lblSql = new System.Windows.Forms.Label();
            this.rchtxtSql = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvQueryResult = new System.Windows.Forms.DataGridView();
            this.gpBoxOpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gpBoxOpts
            // 
            this.gpBoxOpts.Controls.Add(this.txtOutput);
            this.gpBoxOpts.Controls.Add(this.lblOutput);
            this.gpBoxOpts.Controls.Add(this.txtTbName);
            this.gpBoxOpts.Controls.Add(this.txtFilter);
            this.gpBoxOpts.Controls.Add(this.txtDbName);
            this.gpBoxOpts.Controls.Add(this.txtDbHost);
            this.gpBoxOpts.Controls.Add(this.lblFilter);
            this.gpBoxOpts.Controls.Add(this.lblTbName);
            this.gpBoxOpts.Controls.Add(this.lblDbName);
            this.gpBoxOpts.Controls.Add(this.lblDbHost);
            this.gpBoxOpts.Controls.Add(this.txtConStr);
            this.gpBoxOpts.Controls.Add(this.lblConStr);
            this.gpBoxOpts.Controls.Add(this.lblSql);
            this.gpBoxOpts.Controls.Add(this.rchtxtSql);
            this.gpBoxOpts.Controls.Add(this.btnSave);
            this.gpBoxOpts.Controls.Add(this.btnQuery);
            this.gpBoxOpts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpBoxOpts.Location = new System.Drawing.Point(0, 340);
            this.gpBoxOpts.Name = "gpBoxOpts";
            this.gpBoxOpts.Size = new System.Drawing.Size(857, 167);
            this.gpBoxOpts.TabIndex = 1;
            this.gpBoxOpts.TabStop = false;
            this.gpBoxOpts.Text = "Operation";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(353, 41);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(261, 20);
            this.txtOutput.TabIndex = 20;
            this.txtOutput.Visible = false;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(270, 44);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(65, 13);
            this.lblOutput.TabIndex = 19;
            this.lblOutput.Text = "Export Path:";
            this.lblOutput.Visible = false;
            // 
            // txtTbName
            // 
            this.txtTbName.Location = new System.Drawing.Point(353, 13);
            this.txtTbName.Name = "txtTbName";
            this.txtTbName.Size = new System.Drawing.Size(110, 20);
            this.txtTbName.TabIndex = 18;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtFilter.Location = new System.Drawing.Point(744, 16);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(110, 20);
            this.txtFilter.TabIndex = 17;
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(105, 41);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(110, 20);
            this.txtDbName.TabIndex = 15;
            // 
            // txtDbHost
            // 
            this.txtDbHost.Location = new System.Drawing.Point(105, 13);
            this.txtDbHost.Name = "txtDbHost";
            this.txtDbHost.Size = new System.Drawing.Size(110, 20);
            this.txtDbHost.TabIndex = 14;
            // 
            // lblFilter
            // 
            this.lblFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(632, 19);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(65, 13);
            this.lblFilter.TabIndex = 12;
            this.lblFilter.Text = "Result Filter:";
            // 
            // lblTbName
            // 
            this.lblTbName.AutoSize = true;
            this.lblTbName.Location = new System.Drawing.Point(267, 16);
            this.lblTbName.Name = "lblTbName";
            this.lblTbName.Size = new System.Drawing.Size(68, 13);
            this.lblTbName.TabIndex = 11;
            this.lblTbName.Text = "Table Name:";
            // 
            // lblDbName
            // 
            this.lblDbName.AutoSize = true;
            this.lblDbName.Location = new System.Drawing.Point(12, 41);
            this.lblDbName.Name = "lblDbName";
            this.lblDbName.Size = new System.Drawing.Size(87, 13);
            this.lblDbName.TabIndex = 10;
            this.lblDbName.Text = "Database Name:";
            // 
            // lblDbHost
            // 
            this.lblDbHost.AutoSize = true;
            this.lblDbHost.Location = new System.Drawing.Point(18, 16);
            this.lblDbHost.Name = "lblDbHost";
            this.lblDbHost.Size = new System.Drawing.Size(81, 13);
            this.lblDbHost.TabIndex = 9;
            this.lblDbHost.Text = "Database Host:";
            // 
            // txtConStr
            // 
            this.txtConStr.Location = new System.Drawing.Point(106, 83);
            this.txtConStr.Name = "txtConStr";
            this.txtConStr.Size = new System.Drawing.Size(591, 20);
            this.txtConStr.TabIndex = 8;
            // 
            // lblConStr
            // 
            this.lblConStr.AutoSize = true;
            this.lblConStr.Location = new System.Drawing.Point(6, 83);
            this.lblConStr.Name = "lblConStr";
            this.lblConStr.Size = new System.Drawing.Size(94, 13);
            this.lblConStr.TabIndex = 7;
            this.lblConStr.Text = "Connection String:";
            // 
            // lblSql
            // 
            this.lblSql.AutoSize = true;
            this.lblSql.Location = new System.Drawing.Point(74, 112);
            this.lblSql.Name = "lblSql";
            this.lblSql.Size = new System.Drawing.Size(25, 13);
            this.lblSql.TabIndex = 6;
            this.lblSql.Text = "Sql:";
            // 
            // rchtxtSql
            // 
            this.rchtxtSql.Location = new System.Drawing.Point(106, 109);
            this.rchtxtSql.Name = "rchtxtSql";
            this.rchtxtSql.Size = new System.Drawing.Size(721, 24);
            this.rchtxtSql.TabIndex = 5;
            this.rchtxtSql.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(779, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save..";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(8, 138);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvQueryResult
            // 
            this.dgvQueryResult.AllowUserToAddRows = false;
            this.dgvQueryResult.AllowUserToDeleteRows = false;
            this.dgvQueryResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQueryResult.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryResult.Location = new System.Drawing.Point(0, 0);
            this.dgvQueryResult.Name = "dgvQueryResult";
            this.dgvQueryResult.ReadOnly = true;
            this.dgvQueryResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQueryResult.Size = new System.Drawing.Size(857, 339);
            this.dgvQueryResult.TabIndex = 4;
            // 
            // SrvListQueryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 507);
            this.Controls.Add(this.dgvQueryResult);
            this.Controls.Add(this.gpBoxOpts);
            this.Name = "SrvListQueryFrm";
            this.Text = "SrvListQuery";
            this.gpBoxOpts.ResumeLayout(false);
            this.gpBoxOpts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFilteredResultDialog;
        private System.Windows.Forms.GroupBox gpBoxOpts;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblSql;
        private System.Windows.Forms.DataGridView dgvQueryResult;
        private System.Windows.Forms.TextBox txtConStr;
        private System.Windows.Forms.Label lblConStr;
        private System.Windows.Forms.RichTextBox rchtxtSql;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblTbName;
        private System.Windows.Forms.Label lblDbName;
        private System.Windows.Forms.Label lblDbHost;
        private System.Windows.Forms.TextBox txtTbName;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.TextBox txtDbHost;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
    }
}

