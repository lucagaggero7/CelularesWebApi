namespace CelularesWebApi.Entidades
{
    public class Celular
    {
        public int Id {  get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
    }
}
