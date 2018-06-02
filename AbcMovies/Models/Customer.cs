﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AbcMovies.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)] //Overriting data annotations
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }


    }
}