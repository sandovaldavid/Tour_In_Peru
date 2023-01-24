class Tipo_Tarjeta
{
    private int idTipoTarjeta;
    private string nombre;

    public Tipo_Tarjeta()
    {
        this.idTipoTarjeta = 0;
        this.nombre = "";
    }

    public Tipo_Tarjeta(int idTipoTarjeta, string nombre)
    {
        this.idTipoTarjeta = idTipoTarjeta;
        this.nombre = nombre;
    }

    public int GetIdTipoTarjeta()
    {
        return this.idTipoTarjeta;
    }

    public void SetIdTipoTarjeta(int idTipoTarjeta)
    {
        this.idTipoTarjeta = idTipoTarjeta;
    }

    public string GetNombre()
    {
        return this.nombre;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
}
