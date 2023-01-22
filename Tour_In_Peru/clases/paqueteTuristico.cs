public class PaqueteTuristico
{
    private int id;
    private string nombre;
    private string descripcion;
    private int duracion;
    private string estado;

    // Constructor 
    public PaqueteTuristico(int id, string nombre, string descripcion, int duracion, string estado)
    {
        this.id = id;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.duracion = duracion;
        this.estado = estado;
    }

    // Getters y Setters
    public int getId ()
    {
        return id;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public string getNombre()
    {
        return nombre;
    }

    public void setNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public string getDescripcion()
    {
        return descripcion;
    }

    public void setDescripcion(string descripcion)
    {
        this.descripcion = descripcion;
    }

    public int getDuracion()
    {
        return duracion;
    }

    public void setDuracion(int duracion)
    {
        this.duracion = duracion;
    }

    public string getEstado()
    {
        return estado;
    }

    public void setEstado(string estado)
    {
        this.estado = estado;
    }

}