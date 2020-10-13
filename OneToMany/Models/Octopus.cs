using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OneToMany.Models{
    public class Octopus{
        [Key]
        public int OctopusId{get;set;}

        [Required]
        public string Name{get;set;}
        [Required]
        public string Hat{get;set;}
        [Required]
        public int Ink_Amount{get;set;}
        public List<Tentacle> Tentacles{get;set;}
    }
}