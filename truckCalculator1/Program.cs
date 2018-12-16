using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace truckCalculator1
{
    static class Program
    {
        /// <summary>
        /// This program calculates what truck will work for an ltl load
        /// based on L*W*H
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GlorifiedCalculator());
        }
    }
}
