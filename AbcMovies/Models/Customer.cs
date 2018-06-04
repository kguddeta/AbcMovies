using System;
using System.ComponentModel.DataAnnotations;

namespace AbcMovies.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)] //Overriting data annotations
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        [Display(Name = "Membership Type")]
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }


    }
}