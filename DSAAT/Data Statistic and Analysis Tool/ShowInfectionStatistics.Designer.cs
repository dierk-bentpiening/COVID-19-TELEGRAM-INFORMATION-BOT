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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neusteZuerstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ältesteZuerstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvInfect = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInfect)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(48, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // iDToolStripMenuItem
            // 
            this.iDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neusteZuerstToolStripMenuItem,
            this.ältesteZuerstToolStripMenuItem});
            this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            this.iDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iDToolStripMenuItem.Text = "ID";
            // 
            // neusteZuerstToolStripMenuItem
            // 
            this.neusteZuerstToolStripMenuItem.Name = "neusteZuerstToolStripMenuItem";
            this.neusteZuerstToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.neusteZuerstToolStripMenuItem.Text = "Neuste zuerst";
            this.neusteZuerstToolStripMenuItem.Click += new System.EventHandler(this.neusteZuerstToolStripMenuItem_Click);
            // 
            // ältesteZuerstToolStripMenuItem
            // 
            this.ältesteZuerstToolStripMenuItem.Name = "ältesteZuerstToolStripMenuItem";
            this.ältesteZuerstToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.ältesteZuerstToolStripMenuItem.Text = "Älteste zuerst";
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
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReload.Location = new System.Drawing.Point(861, 598);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(106, 23);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Aktualisieren";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(973, 598);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShowInfectionStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1091, 633);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dvInfect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShowInfectionStatistics";
            this.Text = "ShowInfectionStatistics";
            this.Load += new System.EventHandler(this.ShowInfectionStatistics_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInfect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neusteZuerstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ältesteZuerstToolStripMenuItem;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        protected System.Windows.Forms.DataGridView dvInfect;
        protected System.Windows.Forms.Button btnReload;
        protected System.Windows.Forms.Button btnClose;
    }
}