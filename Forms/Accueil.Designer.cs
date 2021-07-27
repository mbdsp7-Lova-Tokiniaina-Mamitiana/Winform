
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.creationMatch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.etatBox = new System.Windows.Forms.CheckBox();
            this.isTodayBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deco
            // 
            this.deco.Location = new System.Drawing.Point(697, 12);
            this.deco.Name = "deco";
            this.deco.Size = new System.Drawing.Size(91, 23);
            this.deco.TabIndex = 0;
            this.deco.Text = "deconnexion";
            this.deco.UseVisualStyleBackColor = true;
            this.deco.Click += new System.EventHandler(this.deco_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 530);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des matchs";
            // 
            // creationMatch
            // 
            this.creationMatch.Location = new System.Drawing.Point(122, 63);
            this.creationMatch.Name = "creationMatch";
            this.creationMatch.Size = new System.Drawing.Size(104, 23);
            this.creationMatch.TabIndex = 3;
            this.creationMatch.Text = "Creer un match";
            this.creationMatch.UseVisualStyleBackColor = true;
            this.creationMatch.Click += new System.EventHandler(this.creationMatch_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(122, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(199, 20);
            this.searchBox.TabIndex = 4;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(336, 9);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 5;
            this.searchbutton.Text = "Rechercher";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // etatBox
            // 
            this.etatBox.AutoSize = true;
            this.etatBox.Location = new System.Drawing.Point(435, 14);
            this.etatBox.Name = "etatBox";
            this.etatBox.Size = new System.Drawing.Size(69, 17);
            this.etatBox.TabIndex = 7;
            this.etatBox.Text = "Terminés";
            this.etatBox.UseVisualStyleBackColor = true;
            // 
            // isTodayBox
            // 
            this.isTodayBox.AutoSize = true;
            this.isTodayBox.Location = new System.Drawing.Point(511, 14);
            this.isTodayBox.Name = "isTodayBox";
            this.isTodayBox.Size = new System.Drawing.Size(78, 17);
            this.isTodayBox.TabIndex = 8;
            this.isTodayBox.Text = "Aujourd\'hui";
            this.isTodayBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(265, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.isTodayBox);
            this.Controls.Add(this.etatBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.creationMatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deco);
            this.Name = "Accueil";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deco;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button creationMatch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox etatBox;
        private System.Windows.Forms.CheckBox isTodayBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}