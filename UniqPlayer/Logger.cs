using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace UniqPlayer
{
    class Logger
    {
        private static String ErrorlineNo, Errormsg, extype, exurl, hostIp, ErrorLocation, HostAdd;

        public static void WriteLogFile(Exception ex)
        {
            string filePath = Application.StartupPath + "\\Log.txt";
            //File.AppendAllText(filePath, ex.StackTrace);

            using (var writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(ex.StackTrace + Environment.NewLine);
                writer.Close();
            }
        }
    }
}
