namespace PIZZERIA.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = default!;
        public string Calle { get; set; } = default!;
        public string ciudad { get; set; } = default!;
    }
}
