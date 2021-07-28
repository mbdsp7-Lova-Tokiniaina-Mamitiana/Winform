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
    public partial class Accueil : Form
    {
        UserService userService = new UserService();
        MatchService matchService = new MatchService();
        private List<Match> liste = new List<Match>();
        private int page = 1, max = 10, nbrpages = 1, totals = 0;

        public Accueil()
        {
            //Check connected

            InitializeComponent();
            setDate();
          
            rechercher();
        }
        private void setDate()
        {
            this.dateTimePicker1.Value = new DateTime(DateTime.Now.Year,1,1);
            this.dateTimePicker2.Value = new DateTime(DateTime.Now.Year, 12, 31);
        }
        private void deco_Click(object sender, EventArgs e)
        {
            userService.logout();
            new Login().Show();
            this.Hide();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            rechercher();
        }

        private void creationMatch_Click(object sender, EventArgs e)
        {
            new CreationMatch(null).Show();

        }
        private void setDataGridView()
        {

          

            DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();
            deletebutton.Name = "terminer";
            deletebutton.Text = "Terminer";
            
            deletebutton.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn voirbutton = new DataGridViewButtonColumn();
            voirbutton.Name = "voir";
            voirbutton.Text = "Voir";
            voirbutton.UseColumnTextForButtonValue = true;
            if (dataGridView1.Columns["terminer"] == null)
            {
              
              //  dataGridView1.Columns.Insert(5, deletebutton);


            }
           
            if (dataGridView1.Columns["voir"] == null)
            {
                dataGridView1.Columns.Insert(4, voirbutton);

                dataGridView1.CellClick += dataGridView_CellClick;


            }
            DataGridViewButtonColumn deletebutton2 = new DataGridViewButtonColumn();
            deletebutton2.Name = "supprimer";
            deletebutton2.Text = "Supprimer";

            deletebutton2.UseColumnTextForButtonValue = true;
            if (dataGridView1.Columns["supprimer"] == null)
            {
                dataGridView1.Columns.Insert(7, deletebutton2);


            }
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["LocalisationY"].Visible = false;
            dataGridView1.Columns["LocalistionX"].Visible = false;
            dataGridView1.Columns["Etat"].Visible = false;
            this.dataGridView1.Update();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["voir"].Index)
            {
                try
                {
                    int index = e.RowIndex;
                    Match m = liste[index];
                    CreationMatch c = new CreationMatch(m);
                    c.Show();

                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message + ": /n" + exc.StackTrace);
                    //  MessageBox.Show(exc.Message);
                   
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["supprimer"].Index)
            {
                try
                {
                    int index = e.RowIndex;
                    Match m = liste[index];
                    DialogResult res = MessageBox.Show("Etes vous sur de vouloir supprimer le match "+m.Description+" ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        matchService.supprimerMatch(m);
                        //this.liste.Remove(m);
                        rechercher();
                    }

                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message + ": /n" + exc.StackTrace);
                    //  MessageBox.Show(exc.Message);

                }
            }
        }
        private void populateData()
        {
            this.nbrpages = MatchService.nbrpages;
            this.totals = MatchService.nbresults;
            if (page == 1)
            {
                this.previous.Visible = false;
            }
            else
            {
                this.previous.Visible = true;
            }
            if (page >= nbrpages)
            {
                this.Suivant.Visible = false;
            }
            else
            {
                this.Suivant.Visible = true;
            }
          //  dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            this.dataGridView1.DataSource = this.liste;
            setDataGridView();
        }
        private void rechercher()
        {
            try
            {

                this.liste = matchService.GetMatches(searchBox.Text, etatBox.Checked, isTodayBox.Checked,dateTimePicker1.Value,dateTimePicker2.Value,page,max);
                populateData();
            }catch(Exception exc)
            {
                Console.WriteLine(exc.Message + "/n" + exc.StackTrace);
            }
        }
    }
    
}
