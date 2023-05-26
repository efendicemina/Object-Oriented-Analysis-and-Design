using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LV5.Models
{
    public class UpisNaPredmet
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Predmet")]
        public int PredmetId { get; set; }
        public Student Student { get; set; }
        public Predmet Predmet { get; set; }

        public UpisNaPredmet()
        {
        }
    }
}
