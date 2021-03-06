﻿using System;
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
        private readonly StudentModel _dbContexStudentModel = new StudentModel();

        public void AddStudent(IStudent student)
        {
            _dbContexStudentModel.Students.Local.Add(new Student(student));
        }

        public List<IStudent> GetAllStudents()
        {
            return new List<IStudent>(_dbContexStudentModel.Students.Local);
        }

        public IStudent FindStudent(string cpr)
        {
            return new Student(_dbContexStudentModel.Students.Local.FirstOrDefault((s) => s.CprNo == cpr));
        }

        public void RemoveStudent(IStudent student)
        {
            //TODO:implement for DB
            //_dbContexStudentModel.Students.Local.Remove(student);
        }

        public void EditStudent(IStudent student)
        {
            //TODO:implement for DB
            //IStudent s = FindStudent(student.CprNo);
            //s.Address = student.Address;
            //s.Name = student.Name;
        }
    }
}
