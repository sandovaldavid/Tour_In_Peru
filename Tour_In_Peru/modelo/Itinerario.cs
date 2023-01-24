class Itinerario
{
    private int idItinerario;
    private DateTime HoraInicio;
    private DateTime HoraCese;
    private string lugarDePartida;
    private string estado;

    public Itinerario()
    {
    }

    public Itinerario(int idItinerario, DateTime HoraInicio, DateTime HoraCese, string lugarDePartida, string estado)
    {
        this.idItinerario = idItinerario;
        this.HoraInicio = HoraInicio;
        this.HoraCese = HoraCese;
        this.lugarDePartida = lugarDePartida;
        this.estado = estado;
    }

    public int getIdItinerario()
    {
        return idItinerario;
    }

    public void setIdItinerario(int idItinerario)
    {
        this.idItinerario = idItinerario;
    }

    public DateTime getHoraInicio()
    {
        return HoraInicio;
    }

    public void setHoraInicio(DateTime HoraInicio)
    {
        this.HoraInicio = HoraInicio;
    }

    public DateTime getHoraCese()
    {
        return HoraCese;
    }

    public void setHoraCese(DateTime HoraCese)
    {
        this.HoraCese = HoraCese;
    }

    public string getLugarDePartida()
    {
        return lugarDePartida;
    }

    public void setLugarDePartida(string lugarDePartida)
    {
        this.lugarDePartida = lugarDePartida;
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
