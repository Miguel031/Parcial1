using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Miguel.Models
{
    public enum TypeList { Mesa, Martillo, Manzana }

    public class Clown
    {
        [Key]
        public int ClownID { get; set; }
        [Required]
        [Display(Name="Nombre Completo")]
        [MinLength(2)]
        [MaxLength(24)]
        public string NickName { get; set; }
        [Required]
        public TypeList Tricks { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name ="Cumpleaños")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }


    }
}