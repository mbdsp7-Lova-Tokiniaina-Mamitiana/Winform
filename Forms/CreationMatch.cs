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
        private MatchService matchService = new MatchService();
        private PariService pariService = new PariService();
        private List<Equipe> listeEquipe = null;
        private List<Pari> listePari = new List<Pari>();
        private Match match = null;
        public CreationMatch(Match m)
        {
            this.match = m;
            InitializeComponent();
           
            this.loadEquipe();
            if (match == null)
            {

                this.enablePariSection(false);
                this.terminer.Enabled = false;


            }
            else
            {
                this.enableMatchSection(false);
            }

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
        private void enableMatchSection(bool enable)
        {
            this.listEquipe1.Enabled = enable;
            this.listEquipe2.Enabled = enable;
            this.choix_equipe.Enabled = enable;
            this.longitude.Enabled = enable;
            this.latitude.Enabled = enable;
            this.pictureBox1.Enabled = enable;
            this.pictureBox2.Enabled = enable;
            this.dateTimePicker1.Enabled = enable;

        }
        private void enablePariSection(bool enable)
        {
            this.description.Enabled = enable;
            this.ajoutpari.Enabled = enable;
            this.cote.Enabled = enable;
            this.dataGridView1.Enabled = enable;
        }
        
        private void choix_equipe_Click(object sender, EventArgs e)
        {
            Match match = new Match();
            try
            {
                DateTime date = dateTimePicker1.Value;
                double longitude=0,latitude = 0;
                try
                {
                    longitude = System.Convert.ToDouble(this.longitude.Text);
                    latitude = System.Convert.ToDouble(this.latitude.Text);
                }
                catch(Exception)
                {
                    throw new Exception("Longitute ou latitude doit etre fournie");
                }
                 
                Equipe domicile = (Equipe)listEquipe1.SelectedItem;
                Equipe exterieur = (Equipe)listEquipe2.SelectedItem;
                match.Date = date;
                match.LocalistionX = longitude;
                match.LocalisationY = latitude;
                match.Exterieur = exterieur;
                match.Domicile = domicile;
                matchService.CreerMatch(match);
                this.match = match;
                enableMatchSection(false);
                enablePariSection(true);
                MessageBox.Show("Match cree", "Creation de match", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Creation de match",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(exc.Message + ": /n" + exc.StackTrace);
               // MessageBox.Show(exc.Message);
            }

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
        private void populateDataPari()
        {
            this.dataGridView1.DataSource = listePari;
            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();
            deletebutton.Name = "suppression";
            deletebutton.Text = "Supprimer";
            deletebutton.UseColumnTextForButtonValue = true;

            
            int columnIndex = 3;
            if (dataGridView1.Columns["suppression"] == null)
            {
                dataGridView1.Columns.Insert(columnIndex, deletebutton);

                dataGridView1.CellClick += dataGridView_CellClick;

            }
            dataGridView1.Columns["Id"].Visible = false;
            this.dataGridView1.Update();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["suppression"].Index)
            {
                try
                {
                    int index = e.RowIndex;
                    pariService.RemovePari(dataGridView1.Rows[index].Cells["Id"].Value.ToString(), match.Id);
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.Update();
                    this.listePari.RemoveAt(index);
                    this.populateDataPari();

                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message + ": /n" + exc.StackTrace);
                  //  MessageBox.Show(exc.Message);
                    MessageBox.Show(exc.Message, "Suppression Pari", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ajoutpari_Click(object sender, EventArgs e)
        {
            Pari pari = new Pari();
            try
            {
                pari.Description = description.Text;
                try
                {
                    pari.Cote = System.Convert.ToDouble(cote.Text);
                }
                catch(Exception)
                {
                    throw new Exception("Cote doit etre valide");
                }
               
                pariService.CreerPari(pari);
                pariService.AddPari(pari.Id, match.Id);
                this.listePari.Add(pari);
                
                populateDataPari();

            }catch(Exception exc)
            {
                Console.WriteLine(exc.Message+": /n"+exc.StackTrace);

                MessageBox.Show(exc.Message, "Ajout Pari", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<Pari> getListeSelected()
        {
            List<Pari> list = new List<Pari>();
            return list;
        }
        private void terminer_Click(object sender, EventArgs e)
        {
            try
            {
                List<Pari> list = getListeSelected();

                matchService.distribuerGain(list, this.match);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message + ": /n" + exc.StackTrace);
                MessageBox.Show(exc.Message, "Terminer match", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
