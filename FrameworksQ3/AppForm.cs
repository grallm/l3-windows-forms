using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameworksQ3
{
    public partial class AppForm : Form
    {
        private string[][] races = {
                new string[] { "Blue Jay", "Fireside", "Not Again" },
                new string[] { "Summers Night", "Coriolanus", "Blue Rinse", "Silver Shadow", "SLK" },
                new string[] { "Purple Rain", "Last Ditch", "Forty Fives", "Too Double" }
        };

        public AppForm()
        {
            InitializeComponent();

            for (int i = 1; i <= races.Length; i++)
            {
                racesListBox.Items.Add("Race " + i);
            }
        }

        // Select a race to display its participants
        private void selectRace(int i)
        {
            participantsListBox.DataSource = races[i];
        }

        private void SelectedRaceChanged(object sender, System.EventArgs e)
        {
            selectRace(racesListBox.SelectedIndex);
        }
    }
}
