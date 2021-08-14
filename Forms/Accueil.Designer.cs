
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
            this.results = new System.Windows.Forms.Label();
            this.creationMatch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.etatBox = new System.Windows.Forms.CheckBox();
            this.isTodayBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.previous = new System.Windows.Forms.Button();
            this.Suivant = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pages = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deco
            // 
            this.deco.BackColor = System.Drawing.Color.Red;
            this.deco.FlatAppearance.BorderSize = 0;
            this.deco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deco.Location = new System.Drawing.Point(736, 12);
            this.deco.Name = "deco";
            this.deco.Size = new System.Drawing.Size(91, 23);
            this.deco.TabIndex = 0;
            this.deco.Text = "Se deconnecter";
            this.deco.UseVisualStyleBackColor = false;
            this.deco.Click += new System.EventHandler(this.deco_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(145, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 530);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // results
            // 
            this.results.AllowDrop = true;
            this.results.AutoSize = true;
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(362, 216);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(102, 13);
            this.results.TabIndex = 2;
            this.results.Text = "Liste des matchs";
            this.results.Click += new System.EventHandler(this.label1_Click);
            // 
            // creationMatch
            // 
            this.creationMatch.BackColor = System.Drawing.Color.ForestGreen;
            this.creationMatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.creationMatch.ForeColor = System.Drawing.SystemColors.Control;
            this.creationMatch.Location = new System.Drawing.Point(12, 12);
            this.creationMatch.Name = "creationMatch";
            this.creationMatch.Size = new System.Drawing.Size(104, 23);
            this.creationMatch.TabIndex = 3;
            this.creationMatch.Text = "Creer un match";
            this.creationMatch.UseVisualStyleBackColor = false;
            this.creationMatch.Click += new System.EventHandler(this.creationMatch_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(245, 58);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(259, 27);
            this.searchBox.TabIndex = 4;
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.searchbutton.FlatAppearance.BorderSize = 0;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbutton.Location = new System.Drawing.Point(510, 58);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 27);
            this.searchbutton.TabIndex = 5;
            this.searchbutton.Text = "Rechercher";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // etatBox
            // 
            this.etatBox.AutoSize = true;
            this.etatBox.Location = new System.Drawing.Point(293, 91);
            this.etatBox.Name = "etatBox";
            this.etatBox.Size = new System.Drawing.Size(69, 17);
            this.etatBox.TabIndex = 7;
            this.etatBox.Text = "Terminés";
            this.etatBox.UseVisualStyleBackColor = true;
            // 
            // isTodayBox
            // 
            this.isTodayBox.AutoSize = true;
            this.isTodayBox.Location = new System.Drawing.Point(386, 91);
            this.isTodayBox.Name = "isTodayBox";
            this.isTodayBox.Size = new System.Drawing.Size(78, 17);
            this.isTodayBox.TabIndex = 8;
            this.isTodayBox.Text = "Aujourd\'hui";
            this.isTodayBox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(386, 132);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.Color.DarkOrange;
            this.previous.FlatAppearance.BorderSize = 0;
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previous.Location = new System.Drawing.Point(145, 768);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 23);
            this.previous.TabIndex = 10;
            this.previous.Text = "Precedent";
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // Suivant
            // 
            this.Suivant.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Suivant.FlatAppearance.BorderSize = 0;
            this.Suivant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Suivant.Location = new System.Drawing.Point(607, 768);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(75, 23);
            this.Suivant.TabIndex = 11;
            this.Suivant.Text = "Suivant";
            this.Suivant.UseVisualStyleBackColor = false;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Liste des matchs";
            // 
            // pages
            // 
            this.pages.AutoSize = true;
            this.pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pages.Location = new System.Drawing.Point(396, 773);
            this.pages.Name = "pages";
            this.pages.Size = new System.Drawing.Size(41, 13);
            this.pages.TabIndex = 13;
            this.pages.Text = "label1";
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading.ForeColor = System.Drawing.Color.Red;
            this.loading.Location = new System.Drawing.Point(273, 176);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(231, 24);
            this.loading.TabIndex = 15;
            this.loading.Text = "Veuillez patienter un instant ....";
            this.loading.UseCompatibleTextRendering = true;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(839, 840);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Suivant);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.isTodayBox);
            this.Controls.Add(this.etatBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.creationMatch);
            this.Controls.Add(this.results);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deco);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Accueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deco;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.Button creationMatch;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox etatBox;
        private System.Windows.Forms.CheckBox isTodayBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button Suivant;
        internal System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pages;
        private System.Windows.Forms.Label loading;
    }
}