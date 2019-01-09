using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMvcECommerce.Models
{
    public class City
    {
        [Key]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "O campo nome é necessário")]
        [Display(Name = "Cidade")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Departamento é necessário")]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }

        [Display(Name = "Departamento")]
        public virtual Departaments Departatament { get; set; }

        public virtual ICollection<Company> Companies { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}