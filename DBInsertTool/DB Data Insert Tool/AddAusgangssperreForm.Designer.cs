namespace DB_Data_Insert_Tool
{
    partial class AddAusgangssperreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLKN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBehörde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBundesland = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dteVON = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dteBis = new System.Windows.Forms.DateTimePicker();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPLZ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Landkreis oder Stadt:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLKN
            // 
            this.txtLKN.Location = new System.Drawing.Point(174, 8);
            this.txtLKN.Name = "txtLKN";
            this.txtLKN.Size = new System.Drawing.Size(315, 20);
            this.txtLKN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Verfügende Behörde:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBehörde
            // 
            this.txtBehörde.Location = new System.Drawing.Point(174, 42);
            this.txtBehörde.Name = "txtBehörde";
            this.txtBehörde.Size = new System.Drawing.Size(315, 20);
            this.txtBehörde.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bundesland:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBundesland
            // 
            this.txtBundesland.Location = new System.Drawing.Point(174, 76);
            this.txtBundesland.Name = "txtBundesland";
            this.txtBundesland.Size = new System.Drawing.Size(315, 20);
            this.txtBundesland.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Von:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dteVON
            // 
            this.dteVON.Location = new System.Drawing.Point(174, 140);
            this.dteVON.Name = "dteVON";
            this.dteVON.Size = new System.Drawing.Size(315, 20);
            this.dteVON.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bis:";
            // 
            // dteBis
            // 
            this.dteBis.Location = new System.Drawing.Point(174, 170);
            this.dteBis.Name = "dteBis";
            this.dteBis.Size = new System.Drawing.Size(315, 20);
            this.dteBis.TabIndex = 9;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(250, 208);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 18);
            this.lblErrorMessage.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(242, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancle.Location = new System.Drawing.Point(371, 257);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(118, 23);
            this.btnCancle.TabIndex = 12;
            this.btnCancle.Text = "Abbrechen";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "PLZ:";
            // 
            // txtPLZ
            // 
            this.txtPLZ.Location = new System.Drawing.Point(174, 107);
            this.txtPLZ.Name = "txtPLZ";
            this.txtPLZ.Size = new System.Drawing.Size(315, 20);
            this.txtPLZ.TabIndex = 14;
            // 
            // AddAusgangssperreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(514, 292);
            this.Controls.Add(this.txtPLZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.dteBis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dteVON);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBundesland);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBehörde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLKN);
            this.Controls.Add(this.label1);
            this.Name = "AddAusgangssperreForm";
            this.Text = "Ausgangssperre Hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLKN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBehörde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBundesland;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dteVON;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dteBis;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPLZ;
    }
}