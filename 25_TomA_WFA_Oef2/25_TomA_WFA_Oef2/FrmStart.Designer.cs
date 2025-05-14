namespace _25_TomA_WFA_Oef2
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
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.lblBoodschap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(276, 262);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(211, 52);
            this.btnAfsluiten.TabIndex = 0;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // lblBoodschap
            // 
            this.lblBoodschap.AutoSize = true;
            this.lblBoodschap.Location = new System.Drawing.Point(2, 67);
            this.lblBoodschap.Name = "lblBoodschap";
            this.lblBoodschap.Size = new System.Drawing.Size(730, 92);
            this.lblBoodschap.TabIndex = 1;
            this.lblBoodschap.Text = "Beste gebruiker.\r\nMijn naam is Tom Adriaens en ik ben de programmeur van dit prog" +
    "ramma.\r\nIk woon in Dendermonde en ik ben 42 jaar oud.\r\nNog een fijne dag verder." +
    "";
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 418);
            this.ControlBox = false;
            this.Controls.Add(this.lblBoodschap);
            this.Controls.Add(this.btnAfsluiten);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startmenu:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfsluiten;
        private System.Windows.Forms.Label lblBoodschap;
    }
}

