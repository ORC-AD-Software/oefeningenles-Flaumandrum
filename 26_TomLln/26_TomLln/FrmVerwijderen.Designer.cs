namespace _26_TomLln
{
    partial class FrmVerwijderen
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
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.lblKiesLln = new System.Windows.Forms.Label();
            this.cmbKiesLeerling = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(172, 84);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(146, 50);
            this.btnAnnuleren.TabIndex = 3;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(16, 84);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(146, 50);
            this.btnVerwijderen.TabIndex = 2;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // lblKiesLln
            // 
            this.lblKiesLln.AutoSize = true;
            this.lblKiesLln.Location = new System.Drawing.Point(12, 9);
            this.lblKiesLln.Name = "lblKiesLln";
            this.lblKiesLln.Size = new System.Drawing.Size(326, 24);
            this.lblKiesLln.TabIndex = 4;
            this.lblKiesLln.Text = "Kies de leerling die u wilt verwijderen:";
            // 
            // cmbKiesLeerling
            // 
            this.cmbKiesLeerling.FormattingEnabled = true;
            this.cmbKiesLeerling.Location = new System.Drawing.Point(16, 46);
            this.cmbKiesLeerling.Name = "cmbKiesLeerling";
            this.cmbKiesLeerling.Size = new System.Drawing.Size(302, 32);
            this.cmbKiesLeerling.TabIndex = 5;
            // 
            // FrmVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 154);
            this.ControlBox = false;
            this.Controls.Add(this.cmbKiesLeerling);
            this.Controls.Add(this.lblKiesLln);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnVerwijderen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmVerwijderen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verwijderen leerling";
            this.Load += new System.EventHandler(this.FrmVerwijderen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Label lblKiesLln;
        private System.Windows.Forms.ComboBox cmbKiesLeerling;
    }
}