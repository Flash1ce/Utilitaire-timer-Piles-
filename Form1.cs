using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        public void Crono(bool CF)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(this.lblSegonce.Text);
            time += 1;
            string times = time.ToString();
            if (time <= 60)
            {
                this.lblSegonce.Text = times;
            }
            else
            {
                this.lblSegonce.Text = "0";
                int minute = Convert.ToInt32(this.lblMinute.Text);
                minute += 1;
                string minutes = minute.ToString();
                this.lblMinute.Text = minutes;
            }

            int minute2 = Convert.ToInt32(this.lblMinute.Text);
            if (minute2 > 60)
            {
                int heure = Convert.ToInt32(this.lblHeure.Text);
                heure += 1;
                string heures = heure.ToString();
                this.lblHeure.Text = heures;
                this.lblMinute.Text = "0";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.lblSegonce.Text = "0";
            this.lblHeure.Text = "0";
            this.lblMinute.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer2.Stop();
            this.numHeure.Value = 0;
            this.numMinu.Value = 0;
            this.numSec.Value = 0;
            this.label2.Text = "0";
            this.label4.Text = "0";
            this.label6.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer2.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timeHeure = Convert.ToInt32(this.label2.Text);
            int timeMinute = Convert.ToInt32(this.label4.Text);
            int timeSecond = Convert.ToInt32(this.label6.Text);

            if (timeSecond >= 1)
            {
                timeSecond -= 1;
                this.label6.Text = timeSecond.ToString();
            }
            if (timeMinute >= 1 && timeSecond == 0)
            {
                timeMinute -= 1;
                this.label6.Text = "60";
                this.label4.Text = timeMinute.ToString();
            }
            if (timeHeure >= 1 && timeMinute == 0 && timeSecond == 0)
            {
                timeHeure -= 1;
                this.label2.Text = timeHeure.ToString();
                this.label4.Text = "59";
                this.label6.Text = "60";
            }
        }

        private void numHeure_ValueChanged(object sender, EventArgs e)
        {
            this.label2.Text = this.numHeure.Value.ToString();
        }

        private void numMinu_ValueChanged(object sender, EventArgs e)
        {
            this.label4.Text = this.numMinu.Value.ToString();
        }

        private void numSec_ValueChanged(object sender, EventArgs e)
        {
            this.label6.Text = this.numSec.Value.ToString();
        }

        //public static Random generateurAleatoire = new Random();
        private void button4_Click(object sender, EventArgs e)
        {
            Random generateurAleatoire = new Random();

            int index = generateurAleatoire.Next(0, 10);
            if (index == 0 || index == 1 || index == 5 || index == 6 ||index == 7)
            {
                this.lblPileOuFace.Text = "Pile";
            }
            else if (index == 2 || index == 3 || index == 4 || index == 8 || index == 9)
            {
                this.lblPileOuFace.Text = "Face";
            }
        }

        private void BtnQuiter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
