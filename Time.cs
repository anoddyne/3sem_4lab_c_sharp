using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task4_cs
{
    internal class Time
    {
        static int H = int.Parse(DateTime.Now.ToString("HH"));
        static int M = int.Parse(DateTime.Now.ToString("mm"));
        static int S = int.Parse(DateTime.Now.ToString("ss"));
        int CurrTimeInS = H * 3600 + M * 60 + S;

        public Time() { }

        public string Current
        {
            get
            {
                string printCurr = "";
                printCurr += "Текущее время: " + H.ToString("D2") + ":" + M.ToString("D2") + ":" + S.ToString("D2") + "\n";
                printCurr += "В секундах: " + CurrTimeInS;
                return printCurr;
            }
        }

        private string CalculateTime(int CurrTimeInS)
        {
            if (CurrTimeInS >= 0)
            {
                int hour = CurrTimeInS / 3600;
                int minute = (CurrTimeInS - hour * 3600) / 60;
                int second = CurrTimeInS - hour * 3600 - minute * 60;
                string print = "Изменённое время: " + hour.ToString("D2") + ":" + minute.ToString("D2") + ":" + second.ToString("D2");
                return print;
            } 
            else
            {
                return "Ошибка: время не может быть отрицательным!";
            }
        }

        public string ChangeHour(int ch)
        {
            CurrTimeInS += ch * 3600;
            string print = CalculateTime(CurrTimeInS);
            CurrTimeInS -= ch * 3600;
            return print;
        }

        public string ChangeMinute(int cm)
        {
            CurrTimeInS += cm * 60;
            string print = CalculateTime(CurrTimeInS);
            CurrTimeInS -= cm * 60;
            return print;
        }

        public string ChangeSecond(int cs)
        {
            CurrTimeInS += cs;
            string print = CalculateTime(CurrTimeInS);
            CurrTimeInS -= cs;
            return print;
        }
    }
}
