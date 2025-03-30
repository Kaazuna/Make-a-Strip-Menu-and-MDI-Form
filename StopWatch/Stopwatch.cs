
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pembuatan_Menu_Strip_dan_MDI_Form
{
    public partial class Stopwatch: Form
    {
        int Jam;
        int Menit;
        int Detik;
        public Stopwatch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                Detik++;
                if (Detik == 60)
                {
                    Detik = 0;
                    Menit++;
                }

                if (Menit == 60)
                {
                    Menit = 0;
                    Jam++;
                }

            }
            LabelDetik.Text = Detik.ToString("D2");
            LabelMenit.Text = Menit.ToString("D2");
            LabelJam.Text = Jam.ToString("D2");
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            Jam = 0;
            Menit = 0;
            Detik = 0;

            LabelDetik.Text = Detik.ToString("D2");
            LabelMenit.Text = Menit.ToString("D2");
            LabelJam.Text = Jam.ToString("D2");
        }
        private void Stopwatch_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; 
        }

    }
}
