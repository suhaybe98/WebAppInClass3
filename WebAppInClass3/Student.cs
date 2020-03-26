using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppInClass3
{
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        
        public double Credit { get; set; }
        public string Phone { get; set; }
        public Student()
        {

        }
        public Student(int StudentID,
                        string name,  
                        double Credit,
                        string phone)
        {
            StudentID = StudentID;
            Name = name;
            Credit = Credit;
            Phone = phone;
        }
    }
}