using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniqPlayer
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            string logContent = File.ReadAllText(Application.StartupPath + "\\Log.txt");
            richTextBox1.Text = logContent;
        }

        public static void WriteLogFile(string innerException, string stackTrace, string message, DateTime logDate)
        {
            string[] logContent = { innerException, stackTrace, message, logDate.ToString() };
            File.WriteAllLines(Application.StartupPath + "\\Log.txt", logContent);
        }
    }
}
