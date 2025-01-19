namespace Product_Project_Api.Models
{
    public class Product
    {
        /// <summary>
        ///ürün Id'si (Primary key)
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ürün adi
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// ürün fiyati
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// ürün aciklamasi
        /// </summary>
        public string Description { get; set; }
    }
}
