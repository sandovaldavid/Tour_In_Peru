public class Persona
{
    private string nombre1;
    private string nombre2;
    private string apellido1;
    private string apellido2;
    private string dni;
    private int edad;
    private string sexo;

    // Constructor 
    public Persona(string nombre1, string nombre2, string apellido1, string apellido2, string dni, int edad, string sexo)
    {
        this.nombre1 = nombre1;
        this.nombre2 = nombre2;
        this.apellido1 = apellido1;
        this.apellido2 = apellido2;
        this.dni = dni;
        this.edad = edad;
        this.sexo = sexo;
    }

    // Getters y Setters
    public string getNombre1() { return this.nombre1; }
    public void setNombre1(string nombre1) { this.nombre1 = nombre1; }
    public string getNombre2() { return this.nombre2; }
    public void setNombre2(string nombre2) { this.nombre2 = nombre2; }
    public string getApellido1() { return this.apellido1; }
    public void setApellido1(string apellido1) { this.apellido1 = apellido1; }
    public string getApellido2() { return this.apellido2; }
    public void setApellido2(string apellido2) { this.apellido2 = apellido2; }
    public string getDni() { return this.dni; }
    public void setDni(string dni) { this.dni = dni; }
    public int getEdad() { return this.edad; }
    public void setEdad(int edad) { this.edad = edad; }
    public string getSexo() { return this.sexo; }
    public void setSexo(string sexo) { this.sexo = sexo; }    
  

}