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
    public partial class Form1 : Form
    {
        int wybor;
        public Form1()
        {
            
            InitializeComponent();
            backgroundWorker1.RunWorkerAsync();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            wybor = 1;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        public void btn_start_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form2 f2 = new Form2(textBox1.Text, wybor);
            f2.ShowDialog();
            this.Close();
            
        }

        private void btn_int_Click(object sender, EventArgs e)
        {

            wybor = 2;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            wybor = 3;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"c:\Images\menu1.wav";
            player.Load();
            player.PlayLooping();
        }
    }
}
