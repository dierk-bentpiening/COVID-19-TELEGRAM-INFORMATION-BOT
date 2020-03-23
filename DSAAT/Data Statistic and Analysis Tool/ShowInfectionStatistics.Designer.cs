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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvInfect = new System.Windows.Forms.DataGridView();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neusteZuerstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ältesteZuerstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvInfect)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1091, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // dvInfect
            // 
            this.dvInfect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvInfect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvInfect.Location = new System.Drawing.Point(0, 27);
            this.dvInfect.Name = "dvInfect";
            this.dvInfect.Size = new System.Drawing.Size(1091, 594);
            this.dvInfect.TabIndex = 4;
            this.dvInfect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            this.neusteZuerstToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neusteZuerstToolStripMenuItem.Text = "Neuste zuerst";
            this.neusteZuerstToolStripMenuItem.Click += new System.EventHandler(this.neusteZuerstToolStripMenuItem_Click);
            // 
            // ältesteZuerstToolStripMenuItem
            // 
            this.ältesteZuerstToolStripMenuItem.Name = "ältesteZuerstToolStripMenuItem";
            this.ältesteZuerstToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ältesteZuerstToolStripMenuItem.Text = "Älteste zuerst";
            // 
            // ShowInfectionStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1091, 633);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.DataGridView dvInfect;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neusteZuerstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ältesteZuerstToolStripMenuItem;
    }
}