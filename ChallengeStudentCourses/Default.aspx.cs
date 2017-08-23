using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */

            List<Course> courses = new List<Course>()
            {
                new Course() { CourseId="CSCI 201", Name="Introduction to Computer Science I", Students= new List<Student>() {
                    new Student() { StudentId=222, Name="Ross Capers" },
                    new Student() { StudentId=747, Name="Heather Rader" } } },
                new Course() { CourseId="BIOL 201", Name="General Biology I", Students= new List<Student>() {
                    new Student() { StudentId=185, Name="Jeremy Francis" },
                    new Student() { StudentId=526, Name="Bonney Guy" } } },
                new Course() {CourseId="ENGL 101", Name="Freshman Composition I", Students= new List<Student>() {
                    new Student() { StudentId=343, Name="Julia Watson" },
                    new Student() { StudentId=892, Name="Rich Rutherford"} } } 
            };

            string result = "";

            foreach (Course course in courses)
            {
                result += "Course: " + course.CourseId + " - " + course.Name + "<br />";

                foreach  (Student student in course.Students)
                {
                    result += "&nbsp;&nbsp;&nbsp;Student: " + student.StudentId + " - " + student.Name + "<br />";
                }
            }


            resultLabel.Text = result;
        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            Course course1 = new Course() { CourseId = "CSCI 201", Name = "Introduction to Computer Science I" };
            Course course2 = new Course() { CourseId = "BIOL 201", Name = "General Biology I" };
            Course course3 = new Course() { CourseId = "ENGL 101", Name = "Freshman Composition I" };
            Course course4 = new Course() { CourseId = "MATH 114", Name = "Differential Calculus" };
            Course course5 = new Course() { CourseId = "HIST 233", Name = "World History: The Renaissance" };
            Course course6 = new Course() { CourseId = "ECON 102", Name = "Introduction to Macroeconomics" };


            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                { 747, new Student() { StudentId=747, Name="Heather Rader", Courses= new List<Course> { course1, course4 } } },
                { 892, new Student() { StudentId=892, Name="Rich Rutherford", Courses= new List<Course> { course3, course5 } } },
                { 526, new Student() { StudentId=526, Name="Bonney Guy", Courses= new List<Course> { course2, course6} } }
            };

            string result = "";

            foreach (var student in students)
            {
                result += "Student: " + student.Value.StudentId + " - " + student.Value.Name + "<br />";
                foreach (var course in student.Value.Courses)
                {
                    result += "&nbsp;&nbsp;&nbsp;Course: " + course.CourseId + " - " + course.Name + "<br />";
                }
            }

            resultLabel.Text = result;
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            Dictionary<string, int> student1Grades = new Dictionary<string, int>()
            {
                { "Introduction to Computer Science I", 88 },
                { "Differential Calculus", 92 },
                { "Freshman Composition I", 85 }
            };

            Dictionary<string, int> student2Grades = new Dictionary<string, int>()
            {
                { "General Biology I", 95 },
                { "Differential Calculus", 78 },
                { "Introduction to Macroeconomics", 93 }
            };

            List<Student> studentList = new List<Student>()
            {
                new Student() { StudentId = 747, Name = "Heather Rader", Grades = student1Grades },
                new Student() { StudentId = 666, Name = "Damien Teufel", Grades = student2Grades }
            };

            string result = "";

            foreach (var student in studentList)
            {
                result += String.Format("Student: {0} {1} <br />", student.StudentId, student.Name);
                foreach (var course in student.Grades)
                {
                    result += String.Format("&nbsp;&nbsp;&nbsp;Enrolled In: {0} - Grade: {1} <br />", course.Key, course.Value);
                }
            }

            resultLabel.Text = result;
        }
    }
}