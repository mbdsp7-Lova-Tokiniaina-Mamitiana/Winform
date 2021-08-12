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
        private bool canTermine = false;
        public CreationMatch(Match m)
        {
            this.match = m;
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.loadEquipe();
            hideLoader();
            if (match == null)
            {

                this.enablePariSection(false);
                this.terminer.Enabled = false;
                supprimer.Enabled = false;


            }
            else
            {
                canTermine = true;
                this.listePari = m.ListePari;
                populateDataPari();
                this.listEquipe1.SelectedIndex = getIndexEquipe(m.Domicile);
                this.listEquipe2.SelectedIndex = getIndexEquipe(m.Exterieur);
                this.pictureBox1.Load(m.Domicile.Avatar);
                this.pictureBox2.Load(m.Exterieur.Avatar);
                if (m.Etat)
                {
                    this.enablePariSection(false);
                }
                else
                {
                    if (canTermine)
                    {
                        this.terminer.Enabled = true;
                    }
                    else
                    {
                        this.terminer.Enabled = false;
                    }

                }
                this.enableMatchSection(false);
            }

        }
        private int getIndexEquipe(Equipe e)
        {
           
            int i = 0;
            foreach(Equipe e1 in listeEquipe)
            {
                if (e1.Nom.Equals(e.Nom))
                {
                    return i;
                }
                i++;
            }
            return 0;
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
            this.terminer.Enabled = enable;
        }
        private void showLoader()
        {
            this.loading.Visible = true;
            this.loading.Refresh();
        }
        private void hideLoader()
        {
            this.loading.Visible = false;
        }
        private void choix_equipe_Click(object sender, EventArgs e)
        {
            Match match = new Match();
            try
            {
                showLoader();
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
                supprimer.Enabled = true;
                MessageBox.Show("Match cree", "Creation de match", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hideLoader();


            }
            catch (Exception exc)
            {
                hideLoader();
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

            
            
            if (dataGridView1.Columns["suppression"] == null)
            {
                dataGridView1.Columns.Insert(3, deletebutton);

                dataGridView1.CellClick += dataGridView_CellClick;

            }
            
            dataGridView1.Columns["Id"].Visible = false;
          //  dataGridView1.Update();
            
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
                    this.dataGridView1.Columns.Clear();
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
                showLoader();
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
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Update();
                this.dataGridView1.Columns.Clear();
                this.listePari.Add(pari);
                hideLoader();
                populateDataPari();
                
            }catch(Exception exc)
            {
                hideLoader();
                Console.WriteLine(exc.Message+": /n"+exc.StackTrace);

                MessageBox.Show(exc.Message, "Ajout Pari", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<Pari> getListeSelected()
        {
            List<Pari> list = new List<Pari>();
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                int index = r.Index;
                Pari p = listePari[index];
                list.Add(p);
            }
            return list;
        }
        private void terminer_Click(object sender, EventArgs e)
        {
            try
            {
                showLoader();
                List<Pari> list = getListeSelected();
                
                matchService.distribuerGain(list, this.match);
                terminer.Enabled = false;
                MessageBox.Show("Le match est terminé", "Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hideLoader();

            }
            catch (Exception exc)
            {
                hideLoader();
                Console.WriteLine(exc.Message + ": /n" + exc.StackTrace);
                MessageBox.Show(exc.Message, "Terminer match", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                showLoader();
                DialogResult res = MessageBox.Show("Etes vous sur de vouloir supprimer ce match?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    matchService.supprimerMatch(match);
                    this.Hide();
                   
                }
                hideLoader();
                
            }catch(Exception exc)
            {
                hideLoader();
                MessageBox.Show(exc.Message, "Suppression match", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
