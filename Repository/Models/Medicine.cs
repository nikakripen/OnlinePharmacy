namespace Repository.Models
{
    public class Medicine : Entity
    {
        public string Name { get; set; }
        public string ProductForm { get; set; }
        public string Manufacturer { get; set; }
        public bool Recipe { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
    }
}
