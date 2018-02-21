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
 * Minors Form for Project3
 * @author Jason Kirshner
 * @version 5/9/2017
 */

namespace Project3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Minors();
        }

        // Consumes Minors data and displays it on the form
        public void Minors()
        {
            string jsonMinors = getRESTData("/minors");
            Minors minors = JToken.Parse(jsonMinors).ToObject<Minors>();

            // Minor1
            gbMinor1.Text = minors.UgMinors[0].name;
            lblMinor1.Text = minors.UgMinors[0].title;
            rtbMinor1.Text = minors.UgMinors[0].description + "\n\nCourses:\n";
            rtbMinor1.AppendText(minors.UgMinors[0].courses[0] + "\n");
            rtbMinor1.AppendText(minors.UgMinors[0].courses[1] + "\n");
            rtbMinor1.AppendText(minors.UgMinors[0].courses[2] + "\n");
            rtbMinor1.AppendText(minors.UgMinors[0].courses[3] + "\n");
            rtbMinor1.AppendText(minors.UgMinors[0].courses[4]);

            // Minor2
            gbMinor2.Text = minors.UgMinors[1].name;
            lblMinor2.Text = minors.UgMinors[1].title;
            rtbMinor2.Text = minors.UgMinors[1].description + "\n\nCourses:\n";
            rtbMinor2.AppendText(minors.UgMinors[1].courses[0] + "\n");
            rtbMinor2.AppendText(minors.UgMinors[1].courses[1] + "\n");
            rtbMinor2.AppendText(minors.UgMinors[1].courses[2] + "\n");
            rtbMinor2.AppendText(minors.UgMinors[1].courses[3] + "\n");
            rtbMinor2.AppendText(minors.UgMinors[1].courses[4] + "\n");
            rtbMinor2.AppendText(minors.UgMinors[1].courses[5] + "\n");
            rtbMinor2.AppendText("Note: \n" + minors.UgMinors[1].note);

            // Minor3
            gbMinor3.Text = minors.UgMinors[2].name;
            lblMinor3.Text = minors.UgMinors[2].title;
            rtbMinor3.Text = minors.UgMinors[2].description + "\n\nCourses:\n";
            rtbMinor3.AppendText(minors.UgMinors[2].courses[0] + "\n");
            rtbMinor3.AppendText(minors.UgMinors[2].courses[1] + "\n");
            rtbMinor3.AppendText(minors.UgMinors[2].courses[2] + "\n");
            rtbMinor3.AppendText(minors.UgMinors[2].courses[3] + "\n");
            rtbMinor3.AppendText(minors.UgMinors[2].courses[4] + "\n");
            rtbMinor3.AppendText("Note: \n" + minors.UgMinors[2].note);

            // Minor4
            gbMinor4.Text = minors.UgMinors[3].name;
            lblMinor4.Text = minors.UgMinors[3].title;
            rtbMinor4.Text = minors.UgMinors[3].description + "\n\nCourses:\n";
            rtbMinor4.AppendText(minors.UgMinors[3].courses[0] + "\n");
            rtbMinor4.AppendText(minors.UgMinors[3].courses[1] + "\n");
            rtbMinor4.AppendText(minors.UgMinors[3].courses[2] + "\n");
            rtbMinor4.AppendText(minors.UgMinors[3].courses[3] + "\n");
            rtbMinor4.AppendText(minors.UgMinors[3].courses[4] + "\n");

            // Minor5
            gbMinor5.Text = minors.UgMinors[4].name;
            lblMinor5.Text = minors.UgMinors[4].title;
            rtbMinor5.Text = minors.UgMinors[4].description + "\n\nCourses:\n";
            rtbMinor5.AppendText(minors.UgMinors[4].courses[0] + "\n");
            rtbMinor5.AppendText(minors.UgMinors[4].courses[1] + "\n");
            rtbMinor5.AppendText(minors.UgMinors[4].courses[2] + "\n");
            rtbMinor5.AppendText(minors.UgMinors[4].courses[3] + "\n");
            rtbMinor5.AppendText(minors.UgMinors[4].courses[4] + "\n");
            rtbMinor5.AppendText(minors.UgMinors[4].courses[5] + "\n");
            rtbMinor5.AppendText("Note: \n" + minors.UgMinors[4].note);

            // Minor6
            gbMinor6.Text = minors.UgMinors[5].name;
            lblMinor6.Text = minors.UgMinors[5].title;
            rtbMinor6.Text = minors.UgMinors[5].description + "\n\nCourses:\n";
            rtbMinor6.AppendText(minors.UgMinors[5].courses[0] + "\n");
            rtbMinor6.AppendText(minors.UgMinors[5].courses[1] + "\n");
            rtbMinor6.AppendText(minors.UgMinors[5].courses[2] + "\n");
            rtbMinor6.AppendText(minors.UgMinors[5].courses[3] + "\n");
            rtbMinor6.AppendText(minors.UgMinors[5].courses[4] + "\n");
            rtbMinor6.AppendText(minors.UgMinors[5].courses[5] + "\n");
            rtbMinor6.AppendText(minors.UgMinors[5].courses[6] + "\n");
            rtbMinor6.AppendText(minors.UgMinors[5].courses[7] + "\n");
            rtbMinor6.AppendText("Note: \n" + minors.UgMinors[5].note);

            // Minor7
            gbMinor7.Text = minors.UgMinors[6].name;
            lblMinor7.Text = minors.UgMinors[6].title;
            rtbMinor7.Text = minors.UgMinors[6].description + "\n\nCourses:\n";
            rtbMinor7.AppendText(minors.UgMinors[6].courses[0] + "\n");
            rtbMinor7.AppendText(minors.UgMinors[6].courses[1] + "\n");
            rtbMinor7.AppendText(minors.UgMinors[6].courses[2] + "\n");
            rtbMinor7.AppendText(minors.UgMinors[6].courses[3] + "\n");
            rtbMinor7.AppendText(minors.UgMinors[6].courses[4] + "\n");
            rtbMinor7.AppendText("Note: \n" + minors.UgMinors[6].note);

            // Minor8
            gbMinor8.Text = minors.UgMinors[7].name;
            lblMinor8.Text = minors.UgMinors[7].title;
            rtbMinor8.Text = minors.UgMinors[7].description + "\n\nCourses:\n";
            rtbMinor8.AppendText(minors.UgMinors[7].courses[0] + "\n");
            rtbMinor8.AppendText(minors.UgMinors[7].courses[1] + "\n");
            rtbMinor8.AppendText(minors.UgMinors[7].courses[2] + "\n");
            rtbMinor8.AppendText(minors.UgMinors[7].courses[3] + "\n");
            rtbMinor8.AppendText(minors.UgMinors[7].courses[4] + "\n");
            rtbMinor8.AppendText(minors.UgMinors[7].courses[5] + "\n");
            rtbMinor8.AppendText("Note: \n" + minors.UgMinors[7].note);
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 HomeForm = new Form1();
            HomeForm.Show();
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
