using Aplicacion.Interfaces;
using Dominio;

namespace Aplicacion.Servicios;

public class SimulacionService : ISimulacionService 
{
    public void Ejecutar (Simulacion simulacion)
    {
        if (Simulacion == null)
        throw new ArgumentNullException (nameof(simulacion));

        foreach (var Dispositivo in simulacion.Dispositivos)
        {
            dispositivo ProcesarPaquete (Simulacion.Paquete);
        }
    }
}