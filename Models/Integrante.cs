public class Integrante
{
    public int Id { get; set; }
    public string Email { get; set; } 
    public string Password { get; set; }

    public string NombreCompleto { get; set; }
    public string DNI { get; set; }
    public string Telefono { get; set; }
    public string Carrera { get; set; }
    public string Rol { get; set; }

    public Integrante() { }
}