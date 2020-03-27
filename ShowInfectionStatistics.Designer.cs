namespace Data_Statistic_and_Analysis_Tool
{
    partial class ShowInfectionStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowInfectionStatistics));
            this.dvInfect = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cDateTime = new System.Windows.Forms.CheckBox();
            this.cDeath = new System.Windows.Forms.CheckBox();
            this.cInfectionCount = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cCrawled = new System.Windows.Forms.CheckBox();
            this.cRecovered = new System.Windows.Forms.CheckBox();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aufsteigendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absteigendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dvInfect)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvInfect
            // 
            this.dvInfect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvInfect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvInfect.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvInfect.Location = new System.Drawing.Point(12, 27);
            this.dvInfect.Name = "dvInfect";
            this.dvInfect.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvInfect.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvInfect.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvInfect.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dvInfect.Size = new System.Drawing.Size(1067, 565);
            this.dvInfect.TabIndex = 4;
            this.dvInfect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(749, 603);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cDateTime
            // 
            this.cDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cDateTime.AutoSize = true;
            this.cDateTime.Location = new System.Drawing.Point(640, 604);
            this.cDateTime.Name = "cDateTime";
            this.cDateTime.Size = new System.Drawing.Size(93, 17);
            this.cDateTime.TabIndex = 16;
            this.cDateTime.Text = "Datum Uhrzeit";
            this.cDateTime.UseVisualStyleBackColor = true;
            this.cDateTime.CheckedChanged += new System.EventHandler(this.cDateTime_CheckedChanged);
            // 
            // cDeath
            // 
            this.cDeath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cDeath.AutoSize = true;
            this.cDeath.Location = new System.Drawing.Point(419, 603);
            this.cDeath.Name = "cDeath";
            this.cDeath.Size = new System.Drawing.Size(75, 17);
            this.cDeath.TabIndex = 15;
            this.cDeath.Text = "Todesfälle";
            this.cDeath.UseVisualStyleBackColor = true;
            this.cDeath.CheckedChanged += new System.EventHandler(this.cDeath_CheckedChanged);
            // 
            // cInfectionCount
            // 
            this.cInfectionCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cInfectionCount.AutoSize = true;
            this.cInfectionCount.Location = new System.Drawing.Point(317, 602);
            this.cInfectionCount.Name = "cInfectionCount";
            this.cInfectionCount.Size = new System.Drawing.Size(96, 17);
            this.cInfectionCount.TabIndex = 14;
            this.cInfectionCount.Text = "Infektions Zahl";
            this.cInfectionCount.UseVisualStyleBackColor = true;
            this.cInfectionCount.CheckedChanged += new System.EventHandler(this.cInfectionCount_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Suchbegriff:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(87, 601);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(861, 603);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(106, 23);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "   Aktualisieren";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(973, 603);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cCrawled
            // 
            this.cCrawled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cCrawled.AutoSize = true;
            this.cCrawled.Location = new System.Drawing.Point(559, 603);
            this.cCrawled.Name = "cCrawled";
            this.cCrawled.Size = new System.Drawing.Size(75, 17);
            this.cCrawled.TabIndex = 18;
            this.cCrawled.Text = "Crawl D/Z";
            this.cCrawled.UseVisualStyleBackColor = true;
            this.cCrawled.CheckedChanged += new System.EventHandler(this.cCrawled_CheckedChanged);
            // 
            // cRecovered
            // 
            this.cRecovered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cRecovered.AutoSize = true;
            this.cRecovered.Location = new System.Drawing.Point(494, 603);
            this.cRecovered.Name = "cRecovered";
            this.cRecovered.Size = new System.Drawing.Size(59, 17);
            this.cRecovered.TabIndex = 19;
            this.cRecovered.Text = "Geheilt";
            this.cRecovered.UseVisualStyleBackColor = true;
            this.cRecovered.CheckedChanged += new System.EventHandler(this.cRecovered_CheckedChanged);
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
            this.schließenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // sortierenToolStripMenuItem
            // 
            this.sortierenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripMenuItem});
            this.sortierenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortierenToolStripMenuItem.Image")));
            this.sortierenToolStripMenuItem.Name = "sortierenToolStripMenuItem";
            this.sortierenToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.sortierenToolStripMenuItem.Text = "Sortieren";
            // 
            // iDToolStripMenuItem
            // 
            this.iDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aufsteigendToolStripMenuItem,
            this.absteigendToolStripMenuItem});
            this.iDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iDToolStripMenuItem.Image")));
            this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            this.iDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iDToolStripMenuItem.Text = "ID";
            // 
            // aufsteigendToolStripMenuItem
            // 
            this.aufsteigendToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aufsteigendToolStripMenuItem.Image")));
            this.aufsteigendToolStripMenuItem.Name = "aufsteigendToolStripMenuItem";
            this.aufsteigendToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.aufsteigendToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.aufsteigendToolStripMenuItem.Text = "Aufsteigend";
            this.aufsteigendToolStripMenuItem.Click += new System.EventHandler(this.aufsteigendToolStripMenuItem_Click);
            // 
            // absteigendToolStripMenuItem
            // 
            this.absteigendToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("absteigendToolStripMenuItem.Image")));
            this.absteigendToolStripMenuItem.Name = "absteigendToolStripMenuItem";
            this.absteigendToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.absteigendToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.absteigendToolStripMenuItem.Text = "Absteigend";
            this.absteigendToolStripMenuItem.Click += new System.EventHandler(this.absteigendToolStripMenuItem_Click);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLToolStripMenuItem,
            this.konsoleToolStripMenuItem});
            this.developerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("developerToolStripMenuItem.Image")));
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.developerToolStripMenuItem.Text = "Developer";
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sQLToolStripMenuItem.Image")));
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // konsoleToolStripMenuItem
            // 
            this.konsoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("konsoleToolStripMenuItem.Image")));
            this.konsoleToolStripMenuItem.Name = "konsoleToolStripMenuItem";
            this.konsoleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.konsoleToolStripMenuItem.Text = "Konsole";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sortierenToolStripMenuItem,
            this.developerToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1091, 24);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem1.Text = "Export";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "PDF";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "CSV";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // ShowInfectionStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1091, 633);
            this.Controls.Add(this.cRecovered);
            this.Controls.Add(this.cCrawled);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cDateTime);
            this.Controls.Add(this.cDeath);
            this.Controls.Add(this.cInfectionCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dvInfect);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowInfectionStatistics";
            this.Text = "ShowInfectionStatistics";
            this.Load += new System.EventHandler(this.ShowInfectionStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvInfect)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.DataGridView dvInfect;
        protected System.Windows.Forms.Button btnSearch;
        protected System.Windows.Forms.CheckBox cDateTime;
        protected System.Windows.Forms.CheckBox cDeath;
        protected System.Windows.Forms.CheckBox cInfectionCount;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        protected System.Windows.Forms.Button btnReload;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.CheckBox cCrawled;
        protected System.Windows.Forms.CheckBox cRecovered;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aufsteigendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absteigendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konsoleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}