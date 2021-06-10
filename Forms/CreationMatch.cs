using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Model;
using Winform.Services;

namespace Winform.Forms
{
    public partial class CreationMatch : Form
    {
        private EquipeService equipeService = new EquipeService();
        private List<Equipe> listeEquipe = null;
        public CreationMatch()
        {
            InitializeComponent();
            this.loadEquipe();

        }
        private void loadEquipe()
        {
            listeEquipe = equipeService.GetEquipes();
            populateListBox();
        }
        private void populateListBox()
        {
            this.listEquipe1.Items.Clear();
            this.listEquipe2.Items.Clear();
            this.listEquipe1.DataSource = listeEquipe;
            Equipe[] liste2 = new Equipe[listeEquipe.Count];
            listeEquipe.CopyTo(liste2);
            this.listEquipe2.DataSource = liste2;
            this.listEquipe1.DisplayMember = "Nom";
            this.listEquipe2.DisplayMember = "Nom";

          

        }
        private void choix_equipe_Click(object sender, EventArgs e)
        {

        }

        private void listEquipe1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipe selected = (Equipe)listEquipe1.SelectedItem;
            this.pictureBox1.Load(selected.Avatar);
        }

        private void listEquipe2_SelectedIndexChanged(object sender, EventArgs e)
        {

            Equipe selected = (Equipe)listEquipe2.SelectedItem;
            this.pictureBox2.Load(selected.Avatar);
        }
    }
}
