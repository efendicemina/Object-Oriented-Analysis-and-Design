using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LV5.Models
{
    public class Predmet
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage =
"Naziv predmeta smije imati između 3 i 50 karaktera!")]
        [RegularExpression(@"[0-9| |a-z|A-Z]*", ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova, brojeva i razmaka!")]

        public string Naziv { get; set; }
        [DisplayName ("ECTS bodovi")]
        public double ECTS { get; set; }
        public int GenerišiID()
        {
            int id = 0;
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                id += (int)Math.Pow(10, i) * generator.Next(0, 9);
            }
            return id;
        }

        public Predmet()
        {
        }
    }
}
