using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNUSocial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ChameleonUI";
            logFromMain("Opening GNUSocial MainFrm now...");
            MainFrm mf = new MainFrm();
            mf.ShowDialog();
        }
        public void log(string text)
        {
            Console.WriteLine("[" + DateTime.Now + "]: " + text);
        }
        public static void logFromMain(string text)
        {
            Console.WriteLine("[" + DateTime.Now + "]: " + text);
        }
    }
}
