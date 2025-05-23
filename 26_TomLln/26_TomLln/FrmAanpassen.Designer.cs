namespace _26_TomLln
{
    partial class FrmAanpassen
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
            this.cmbKiesLeerling = new System.Windows.Forms.ComboBox();
            this.lblKiesLln = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbKiesLeerling
            // 
            this.cmbKiesLeerling.FormattingEnabled = true;
            this.cmbKiesLeerling.Location = new System.Drawing.Point(16, 46);
            this.cmbKiesLeerling.Name = "cmbKiesLeerling";
            this.cmbKiesLeerling.Size = new System.Drawing.Size(326, 32);
            this.cmbKiesLeerling.TabIndex = 7;
            // 
            // lblKiesLln
            // 
            this.lblKiesLln.AutoSize = true;
            this.lblKiesLln.Location = new System.Drawing.Point(12, 9);
            this.lblKiesLln.Name = "lblKiesLln";
            this.lblKiesLln.Size = new System.Drawing.Size(320, 24);
            this.lblKiesLln.TabIndex = 6;
            this.lblKiesLln.Text = "Kies de leerling die u wilt aanpassen:";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(16, 131);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(326, 29);
            this.txtNaam.TabIndex = 11;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 93);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(330, 24);
            this.lblNaam.TabIndex = 10;
            this.lblNaam.Text = "Geef de nieuwe naam van de leerling:";
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(182, 176);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(160, 50);
            this.btnAnnuleren.TabIndex = 9;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(16, 176);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(160, 50);
            this.btnToevoegen.TabIndex = 8;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            // 
            // FrmAanpassen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 243);
            this.ControlBox = false;
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.cmbKiesLeerling);
            this.Controls.Add(this.lblKiesLln);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmAanpassen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aanpassen leerling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKiesLeerling;
        private System.Windows.Forms.Label lblKiesLln;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnToevoegen;
    }
}