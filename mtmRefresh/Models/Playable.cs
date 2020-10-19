using System;
using System.ComponentModel.DataAnnotations;

namespace mtmRefresh.Models
{
    public class Playable
    {
        [Key]
        public int PlayableId {get;set;}
        public int GameId {get;set;}
        public int PlatformId {get;set;}
        public Game Game {get;set;}
        public Platform Platform {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}