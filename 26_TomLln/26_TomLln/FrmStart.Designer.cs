namespace _26_TomLln
{
    partial class FrmStart
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
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnTonen = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.BackColor = System.Drawing.Color.White;
            this.btnToevoegen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnToevoegen.Location = new System.Drawing.Point(12, 12);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(218, 49);
            this.btnToevoegen.TabIndex = 0;
            this.btnToevoegen.Text = "Toevoegen leerling";
            this.btnToevoegen.UseVisualStyleBackColor = false;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnTonen
            // 
            this.btnTonen.BackColor = System.Drawing.Color.White;
            this.btnTonen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTonen.Location = new System.Drawing.Point(12, 67);
            this.btnTonen.Name = "btnTonen";
            this.btnTonen.Size = new System.Drawing.Size(218, 49);
            this.btnTonen.TabIndex = 1;
            this.btnTonen.Text = "Tonen leerling";
            this.btnTonen.UseVisualStyleBackColor = false;
            this.btnTonen.Click += new System.EventHandler(this.btnTonen_Click);
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.BackColor = System.Drawing.Color.White;
            this.btnAfsluiten.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAfsluiten.Location = new System.Drawing.Point(12, 232);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(218, 49);
            this.btnAfsluiten.TabIndex = 2;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = false;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.BackColor = System.Drawing.Color.White;
            this.btnVerwijderen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerwijderen.Location = new System.Drawing.Point(12, 177);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(218, 49);
            this.btnVerwijderen.TabIndex = 4;
            this.btnVerwijderen.Text = "Verwijderen leerling";
            this.btnVerwijderen.UseVisualStyleBackColor = false;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.BackColor = System.Drawing.Color.White;
            this.btnAanpassen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAanpassen.Location = new System.Drawing.Point(12, 122);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(218, 49);
            this.btnAanpassen.TabIndex = 3;
            this.btnAanpassen.Text = "Aanpassen leerling";
            this.btnAanpassen.UseVisualStyleBackColor = false;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(241, 293);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnTonen);
            this.Controls.Add(this.btnToevoegen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startmenu:";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnTonen;
        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.Button btnAanpassen;
    }
}

