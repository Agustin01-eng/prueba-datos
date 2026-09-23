using Dominio;

namespace Tests;

public class PolimorfismoTests
{
    [Fact]
    public void LosDispositivosProcesanElPaquete()
    {
        // Arrange: creamos el paquete
        var paquete = new PaqueteRed(
            "192.168.1.10",
            "192.168.1.20",
            5000,
            80,
            "TCP",
            1024
        );

        // Creamos distintos dispositivos
        var dispositivos = new List<DispositivoRed>
        {
            new Router("Router 1", 10),
            new Switch("Switch 1", 5),
            new AccessPoint("Access Point 1", 8),
            new Firewall("Firewall 1", 15)
        };

        // Act: cada dispositivo procesa el mismo paquete
        foreach (var dispositivo in dispositivos)
        {
            dispositivo.ProcesarPaquete(paquete);
        }

        // Assert
        Assert.Equal(4, dispositivos.Count);
    }
}