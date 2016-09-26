namespace WCFServiceWebRole1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public interface IStudent
    {
        string CprNo { get; set; }
        string Name { get; set; }
        string Address { get; set; }
    }

    public partial class Student : IStudent
    {
        [Key]
        [StringLength(50)]
        public string CprNo { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public Student(IStudent iStudent)
        {
            this.CprNo = iStudent.CprNo;
            this.Address = iStudent.Address;
            this.Name = iStudent.Name;
        }
    }
}
