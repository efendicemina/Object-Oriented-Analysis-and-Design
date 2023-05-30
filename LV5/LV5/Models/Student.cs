using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LV5.Models
{
    public class Student
    {
        [Key]
        public int BrojIndeksa { get; set; }

        [EnumDataType(typeof(VrstaStudenta))]
        public VrstaStudenta Vrsta { get; set; }
        public int GodinaStudija { get; set; }

        public Student()
        {
        }
    }
}
