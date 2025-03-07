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
    public partial class FansForm : Form
    {
        int over_perc = 250;
        int perc_rest = 85;
        int[] Percents = new int[4];
        int Corr_ans;
        private SoundPlayer CallingSound = new SoundPlayer(@"C:\Users\Lenovo\Documents\Visual Studio 2019\Projects\HowWinWithMillionApp\HowWinWithMillionApp\Resources\Sounds\fans.wav");

        public FansForm(int corr_ans)
        {
            this.Corr_ans = corr_ans;
            InitializeComponent();
        }
        private void getRandomPercent()
        {
            Random R = new Random();
            int num;

            for (int i = 0;i < 4; i++) {

                if (i == 3)
                {
                    Percents[i] = perc_rest;
                    break;
                }
               // do
                //{
                    num = R.Next(0,perc_rest);

                //} //while (Percents.Contains<int>(num));

                Percents[i] = num;
                perc_rest = perc_rest - num;
            }  
        }
        private void SwapPercents()
        {
            int Max = Percents.Max();

            for (int i = 0; i < 4; i++)
            {
               if(Max == Percents[i] && (i + 1) != Corr_ans)
                {
                    int temp = Percents[Corr_ans - 1];
                    Percents[Corr_ans - 1] = Max;
                    Percents[i] = temp;
                }
            }
        }
        private void AssignThePercents()
        {
            for (int i = 0; i < 4; i++)
            {
                Label label = (Label)this.guna2Panel1.Controls[$"percent{i+1}"];
                label.Text = Percents[i].ToString() + " %";
                label.BringToFront();
            }
        }
        async private void FansForm_Load(object sender, EventArgs e)
        {
            CallingSound.Load(); // sound
            CallingSound.Play(); // sound

            getRandomPercent();
            SwapPercents();
            AssignThePercents();

            await Task.Delay(30000);
            CallingSound.Stop();
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            CallingSound.Stop();
            this.Close();
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            int horizontal_space = 40;
            Graphics g = e.Graphics;
            Brush mybrush = new SolidBrush(Color.Orange);

            for (int i = 0; i < 4; i++)
            {
                Point start_point = new Point(guna2Panel1.Width - 49, guna2Panel1.Height - ((Percents[i] * over_perc)/100) );
                Rectangle R = new Rectangle(start_point.X - horizontal_space, start_point.Y - 60, 49, (Percents[i] * over_perc) / 100);

                g.FillRectangle(mybrush, R);

                Label label = (Label)this.guna2Panel1.Controls[$"percent{i + 1}"];
                label.Location = new Point(label.Location.X,R.Location.Y - 35);

                horizontal_space += (25 + 49);
            }
        }
    }
}
