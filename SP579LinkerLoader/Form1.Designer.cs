namespace SP579LinkerLoader
{
    partial class Form1
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.program1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.program2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnErrorCheck = new System.Windows.Forms.Button();
            this.btnLinkLoad = new System.Windows.Forms.Button();
            this.txtStartAddress = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtProgram1 = new System.Windows.Forms.TextBox();
            this.txtProgram2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvGEST = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.program1ToolStripMenuItem,
            this.program2ToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // program1ToolStripMenuItem
            // 
            this.program1ToolStripMenuItem.Name = "program1ToolStripMenuItem";
            this.program1ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.program1ToolStripMenuItem.Text = "Program 1";
            this.program1ToolStripMenuItem.Click += new System.EventHandler(this.program1ToolStripMenuItem_Click);
            // 
            // program2ToolStripMenuItem
            // 
            this.program2ToolStripMenuItem.Name = "program2ToolStripMenuItem";
            this.program2ToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.program2ToolStripMenuItem.Text = "Program 2";
            this.program2ToolStripMenuItem.Click += new System.EventHandler(this.program2ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnErrorCheck
            // 
            this.btnErrorCheck.Location = new System.Drawing.Point(12, 27);
            this.btnErrorCheck.Name = "btnErrorCheck";
            this.btnErrorCheck.Size = new System.Drawing.Size(75, 23);
            this.btnErrorCheck.TabIndex = 1;
            this.btnErrorCheck.Text = "Check";
            this.btnErrorCheck.UseVisualStyleBackColor = true;
            this.btnErrorCheck.Click += new System.EventHandler(this.btnErrorCheck_Click);
            // 
            // btnLinkLoad
            // 
            this.btnLinkLoad.Location = new System.Drawing.Point(93, 27);
            this.btnLinkLoad.Name = "btnLinkLoad";
            this.btnLinkLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLinkLoad.TabIndex = 2;
            this.btnLinkLoad.Text = "Link/Load";
            this.btnLinkLoad.UseVisualStyleBackColor = true;
            this.btnLinkLoad.Click += new System.EventHandler(this.btnLinkLoad_Click);
            // 
            // txtStartAddress
            // 
            this.txtStartAddress.Location = new System.Drawing.Point(278, 30);
            this.txtStartAddress.Name = "txtStartAddress";
            this.txtStartAddress.Size = new System.Drawing.Size(100, 20);
            this.txtStartAddress.TabIndex = 3;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(202, 33);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(70, 13);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Start Address";
            // 
            // txtProgram1
            // 
            this.txtProgram1.Location = new System.Drawing.Point(12, 104);
            this.txtProgram1.Multiline = true;
            this.txtProgram1.Name = "txtProgram1";
            this.txtProgram1.Size = new System.Drawing.Size(280, 193);
            this.txtProgram1.TabIndex = 6;
            // 
            // txtProgram2
            // 
            this.txtProgram2.Location = new System.Drawing.Point(298, 104);
            this.txtProgram2.Multiline = true;
            this.txtProgram2.Name = "txtProgram2";
            this.txtProgram2.Size = new System.Drawing.Size(280, 193);
            this.txtProgram2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Program 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Program 2";
            // 
            // lvGEST
            // 
            this.lvGEST.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvGEST.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvGEST.Location = new System.Drawing.Point(584, 104);
            this.lvGEST.Name = "lvGEST";
            this.lvGEST.Size = new System.Drawing.Size(264, 317);
            this.lvGEST.TabIndex = 10;
            this.lvGEST.UseCompatibleStateImageBehavior = false;
            this.lvGEST.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Symbol";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "RelativeLocation";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LoadAddress";
            this.columnHeader3.Width = 74;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Length";
            this.columnHeader4.Width = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "GEST";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 320);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(563, 101);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Error List";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLinkLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 433);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvGEST);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProgram2);
            this.Controls.Add(this.txtProgram1);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.txtStartAddress);
            this.Controls.Add(this.btnLinkLoad);
            this.Controls.Add(this.btnErrorCheck);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem program1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem program2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnErrorCheck;
        private System.Windows.Forms.Button btnLinkLoad;
        private System.Windows.Forms.TextBox txtStartAddress;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtProgram1;
        private System.Windows.Forms.TextBox txtProgram2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public  System.Windows.Forms.ListView lvGEST;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        public  System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
    }
}

