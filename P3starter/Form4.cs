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
 * Employment Form for Project3
 * @author Jason Kirshner
 * @version 5/9/2017
 */

namespace Project3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Introduction();
            Stats();
            EmployersCareers();
            EmpTable();
            CoopTable();
        }

        // Consumes employment data and displays the introduction data to the form
        public void Introduction()
        {
            string jsonEmployment = getRESTData("/employment");
            Employment emp = JToken.Parse(jsonEmployment).ToObject<Employment>();

            // Intro
            lblIntroTitle.Text = emp.introduction.title;
            lblIntroEmp.Text = emp.introduction.content[0].title;
            rtbIntroEmp.Text = emp.introduction.content[0].description;
            lblIntroCoop.Text = emp.introduction.content[1].title;
            rtbIntroCoop.Text = emp.introduction.content[1].description;
        }

        // Consumes employment data and displays degreeStatistics data to the form
        public void Stats()
        {
            string jsonEmployment = getRESTData("/employment");
            Employment emp = JToken.Parse(jsonEmployment).ToObject<Employment>();

            // Stats
            lblStats.Text = emp.degreeStatistics.title;
            gbStat1.Text = emp.degreeStatistics.statistics[0].value;
            rtbStat1.Text = emp.degreeStatistics.statistics[0].description;
            gbStat2.Text = emp.degreeStatistics.statistics[1].value;
            rtbStat2.Text = emp.degreeStatistics.statistics[1].description;
            gbStat3.Text = emp.degreeStatistics.statistics[2].value;
            rtbStat3.Text = emp.degreeStatistics.statistics[2].description;
            gbStat4.Text = emp.degreeStatistics.statistics[3].value;
            rtbStat4.Text = emp.degreeStatistics.statistics[3].description;
        }

        // Consumes employment data and displays employers and careers data displaying it to the form
        public void EmployersCareers()
        {
            string jsonEmployment = getRESTData("/employment");
            Employment emp = JToken.Parse(jsonEmployment).ToObject<Employment>();

            // Employers
            lblEmpTitle.Text = emp.employers.title;
            rtbEmps.Text = emp.employers.employerNames[0] + "\n";
            rtbEmps.AppendText(emp.employers.employerNames[1] + "\n");
            rtbEmps.AppendText(emp.employers.employerNames[2] + "\n");
            rtbEmps.AppendText(emp.employers.employerNames[3] + "\n");
            rtbEmps.AppendText(emp.employers.employerNames[4] + "\n");
            rtbEmps.AppendText(emp.employers.employerNames[5]);

            // Careers
            lblCareersTitle.Text = emp.careers.title;
            rtbCareers.Text = emp.careers.careerNames[0] + "\n";
            rtbCareers.AppendText(emp.careers.careerNames[1] + "\n");
            rtbCareers.AppendText(emp.careers.careerNames[2] + "\n");
            rtbCareers.AppendText(emp.careers.careerNames[3] + "\n");
            rtbCareers.AppendText(emp.careers.careerNames[4] + "\n");
            rtbCareers.AppendText(emp.careers.careerNames[5]);
        }

        // Consumes employment data and displays employerTable data to a treeNode in the form
        public void EmpTable()
        {
            string jsonEmployment = getRESTData("/employment");
            Employment emp = JToken.Parse(jsonEmployment).ToObject<Employment>();

            lblEmpTable.Text = emp.employmentTable.title;

            // Adds employmentTable data to a treeview in the form
            foreach (ProfessionalEmploymentInformation empTable in emp.employmentTable.professionalEmploymentInformation)
            {
                TreeNode employer = new TreeNode(empTable.employer);
                TreeNode degree = new TreeNode("Degree: " + empTable.degree);
                TreeNode city = new TreeNode("City: " + empTable.city);
                TreeNode title = new TreeNode("Title: " + empTable.title);
                TreeNode startDate = new TreeNode("Start Date: " + empTable.startDate);
                employer.Nodes.Add(degree);
                employer.Nodes.Add(city);
                employer.Nodes.Add(title);
                employer.Nodes.Add(startDate);
                tvEmp.Nodes.Add(employer);
            }
        }

        // Consumes employment data and diplays coopTable data to a treeNode in the form
        public void CoopTable()
        {
            string jsonEmployment = getRESTData("/employment");
            Employment coop = JToken.Parse(jsonEmployment).ToObject<Employment>();

            lblCoopTable.Text = coop.coopTable.title;

            // Adds coopTable info to a treeview in the form
            foreach (CoopInformation coopTable in coop.coopTable.coopInformation)
            {
                TreeNode employer = new TreeNode(coopTable.employer);
                TreeNode degree = new TreeNode("Degree: " + coopTable.degree);
                TreeNode city = new TreeNode("City: " + coopTable.city);
                TreeNode term = new TreeNode("Term: " + coopTable.term);
                employer.Nodes.Add(degree);
                employer.Nodes.Add(city);
                employer.Nodes.Add(term);
                tvCoop.Nodes.Add(employer);
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form1 HomeForm = new Form1();
            HomeForm.Show();
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
