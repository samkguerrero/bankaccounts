using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistration.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId {get;set;}

        [Required]
        [Display(Name="Amount")]
        public float Amount {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public User Creator {get;set;}

        public int CreatorUserId {get;set;}

        public string TheMakerOfTransaction {get;set;}
    }
}