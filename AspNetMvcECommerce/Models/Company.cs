using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMvcECommerce.Models
{
    public class Company
    {
        [Key]
        [Display(Name = "Companhia")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "O campo nome é necessário")]
        [MaxLength(50, ErrorMessage = "Tamanho máximo ultrapassado")]
        [Index("Company_Name_Index", IsUnique = true)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo endereço é necessário")]
        [MaxLength(100, ErrorMessage = "Tamanho máximo ultrapassado")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Required(ErrorMessage = "O campo telefone é necessário")]
        [MaxLength(50, ErrorMessage = "Tamanho máximo ultrapassado")]
        [Index("Company_Telephony_Index", IsUnique = true)]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string Telephony { get; set; }

        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [NotMapped]
        public HttpPostedFileBase LogoFile { get; set; }

        [Required(ErrorMessage = "O campo cidade é necessário")]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "O campo departamento é necessário")]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }

        public virtual Departaments Departament { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<User> Users { get; set; }

    }
}