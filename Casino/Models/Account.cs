using System.ComponentModel.DataAnnotations;

namespace Casino.Models 
{
    public class Account
    {
        [Key] public int AccountId {get; set;}
        public int Balance {get; set;}
        public string? Name {get; set;}
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool IsAuthor { get; set; }
        public int Category {  get; set; }
    }
}