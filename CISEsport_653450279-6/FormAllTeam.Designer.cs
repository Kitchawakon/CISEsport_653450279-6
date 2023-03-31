namespace CISESPORT
{
    partial class FormAllTeam
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGname_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGname_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGname_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGname_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGname_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.teamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1733, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTeamToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.teamToolStripMenuItem.Text = "Team";
            // 
            // newTeamToolStripMenuItem
            // 
            this.newTeamToolStripMenuItem.Name = "newTeamToolStripMenuItem";
            this.newTeamToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.newTeamToolStripMenuItem.Text = "New Team";
            this.newTeamToolStripMenuItem.Click += new System.EventHandler(this.newTeamToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTeam,
            this.ColumnName_1,
            this.ColumnGname_1,
            this.ColumnName_2,
            this.ColumnGname_2,
            this.ColumnName_3,
            this.ColumnGname_3,
            this.ColumnName_4,
            this.ColumnGname_4,
            this.ColumnName_5,
            this.ColumnGname_5});
            this.dataGridView1.Location = new System.Drawing.Point(17, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1703, 685);
            this.dataGridView1.TabIndex = 1;
            // 
            // ColumnTeam
            // 
            this.ColumnTeam.DataPropertyName = "_Team";
            this.ColumnTeam.HeaderText = "Team";
            this.ColumnTeam.MinimumWidth = 8;
            this.ColumnTeam.Name = "ColumnTeam";
            this.ColumnTeam.ReadOnly = true;
            this.ColumnTeam.Width = 150;
            // 
            // ColumnName_1
            // 
            this.ColumnName_1.DataPropertyName = "name1";
            this.ColumnName_1.HeaderText = "Name_1";
            this.ColumnName_1.MinimumWidth = 8;
            this.ColumnName_1.Name = "ColumnName_1";
            this.ColumnName_1.ReadOnly = true;
            this.ColumnName_1.Width = 150;
            // 
            // ColumnGname_1
            // 
            this.ColumnGname_1.DataPropertyName = "gname1";
            this.ColumnGname_1.HeaderText = "Gname_1";
            this.ColumnGname_1.MinimumWidth = 8;
            this.ColumnGname_1.Name = "ColumnGname_1";
            this.ColumnGname_1.ReadOnly = true;
            this.ColumnGname_1.Width = 150;
            // 
            // ColumnName_2
            // 
            this.ColumnName_2.DataPropertyName = "name2";
            this.ColumnName_2.HeaderText = "Name_2";
            this.ColumnName_2.MinimumWidth = 8;
            this.ColumnName_2.Name = "ColumnName_2";
            this.ColumnName_2.ReadOnly = true;
            this.ColumnName_2.Width = 150;
            // 
            // ColumnGname_2
            // 
            this.ColumnGname_2.DataPropertyName = "gname2";
            this.ColumnGname_2.HeaderText = "Gname_2";
            this.ColumnGname_2.MinimumWidth = 8;
            this.ColumnGname_2.Name = "ColumnGname_2";
            this.ColumnGname_2.ReadOnly = true;
            this.ColumnGname_2.Width = 150;
            // 
            // ColumnName_3
            // 
            this.ColumnName_3.DataPropertyName = "name3";
            this.ColumnName_3.HeaderText = "Name_3";
            this.ColumnName_3.MinimumWidth = 8;
            this.ColumnName_3.Name = "ColumnName_3";
            this.ColumnName_3.ReadOnly = true;
            this.ColumnName_3.Width = 150;
            // 
            // ColumnGname_3
            // 
            this.ColumnGname_3.DataPropertyName = "gname3";
            this.ColumnGname_3.HeaderText = "Gname_3";
            this.ColumnGname_3.MinimumWidth = 8;
            this.ColumnGname_3.Name = "ColumnGname_3";
            this.ColumnGname_3.ReadOnly = true;
            this.ColumnGname_3.Width = 150;
            // 
            // ColumnName_4
            // 
            this.ColumnName_4.DataPropertyName = "name4";
            this.ColumnName_4.HeaderText = "Name_4";
            this.ColumnName_4.MinimumWidth = 8;
            this.ColumnName_4.Name = "ColumnName_4";
            this.ColumnName_4.ReadOnly = true;
            this.ColumnName_4.Width = 150;
            // 
            // ColumnGname_4
            // 
            this.ColumnGname_4.DataPropertyName = "gname4";
            this.ColumnGname_4.HeaderText = "Gname_4";
            this.ColumnGname_4.MinimumWidth = 8;
            this.ColumnGname_4.Name = "ColumnGname_4";
            this.ColumnGname_4.ReadOnly = true;
            this.ColumnGname_4.Width = 150;
            // 
            // ColumnName_5
            // 
            this.ColumnName_5.DataPropertyName = "name5";
            this.ColumnName_5.HeaderText = "Name_5";
            this.ColumnName_5.MinimumWidth = 8;
            this.ColumnName_5.Name = "ColumnName_5";
            this.ColumnName_5.ReadOnly = true;
            this.ColumnName_5.Width = 150;
            // 
            // ColumnGname_5
            // 
            this.ColumnGname_5.DataPropertyName = "gname5";
            this.ColumnGname_5.HeaderText = "Gname_5";
            this.ColumnGname_5.MinimumWidth = 8;
            this.ColumnGname_5.Name = "ColumnGname_5";
            this.ColumnGname_5.ReadOnly = true;
            this.ColumnGname_5.Width = 150;
            // 
            // FormAllTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 750);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAllTeam";
            this.Text = "FormAllTeam";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem teamToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem newTeamToolStripMenuItem;
        private DataGridViewTextBoxColumn ColumnTeam;
        private DataGridViewTextBoxColumn ColumnName_1;
        private DataGridViewTextBoxColumn ColumnGname_1;
        private DataGridViewTextBoxColumn ColumnName_2;
        private DataGridViewTextBoxColumn ColumnGname_2;
        private DataGridViewTextBoxColumn ColumnName_3;
        private DataGridViewTextBoxColumn ColumnGname_3;
        private DataGridViewTextBoxColumn ColumnName_4;
        private DataGridViewTextBoxColumn ColumnGname_4;
        private DataGridViewTextBoxColumn ColumnName_5;
        private DataGridViewTextBoxColumn ColumnGname_5;
    }
}