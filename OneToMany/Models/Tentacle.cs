using System;
using System.ComponentModel.DataAnnotations;

namespace OneToMany.Models{
    public class Tentacle{
        [Key]
        public int TentacleId{get;set;}
        [Required]
        public string Name{get;set;}
        [Required]
        public int Num_Suction_Cups{get;set;}
        [Required]
        public bool Has_Boxing_Glove{get;set;}
        [Required]
        public int Length{get;set;}
        [Required]
        [Display(Name="Bearer")]
        public int OctopusId{get;set;}
        public Octopus Bearer{get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}