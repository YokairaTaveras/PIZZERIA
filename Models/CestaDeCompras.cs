namespace PIZZERIA.Models
{
    public class CestaDeCompras
    {
        public Cliente Cliente { get; set; } = new Cliente();
        public List<int> Ordenes { get; set; } = new List<int>();
        public bool HaPagado { get; set; }

        public void Add(int pizzaId)
       => Ordenes.Add(pizzaId);

        public void RemoveAt(int pos)
        => Ordenes.RemoveAt(pos);
    }
}
