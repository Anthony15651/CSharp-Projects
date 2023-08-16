using System;

namespace FinalChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Uses SchoolContext to access the db, creates a new student, and adds that student to the db 
            using (var context = new SchoolContext())
            {
                var student = new Student()
                {
                    FirstName = "Anthony",
                    LastName = "Garcia",
                    GradeYear = 12
                };

                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }
}
