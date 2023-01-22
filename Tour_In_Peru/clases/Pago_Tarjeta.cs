class Pago_Tarjeta
{
    private decimal monto;
    private DateTime fechaPago;
    private string estado;

    public Pago_Tarjeta()
    {
        this.monto = 0;
        this.fechaPago = DateTime.Now;
        this.estado = "";
    }

    public Pago_Tarjeta(decimal monto, DateTime fechaPago, string estado)
    {
        this.monto = monto;
        this.fechaPago = fechaPago;
        this.estado = estado;
    }

    public decimal GetMonto()
    {
        return this.monto;
    }

    public void SetMonto(decimal monto)
    {
        this.monto = monto;
    }

    public DateTime GetFechaPago()
    {
        return this.fechaPago;
    }

    public void SetFechaPago(DateTime fechaPago)
    {
        this.fechaPago = fechaPago;
    }

    public string GetEstado()
    {
        return this.estado;
    }

    public void SetEstado(string estado)
    {
        this.estado = estado;
    }
}