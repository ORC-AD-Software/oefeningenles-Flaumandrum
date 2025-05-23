namespace _26_TomLln
{
    partial class FrmTonen
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
            this.txtToon = new System.Windows.Forms.TextBox();
            this.lblToon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(81, 203);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(131, 50);
            this.btnAnnuleren.TabIndex = 2;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // txtToon
            // 
            this.txtToon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtToon.Location = new System.Drawing.Point(17, 51);
            this.txtToon.Multiline = true;
            this.txtToon.Name = "txtToon";
            this.txtToon.ReadOnly = true;
            this.txtToon.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtToon.Size = new System.Drawing.Size(279, 131);
            this.txtToon.TabIndex = 3;
            // 
            // lblToon
            // 
            this.lblToon.AutoSize = true;
            this.lblToon.Location = new System.Drawing.Point(13, 13);
            this.lblToon.Name = "lblToon";
            this.lblToon.Size = new System.Drawing.Size(199, 24);
            this.lblToon.TabIndex = 4;
            this.lblToon.Text = "Hier zijn de leerlingen:";
            // 
            // FrmTonen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 277);
            this.ControlBox = false;
            this.Controls.Add(this.lblToon);
            this.Controls.Add(this.txtToon);
            this.Controls.Add(this.btnAnnuleren);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmTonen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toon leerlingen";
            this.Load += new System.EventHandler(this.FrmTonen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.TextBox txtToon;
        private System.Windows.Forms.Label lblToon;
    }
}