using Microsoft.Data.SqlClient;
using Dapper;

namespace PodsFifAndChef.Models;

public class BD{
    public string email {get; private set;}
    public string password {get; private set;}
    public string nombre {get; private set;}
    public string apellido {get; private set;}
    public string hobby {get; private set;}
    public int edad {get; private set;}
    public string genero {get; private set;}

    public BD (){

    }
}