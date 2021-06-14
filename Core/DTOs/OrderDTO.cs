using System.ComponentModel.DataAnnotations;
using Core.Models;

namespace Core.DTOs
{
    public class OrderDTO
    {
        [Required]
        public int SellerId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public Payment Payment { get; set; }
        [Required]
        public int[] ProductsId { get; set; }

        public OrderDTO(int sellerId, int customerId, int[] productsId, Payment payment)
        {
            SellerId = sellerId;
            CustomerId = customerId;
            Payment = payment;
            ProductsId = productsId;
        }
    }
}
