using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class Stdform
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CNIC { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Degree { get; set; }
        public string Semester { get; set; }
        public string Address { get; set; }



    }
}
