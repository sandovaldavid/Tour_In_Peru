class Banco
{
    private int idBanco;
    private string nombre;

    public Banco(int idBanco, string nombre)
    {
        this.idBanco = idBanco;
        this.nombre = nombre;
    }

    public int getIdBanco()
    {
        return idBanco;
    }

    public void setIdBanco(int idBanco)
    {
        this.idBanco = idBanco;
    }

    public string getNombre()
    {
        return nombre;
    }

    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }
}
