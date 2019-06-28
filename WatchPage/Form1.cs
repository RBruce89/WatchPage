using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            string url = urlTxb.Text;

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    using (HttpContent sourceCode = response.Content)
                    {
                        String fileName = url.Replace("://", "-").Replace("/", "-");
                        String stored = System.IO.File.ReadAllText(fileName + ".txt");
                        
                        string result = sourceCode.ReadAsStringAsync().Result;

                        if (!string.Equals(stored, result))
                        {
                            String messageText = "The Website's sourcecode has changed!";
                            MessageBox.Show(messageText, "Change detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void Add(object sender, EventArgs e)
        {
            string url = urlTxb.Text;

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(url).Result)
                {
                    using (HttpContent sourceCode = response.Content)
                    {
                        String fileName = url.Replace("://", "-").Replace("/", "-");

                        string result = sourceCode.ReadAsStringAsync().Result;
                        System.IO.File.WriteAllText(fileName + ".txt", result);
                    }
                }
            }
        }
    }
}
