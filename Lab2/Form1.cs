using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1 || numericUpDown1.Value > 30)
            {
                MessageBox.Show("ви ввели не правильне число", "Error!", MessageBoxButtons.OK);
                Close();
            }
             Random random = new Random(DateTime.Now.Millisecond);
            DialogResult result;
            int counter = 0;
            do
            {
                counter++;
                result = MessageBox.Show($"Ваше число-{random.Next(1, 30)}?", $"Спроба-{counter}", MessageBoxButtons.YesNo);
            } while (result != DialogResult.Yes);
            MessageBox.Show($"Ура я вгадав!","Перемога" ,MessageBoxButtons.OK);
            Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
