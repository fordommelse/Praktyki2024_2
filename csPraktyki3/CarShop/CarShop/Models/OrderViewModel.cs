namespace CarShop.Models
{
    public class OrderViewModel
    {
        public decimal TotalAmount { get; set; }

        // Inicjalizacja pustej listy, aby uniknąć błędu NullReferenceException
        public List<OrderItemViewModel> OrderItems { get; set; } = new List<OrderItemViewModel>();

        public IEnumerable<Product> Products { get; set; }
    }
}