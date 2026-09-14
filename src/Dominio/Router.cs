namespace Dominio;

public class Router : DispositivoRed
{
    public Router(string nombre, double latencia)
        : base(nombre, latencia)
    {
    }

    public override void ProcesarPaquete(PaqueteRed paquete)
    {
        Console.WriteLine(
            $"Router {Nombre}: buscando una ruta hacia {paquete.IpDestino}."
        );
    }
}