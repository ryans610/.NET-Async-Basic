using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDeadLock
{
    public partial class Form1 : Form
    {
        private static async Task<string> GetGoogleAsync()
        {
            var client = new HttpClient();
            return await client.GetStringAsync("https://www.google.com/");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = GetGoogleAsync();
            richTextBox1.Text = result.Result;
        }
    }
}
