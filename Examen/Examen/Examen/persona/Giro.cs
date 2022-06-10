public class Giro
{
    protected int _numeroAleatorio;

    public Giro(int numeroAleatorio)
    {
        this._numeroAleatorio = numeroAleatorio;
    }

    public int numeroAleatorio
    {
        get { return _numeroAleatorio; }
        set { _numeroAleatorio = value;}
    }
    public override string ToString()
    {
        return "El número obtenido en el giro es: " + numeroAleatorio;
    }
}
