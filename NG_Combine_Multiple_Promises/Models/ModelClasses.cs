using System.Collections.Generic;

namespace NG_Combine_Multiple_Promises.Models
{
    public class Courses
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
    public class CourseDatabase : List<Courses>
    {
        public CourseDatabase()
        {
            Add(new Courses() { CourseId=1,CourseName="Electronics"});
            Add(new Courses() { CourseId = 2, CourseName = "Electrical" });
            Add(new Courses() { CourseId = 3, CourseName = "Civil" });
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string AcadmicYear { get; set; }
    }

    public class StudentDatabase : List<Student>
    {
        public StudentDatabase()
        {
            Add(new Student() {StudentId=101,Name="MS",AcadmicYear="First" });
            Add(new Student() { StudentId = 102, Name = "TS", AcadmicYear = "Second" });
            Add(new Student() { StudentId = 103, Name = "LS", AcadmicYear = "Third" });
            Add(new Student() { StudentId = 104, Name = "VB", AcadmicYear = "First" });
            Add(new Student() { StudentId = 105, Name = "PB", AcadmicYear = "Second" });
            Add(new Student() { StudentId = 106, Name = "AB", AcadmicYear = "Third" });
            Add(new Student() { StudentId = 107, Name = "SA", AcadmicYear = "First" });
            Add(new Student() { StudentId = 108, Name = "SN", AcadmicYear = "Second" });
            Add(new Student() { StudentId = 109, Name = "SK", AcadmicYear = "Third" });
        }
    }
    
}
