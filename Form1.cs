using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nr7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b, c, x1, x2;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("7 lab_nr 5. Kvadratinės lygties ax^2+bx+c=0 sprendimas.  Darbą atliko Marius Petokaitis PS16.", "Informacija", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num;
            bool sk = double.TryParse(textBox1.Text, out num);
            bool sk2 = double.TryParse(textBox2.Text, out num);
            bool sk3 = double.TryParse(textBox3.Text, out num);
            if (sk & sk2 & sk3)
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                if (a != 0)
                {
                    double D = Math.Round(b * b - 4 * a * c, 3);
                    if (D >= 0)
                    {
                        x1 = Math.Round((-b + Math.Sqrt(D)) / (2 * a), 3);
                        x2 = Math.Round((-b - Math.Sqrt(D)) / (2 * a), 3);
                        textBox4.Text = Convert.ToString(x1);
                        textBox5.Text = Convert.ToString(x2);
                    }
                    else
                    {
                        MessageBox.Show("Diskriminantas yra neigiamas. Nėra tokių taškų, kuriuose grafikas kirstų OX ašį.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Koeficientas a negali būti lygus 0, nes lygtis nebus kvadratinė. Įveskite kitą a reikšmę.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Suklydote, įvedėte raidę arba netinkamą ženklą. Koeficientas gali būti tik skaičius (dešimtainiame skaičiuje naujojamas kablelis).", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num;
            bool sk = double.TryParse(textBox1.Text, out num);
            bool sk2 = double.TryParse(textBox2.Text, out num);
            bool sk3 = double.TryParse(textBox3.Text, out num);
            if (sk & sk2 & sk3)
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                c = double.Parse(textBox3.Text);
                var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Color = System.Drawing.Color.Red,
                    IsVisibleInLegend = false,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
                };

                this.chart1.Series.Add(series1);
                for (int x = -22; x < 19; x++)
                {
                    var fx = a * x * x + b * x + c;
                    series1.Points.AddXY(x, fx);
                }
            }
            else
            {
                MessageBox.Show("Įvesti koeficientai yra netinkami ir grafiko nubrėžti nepavyks. Patikrinkite ar tikrai įvedėte skaičius", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)

       {
           chart1.Series.Clear();
       }

    }
}

