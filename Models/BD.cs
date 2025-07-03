using Microsoft.Data.SqlClient;
using Dapper; 

public static class BD
{
    private static string _connectionString = @"PodsFifAndChef=localhost;DataBase=EquipoLosPibes;Integrated Security=True;TrustServerCertificate=True;";

    public static List<Integrante> Integrantes = new List<Integrante>
    {
        new Integrante
        {
            Id = 1,
            Email = "fidelgoldsman@gmail.com",
            Password = "Fidel",
            NombreCompleto = "Fidel Goldsman",
            DNI = "49002222",
            Telefono = "1159598537",
            Carrera = "Informática",
            Rol = "Estudiante"
        },
        new Integrante
        {
            Id = 2,
            Email = "poda@gmail.com",
            Password = "Poda",
            NombreCompleto = "Poda Pods",
            DNI = "49002221",
            Telefono = "1155552222",
            Carrera = "Informatica",
            Rol = "Estudiante"
        }

        
      
    };

   
    public static Integrante BuscarIntegrante(string email)
    {
        Integrante integrante = null;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Integrantes WHERE Email = @Email";
            integrante = connection.QueryFirstOrDefault<Integrante>(query, new { Email = email });
        }
        return integrante;
    }


    public static Integrante BuscarIntegrantePorId(int id)
    {
        Integrante integrante = null;
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Integrantes WHERE Id = @Id";
            integrante = connection.QueryFirstOrDefault<Integrante>(query, new { Id = id });
        }
        return integrante;
    }
}