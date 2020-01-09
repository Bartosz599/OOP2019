using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRARPG
{
    public partial class Form2 : Form
    {
        public static int newhp, newdef, newdps, neweng;
        string text1;
        int wybor;
        public dynamic Bohater  => HeroSelection(wybor);
        
        public Form2(string text2, int wybor)
        {
            InitializeComponent();
            this.text1 = text2;
            this.wybor = wybor;
            label1.Text = text1;
            statystyki();
            czylvlup();
            backgroundWorker2.RunWorkerAsync();
            
            



        }
        
        dynamic HeroSelection(int wybor)
        {
            
            if (wybor == 1)
            {
                label8.Text = "dex";
                pictureBox1.ImageLocation = @"c:\Images\icon1.jpg";
                return new Lotrzyk(50,100, 100, 25, 1, 150, 100, 100, text1, 75, 75);
                
            }
            if (wybor == 2)
            {
                label8.Text = "int";
                pictureBox1.ImageLocation = @"c:\Images\icon2.jpg";
                return new Mag(50,75, 75, 15, 1, 0, 100, 100, text1, 100, 100);
            }
            else
            {
                pictureBox1.ImageLocation = @"c:\Images\icon3.jpg";
                label8.Text = "str";
                return new Wojownik(50, 50, 50, 75, 1, 0, 100, 100, text1, 125, 125);
            }

        }

        void statystyki()
        {
            if (Bohater.GetType().Name == "Lotrzyk")
            {

               
                progressBar2.Maximum = Bohater.hp_max;
                progressBar2.Value = Bohater.hp;
                    progressBar1.Maximum = Bohater.sp;
                    progressBar1.Value = Bohater.sp_max;
                    label7.Text = Convert.ToString(Bohater.lvl);
                    label9.Text = Convert.ToString(Bohater.def);
                    label4.Text = Convert.ToString(Bohater.gold);
                    label5.Text = Convert.ToString(Bohater.dex);
                

            }
            else if (Bohater.GetType().Name == "Mag")
            {

                
                progressBar2.Maximum = Bohater.hp_max;
                    progressBar2.Value = Bohater.hp;
                    progressBar1.Maximum = Bohater.mp;
                    progressBar1.Value = Bohater.mp_max;
                    label7.Text = Convert.ToString(Bohater.lvl);
                    label9.Text = Convert.ToString(Bohater.def);
                    label4.Text = Convert.ToString(Bohater.gold);
                    label5.Text = Convert.ToString(Bohater.Int);
                

            }
            else if (Bohater.GetType().Name == "Wojownik")
            {

                    
                    progressBar2.Maximum = Bohater.hp_max;
                    progressBar2.Value = Bohater.hp;
                    progressBar1.Maximum = Bohater.rage;
                    progressBar1.Value = Bohater.rage_max;
                    label7.Text = Convert.ToString(Bohater.lvl);
                    label9.Text = Convert.ToString(Bohater.def);
                    label4.Text = Convert.ToString(Bohater.gold);
                    label5.Text = Convert.ToString(Bohater.str);

                
            }
        }
        public void czylvlup()
        {
            
            if (Bohater.exp >= Bohater.lvl_next)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"c:\Images\lvlup.wav";
                player.Load();
                player.Play();
                if (wybor == 1)
                {
                    Form3 f3 = new Form3(wybor,Bohater.hp_max,Bohater.sp_max,Bohater.def,Bohater.dex);
                    this.Hide();
                    f3.ShowDialog();
                    
                    statystyki();

                }
                else if (wybor == 2)
                {
                    Form3 f3 = new Form3(wybor, Bohater.hp_max, Bohater.mp_max, Bohater.def, Bohater.Int);
                    this.Hide();
                    f3.ShowDialog();
                    Bohater.hp_max = newhp;
                    Bohater.mp_max = neweng;
                    Bohater.def = newdef;
                    Bohater.Int = newdps;
                    Bohater.lvl_next = Bohater.lvl_next * 2;
                    statystyki();
                }
                else if(wybor==3)
                {
                    Form3 f3 = new Form3(wybor, Bohater.hp_max, Bohater.rage_max, Bohater.def, Bohater.str);
                    this.Hide();
                    f3.ShowDialog();
                    //Bohater = Wojownik.lvlup(Bohater.lvl, Bohater.lvl_next, Bohater.gold, Bohater.exp, Bohater.name, newhp, neweng, newdps, newdef);
                    statystyki();
                    


                }
                
                

            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        public void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork_1(object sender, DoWorkEventArgs e)
        {

            
            
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = @"c:\Images\fight.wav";
                player.Load();
                player.PlayLooping();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
