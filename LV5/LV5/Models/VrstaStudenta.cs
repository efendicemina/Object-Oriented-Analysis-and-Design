using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LV5.Models
{
    public enum VrstaStudenta
    {
        [Display(Name = "Redovni student")]
        Redovni,
        [Display(Name = "Redovni samofinansirajući student")]
        RedovniSF,
        [Display(Name = "Vanredni student")]
        Vanredni


    }
}
