namespace CISESPORT
{
    partial class FormAllPlayer
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
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlayerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxGName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1096, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlayerToolStripMenuItem1});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.playerToolStripMenuItem.Text = "Player";
            // 
            // newPlayerToolStripMenuItem1
            // 
            this.newPlayerToolStripMenuItem1.Name = "newPlayerToolStripMenuItem1";
            this.newPlayerToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.newPlayerToolStripMenuItem1.Text = "New Player";
            this.newPlayerToolStripMenuItem1.Click += new System.EventHandler(this.newPlayerToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnLname,
            this.ColumnID,
            this.ColumnField,
            this.ColumnGname,
            this.ColumnMail,
            this.ColumnTel,
            this.ColumnAge});
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(892, 403);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxGName
            // 
            this.textBoxGName.Location = new System.Drawing.Point(984, 121);
            this.textBoxGName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGName.Name = "textBoxGName";
            this.textBoxGName.Size = new System.Drawing.Size(106, 23);
            this.textBoxGName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(909, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "ชื่อในเกม";
            // 
            // textBoxField
            // 
            this.textBoxField.Location = new System.Drawing.Point(984, 91);
            this.textBoxField.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxField.Name = "textBoxField";
            this.textBoxField.Size = new System.Drawing.Size(106, 23);
            this.textBoxField.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(909, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "สาขา";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(984, 61);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(106, 23);
            this.textBoxID.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(909, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "รหัสนักศึกษา";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(984, 30);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(106, 23);
            this.textBoxName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(909, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "ชื่อ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(999, 153);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 20);
            this.button1.TabIndex = 29;
            this.button1.Text = "ยืนยัน";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "name";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 150;
            // 
            // ColumnLname
            // 
            this.ColumnLname.DataPropertyName = "lastname";
            this.ColumnLname.HeaderText = "Lastname";
            this.ColumnLname.MinimumWidth = 8;
            this.ColumnLname.Name = "ColumnLname";
            this.ColumnLname.ReadOnly = true;
            this.ColumnLname.Width = 150;
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "id";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 8;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 150;
            // 
            // ColumnField
            // 
            this.ColumnField.DataPropertyName = "field";
            this.ColumnField.HeaderText = "Field";
            this.ColumnField.MinimumWidth = 8;
            this.ColumnField.Name = "ColumnField";
            this.ColumnField.ReadOnly = true;
            this.ColumnField.Width = 150;
            // 
            // ColumnGname
            // 
            this.ColumnGname.DataPropertyName = "gamename";
            this.ColumnGname.HeaderText = "Gamename";
            this.ColumnGname.MinimumWidth = 8;
            this.ColumnGname.Name = "ColumnGname";
            this.ColumnGname.ReadOnly = true;
            this.ColumnGname.Width = 150;
            // 
            // ColumnMail
            // 
            this.ColumnMail.DataPropertyName = "email";
            this.ColumnMail.HeaderText = "Email";
            this.ColumnMail.MinimumWidth = 8;
            this.ColumnMail.Name = "ColumnMail";
            this.ColumnMail.ReadOnly = true;
            this.ColumnMail.Width = 150;
            // 
            // ColumnTel
            // 
            this.ColumnTel.DataPropertyName = "tel";
            this.ColumnTel.HeaderText = "Tel";
            this.ColumnTel.MinimumWidth = 8;
            this.ColumnTel.Name = "ColumnTel";
            this.ColumnTel.ReadOnly = true;
            this.ColumnTel.Width = 150;
            // 
            // ColumnAge
            // 
            this.ColumnAge.DataPropertyName = "age";
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.MinimumWidth = 8;
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.ReadOnly = true;
            this.ColumnAge.Width = 150;
            // 
            // FormAllPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxGName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAllPlayer";
            this.Text = "FormAllPlayer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem newPlayerToolStripMenuItem1;
        private TextBox textBoxGName;
        private Label label5;
        private TextBox textBoxField;
        private Label label4;
        private TextBox textBoxID;
        private Label label3;
        private TextBox textBoxName;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLname;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnField;
        private DataGridViewTextBoxColumn ColumnGname;
        private DataGridViewTextBoxColumn ColumnMail;
        private DataGridViewTextBoxColumn ColumnTel;
        private DataGridViewTextBoxColumn ColumnAge;
    }
}