using Microsoft.AspNetCore.SignalR;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication11.Data.Entity
{
    public class Order
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get;set; }  
        public DateTime CreatedDate { get;set; }    
        public User User { get;set; }   
    }
}
