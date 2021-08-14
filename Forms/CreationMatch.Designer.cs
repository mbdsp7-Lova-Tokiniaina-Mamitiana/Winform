
namespace Winform.Forms
{
    partial class CreationMatch
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
            this.description = new System.Windows.Forms.TextBox();
            this.ajoutpari = new System.Windows.Forms.Button();
            this.cote = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.choix_equipe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listEquipe1 = new System.Windows.Forms.ComboBox();
            this.listEquipe2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.longitude = new System.Windows.Forms.TextBox();
            this.latitude = new System.Windows.Forms.TextBox();
            this.terminer = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creation d\'un match";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(78, 286);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(549, 50);
            this.description.TabIndex = 3;
            // 
            // ajoutpari
            // 
            this.ajoutpari.BackColor = System.Drawing.Color.Orange;
            this.ajoutpari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ajoutpari.Location = new System.Drawing.Point(328, 402);
            this.ajoutpari.Name = "ajoutpari";
            this.ajoutpari.Size = new System.Drawing.Size(75, 23);
            this.ajoutpari.TabIndex = 4;
            this.ajoutpari.Text = "Ajouter pari";
            this.ajoutpari.UseVisualStyleBackColor = false;
            this.ajoutpari.Click += new System.EventHandler(this.ajoutpari_Click);
            // 
            // cote
            // 
            this.cote.Location = new System.Drawing.Point(328, 360);
            this.cote.Name = "cote";
            this.cote.Size = new System.Drawing.Size(77, 20);
            this.cote.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(78, 477);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 250);
            this.dataGridView1.TabIndex = 6;
            // 
            // choix_equipe
            // 
            this.choix_equipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.choix_equipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.choix_equipe.Location = new System.Drawing.Point(328, 235);
            this.choix_equipe.Name = "choix_equipe";
            this.choix_equipe.Size = new System.Drawing.Size(75, 23);
            this.choix_equipe.TabIndex = 8;
            this.choix_equipe.Text = "Creer Match";
            this.choix_equipe.UseVisualStyleBackColor = false;
            this.choix_equipe.Click += new System.EventHandler(this.choix_equipe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Liste des paris";
            // 
            // listEquipe1
            // 
            this.listEquipe1.FormattingEnabled = true;
            this.listEquipe1.Location = new System.Drawing.Point(78, 81);
            this.listEquipe1.Name = "listEquipe1";
            this.listEquipe1.Size = new System.Drawing.Size(121, 21);
            this.listEquipe1.TabIndex = 10;
            this.listEquipe1.SelectedIndexChanged += new System.EventHandler(this.listEquipe1_SelectedIndexChanged);
            // 
            // listEquipe2
            // 
            this.listEquipe2.FormattingEnabled = true;
            this.listEquipe2.Location = new System.Drawing.Point(506, 81);
            this.listEquipe2.Name = "listEquipe2";
            this.listEquipe2.Size = new System.Drawing.Size(121, 21);
            this.listEquipe2.TabIndex = 11;
            this.listEquipe2.SelectedIndexChanged += new System.EventHandler(this.listEquipe2_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(78, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(506, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(259, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // longitude
            // 
            this.longitude.Location = new System.Drawing.Point(314, 165);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(100, 20);
            this.longitude.TabIndex = 15;
            // 
            // latitude
            // 
            this.latitude.Location = new System.Drawing.Point(314, 209);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(100, 20);
            this.latitude.TabIndex = 16;
            // 
            // terminer
            // 
            this.terminer.BackColor = System.Drawing.Color.OrangeRed;
            this.terminer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.terminer.Location = new System.Drawing.Point(672, 517);
            this.terminer.Name = "terminer";
            this.terminer.Size = new System.Drawing.Size(75, 23);
            this.terminer.TabIndex = 17;
            this.terminer.Text = "Terminer Match";
            this.terminer.UseVisualStyleBackColor = false;
            this.terminer.Click += new System.EventHandler(this.terminer_Click);
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Red;
            this.supprimer.FlatAppearance.BorderSize = 0;
            this.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.supprimer.ForeColor = System.Drawing.SystemColors.Window;
            this.supprimer.Location = new System.Drawing.Point(518, 13);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(75, 23);
            this.supprimer.TabIndex = 18;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Description du pari";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "cote";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(314, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "longitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "latitude";
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading.ForeColor = System.Drawing.Color.Red;
            this.loading.Location = new System.Drawing.Point(255, 54);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(225, 20);
            this.loading.TabIndex = 24;
            this.loading.Text = "Veuillez patienter un instant ....";
            // 
            // CreationMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 739);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.terminer);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.longitude);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listEquipe2);
            this.Controls.Add(this.listEquipe1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.choix_equipe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cote);
            this.Controls.Add(this.ajoutpari);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label1);
            this.Name = "CreationMatch";
            this.Text = "CreationMatch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button ajoutpari;
        private System.Windows.Forms.TextBox cote;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button choix_equipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox listEquipe1;
        private System.Windows.Forms.ComboBox listEquipe2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.Button terminer;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label loading;
    }
}