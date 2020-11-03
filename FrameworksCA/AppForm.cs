using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrameworksCA
{
    public partial class AppForm : Form
    {
        private readonly Random random = new Random();
        private List<TextBox> allTextBoxes = new List<TextBox>();

        public AppForm()
        {
            InitializeComponent();

            TextBox[] textBoxesArr = { textBox1, textBox2, textBox6, textBox5, textBox4, textBox3 };
            allTextBoxes = new List<TextBox>(textBoxesArr);

            generateNumbers();
        }

        // Generate and display all 6 Lotto numbers
        private void generateNumbers()
        {
            SortedSet<int> numbers = new SortedSet<int>();

            while (numbers.Count < allTextBoxes.Count)
            {
                numbers.Add(random.Next(1, 50));
            }

            int i = 0;
            foreach (int number in numbers)
            {
                allTextBoxes[i].Text = number.ToString();
                ++i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generateNumbers();
        }
    }
}
