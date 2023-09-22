namespace PIZZERIA.Models
{
    public class Estado
    {
        public Menu Menu { get; } = new Menu();
        public CestaDeCompras Canasta { get; } = new CestaDeCompras();
        public UI UI { get; set; } = new UI();

        public decimal PrecioTotal
     => Canasta.Ordenes.Sum(id => Menu.GetPizza(id)!.Precio);
    }
}

