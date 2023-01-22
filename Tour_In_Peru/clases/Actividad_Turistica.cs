class ActividadTuristica
{
    private int idActividadTuristica;
    private string nombre;
    private string tipo;

    public ActividadTuristica(int idActividadTuristica, string nombre, string tipo)
    {
        this.idActividadTuristica = idActividadTuristica;
        this.nombre = nombre;
        this.tipo = tipo;
    }

    public int getIdActividadTuristica()
    {
        return idActividadTuristica;
    }

    public void setIdActividadTuristica(int idActividadTuristica)
    {
        this.idActividadTuristica = idActividadTuristica;
    }

    public string getNombre()
    {
        return nombre;
    }

    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public string getTipo()
    {
        return tipo;
    }

    public void setTipo(string tipo)
    {
        this.tipo = tipo;
    }
}
