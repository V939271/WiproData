using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankProjectCore.Models
{
    public class Account
    {
        [Key]
        [Column("AccountNo")]
        public int AccountNo { get; set; }
        [Column("FirstName")]
        public string? FirstName { get; set; }
        [Column("LastName")]
        public string? LastName { get; set; }
        [Column("City")]
        public string? City { get; set; }
        [Column("State")]
        public string? State { get; set; }
        [Column("Amount")]
        public decimal Amount { get; set; }
        [Column("AccountType")]
        public string? AccountType { get; set; }
        [Column("CheqFacil")]
        public string? CheqFacil { get; set; }
    }
}