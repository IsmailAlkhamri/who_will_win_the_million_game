using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowWinWithMillionApp
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (C_Name.Text != null && C_Name.Text.Length <3 )
                MessageBox.Show(".من فضلك ادخل اسمك","توضيح", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else{
                Competitor.Name = C_Name.Text;
                Competitor.TimeForQues = (int)timeForQues.Value;
                this.Close();
            }
        }
    }
}
