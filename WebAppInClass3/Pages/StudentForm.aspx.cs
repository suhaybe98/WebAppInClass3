using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppInClass3.Pages
{
    public partial class StudentForm : System.Web.UI.Page
    {

        private static List<Student> People = new List<Student>();

        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }
        protected void Add_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "StudID = " + StudID.Text + " Name = " + Name.Text;
            if (Page.IsValid)
            {
                bool found = false;
                foreach (var item in People)
                {
                    if (item.StudID == int.Parse(StudID.Text))
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    MessageLabel.Text = "Record already exists.";
                }
                else
                {
                    Student newitem = new Student(int.Parse(StudID.Text), Name.Text, double.Parse(Credit.Text), Phone.Text);
                    People.Add(newitem);
                    PeopleGridView.DataSource = People;
                    PeopleGridView.DataBind();
                }
            }
        }
        protected void Clear_Click(object sender, EventArgs e)
        {
            StudID.Text = "";
            Name.Text = "";
            Credit.Text = "";
            Phone.Text = "";
        }
    }
}