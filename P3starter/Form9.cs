using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * News Form for Project3
 * @author Jason Kirshner
 * @version 5/9/2017
 */

namespace Project3
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            News();
        }

        // Consumes News Data and displays it to the form
        public void News()
        {
            string jsonNews = getRESTData("/news");
            News news = JToken.Parse(jsonNews).ToObject<News>();

            // Past year's news data
            tpNews1.Text = news.year[0].title;
            tpNews2.Text = news.year[1].title;
            tpNews3.Text = news.year[2].title;
            tpNews4.Text = news.year[3].title;

            rtbNews1.Text = news.year[0].description;
            rtbNews2.Text = news.year[1].description;
            rtbNews3.Text = news.year[2].description;
            rtbNews4.Text = news.year[3].description;

            rtbNews1.AppendText("\n\nDate: " + news.year[0].date);
            rtbNews2.AppendText("\n\nDate: " + news.year[1].date);
            rtbNews3.AppendText("\n\nDate: " + news.year[2].date);
            rtbNews4.AppendText("\n\nDate: " + news.year[3].date);

            // Adds old news data to the old news comboBox
            foreach (Older old in news.older) {
                cbOlder.Items.Add(old.title + " " + old.date);
            }
        }

        // This function Displays a dialog containing the news data for the older dates upon index change
        public void cbOlder_SelectedIndexChanged(object sender, EventArgs e) {
            string jsonNews = getRESTData("/news");
            News news = JToken.Parse(jsonNews).ToObject<News>();

            // Displays the dialog
            DialogResult dr = MessageBox.Show(news.older[cbOlder.SelectedIndex].description + "\n\nDate: " + news.older[cbOlder.SelectedIndex].date,  news.older[cbOlder.SelectedIndex].title, MessageBoxButtons.OK);
            switch (dr)
            {
                case DialogResult.OK:
                    {
                        this.Text = "[OK]";
                        break;
                    }
            }
        }

        // Button Listeners for Switching between Forms
        private void btnPeople_Click(object sender, EventArgs e)
        {
            Form2 PeopleForm = new Form2();
            PeopleForm.Show();
            this.Hide();
        }

        private void btnDegrees_Click(object sender, EventArgs e)
        {
            Form3 DegreesForm = new Form3();
            DegreesForm.Show();
            this.Hide();
        }

        private void btnEmployment_Click(object sender, EventArgs e)
        {
            Form4 EmpForm = new Form4();
            EmpForm.Show();
            this.Hide();
        }

        private void btnMinors_Click(object sender, EventArgs e)
        {
            Form5 MinorsForm = new Form5();
            MinorsForm.Show();
            this.Hide();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            Form6 MapForm = new Form6();
            MapForm.Show();
            this.Hide();
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            Form7 ResourcesForm = new Form7();
            ResourcesForm.Show();
            this.Hide();
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            Form8 ResearchForm = new Form8();
            ResearchForm.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 HomeForm = new Form1();
            HomeForm.Show();
            this.Hide();
        }

        #region Common method to getRESTData( url ) from the API
        // Get the REST API information from ist.rit.edu
        private string getRESTData(string url)
        {
            const string baseUri = "http://ist.rit.edu/api";

            // connect to the API
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUri + url);

            try
            {
                // Wait and get the response for this web request
                WebResponse response = request.GetResponse();

                // Using the response stream from the web request
                // get the information requested
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException we)     // Just because we have an exception,
            {                           //  we still have information to use for debug
                // get the response 
                WebResponse err = we.Response;
                using (Stream responseStream = err.GetResponseStream())
                {
                    StreamReader r = new StreamReader(responseStream, Encoding.UTF8);
                    // do something with the error
                    string errorText = r.ReadToEnd();
                    Console.WriteLine("ERROR: " + errorText);
                }
                // Can't do anything more with this exception. 
                // Throw it. Make it someone elses problem.
                throw;
            }


        }   // end getRESTData()

        #endregion
    }
}
