namespace Sales_Report
{
    public class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public static Sale Parse(string saleAsString)
        {
            string[] salesPart = saleAsString.Split(' ');

            return new Sale
            {
                Town = salesPart[0],
                Product = salesPart[1],
                Price = decimal.Parse(salesPart[2]),
                Quantity = decimal.Parse(salesPart[3])
            };
        }
    }
}
