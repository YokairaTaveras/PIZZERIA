namespace PIZZERIA.Models
{
    public class Pizza
    {
        public Pizza(int id, string Nombre, decimal Precio, Picantes Picantes)
        {
            this.PizzaId = PizzaId;
            this.Nombre = Nombre;
            this.Precio = Precio;
            this.Picantes = Picantes;
        }
        public int PizzaId { get; }
        public string Nombre { get; }
        public decimal Precio { get; }
        public Picantes Picantes { get; }
    }
}
