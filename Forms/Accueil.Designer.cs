
namespace Winform.Forms
{
    partial class Accueil
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
            this.deco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deco
            // 
            this.deco.Location = new System.Drawing.Point(576, 13);
            this.deco.Name = "deco";
            this.deco.Size = new System.Drawing.Size(75, 23);
            this.deco.TabIndex = 0;
            this.deco.Text = "deconnexion";
            this.deco.UseVisualStyleBackColor = true;
            this.deco.Click += new System.EventHandler(this.deco_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deco);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deco;
    }
}