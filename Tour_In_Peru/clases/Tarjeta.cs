class Tarjeta
{
    private string numero_Tarjeta;
    private DateTime fecha_Caducidad;
    private int cvv;

    public Tarjeta()
    {
    }

    public Tarjeta(string numero_Tarjeta, DateTime fecha_Caducidad, int cvv)
    {
        this.numero_Tarjeta = numero_Tarjeta;
        this.fecha_Caducidad = fecha_Caducidad;
        this.cvv = cvv;
    }

    public string GetNumeroTarjeta()
    {
        return this.numero_Tarjeta;
    }

    public void SetNumeroTarjeta(string numero_Tarjeta)
    {
        this.numero_Tarjeta = numero_Tarjeta;
    }

    public DateTime GetFechaCaducidad()
    {
        return this.fecha_Caducidad;
    }

    public void SetFechaCaducidad(DateTime fecha_Caducidad)
    {
        this.fecha_Caducidad = fecha_Caducidad;
    }

    public int GetCvv()
    {
        return this.cvv;
    }

    public void SetCvv(int cvv)
    {
        this.cvv = cvv;
    }
}
