using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantOnline.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        public List<OrderDetail> OrderLines { get; set; }

        [Required(ErrorMessage = "Introduce-ti numele!")]
        [Display(Name = "Nume")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Introduce-ti prenumele!")]
        [Display(Name = "Prenume")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Introduce-ti adresa!")]
        [StringLength(100)]
        [Display(Name = "Adresa 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Adresa 2")]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Introduce-ti codul postal!")]
        [Display(Name = "Cod Postal")]
        [StringLength(10, MinimumLength = 4)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Introduce-ti orasul!")]
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(10)]
        public string State { get; set; }

        [Required(ErrorMessage = "Introduce-ti judetul!")]
        [StringLength(50)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Introduce-ti numarul de telefon.")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefon")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "Emailul introdus este de format invalid. (Corect: exemplu@ceva.undeva")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
