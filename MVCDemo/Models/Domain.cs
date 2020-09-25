using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required, Display (Name = "First Name")]
        public string FirstName { get; set; }
        [Required , Display (Name = "Last Name")]
        public string LastName { get; set; }
        
        public string Phone { get; set; }

        public string FullName { get { return $"{FirstName}{LastName}"; } }
    }


    public class StudentManager
    {
        private static List<Student> _students;

        static StudentManager()
        {
            _students = new List<Student>
            {
                new Student{ Id=1, FirstName="Bob", LastName = "Smith", Phone="403-123-4567"},
                new Student{ Id=2, FirstName="Jane", LastName = "Doe", Phone="403-234-5678"},
                new Student{ Id=3, FirstName="Bob", LastName = "Marley", Phone="403-555-6789"},
                new Student{ Id=4, FirstName="Ann", LastName = "Black", Phone="403-987-6543"},
            };
        }

        public static List<Student> GetAll()
        {
            return _students;
        }

        public static void Add(Student student)
        {
            var id = _students.Max(s => s.Id);
            id++;
            student.Id = id;
            _students.Add(student);
        }
    }

}
