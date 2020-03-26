namespace Data_Statistic_and_Analysis_Tool
{
    partial class ShowStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowStatistics));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aufsteigendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absteigendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvInfect = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cChatID = new System.Windows.Forms.CheckBox();
            this.cQuerryType = new System.Windows.Forms.CheckBox();
            this.cDateTime = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInfect)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.dateiToolStripMenuItem,
            this.sortierenToolStripMenuItem,
            this.developerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(306, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dateiToolStripMenuItem.Image")));
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
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
            this.iDToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
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
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // konsoleToolStripMenuItem
            // 
            this.konsoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("konsoleToolStripMenuItem.Image")));
            this.konsoleToolStripMenuItem.Name = "konsoleToolStripMenuItem";
            this.konsoleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.konsoleToolStripMenuItem.Text = "Konsole";
            // 
            // dvInfect
            // 
            this.dvInfect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvInfect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dvInfect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dvInfect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvInfect.Location = new System.Drawing.Point(12, 27);
            this.dvInfect.Name = "dvInfect";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvInfect.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvInfect.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvInfect.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dvInfect.Size = new System.Drawing.Size(924, 541);
            this.dvInfect.TabIndex = 1;
            this.dvInfect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvInfect_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(830, 574);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(718, 574);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(106, 23);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "   Aktualisieren";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(82, 576);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Suchbegriff:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cChatID
            // 
            this.cChatID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cChatID.AutoSize = true;
            this.cChatID.Location = new System.Drawing.Point(312, 578);
            this.cChatID.Name = "cChatID";
            this.cChatID.Size = new System.Drawing.Size(59, 17);
            this.cChatID.TabIndex = 6;
            this.cChatID.Text = "ChatID";
            this.cChatID.UseVisualStyleBackColor = true;
            this.cChatID.CheckedChanged += new System.EventHandler(this.cChatID_CheckedChanged);
            // 
            // cQuerryType
            // 
            this.cQuerryType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cQuerryType.AutoSize = true;
            this.cQuerryType.Location = new System.Drawing.Point(377, 578);
            this.cQuerryType.Name = "cQuerryType";
            this.cQuerryType.Size = new System.Drawing.Size(84, 17);
            this.cQuerryType.TabIndex = 7;
            this.cQuerryType.Text = "Querry Type";
            this.cQuerryType.UseVisualStyleBackColor = true;
            this.cQuerryType.CheckedChanged += new System.EventHandler(this.cQuerryType_CheckedChanged);
            // 
            // cDateTime
            // 
            this.cDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cDateTime.AutoSize = true;
            this.cDateTime.Location = new System.Drawing.Point(467, 579);
            this.cDateTime.Name = "cDateTime";
            this.cDateTime.Size = new System.Drawing.Size(93, 17);
            this.cDateTime.TabIndex = 8;
            this.cDateTime.Text = "Datum Uhrzeit";
            this.cDateTime.UseVisualStyleBackColor = true;
            this.cDateTime.CheckedChanged += new System.EventHandler(this.cDateTime_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(606, 573);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ShowStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(948, 605);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cDateTime);
            this.Controls.Add(this.cQuerryType);
            this.Controls.Add(this.cChatID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dvInfect);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShowStatistics";
            this.Text = "Bot Statistiken";
            this.Load += new System.EventHandler(this.ShowStatistics_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInfect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        protected System.Windows.Forms.CheckBox cChatID;
        protected System.Windows.Forms.CheckBox cQuerryType;
        protected System.Windows.Forms.CheckBox cDateTime;
        protected System.Windows.Forms.Button btnSearch;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem sortierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aufsteigendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absteigendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konsoleToolStripMenuItem;
        public System.Windows.Forms.DataGridView dvInfect;
    }
}