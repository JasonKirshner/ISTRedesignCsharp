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
 * Research Form for Project3
 * @author Jason Kirshner
 * @version 5/9/2017
 */

namespace Project3
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            Area();
            Faculty();
        }

        // Consumes Interest Area data from the research node and diplays data onto the form
        public void Area()
        {
            string jsonResearch = getRESTData("/research");
            Research research = JToken.Parse(jsonResearch).ToObject<Research>();
            int x = 0;
            int y = research.byInterestArea.Count();
            String s = "";
            
            // Adds Interest Area data to the form
            foreach (ByInterestArea area in research.byInterestArea) {
                TabPage tb = new TabPage(area.areaName);
                tcArea.TabPages.Add(tb);
                RichTextBox[] rtb = new RichTextBox[y];
                rtb[x] = new RichTextBox();
                rtb[x].SetBounds(0, 0, 870, 215);
                rtb[x].BackColor = Color.PapayaWhip;
                tcArea.TabPages[x].Controls.Add(rtb[x]);
                for (int i = 0; i < area.citations.Count(); i++) {
                    s += area.citations[i] + "\n\n";
                }
                rtb[x].AppendText(s);
                x++;
                s = "";
            }
        }

        // Adds Faculty research data to the form
        public void Faculty()
        {
            string jsonResearch = getRESTData("/research");
            Research research = JToken.Parse(jsonResearch).ToObject<Research>();
            int x = 0;
            int y = research.byFaculty.Count();
            String s = "";

            // Adding facultyResearch data to a RichTextBox within the form
            foreach (ByFaculty area in research.byFaculty)
            {
                TabPage tb = new TabPage(area.facultyName);
                tcFac.TabPages.Add(tb);
                RichTextBox[] rtb = new RichTextBox[y];
                rtb[x] = new RichTextBox();
                rtb[x].SetBounds(0, 0, 870, 215);
                rtb[x].BackColor = Color.PapayaWhip;
                tcFac.TabPages[x].Controls.Add(rtb[x]);
                for (int i = 0; i < area.citations.Count(); i++)
                {
                    s += area.citations[i] + "\n\n";
                }
                rtb[x].AppendText(s);
                x++;
                s = "";
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 HomeForm = new Form1();
            HomeForm.Show();
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
