namespace Dominio;

public class AccessPoint : DispositivoRed
{
    public AccessPoint(string nombre, double latencia)
        : base(nombre, latencia)
    {
    }

    public override void ProcesarPaquete(PaqueteRed paquete)
    {
        Console.WriteLine(
            $"Access Point {Nombre}: transmitiendo el paquete por Wi-Fi."
        ); 
    }
}