using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMvcECommerce.Models
{
    public class User
    {
        [Key]
        [Display(Name = "Usuario")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "O campo email é necessário")]
        [MaxLength(250, ErrorMessage = "Tamanho máximo ultrapassado")]
        [Index("User_UserName_Index", IsUnique = true)]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "O campo email é necessário")]
        [MaxLength(250, ErrorMessage = "Tamanho máximo ultrapassado")]
        [Display(Name = "Primeiro nome")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "O campo email é necessário")]
        [MaxLength(250, ErrorMessage = "Tamanho máximo ultrapassado")]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Display(Name = "Nome completo")]
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        [Required(ErrorMessage = "O campo endereço é necessário")]
        [MaxLength(100, ErrorMessage = "Tamanho máximo ultrapassado")]
        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Required(ErrorMessage = "O campo telefone é necessário")]
        [MaxLength(50, ErrorMessage = "Tamanho máximo ultrapassado")]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string Telephony { get; set; }

        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Photo { get; set; }

        [NotMapped]
        public HttpPostedFileBase PhotoFile { get; set; }

        [Required(ErrorMessage = "O campo cidade é necessário")]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "O campo departamento é necessário")]
        [Display(Name = "Departamento")]
        public int DepartamentsId { get; set; }

        [Required(ErrorMessage = "O campo departamento é necessário")]
        [Display(Name = "Departamento")]
        public int CompanyId { get; set; }

        public virtual Departaments Departament { get; set; }
        public virtual City City { get; set; }
        public virtual Company Company { get; set; }
    }
}