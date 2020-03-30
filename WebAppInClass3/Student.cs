using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppInClass3
{
    public class Student
    {
        public int StudID { get; set; }
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
            StudID = StudentID;
            Name = name;
            Credit = Credit;
            Phone = phone;
        }
    }
}