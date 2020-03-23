namespace DB_Data_Insert_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.btnAddAusgangssperre = new System.Windows.Forms.Button();
            this.btnAddMessage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddLink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoBox
            // 
            this.LogoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("LogoBox.ErrorImage")));
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoBox.InitialImage")));
            this.LogoBox.Location = new System.Drawing.Point(-2, -102);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(520, 359);
            this.LogoBox.TabIndex = 0;
            this.LogoBox.TabStop = false;
            // 
            // btnAddAusgangssperre
            // 
            this.btnAddAusgangssperre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddAusgangssperre.Location = new System.Drawing.Point(162, 259);
            this.btnAddAusgangssperre.Name = "btnAddAusgangssperre";
            this.btnAddAusgangssperre.Size = new System.Drawing.Size(177, 23);
            this.btnAddAusgangssperre.TabIndex = 1;
            this.btnAddAusgangssperre.Text = "Ausgangssperre Hinzufügen";
            this.btnAddAusgangssperre.UseVisualStyleBackColor = false;
            this.btnAddAusgangssperre.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddMessage
            // 
            this.btnAddMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddMessage.Location = new System.Drawing.Point(162, 289);
            this.btnAddMessage.Name = "btnAddMessage";
            this.btnAddMessage.Size = new System.Drawing.Size(177, 23);
            this.btnAddMessage.TabIndex = 2;
            this.btnAddMessage.Text = "Nachricht Hinzufügen";
            this.btnAddMessage.UseVisualStyleBackColor = false;
            this.btnAddMessage.Click += new System.EventHandler(this.btnAddMessage_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(162, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddLink
            // 
            this.btnAddLink.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddLink.Location = new System.Drawing.Point(162, 321);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(177, 23);
            this.btnAddLink.TabIndex = 4;
            this.btnAddLink.Text = "Link Hinzufügen";
            this.btnAddLink.UseVisualStyleBackColor = false;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(518, 385);
            this.Controls.Add(this.btnAddLink);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddMessage);
            this.Controls.Add(this.btnAddAusgangssperre);
            this.Controls.Add(this.LogoBox);
            this.Name = "Form1";
            this.Text = "CISBS Data Insert Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Button btnAddAusgangssperre;
        private System.Windows.Forms.Button btnAddMessage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddLink;
    }
}

