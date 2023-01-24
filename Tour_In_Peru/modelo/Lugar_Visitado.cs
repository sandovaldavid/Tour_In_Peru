class Lugar_Visitado
{
    private int idLugarVisitado;
    private string nombre;

    public Lugar_Visitado()
    {
        this.idLugarVisitado = 0;
        this.nombre = "";
    }

    public Lugar_Visitado(int idLugarVisitado, string nombre)
    {
        this.idLugarVisitado = idLugarVisitado;
        this.nombre = nombre;
    }

    public int GetIdLugarVisitado()
    {
        return this.idLugarVisitado;
    }

    public void SetIdLugarVisitado(int idLugarVisitado)
    {
        this.idLugarVisitado = idLugarVisitado;
    }

    public string GetNombre()
    {
        return this.nombre;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
}
