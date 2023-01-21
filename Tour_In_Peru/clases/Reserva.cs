
class Reserva
{
    private int idReserva;
    private DateTime fechaReserva;
    private int numeroCuenta;
    private string tipo;
    private string nombreAgencia;
    private string estado;


    public Reserva(int idReserva, DateTime fechaReserva, int numeroCuenta, string tipo, string nombreAgencia, string estado)
    {
        this.idReserva = idReserva;
        this.fechaReserva = fechaReserva;
        this.numeroCuenta = numeroCuenta;
        this.tipo = tipo;
        this.nombreAgencia = nombreAgencia;
        this.estado = estado;
    }

    public int IdReserva { get => idReserva; set => idReserva = value; }
    public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }
    public int NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
    public string Tipo { get => tipo; set => tipo = value; }
    public string NombreAgencia { get => nombreAgencia; set => nombreAgencia = value; }
    public string Estado { get => estado; set => estado = value; }
}