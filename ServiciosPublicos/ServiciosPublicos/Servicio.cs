
namespace ServiciosPublicos
{
    public class Servicio
    {
        //Propiedades
        public string Nombre { get; set; }
        public float Consumo { get; set; }

        //Constructor de la clase
        public Servicio(string nombre, float consumo)
        {
            this.Nombre = nombre;
            this.Consumo = consumo;
            //Nombre = "";
            //Consumo = 0;
        }        
    }
}
