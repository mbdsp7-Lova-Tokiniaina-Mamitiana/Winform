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
        private void populateData()
        {
            this.nbrpages = MatchService.nbrpages;
            this.totals = MatchService.nbresults;
            this.dataGridView1.DataSource = this.liste;
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
