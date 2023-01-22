class GestionCotizacion
{
    //Lista de cotizaciones
    private List<Cotizacion> cotizaciones;

    public GestionCotizacion()
    {
        cotizaciones = new List<Cotizacion>();
    }

    //Método para agregar una nueva cotizacion
    public void agregarCotizacion(Cotizacion cotizacion)
    {
        cotizaciones.Add(cotizacion);
    }

    //Método para eliminar una cotizacion
    public void eliminarCotizacion(int idCotizacion)
    {
        Cotizacion cotizacionEliminar = cotizaciones.Find(x => x.getIdCotizacion() == idCotizacion);
        cotizaciones.Remove(cotizacionEliminar);
    }

    //Método para obtener una cotizacion
    public Cotizacion obtenerCotizacion(int idCotizacion)
    {
        