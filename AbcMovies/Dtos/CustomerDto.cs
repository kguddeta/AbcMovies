﻿using System;
using System.ComponentModel.DataAnnotations;
using AbcMovies.Models;

namespace AbcMovies.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        
        [StringLength(255)] 
        public string Name { get; set; }

  //      [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }

    }
}