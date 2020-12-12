using System.ComponentModel.DataAnnotations.Schema;

namespace aspnetcore_deployment.Data
{
    public class Sample
    {
        public Sample(int id, string name, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
    }
}