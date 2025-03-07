using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HowWinWithMillionApp
{
    public partial class QuesPage : Form
    {
        static int count = 0;
        int count_ques_label = 1;
        int timeforbar;
        static int Correct_Ans;
        static int ques_time = Competitor.TimeForQues;
        static int colortimerCounter = 10;
        static int colortimerCounterred = 10;
        int waitCounter = 0;
        Guna.UI2.WinForms.Guna2Button clicked_B;
        Label ans_char;
        static bool is_correct = false;
        int[] selected_ques;
        static int ques_counter = 0;
        bool is_deleteAns_clicked = false;
        SoundPlayer AnsWaitSound = new SoundPlayer(@"C:\Users\Lenovo\Documents\Visual Studio 2019\Projects\HowWinWithMillionApp\HowWinWithMillionApp\Resources\Sounds\QuestionEffect.wav");

        public QuesPage()
        {
            timeforbar = Competitor.TimeForQues;
            InitializeComponent();
        }
        private void ResetquesTime()
        {
            timelabel.Text = Competitor.TimeForQues.ToString();
            ques_time = Competitor.TimeForQues;
            questimeBar.Value = 100;

            colortimerCounter = 10;
            questimer.Start();

        }
        private void SetImagesofButtons(Guna.UI2.WinForms.Guna2Button B,string image_name)
        {          
            B.Image = Image.FromFile(@"C:\Users\Lenovo\Documents\Visual Studio 2019\Projects\HowWinWithMillionApp\HowWinWithMillionApp\Resources\Image\"+image_name);
        }
        private void QuesPage_Load(object sender, EventArgs e)
        {
            SetImagesofButtons(callfriendBtn, "phone.ico.png");
            SetImagesofButtons(peopleBtn, "people.ico.png");
            changeBorderColorandBack(null, Btn1);

            count = 0; // no of created ques

            ResetquesTime();
            questimer.Start();

            competitorName.Text = Competitor.Name;

            CreateQues();
        }
        private string getDifficulity()
        {
            if (count >= 0 && count < 4)
                return "simple";
            if (count >= 4 && count < 7)
                return "medium";
            else return "difficult";
        }
        private int GenerateRnadomQuesNo()
        {
            int num;
            Random R = new Random();
            do
            {
                num = R.Next(1, 11);
            } while (selected_ques != null && selected_ques.Contains<int>(num));

            selected_ques[ques_counter++] = num;
            return num;
        }
        private void ResetArrayOfQuestions()
        {
            if (count == 0 || count == 4 || count == 7)
            {
                selected_ques = new int[5];
                ques_counter = 0;
            }
        }
        private SqlDataReader QueryFromDB()
        {
            Competitor.Connect = new SqlConnection();
            Competitor.Connect.ConnectionString = @"server=DESKTOP-S3PRJ8R\MSSQLSERVER1;database=GameQuestions;integrated security=true";
            Competitor.Connect.Open();

            ResetArrayOfQuestions();

            var sql = "SELECT * FROM Question Where ques_Difficulity = '" + getDifficulity() + "' and ques_no = " + GenerateRnadomQuesNo();

            SqlCommand Display_c = new SqlCommand(sql, Competitor.Connect);

            SqlDataReader Data_Reader = Display_c.ExecuteReader();

            Data_Reader.Read();

            return Data_Reader;
        }
        private void SetAnswers(SqlDataReader Data_Reader, clsQuestion Question)
        {

            for (int i = 1; i <= 4; i++)
            {
                this.Controls["Ans" + i].Text = Data_Reader["Answer" + i].ToString();
            }

            Random R = new Random();
            Correct_Ans = R.Next(1, 5);

            int corr_no = int.Parse(Data_Reader["Corr_No"].ToString());

            string ans = this.Controls["Ans" + Correct_Ans].Text;

            this.Controls["Ans" + Correct_Ans].Text = this.Controls["Ans" + corr_no].Text;

            this.Controls["Ans" + corr_no].Text = ans;

        }
        private void CreateQues()
        {
            SqlDataReader Data_Reader = QueryFromDB();

            clsQuestion Question = new clsQuestion(count, Data_Reader["ques_title"].ToString());
            SetAnswers(Data_Reader, Question);

            queslabel.Text = Question.QuesTitle;

            count++;
            quesnolabel.Text = "("+ count_ques_label++.ToString();

            Data_Reader.Close();
            Competitor.Connect.Close();

        }
        private void changeBorderColorandBack(Guna.UI2.WinForms.Guna2Button B_Prev = null, Guna.UI2.WinForms.Guna2Button B_New = null)
        {
            if(B_Prev != null)
            {
                B_Prev.BorderColor = Color.Transparent;
                B_Prev.FillColor = Color.Transparent;
            }

            B_New.FillColor = Color.Goldenrod;
            B_New.BorderColor = Color.White;
        }
        private void SetMoney()
        {
            float number = 0;
            switch (count)
            {
                case 1:
                    number = 100;
                    changeBorderColorandBack(Btn1, Btn2); break;
                case 2:
                    number = 200;
                    changeBorderColorandBack(Btn2, Btn3); break;
                case 3:
                    number = 500;
                    changeBorderColorandBack(Btn3, Btn4); break;
                case 4:
                    number = 1000;
                    changeBorderColorandBack(Btn4, Btn5); break;
                case 5:
                    number = 2000;
                    changeBorderColorandBack(Btn5, Btn6); break;
                case 6:
                    number = 10000;
                    changeBorderColorandBack(Btn6, Btn7); break;
                case 7:
                    number = 50000;
                    changeBorderColorandBack(Btn7, Btn8); break;
                case 8:
                    number = 100000;
                    changeBorderColorandBack(Btn8, Btn9); break;
                case 9:
                    number = 500000;
                    changeBorderColorandBack(Btn9, Btn10); break;
                case 10:
                    number = 1000000; break;
            }

            Competitor.Stock = number;
            stock.Text = number.ToString();
        }
        private bool CheckCorrectAnswer(int answer_no) {
            return (answer_no == Correct_Ans);
        }
        private void getAnsWaitsound()
        {
            AnsWaitSound.Load();
            AnsWaitSound.Play();
        }
        private void Ans1_Click(object sender, EventArgs e)
        {
            questimer.Stop();

            AnsWaitSound = new SoundPlayer(@"C:\Users\Lenovo\Documents\Visual Studio 2019\Projects\HowWinWithMillionApp\HowWinWithMillionApp\Resources\Sounds\QuestionEffect.wav");
            getAnsWaitsound();

            waitCounter = 0;
            AnswaitTimer.Start();

            clicked_B = (Guna.UI2.WinForms.Guna2Button)sender;
            clicked_B.FillColor = Color.Goldenrod;
            clicked_B.HoverState.FillColor = clicked_B.FillColor; // hoverState FillColor

            ans_char = (Label)this.Controls["Char" + clicked_B.Tag];
            ans_char.BackColor = Color.Goldenrod;



        }

        private void colortimer_Tick(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button clicked_B = (Guna.UI2.WinForms.Guna2Button)this.Controls["Ans" + Correct_Ans];
            Label ans_char = (Label)this.Controls["Char" + Correct_Ans];

            if (colortimerCounter-- == 0)
            {
                colortimer.Stop();
                AnsWaitSound.Stop(); // sound

                colortimerCounter = 10;

                if (is_correct && ques_time > 0)
                {
                    SetMoney();

                    if(count != 10)
                    {
                        CreateQues();
                        ResetquesTime();
                    }
                    else GameOver();

                    if (is_deleteAns_clicked)
                        ShowAllButtons();

                    ans_char.BackColor = clicked_B.HoverState.FillColor = clicked_B.FillColor = SystemColors.HotTrack;

                }
                else
                {
                    GameOver();
                }
            }
            else
            {
                ans_char.BackColor = clicked_B.HoverState.FillColor = clicked_B.FillColor = (clicked_B.FillColor != Color.Green) ? Color.Green : SystemColors.HotTrack;
            }

        }
        private void redcolortimer_Tick(object sender, EventArgs e)
        {
            if (colortimerCounterred-- == 0)
            {
                redcolortimer.Stop();

                AnsWaitSound.Stop(); // sound

                ans_char.BackColor = clicked_B.HoverState.FillColor = clicked_B.FillColor = SystemColors.HotTrack;

                colortimerCounterred = 10;
            }
            else
            {
                ans_char.BackColor = clicked_B.HoverState.FillColor = clicked_B.FillColor = (clicked_B.FillColor != Color.Red) ? Color.Red : SystemColors.HotTrack;
            }
        }

        private void questimer_Tick(object sender, EventArgs e)
        {
            ques_time--;
            questimeBar.Value -= 100 / timeforbar;

            timelabel.Text = ques_time.ToString();

            if (ques_time == 0)
            {
                colortimer.Start();
                questimer.Stop();
            }

        }
        private void GameOver()
        {
            questimer.Stop();
            createResultForm();
        }

        private int GenerateRnadomAnsNo(int First = 0)
        {
            int num;
            Random R = new Random();
            do
            {
                num = R.Next(1, 4);
            } while (num == Correct_Ans || num == First);

            return num;
        }
        private void DeleteButton(int num)
        {
            this.Controls["Ans" + num].Visible = false;
        }
        private void DeleteChar(int num)
        {
            this.Controls["Char" + num].Visible = false;
        }
        private void DeleteTwoAnswers()
        {
            Random R = new Random();

            int ans1 = GenerateRnadomAnsNo();
            int ans2 = GenerateRnadomAnsNo(ans1);

            DeleteButton(ans1); DeleteChar(ans1);
            DeleteButton(ans2); DeleteChar(ans2);
        }
        private void ShowAllButtons()
        {
            for(int i=1;i<=4;i++)
            {
                this.Controls["Ans" + i].Visible = true;
                this.Controls["Char" + i].Visible = true;
            }
        }
        async private void guna2Button20_Click(object sender, EventArgs e)
        {
            questimer.Stop();

            AnsWaitSound = new SoundPlayer(@"C:\Users\Lenovo\Documents\Visual Studio 2019\Projects\HowWinWithMillionApp\HowWinWithMillionApp\Resources\Sounds\DeleteTwoAns.wav");
            getAnsWaitsound();

            is_deleteAns_clicked = true;

            guna2Button20.Enabled = false;
            
            await Task.Delay(8500); // wait time for sound

            DeleteTwoAnswers();

            questimer.Start();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {  
            callfriendBtn.Enabled = false;
          
            questimer.Stop();

            CallFriend CF = new CallFriend(Correct_Ans);
            CF.ShowDialog();

            questimer.Start();
        }

        private void createResultForm()
        {
            this.Close();
            Results R = new Results();
            R.Show();
        }
        private void guna2Button21_Click(object sender, EventArgs e)
        {
            GameOver();
        }

        private void peopleBtn_Click(object sender, EventArgs e)
        {
            peopleBtn.Enabled = false;

            questimer.Stop();

            FansForm FF = new FansForm(Correct_Ans);
            FF.ShowDialog();

            questimer.Start();

        }

        async private void AnswaitTimer_Tick(object sender, EventArgs e)
        { 
            if (waitCounter++ == 2)
            {
                AnswaitTimer.Stop(); // timer 
                AnsWaitSound.Stop(); // sound

                if (CheckCorrectAnswer(int.Parse(clicked_B.Name.ToString().Substring(3))))
                {
                    is_correct = true;
                    
                    AnsWaitSound = new SoundPlayer(@"C:\Users\Lenovo\Documents\Visual Studio 2019\Projects\HowWinWithMillionApp\HowWinWithMillionApp\Resources\Sounds\CorrectAnswer.wav");
                    getAnsWaitsound();

                    colortimer.Start();
                    Competitor.Corr_Ans++;
                }
                else
                {
                    is_correct = false;
                    Competitor.inCorr_Ans++;

                    AnsWaitSound = new SoundPlayer(@"C:\Users\Lenovo\Documents\Visual Studio 2019\Projects\HowWinWithMillionApp\HowWinWithMillionApp\Resources\Sounds\WrongAnswer.wav");
                    getAnsWaitsound();
                    await Task.Delay(1000);


                    redcolortimer.Start();

                    await Task.Delay(1000); // delay for correct answer color

                    colortimer.Start();
                }

            }
        }

        private void Char1_Click(object sender, EventArgs e)
        {

        }

        private void Char3_Click(object sender, EventArgs e)
        {

        }

        private void timelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
