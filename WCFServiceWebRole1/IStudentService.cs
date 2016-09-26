using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentService" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {

        [OperationContract]
        void AddStudent(IStudent student);

        [OperationContract]
        List<IStudent> GetAllStudents();

        [OperationContract]
        IStudent FindStudent(string cpr);

        [OperationContract]
        void RemoveStudent(IStudent student);

        [OperationContract]
        void EditStudent(IStudent student);
        

    }


    //// Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]

    //public class Student
    //{
    //    private String _name;
    //    private String _address;
    //    private String _cprNo;

    //    [DataMember]
    //    public String Name
    //    {
    //        get { return _name; }
    //        set { _name = value; }
    //    }

    //    [DataMember]
    //    public String Address
    //    {
    //        get { return _address; }
    //        set { _address = value; }
    //    }

    //    [DataMember]
    //    public String CprNo
    //    {
    //        get { return _cprNo; }
    //        set { _cprNo = value; }
    //    }

    //    /// <summary>
    //    /// Initializes a Student object with the corresponding properties
    //    /// </summary>
    //    /// <param name="name">Student's First name</param>
    //    /// <param name="address">Student's City they live in</param>
    //    /// <param name="cprNo">Student's social security number</param>
    //    public Student(string name, string address, string cprNo)
    //    {
    //        _name = name;
    //        _address = address;
    //        _cprNo = cprNo;
    //    }

    //    /// <summary>
    //    /// Initializes a Student object with empty strings, default constructor
    //    /// </summary>
    //    public Student()
    //    {
            
    //    }

    //    #region Equality members

    //    //If the CPR number is equal the objects are the same
       
    //    protected bool Equals(Student other)
    //    {
    //        return string.Equals(_cprNo, other._cprNo);
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        if (ReferenceEquals(null, obj)) return false;
    //        if (ReferenceEquals(this, obj)) return true;
    //        if (obj.GetType() != this.GetType()) return false;
    //        return Equals((Student)obj);
    //    }

    //    public override int GetHashCode()
    //    {
    //        return (_cprNo != null ? _cprNo.GetHashCode() : 0);
    //    }

    //    #endregion

    //}
    
}
