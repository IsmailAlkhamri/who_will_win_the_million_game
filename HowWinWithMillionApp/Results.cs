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
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private string getAmountWriting()
        {
            switch (Competitor.Stock)
            {
                case 100:
                    return "مائة دولار نقداً";
                case 200:
                    return "مائتي دولار نقداً";
                case 500:
                    return "خمسمائة دولار نقداً";
                case 1000:
                    return "ألف دولار نقداً";
                case 2000:
                    return "ألفين دولار نقداً";
                case 10000:
                    return "عشرة الاف دولار نقداً";
                case 50000:
                    return "خمسون ألف دولار نقداً";
                case 100000:
                    return "مائة ألف دولار نقداً";
                case 500000:
                    return "خمسمائة ألف دولار نقداً";
                case 1000000:
                    return "مليون دولار نقداً";
                default:
                    return "صفر دولار";
            }
        }
        private string getLevel()
        {
            if (Competitor.Corr_Ans > -1 && Competitor.Corr_Ans < 5)
                return "مبتدأ";
            else if (Competitor.Corr_Ans > 4 && Competitor.Corr_Ans < 8)
                return "متوسط";
            else return "محترف";
        }
        private void Results_Load(object sender, EventArgs e)
        {
            this.BringToFront();

            c_name.Text = Competitor.Name;
            stock.Text = Competitor.Stock.ToString() + "  $";
            level.Text = getLevel();
            corr_ans.Text = Competitor.Corr_Ans.ToString();
            amountWrite.Text = getAmountWriting();
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
