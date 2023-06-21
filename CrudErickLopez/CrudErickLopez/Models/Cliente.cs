namespace CrudErickLopez.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Nro_documento { get; set; }
        public string Email { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public string Direccion { get; set; }
    }
}
