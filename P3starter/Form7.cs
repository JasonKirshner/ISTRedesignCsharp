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
 * Resources Form for Project3
 * @author Jason Kirshner
 * @version 5/9/2017
 */

namespace Project3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Resources();
        }

        // Consumes reources data and displays studyAbroad, studentServices, tutorsAndLabInformation, minorAdvising, studentAmbassadors, and coopEnrollment data to the form
        public void Resources()
        {
            string jsonResources = getRESTData("/resources");
            Resources resources = JToken.Parse(jsonResources).ToObject<Resources>();

            lblTitle.Text = resources.title;

            // Study Abroad
            gbStudA.Text = resources.studyAbroad.title;
            rtbStudA.Text = resources.studyAbroad.description;
            tpPlace1.Text = resources.studyAbroad.places[0].nameOfPlace;
            tpPlace2.Text = resources.studyAbroad.places[1].nameOfPlace;
            rtbPlace1.Text = resources.studyAbroad.places[0].description;
            rtbPlace2.Text = resources.studyAbroad.places[1].description;

            // Student Services
            lblAdvTitle.Text = resources.studentServices.title;
            tpAdv1.Text = resources.studentServices.academicAdvisors.title;
            rtbAdv1.Text = resources.studentServices.academicAdvisors.description;

            // Advisor Info
            tpAdv2.Text = resources.studentServices.professonalAdvisors.title;
            foreach (AdvisorInformation adv in resources.studentServices.professonalAdvisors.advisorInformation)
            {
                TreeNode name = new TreeNode(adv.name);
                TreeNode dept = new TreeNode(adv.department);
                TreeNode email = new TreeNode(adv.email);
                name.Nodes.Add(dept);
                name.Nodes.Add(email); 
                tvAdv1.Nodes.Add(name);
            }

            tpAdv3.Text = resources.studentServices.facultyAdvisors.title;
            rtbAdv3.Text = resources.studentServices.facultyAdvisors.description;

            // Minor Advisor Info
            tpAdv4.Text = resources.studentServices.istMinorAdvising.title;
            foreach (MinorAdvisorInformation adv in resources.studentServices.istMinorAdvising.minorAdvisorInformation)
            {
                TreeNode title = new TreeNode(adv.title);
                TreeNode advisor = new TreeNode(adv.advisor);
                TreeNode email = new TreeNode(adv.email);
                title.Nodes.Add(advisor);
                title.Nodes.Add(email);
                tvAdv2.Nodes.Add(title);
            }

            // Tutors and Lab Information
            lblTali.Text = resources.tutorsAndLabInformation.title;
            rtbTali.Text = resources.tutorsAndLabInformation.description;

            // Student Ambassadors
            lblStuAm.Text = resources.studentAmbassadors.title;
            tpCon1.Text = resources.studentAmbassadors.subSectionContent[0].title;
            rtbCon1.Text = resources.studentAmbassadors.subSectionContent[0].description;
            tpCon2.Text = resources.studentAmbassadors.subSectionContent[1].title;
            rtbCon2.Text = resources.studentAmbassadors.subSectionContent[1].description;
            tpCon3.Text = resources.studentAmbassadors.subSectionContent[2].title;
            rtbCon3.Text = resources.studentAmbassadors.subSectionContent[2].description;
            tpCon4.Text = resources.studentAmbassadors.subSectionContent[3].title;
            rtbCon4.Text = resources.studentAmbassadors.subSectionContent[3].description;
            tpCon5.Text = resources.studentAmbassadors.subSectionContent[4].title;
            rtbCon5.Text = resources.studentAmbassadors.subSectionContent[4].description;
            tpCon6.Text = resources.studentAmbassadors.subSectionContent[5].title;
            rtbCon6.Text = resources.studentAmbassadors.subSectionContent[5].description;
            tpCon7.Text = resources.studentAmbassadors.subSectionContent[6].title;
            rtbCon7.Text = resources.studentAmbassadors.subSectionContent[6].description;

            // Coop Enrollment
            lblCoopE.Text = resources.coopEnrollment.title;
            tpCoopE1.Text = resources.coopEnrollment.enrollmentInformationContent[0].title;
            rtbCoopE1.Text = resources.coopEnrollment.enrollmentInformationContent[0].description;
            tpCoopE2.Text = resources.coopEnrollment.enrollmentInformationContent[1].title;
            rtbCoopE2.Text = resources.coopEnrollment.enrollmentInformationContent[1].description;
            tpCoopE3.Text = resources.coopEnrollment.enrollmentInformationContent[2].title;
            rtbCoopE3.Text = resources.coopEnrollment.enrollmentInformationContent[2].description;
            tpCoopE4.Text = resources.coopEnrollment.enrollmentInformationContent[3].title;
            rtbCoopE4.Text = resources.coopEnrollment.enrollmentInformationContent[3].description;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 HomeForm = new Form1();
            HomeForm.Show();
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
