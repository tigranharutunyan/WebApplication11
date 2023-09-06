using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication11.Data.Entity
{
    public class Cart
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get;set; }
        
        public int Count { get; set; }
        public int? Price { get; set; }        
        public int UserId { get; set; }

        public DateTime AddDate { get; set; }  
        public Product Product { get;set; }//navigation property       
    }
}
