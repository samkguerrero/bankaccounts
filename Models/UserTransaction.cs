using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistration.Models
{
    public class UserTransaction
    {
        public User User {get;set;}
        public Transaction Transaction {get;set;}

    }
}