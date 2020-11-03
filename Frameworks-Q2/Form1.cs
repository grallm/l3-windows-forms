using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frameworks_Q2
{
    public partial class Form1 : Form
    {
        private SortedList<int, int[]> rainfallYears = new SortedList<int, int[]> {
            { 2017, new int[] { 163, 89, 97, 133} },
            { 2018, new int[] { 147, 88, 96, 129 } },
            { 2016, new int[] { 150, 100, 157, 184} },
            { 2019, new int[] { 138, 87, 94, 117 } }
        };

        private readonly string[] seasons = { "Spring", "Summer", "Autumn", "Winter" };

        private List<int>[] fallsBySeasons()
        {
            // Prepare seasons
            List<int>[] rainfallsSeasons =
            {
                new List<int>(), new List<int>(), new List<int>(), new List<int>()
            };

            for (int i = 0; i < rainfallYears.Count; i++)
            {
                rainfallsSeasons[0].Add(rainfallYears.Values[i][0]);
                rainfallsSeasons[1].Add(rainfallYears.Values[i][1]);
                rainfallsSeasons[2].Add(rainfallYears.Values[i][2]);
                rainfallsSeasons[3].Add(rainfallYears.Values[i][3]);
            }

            return rainfallsSeasons;
        }

        public Form1()
        {
            InitializeComponent();
            fillRainfallGrid();

            // Prepare combos
            yearCombo.Items.Add("All Years");
            yearCombo.Items.AddRange(rainfallYears.Keys.ToArray().Cast<object>().ToArray());
            seasonCombo.Items.Add("All Seasons");
            seasonCombo.Items.AddRange(seasons.Cast<object>().ToArray());

            // Fill all labels
            driestYear_click(null, null);
            wettestYear_click(null, null);
            driestSeason_click(null, null);
            wettestSeason_click(null, null);

            // Default total value
            displayTotalRainfall(null, null);
        }

        private void fillRainfallGrid()
        {
            rainfallDataGrid.Rows.Clear();
            rainfallDataGrid.ColumnCount = rainfallYears.Count + 1;

            // Prepare rows
            List<string>[] rainfallsSeasons =
            {
                new List<string>{ seasons[0] }, new List<string>{ seasons[1] }, new List<string>{ seasons[2] }, new List<string>{ seasons[3] }
            };

            // Add all years as column names
            for (int i = 0; i <= rainfallYears.Count; i++)
            {
                rainfallDataGrid.Columns[i].Name = (i == 0) ? "" : rainfallYears.Keys[i - 1].ToString();

                // Fill all seasons
                if (i > 0)
                {
                    rainfallsSeasons[0].Add(rainfallYears.Values[i - 1][0].ToString());
                    rainfallsSeasons[1].Add(rainfallYears.Values[i - 1][1].ToString());
                    rainfallsSeasons[2].Add(rainfallYears.Values[i - 1][2].ToString());
                    rainfallsSeasons[3].Add(rainfallYears.Values[i - 1][3].ToString());
                }
            }

            // Display all seasons
            for (int i = 0; i < seasons.Length; i++)
            {
                rainfallDataGrid.Rows.Add(rainfallsSeasons[i].ToArray());
            }
        }

        // Display ther driest year 
        public void driestYear_click(object sender, EventArgs e)
        {
            int[] rainfallYearsSum = rainfallYears.Select(year => year.Value.Sum()).ToArray();
            int indexYearMin = Array.IndexOf(rainfallYearsSum, rainfallYearsSum.Min());

            driestYrText.Text = "Driest Year : " + rainfallYears.Keys[indexYearMin].ToString() + " - " + rainfallYearsSum[indexYearMin] + "mm";
        }

        // Display ther wettest year 
        public void wettestYear_click(object sender, EventArgs e)
        {
            int[] rainfallYearsSum = rainfallYears.Select(year => year.Value.Sum()).ToArray();
            int indexYearMax = Array.IndexOf(rainfallYearsSum, rainfallYearsSum.Max());

            wettestYrText.Text = "Wettest Year : " + rainfallYears.Keys[indexYearMax].ToString() + " - " + rainfallYearsSum[indexYearMax] + "mm";
        }

        // Display ther driest season 
        public void driestSeason_click(object sender, EventArgs e)
        {
            int[] rainfallSeasonSum = fallsBySeasons().Select(season => season.Sum()).ToArray();
            int indexSeasMin = Array.IndexOf(rainfallSeasonSum, rainfallSeasonSum.Min());

            driestSsText.Text = "Driest Season : " + seasons[indexSeasMin] + " - " + rainfallSeasonSum[indexSeasMin] + "mm";
        }

        // Display ther wettest season 
        public void wettestSeason_click(object sender, EventArgs e)
        {
            int[] rainfallSeasonSum = fallsBySeasons().Select(season => season.Sum()).ToArray();
            int indexSeasMax = Array.IndexOf(rainfallSeasonSum, rainfallSeasonSum.Max());

            wettestSsText.Text = "Wettest Season : " + seasons[indexSeasMax] + " - " + rainfallSeasonSum[indexSeasMax] + "mm";
        }


        // Display total rainfall for years/seasons selected
        public void displayTotalRainfall(object sender, System.EventArgs e)
        {
            int yearIndex = (yearCombo.SelectedIndex == -1) ? 0 : yearCombo.SelectedIndex;
            int seasonIndex = (seasonCombo.SelectedIndex == -1) ? 0 : seasonCombo.SelectedIndex;

            int rainfall;

            // If all years
            if (yearIndex == 0)
            {
                List<int>[] fallsSeasons = fallsBySeasons();
                // All seasons or 1
                rainfall = (seasonIndex == 0) ? fallsSeasons.Select(season => season.Sum()).Sum() : fallsSeasons[seasonIndex - 1].Sum();
            }
            else
            {
                int[] yearFalls = rainfallYears.Values[yearIndex - 1];
                // All seasons or 1
                rainfall = (seasonIndex == 0) ? yearFalls.Sum() : yearFalls[seasonIndex - 1];
            }

            totalRainfallText.Text = "Total Rainfall : "
                + ((yearIndex == 0) ? "All Years" : yearCombo.SelectedItem)
                + " - "
                + ((seasonIndex == 0) ? "All Years" : seasonCombo.SelectedItem)
                + " = " + rainfall.ToString() + "mm";
        }

        private void addYear_Click(object sender, EventArgs e)
        {
            // Transform strings to int
            string[] valToParse = { yearInput.Text, springInput.Text, summerInput.Text, autumnInput.Text, winterInput.Text };
            int[] valParsed = new int[5];

            for (int i = 0; i < valToParse.Length; i++)
            {
                // Check if all int
                if (int.TryParse(valToParse[i], out valParsed[i]))
                {
                    // Check if falls > 0
                    if (i > 0 && valParsed[i] < 0)
                    {
                        return;
                    }
                }
                else
                {
                    return ;
                }
            }

            // Refresh Datagrid
            rainfallYears[valParsed[0]] = new int[] { valParsed[1], valParsed[2], valParsed[3], valParsed[4] };
            fillRainfallGrid();

            // Refresh Combos
            yearCombo.Items.Clear();
            yearCombo.Items.Add("All Years");
            yearCombo.Items.AddRange(rainfallYears.Keys.ToArray().Cast<object>().ToArray());
            seasonCombo.Items.Clear();
            seasonCombo.Items.Add("All Seasons");
            seasonCombo.Items.AddRange(seasons.Cast<object>().ToArray());
        }
    }
}
     