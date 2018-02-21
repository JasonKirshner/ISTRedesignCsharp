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
 * People Form for Project3
 * @author Jason Kirshner
 * @version 5/9/2017
 */

namespace Project3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Faculty();
            Staff();
        }

        // Consumes People data and displays Faculty data to the form
        public void Faculty()
        {
            string jsonPeople = getRESTData("/people/");
            People people = JToken.Parse(jsonPeople).ToObject<People>();

            // Updates titles
            lblPplTitle.Text = people.title;
            lblPplSubTitle.Text = people.subTitle;

            // Adds Faculty member names to the faculty comboBox
            foreach (Faculty fac in people.faculty)
            {
                // Checks for Jerry Powell and doesn't add his name
                if (fac.username != "djpihst")
                {
                    cbPeople.Items.Add(fac.name);
                }
            }
        }

        // Initiated once the index of the faculty comboBox has changed
        public void cbPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jsonPeople = getRESTData("/people/");
            People people = JToken.Parse(jsonPeople).ToObject<People>();

            // The Faculty members before Jerry Powell's index in the faculty array
            if (cbPeople.SelectedIndex < 26)
            {
                // Adds selected faculty members data to the form
                pbFacImg.ImageLocation = people.faculty[cbPeople.SelectedIndex].imagePath;
                lblFacName.Text = people.faculty[cbPeople.SelectedIndex].name;
                lblFacTitle.Text = "Title: " + people.faculty[cbPeople.SelectedIndex].title;
                lblFacIA.Text = "Interest Area: " + people.faculty[cbPeople.SelectedIndex].interestArea;
                lblFacOffice.Text = "Office: " + people.faculty[cbPeople.SelectedIndex].office;
                lblFacPhone.Text = "Phone: " + people.faculty[cbPeople.SelectedIndex].phone;
                llFacWeb.Text = people.faculty[cbPeople.SelectedIndex].website;
                lblFacEmail.Text = "Email: " + people.faculty[cbPeople.SelectedIndex].email;
            }
            // The Faculty members after Jerry Powell's index in the faculty array
            else
            {
                // Adds selected faulty members data to the form
                pbFacImg.ImageLocation = people.faculty[cbPeople.SelectedIndex +1].imagePath;
                lblFacName.Text = people.faculty[cbPeople.SelectedIndex + 1].name;
                lblFacTitle.Text = "Title: " + people.faculty[cbPeople.SelectedIndex + 1].title;
                lblFacIA.Text = "Interest Area: " + people.faculty[cbPeople.SelectedIndex + 1].interestArea;
                lblFacOffice.Text = "Office: " + people.faculty[cbPeople.SelectedIndex + 1].office;
                lblFacPhone.Text = "Phone: " + people.faculty[cbPeople.SelectedIndex + 1].phone;
                llFacWeb.Text = people.faculty[cbPeople.SelectedIndex + 1].website;
                lblFacEmail.Text = "Email: " + people.faculty[cbPeople.SelectedIndex + 1].email;
            }
        }

        // Opens clicked faculty member website link and opens the address in local browser
        public void llFacWeb_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(llFacWeb.Text);
        }

        // Consumes people data and adds staff names to the staff comboBox
        public void Staff()
        {
            string jsonPeople = getRESTData("/people/");
            People people = JToken.Parse(jsonPeople).ToObject<People>();

            // Adds staff names to the staff comboBox
            foreach (Staff staff in people.staff)
            {
                cbStaff.Items.Add(staff.name);
            }
        }

        // Initiated once the staff comboBox index has changed and adds staff info to the form
        public void cbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jsonPeople = getRESTData("/people/");
            People people = JToken.Parse(jsonPeople).ToObject<People>();

            // Adds Staff info to the form
            pbStaff.ImageLocation = people.staff[cbStaff.SelectedIndex].imagePath;
            lblStaffName.Text = people.staff[cbStaff.SelectedIndex].name;
            lblStaffTitle.Text = "Title: " + people.staff[cbStaff.SelectedIndex].title;
            lblStaffIA.Text = "Interest Area: " + people.staff[cbStaff.SelectedIndex].interestArea;
            lblStaffOffice.Text = "Office: " + people.staff[cbStaff.SelectedIndex].office;
            lblStaffPhone.Text = "Phone: " + people.staff[cbStaff.SelectedIndex].phone;
            llStaffWeb.Text = people.staff[cbStaff.SelectedIndex].website;
            lblStaffEmail.Text = "Email: " + people.staff[cbStaff.SelectedIndex].email;
        }

        // If staff member's website is clicked, that address is opened within local browser
        public void llStaffWeb_LinkClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(llStaffWeb.Text);
        }

        // Button Listeners for Switching between Forms
        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 HomeForm = new Form1();
            HomeForm.Show();
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
