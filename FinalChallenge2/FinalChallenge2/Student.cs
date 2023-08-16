using System;
using System.Collections.Generic;
using System.Text;

namespace FinalChallenge2
{
    // Creating the student class to use in the db
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GradeYear { get; set; }
    }
}
