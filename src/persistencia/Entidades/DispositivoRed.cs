namespace Persistencia.Entidades;

public abstract class DispositivoRed
{
    private string nombre;
    private double latencia;

    public string Nombre
    {
        get { return nombre; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío.");

            nombre = value.Trim();
        }
    }

    public double Latencia
    {
        get { return latencia; }
        protected set
        {
            if (value < 0)
                throw new ArgumentException("La latencia no puede ser negativa.");

            latencia = value;
        }
    }

    protected DispositivoRed(string nombre, double latencia)
    {
        Nombre = nombre;
        Latencia = latencia;
    }

    public abstract void ProcesarPaquete(PaqueteRed paquete);
}