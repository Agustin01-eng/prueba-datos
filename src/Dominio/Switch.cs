namespace Dominio;

public class Simulacion
{
    private readonly List<DispositivoRed> dispositivos;

    public PaqueteRed Paquete { get; private set; }

    public IReadOnlyList<DispositivoRed> Dispositivos
    {
        get { return dispositivos; }
    }

    public Simulacion(PaqueteRed paquete)
    {
        Paquete = paquete ?? throw new ArgumentNullException(nameof(paquete));

        dispositivos = new List<DispositivoRed>();
    } 

    public void AgregarDispositivo(DispositivoRed dispositivo)
    {
        if (dispositivo == null)
            throw new ArgumentNullException(nameof(dispositivo));

        dispositivos.Add(dispositivo);
    }
}|