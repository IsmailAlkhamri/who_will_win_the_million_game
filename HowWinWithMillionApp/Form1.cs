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

namespace HowWinWithMillionApp
{
    public partial class Form1 : Form
    {
        SoundPlayer CallingSound = new SoundPlayer(@"C:\Users\Lenovo\Documents\Visual Studio 2019\Projects\HowWinWithMillionApp\HowWinWithMillionApp\Resources\Sounds\Introduction.wav");

        public Form1()
        {
            InitializeComponent();
        }
        private void ResetCompetitorProperties()
        {
            Competitor.Stock = 0;
            Competitor.Corr_Ans = 0;
            Competitor.inCorr_Ans = 0;
        }
        private void createQuesPage()
        {
            QuesPage QP = new QuesPage();
            QP.Show();
        }
        private void settingBtn_Click(object sender, EventArgs e)
        {
            if (Competitor.Name != null && Competitor.Name.Length > 2)
            {
                ResetCompetitorProperties();
                createQuesPage();
            }
            else MessageBox.Show("(من فضلك ادخل اسمك وحدد الوقت بالضغط على زر(الاعدادات", "توضيح", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            CallingSound.Stop();

            Settings Sett = new Settings();
            Sett.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        async private void Form1_Load(object sender, EventArgs e)
        {
            CallingSound.Load();
            CallingSound.Play();
            
            await Task.Delay(120000); 

            CallingSound.Stop();
        }

       
    }
}
