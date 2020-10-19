using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace mtmRefresh.Models
{
    public class Platform
    {
        [Key]
        public int PlatformId {get;set;}

        [Required]
        public string PlatformName {get;set;}
        [Required]
        public string Company {get;set;}
        public List<Playable> GamesPlayable {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}