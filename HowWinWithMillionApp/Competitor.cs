using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HowWinWithMillionApp
{
    public static class Competitor
    {
        public static SqlConnection Connect;
        public static string Name { get; set; }

        public static int TimeForQues = 10;

        public static float Stock = 0;

        public static int Corr_Ans = 0;

        public static int inCorr_Ans = 0;

    }
}
