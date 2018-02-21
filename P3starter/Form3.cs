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
 * Degrees Form for Project3
 * @author Jason Kirshner
 * @version 5/9/2017
 */

namespace Project3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Undergrad();
            Grad();
        }

        // Consumes degree data and displays Undergrad data to the form
        public void Undergrad()
        {
            string jsonDegrees = getRESTData("/degrees");
            Degrees deg = JToken.Parse(jsonDegrees).ToObject<Degrees>();

            // WMC
            tpWmc.Text = deg.undergraduate[0].degreeName;
            lblWmc.Text = deg.undergraduate[0].title;
            rtbWmc.Text = deg.undergraduate[0].description + "\n\nConcentrations: \n";
            rtbWmc.AppendText(deg.undergraduate[0].concentrations[0] + "\n");
            rtbWmc.AppendText(deg.undergraduate[0].concentrations[1] + "\n");
            rtbWmc.AppendText(deg.undergraduate[0].concentrations[2] + "\n");
            rtbWmc.AppendText(deg.undergraduate[0].concentrations[3] + "\n");

            // HCC
            tpHcc.Text = deg.undergraduate[1].degreeName;
            lblHcc.Text = deg.undergraduate[1].title;
            rtbHcc.Text = deg.undergraduate[1].description + "\n\nConcentrations: \n";
            rtbHcc.AppendText(deg.undergraduate[1].concentrations[0] + "\n");
            rtbHcc.AppendText(deg.undergraduate[1].concentrations[1] + "\n");
            rtbHcc.AppendText(deg.undergraduate[1].concentrations[2] + "\n");
            rtbHcc.AppendText(deg.undergraduate[1].concentrations[3] + "\n");
            rtbHcc.AppendText(deg.undergraduate[1].concentrations[4] + "\n");
            rtbHcc.AppendText(deg.undergraduate[1].concentrations[5] + "\n");

            // CIT
            tpCit.Text = deg.undergraduate[2].degreeName;
            lblCit.Text = deg.undergraduate[2].title;
            rtbCit.Text = deg.undergraduate[2].description + "\n\nConcentrations: \n";
            rtbCit.AppendText(deg.undergraduate[2].concentrations[0] + "\n");
            rtbCit.AppendText(deg.undergraduate[2].concentrations[1] + "\n");
            rtbCit.AppendText(deg.undergraduate[2].concentrations[2] + "\n");
            rtbCit.AppendText(deg.undergraduate[2].concentrations[3] + "\n");
            rtbCit.AppendText(deg.undergraduate[2].concentrations[4] + "\n");
        }

        // Consumes degree data and displays grad data to the form
        public void Grad()
        {
            string jsonDegrees = getRESTData("/degrees");
            Degrees deg = JToken.Parse(jsonDegrees).ToObject<Degrees>();

            // WMC
            tpIst.Text = deg.graduate[0].degreeName;
            lblIst.Text = deg.graduate[0].title;
            rtbIst.Text = deg.graduate[0].description + "\n\nConcentrations: \n";
            rtbIst.AppendText(deg.graduate[0].concentrations[0] + "\n");
            rtbIst.AppendText(deg.graduate[0].concentrations[1] + "\n");
            rtbIst.AppendText(deg.graduate[0].concentrations[2] + "\n");

            // HCC
            tpHci.Text = deg.graduate[1].degreeName;
            lblHci.Text = deg.graduate[1].title;
            rtbHci.Text = deg.graduate[1].description + "\n\nConcentrations: \n";
            rtbHci.AppendText(deg.graduate[1].concentrations[0] + "\n");
            rtbHci.AppendText(deg.graduate[1].concentrations[1] + "\n");
            rtbHci.AppendText(deg.graduate[1].concentrations[2] + "\n");
            rtbHci.AppendText(deg.graduate[1].concentrations[3] + "\n");
            rtbHci.AppendText(deg.graduate[1].concentrations[4] + "\n");
            rtbHci.AppendText(deg.graduate[1].concentrations[5] + "\n");

            // CIT
            tpNsa.Text = deg.graduate[2].degreeName;
            lblNsa.Text = deg.graduate[2].title;
            rtbNsa.Text = deg.graduate[2].description + "\n\nConcentrations: \n";
            rtbNsa.AppendText(deg.graduate[2].concentrations[0] + "\n");
            rtbNsa.AppendText(deg.graduate[2].concentrations[1] + "\n");
            rtbNsa.AppendText(deg.graduate[2].concentrations[2] + "\n");

            // Graduate Advanced Degrees
            tpGac.Text = deg.graduate[3].degreeName;
            lblGac1.Text = deg.graduate[3].availableCertificates[0];
            lblGac2.Text = deg.graduate[3].availableCertificates[1];
        }

        // Button Listeners for Switching between Forms
        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 HomeForm = new Form1();
            HomeForm.Show();
            this.Hide();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            Form2 PeopleForm = new Form2();
            PeopleForm.Show();
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
