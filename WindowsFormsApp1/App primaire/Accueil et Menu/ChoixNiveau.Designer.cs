namespace WindowsFormsApp1
{
    partial class ChoixNiveau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoixNiveau));
            this.BoutonCP = new System.Windows.Forms.Button();
            this.BoutonCE1 = new System.Windows.Forms.Button();
            this.BoutonCE2 = new System.Windows.Forms.Button();
            this.BoutonCM1 = new System.Windows.Forms.Button();
            this.BoutonCM2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoutonCP
            // 
            this.BoutonCP.Location = new System.Drawing.Point(25, 50);
            this.BoutonCP.Name = "BoutonCP";
            this.BoutonCP.Size = new System.Drawing.Size(128, 70);
            this.BoutonCP.TabIndex = 0;
            this.BoutonCP.Text = "CP";
            this.BoutonCP.UseVisualStyleBackColor = true;
            this.BoutonCP.Click += new System.EventHandler(this.BoutonCP_Click);
            // 
            // BoutonCE1
            // 
            this.BoutonCE1.Location = new System.Drawing.Point(25, 171);
            this.BoutonCE1.Name = "BoutonCE1";
            this.BoutonCE1.Size = new System.Drawing.Size(128, 70);
            this.BoutonCE1.TabIndex = 1;
            this.BoutonCE1.Text = "CE1";
            this.BoutonCE1.UseVisualStyleBackColor = true;
            // 
            // BoutonCE2
            // 
            this.BoutonCE2.Location = new System.Drawing.Point(25, 295);
            this.BoutonCE2.Name = "BoutonCE2";
            this.BoutonCE2.Size = new System.Drawing.Size(128, 70);
            this.BoutonCE2.TabIndex = 2;
            this.BoutonCE2.Text = "CE2";
            this.BoutonCE2.UseVisualStyleBackColor = true;
            // 
            // BoutonCM1
            // 
            this.BoutonCM1.Location = new System.Drawing.Point(25, 420);
            this.BoutonCM1.Name = "BoutonCM1";
            this.BoutonCM1.Size = new System.Drawing.Size(128, 70);
            this.BoutonCM1.TabIndex = 3;
            this.BoutonCM1.Text = "CM1";
            this.BoutonCM1.UseVisualStyleBackColor = true;
            // 
            // BoutonCM2
            // 
            this.BoutonCM2.Location = new System.Drawing.Point(25, 544);
            this.BoutonCM2.Name = "BoutonCM2";
            this.BoutonCM2.Size = new System.Drawing.Size(128, 70);
            this.BoutonCM2.TabIndex = 4;
            this.BoutonCM2.Text = "CM2";
            this.BoutonCM2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 716);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 86);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Retour);
            // 
            // ChoixNiveau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 826);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoutonCM2);
            this.Controls.Add(this.BoutonCM1);
            this.Controls.Add(this.BoutonCE2);
            this.Controls.Add(this.BoutonCE1);
            this.Controls.Add(this.BoutonCP);
            this.Name = "ChoixNiveau";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BoutonCP;
        private System.Windows.Forms.Button BoutonCE1;
        private System.Windows.Forms.Button BoutonCE2;
        private System.Windows.Forms.Button BoutonCM1;
        private System.Windows.Forms.Button BoutonCM2;
        private System.Windows.Forms.Button button1;
    }
}