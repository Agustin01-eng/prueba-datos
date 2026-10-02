namespace Persistencia.Entidades;

public class PaqueteRed
{
    private string ipOrigen;
    private string ipDestino;
    private int puertoOrigen;
    private int puertoDestino;
    private string protocolo;
    private int tamanio;

    public string IpOrigen
    {
        get { return ipOrigen; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("La IP de origen no puede estar vacía.");

            ipOrigen = value;
        }
    }

    public string IpDestino
    {
        get { return ipDestino; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("La IP de destino no puede estar vacía.");

            ipDestino = value;
        }
    }

    public int PuertoOrigen
    {
        get { return puertoOrigen; }
        private set
        {
            if (value < 0 || value > 65535)
                throw new ArgumentException("Puerto de origen inválido.");

            puertoOrigen = value; 
        }
    }

    public int PuertoDestino
    {
        get { return puertoDestino; }
        private set
        {
            if (value < 0 || value > 65535)
                throw new ArgumentException("Puerto de destino inválido.");

            puertoDestino = value;
        }
    }

    public string Protocolo
    {
        get { return protocolo; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El protocolo no puede estar vacío.");

            protocolo = value;
        }
    }

    public int Tamanio
    {
        get { return tamanio; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("El tamaño debe ser mayor a cero.");

            tamanio = value;
        }
    }

    public PaqueteRed(
        string ipOrigen,
        string ipDestino,
        int puertoOrigen,
        int puertoDestino,
        string protocolo,
        int tamanio)
    {
        IpOrigen = ipOrigen;
        IpDestino = ipDestino;
        PuertoOrigen = puertoOrigen;
        PuertoDestino = puertoDestino;
        Protocolo = protocolo;
        Tamanio = tamanio;
    }
}