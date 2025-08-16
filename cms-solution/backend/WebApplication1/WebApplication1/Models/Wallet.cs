using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApplication1.Models
{
    [Table("Wallet")]
    public class Wallet
    {
        [Key] 
        public int WalletId { get; set; }
        public int CustId { get; set; }
        public string? WalletType { get; set; }
        public decimal? WalletAmount { get; set; }
    }
}
