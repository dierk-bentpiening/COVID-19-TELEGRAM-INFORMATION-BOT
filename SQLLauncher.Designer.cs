namespace Data_Statistic_and_Analysis_Tool
{
    partial class SQLLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLLauncher));
            this.label2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausführenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpreterStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSQL = new System.Windows.Forms.RichTextBox();
            this.chkDevelTrue = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(141, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "               SQL Querry Ausführen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(201, 341);
            this.btnRun.Name = "btnRun";
            this.btnRun.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRun.Size = new System.Drawing.Size(134, 23);
            this.btnRun.TabIndex = 22;
            this.btnRun.Text = "Ausführen";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(341, 341);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.codeToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schließenToolStripMenuItem});
            this.menüToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menüToolStripMenuItem.Image")));
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("schließenToolStripMenuItem.Image")));
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausführenToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.codeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("codeToolStripMenuItem.Image")));
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // ausführenToolStripMenuItem
            // 
            this.ausführenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ausführenToolStripMenuItem.Image")));
            this.ausführenToolStripMenuItem.Name = "ausführenToolStripMenuItem";
            this.ausführenToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ausführenToolStripMenuItem.Text = "Ausführen";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konsoleToolStripMenuItem});
            this.debugToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("debugToolStripMenuItem.Image")));
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // konsoleToolStripMenuItem
            // 
            this.konsoleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anzeigenToolStripMenuItem,
            this.interpreterStartenToolStripMenuItem});
            this.konsoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("konsoleToolStripMenuItem.Image")));
            this.konsoleToolStripMenuItem.Name = "konsoleToolStripMenuItem";
            this.konsoleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.konsoleToolStripMenuItem.Text = "Konsole";
            // 
            // anzeigenToolStripMenuItem
            // 
            this.anzeigenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anzeigenToolStripMenuItem.Image")));
            this.anzeigenToolStripMenuItem.Name = "anzeigenToolStripMenuItem";
            this.anzeigenToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.anzeigenToolStripMenuItem.Text = "Anzeigen";
            this.anzeigenToolStripMenuItem.Click += new System.EventHandler(this.anzeigenToolStripMenuItem_Click);
            // 
            // interpreterStartenToolStripMenuItem
            // 
            this.interpreterStartenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("interpreterStartenToolStripMenuItem.Image")));
            this.interpreterStartenToolStripMenuItem.Name = "interpreterStartenToolStripMenuItem";
            this.interpreterStartenToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.interpreterStartenToolStripMenuItem.Text = "Interpreter Starten";
            this.interpreterStartenToolStripMenuItem.Click += new System.EventHandler(this.interpreterStartenToolStripMenuItem_Click);
            // 
            // txtSQL
            // 
            this.txtSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSQL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSQL.Location = new System.Drawing.Point(12, 72);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(463, 233);
            this.txtSQL.TabIndex = 24;
            this.txtSQL.Text = "";
            this.txtSQL.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // chkDevelTrue
            // 
            this.chkDevelTrue.AutoSize = true;
            this.chkDevelTrue.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkDevelTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDevelTrue.Location = new System.Drawing.Point(29, 347);
            this.chkDevelTrue.Name = "chkDevelTrue";
            this.chkDevelTrue.Size = new System.Drawing.Size(127, 17);
            this.chkDevelTrue.TabIndex = 25;
            this.chkDevelTrue.Text = "Ich weiss was ich tue.";
            this.chkDevelTrue.UseVisualStyleBackColor = false;
            this.chkDevelTrue.CheckedChanged += new System.EventHandler(this.chkDevelTrue_CheckedChanged);
            // 
            // SQLLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 376);
            this.Controls.Add(this.chkDevelTrue);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SQLLauncher";
            this.Text = "SQL Ausführen";
            this.Load += new System.EventHandler(this.SQLLauncher_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnRun;
        protected System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausführenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        protected System.Windows.Forms.RichTextBox txtSQL;
        private System.Windows.Forms.CheckBox chkDevelTrue;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpreterStartenToolStripMenuItem;
    }
}