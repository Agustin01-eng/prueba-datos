namespace Dominio;

public class Firewall : DispositivoRed
{
    public Firewall(string nombre, double latencia)
        : base(nombre, latencia)
    {
    }

    public override void ProcesarPaquete(PaqueteRed paquete)
    {
        Console.WriteLine(
            $"Firewall {Nombre}: revisando las reglas de seguridad."
        );
    }
}