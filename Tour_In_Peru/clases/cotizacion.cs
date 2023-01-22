class Cotizacion
{
    private int idCotizacion;
    private int numeroPersonas;
    private DateTime fechaViaje;
    private string tipoViaje;
    private double montoTotal;
    private string estado;
    public Cotizacion(int idCotizacion, int numeroPersonas, DateTime fechaViaje, string tipoViaje, double montoTotal, string estado)
    {
        this.idCotizacion = idCotizacion;
        this.numeroPersonas = numeroPersonas;
        this.fechaViaje = fechaViaje;
        this.tipoViaje = tipoViaje;
        this.montoTotal = montoTotal;
        this.estado = estado;
    }
    public int getIdCotizacion()
    {
        return idCotizacion;
    }
    
    public int getNumeroPersonas()
    {
        return numeroPersonas;
    }


    public void setNumeroPersonas(int numeroPersonas)
    {

        this.numeroPersonas = numeroPersonas;
    }



    public DateTime getFechaViaje()
    {
        return fechaViaje;
    }
    public void setFechaViaje(DateTime fechaViaje)
    {
        this.fechaViaje = fechaViaje;
    }
    public string getTipoViaje()
    {
        return tipoViaje;
    }
    public void setTipoViaje(string tipoViaje)
    {
        this.tipoViaje = tipoViaje;
    }
    public double getMontoTotal()
    {
        return montoTotal;
    }
    public void setMontoTotal(double montoTotal)
    {
        this.montoTotal = montoTotal;
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




