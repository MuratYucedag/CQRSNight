﻿namespace CQRSNight.CQRSDesignPattern.Results.ProductResults
{
    public class GetProductByIdQueryResult
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
