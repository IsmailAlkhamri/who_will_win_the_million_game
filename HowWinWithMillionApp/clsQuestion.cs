using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowWinWithMillionApp
{
    public class clsQuestion
    {
        public int quesNo;
        public string QuesTitle;
        public clsQuestion(int quesNo, string QuesTitle)
        {
            this.quesNo = quesNo;
            this.QuesTitle = QuesTitle;
        }
    }
}
