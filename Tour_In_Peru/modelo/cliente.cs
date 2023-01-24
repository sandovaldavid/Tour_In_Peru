public class Cliente : Persona
{
    private string pasaporte;
    private string numCelular;
    private string correo;
    private string direccion;
    private string contraseña;
    private string nacionalidad;
    private string estado;

    // Constructor 
    public Cliente(string nombre1, string nombre2, string apellido1, string apellido2, string dni, int edad, string sexo, string pasaporte, string numCelular, string correo, string direccion, string contraseña, string nacionalidad, string estado) : base(nombre1, nombre2, apellido1, apellido2, dni, edad, sexo)
    {
        this.pasaporte = pasaporte;
        this.numCelular = numCelular;
        this.correo = correo;
        this.direccion = direccion;
        this.contraseña = contraseña;
        this.nacionalidad = nacionalidad;
        this.estado = estado;
    }

    // Getters y Setters
    public string getPasaporte() { return this.pasaporte; }
    public void setPasaporte(string pasaporte) { this.pasaporte = pasaporte; }
    public string getNumCelular() { return this.numCelular; }
    public void setNumCelula(string numCelular) { this.numCelular = numCelular; }
    public string getCorreo() { return this.correo; }
    public void setCorreo(string correo) { this.correo = correo; }
    public string getDireccion() { return this.direccion; }
    public void setDireccion(string direccion) { this.direccion = direccion; }
    public string getContraseña() { return this.contraseña; }
    public void setContraseña(string contraseña) { this.contraseña = contraseña; }
    public string getNacionalidad() { return this.nacionalidad; }
    public void setNacionalidad(string nacionalidad) { this.nacionalidad = nacionalidad; }
    public string GetEstado() { return this.estado; }
    public void SetEstado(string estado) { this.estado = estado; }

}