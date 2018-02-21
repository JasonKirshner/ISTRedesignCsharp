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
 * Home Form for Project3
 * @author Jason Kirshner
 * @version 5/9/2017
 */

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AboutHome();
            Footer();
        }

        // Consumes about data and displays it to the form
        public void AboutHome()
        {
            string jsonAbout = getRESTData("/about/");
            About about = JToken.Parse(jsonAbout).ToObject<About>();

            // about title and description
            abtTitle_label.Text = about.title;
            rtbDesc.Text = about.description;

            // about qupte and quote author
            string quote = about.quote;
            string quoteAuthor = about.quoteAuthor;
            rtbQuote.AppendText("\"" + quote + "\"" + "\n\n" + "- " + quoteAuthor);
        }

        // Consumes footer data and displays it to the form
        public void Footer()
        {
            string jsonFooter = getRESTData("/footer");
            Footer footer = JToken.Parse(jsonFooter).ToObject<Footer>();

            // Social Media by RIT 
            lblSocialTitle.Text = footer.social.title;
            rtbTweet.AppendText(footer.social.tweet + "\n\n" + footer.social.by);
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

        private void btnNews_Click(object sender, EventArgs e)
        {
            Form9 NewsForm = new Form9();
            NewsForm.Show();
            this.Hide();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Form10 ContactForm = new Form10();
            ContactForm.Show();
            this.Hide();
        }
    }
}
