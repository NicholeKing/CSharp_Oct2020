using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace mtmRefresh.Models
{
    public class Game
    {
        [Key]
        public int GameId {get;set;}
        [Required]
        public string GameName {get;set;}
        [Required]
        public string Rating {get;set;} 
        public List<Playable> PlatformsPlayableOn {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}