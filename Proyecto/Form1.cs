using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Proyecto
{
    public partial class Form1 : Form
    {
         int level;
         int conde;
         int score=0;
         int dificultad = 1;
         public System.Media.SoundPlayer musica = new System.Media.SoundPlayer();
         int vidas=3;
         public int i, j;

        public Form1()
        {
            InitializeComponent();
            hm.Visible = false;
            asteroide1.Visible = false;
            asteroide2.Visible = false;
            aste3.Visible = false;
            aste4.Visible = false;
            aste5.Visible = false;
            aste6.Visible = false;
            laser.Visible = false;
            label2.Visible = false;
            timer1.Start();
            //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\personal\Downloads\SWS.wav");
            //simpleSound.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            this.BackgroundImage = Properties.Resources.spacee;

            label2.Text = "Score: " + score + Environment.NewLine + "Vidas: " + vidas;
            label2.Visible = true;
            hm.Visible = true;
            asteroide1.Visible = true;
            asteroide2.Visible = true;
            aste3.Visible = true;
            aste4.Visible = true;
            aste5.Visible = true;
            aste6.Visible = true;
            laser.Visible = true;
            btnSalir.Visible = false;
            btnDifficult.Visible = false;
            btnInstr.Visible = false;
            btnStart.Visible = false;
            dificultad = form4.Dificultad();
            #region dificultad
            if (dificultad == 0)
                dificultad = 1;

            if (dificultad == 1)
            {
                timer1.Interval = 110;
            }
            if (dificultad == 2)
            {
                timer1.Interval = 56;

                if (timer1.Enabled)
                {
                    //level2.start();
                }
            }
            if (dificultad == 3)
            {
                timer1.Interval = 40;
            }
            #endregion

            Nave ast1 = new Nave();
            Random rdn = new Random();
            int a = rdn.Next(50, 550);
            int b = rdn.Next(50, 550);
            int c = rdn.Next(50, 550);

            asteroide1.Location = new Point(a, 0);
            asteroide2.Location = new Point(b, 0);

        }




        private void btnDifficult_Click_1(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
