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
    public partial class CallFriend : Form
    {
        public int Count = 10;
        private int corr_ans;
        private SoundPlayer CallingSound;

        public CallFriend(int corr_ans)
        {
            this.corr_ans = corr_ans;           
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         async private void timer1_Tick(object sender, EventArgs e)
        {
            if(Count-- == 0)
            {
                CallingSound.Stop();

                await Task.Delay(1600);

                Ans.Text = "(" + getChoiceAsChar() + ")";

                Calllabel.Visible = false;
                panel1.Visible = true;
            }
        }
        private char getChoiceAsChar()
        {
            switch (corr_ans)
            {
                case 1: return 'أ';
                case 2: return 'ب';
                case 3: return 'ج';
                case 4: return 'د';
            }
            return '\0';
        }

        async private void CallFriend_Load(object sender, EventArgs e)
        {
            CallingSound = new SoundPlayer(@"C:\Users\Lenovo\Documents\Visual Studio 2019\Projects\HowWinWithMillionApp\HowWinWithMillionApp\Resources\Sounds\callFriend2.wav");
            CallingSound.Load();
            CallingSound.Play();

            await Task.Delay(4000);
            Calllabel.Visible = true;

            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CallFriend_FormClosing(object sender, FormClosingEventArgs e)
        {
            CallingSound.Stop();
        }
    }
}
