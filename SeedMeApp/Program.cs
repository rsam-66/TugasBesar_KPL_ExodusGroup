namespace SeedMeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalogService = new CatalogService();
            var donationService = new DonationService<string>();

            try
            {
                var product = new Product("Eco-Friendly Straw", 5.99m, "A reusable straw.");
                catalogService.AddProduct(product);

                donationService.AddDonation("Tree Seed Donation");

                Console.WriteLine("Catalog Products:");
                foreach (var p in catalogService.GetProducts())
                {
                    Console.WriteLine($"- {p.Name}: {p.Price:C} - {p.Description}");
                }

                Console.WriteLine("\nDonations:");
                foreach (var d in donationService.GetDonations())
                {
                    Console.WriteLine($"- {d}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    internal class Product
    {
        private string v1;
        private decimal v2;
        private string v3;

        public Product(string v1, decimal v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }

    internal class CatalogService
    {
        public CatalogService()
        {
        }

        internal void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<object> GetProducts()
        {
            throw new NotImplementedException();
        }
    }

    internal class DonationService<T>
    {
        public DonationService()
        {
        }

        internal void AddDonation(string v)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<object> GetDonations()
        {
            throw new NotImplementedException();
        }
    }
}
