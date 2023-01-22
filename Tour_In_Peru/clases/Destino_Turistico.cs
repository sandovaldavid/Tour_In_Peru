class DestinoTuristico
{
    private int idDestinoTuristico;
    private string nombre;

    public DestinoTuristico(int idDestinoTuristico, string nombre)
    {
        this.idDestinoTuristico = idDestinoTuristico;
        this.nombre = nombre;
    }

    public int getIdDestinoTuristico()
    {
        return idDestinoTuristico;
    }

    public void setIdDestinoTuristico(int idDestinoTuristico)
    {
        this.idDestinoTuristico = idDestinoTuristico;
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
