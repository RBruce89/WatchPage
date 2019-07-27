using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchPage
{
    public partial class Form1 : Form
    {

        Boolean timerRunning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Start timer and compare at specified intervals when watch button is clicked
        private async void watchBtn_Click(object sender, EventArgs e)
        {
            Boolean runCheck = true;

            if (!timerRunning)
            {
                int days = Int32.Parse(daysNUD.Text);
                int hours = Int32.Parse(hoursNUD.Text);
                if (days > 0 || hours > 0)
                {
                    watchBtn.Text = "Watching";
                    watchBtn.Enabled = false;
                }

                timerRunning = true;
                while (runCheck)
                {
                    Task<bool> pauseTask = new Task<bool>(PauseTimer);
                    pauseTask.Start();
                    runCheck = await pauseTask;

                    Compare();
                }
                timerRunning = false;
            }
        }

        // Save source code for the page in add box and add that page to the watch list
        private void Add(object sender, EventArgs e)
        {
            string url = urlTxb.Text;
            if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
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
                
                urlLbx.Items.Add(url);
                urlTxb.Text = null;
            } else
            {
                String messageText = "Please enter a valid URL";
                MessageBox.Show(messageText, "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Check saved source code against webpage's current source code for each page on the list
        private void Compare()
        {
            string[] url = new string[urlLbx.Items.Count];
            for (int i = 0; i < urlLbx.Items.Count; i++)
            {
                url[i] = urlLbx.Items[i].ToString();
            }

            for (var i = 0; i < url.Length; i++)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = client.GetAsync(url[i]).Result)
                    {
                        using (HttpContent sourceCode = response.Content)
                        {
                            String fileName = url[i].Replace("://", "-").Replace("/", "-");
                            String stored = System.IO.File.ReadAllText(fileName + ".txt");

                            string result = sourceCode.ReadAsStringAsync().Result;

                            if (!string.Equals(stored, result))
                            {
                                String messageText = url[i] + " source code has changed!";
                                var okPress = MessageBox.Show(messageText, "Change detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                if (okPress == System.Windows.Forms.DialogResult.OK)
                                {
                                    System.IO.File.WriteAllText(fileName + ".txt", result);
                                }
                            }
                        }
                    }
                }
            }
        }

        // Determine pause intervals from information in the numeric up downs
        private Boolean PauseTimer()
        {
            int days = Int32.Parse(daysNUD.Text);
            int hours = Int32.Parse(hoursNUD.Text);
            int waitTime = (((days * 24) + hours) * 3600) * 1000;

            if (waitTime > 0)
            {
                Thread.Sleep(waitTime);
                return true;
            }

            return false;
        }
    }
}
