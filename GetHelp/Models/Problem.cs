using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetHelp.Models
{

    public enum Level
    {
        Easy,
        Medium,
        Hard

    }

    public class Problem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Problem Name")]
        public string Name { get; set; }

        [DisplayName("Problem  Link")]
        public string Link { get; set; }

        public string  Notes { get; set; }
        public Level Level { get; set; }




    }

}
