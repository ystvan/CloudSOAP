using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentService.svc or StudentService.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService
    {

        private static List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student FindStudent(string cpr)
        {
            return students.FirstOrDefault((s) => s.CprNo == cpr);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void EditStudent(Student student)
        {
            Student s = FindStudent(student.CprNo);
            s.Address = student.Address;
            s.Name = student.Name;
        }
    }
}
