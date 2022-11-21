using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; } 

        public string Nome { get; set; }

        [Column(TypeName = "text")]
        public string? Description { get; set; }

        public string Image { get; set; }

        public double Price { get; set; }

        

        public Pizza()
        {

        }

        public Pizza(string nome, string image, double price)
        {
            Nome = nome;
            Image = image;
            Price = price;
        }
    }
}
