using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pembuatan_Menu_Strip_dan_MDI_Form.GUI
{

    public partial class Tiimer : Form
    {
        int seconds;
        int minute;
        int hour;

        public Tiimer()
        {
            InitializeComponent();
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (minute == 59)
            {
                minute = 0;
            }
            else
            {
                minute++;
            }
            TimerMenit.Text = minute.ToString("D2");
        }

        private void TimerJam_Click(object sender, EventArgs e)
        {

        }

        private void TimerStart_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer2.Enabled)
            {
                if (seconds > 0 || minute > 0 || hour > 0)
                {
                    if (seconds > 0)
                    {
                        seconds--;
                    }
                    else
                    {
                        if (minute > 0)
                        {
                            minute--;
                            seconds = 59;
                        }
                        else if (hour > 0)
                        {
                            hour--;
                            minute = 59;
                            seconds = 59;
                        }
                    }
                }

            }
            TimerDetik.Text = seconds.ToString("D2");
            TimerMenit.Text = minute.ToString("D2");
            TimerJam.Text = hour.ToString("D2");

        }

        private void TimerStop_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void KurangDetik_Click(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds--;
            }
            else
            {
                seconds = 59;
            }

            TimerDetik.Text = seconds.ToString("D2");
        }

        private void TambahDetik_Click(object sender, EventArgs e)
        {
            if (seconds == 59)
            {
                seconds = 00;
            }
            else
            {
                seconds++;
            }
            TimerDetik.Text = seconds.ToString("D2");
        }

        private void TimerReset_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;

            hour = 00;
            minute = 00;
            seconds = 00;

            TimerJam.Text = hour.ToString("D2");
            TimerMenit.Text = minute.ToString("D2");
            TimerDetik.Text = seconds.ToString("D2");
        }

        private void KurangMenit_Click(object sender, EventArgs e)
        {
            if (minute > 0)
            {
                minute--;
            }
            else
            {
                minute = 59;
            }

            TimerMenit.Text = minute.ToString("D2");
        }

        private void TambahJam_Click(object sender, EventArgs e)
        {
            hour++;
            TimerJam.Text = hour.ToString("D2");
        }

        private void KurangJam_Click(object sender, EventArgs e)
        {
            if (hour > 0)
            {
                hour--;
            }
            else
            {
                hour = 23;
            }

            TimerJam.Text = hour.ToString("D2");
        }
    }
}
