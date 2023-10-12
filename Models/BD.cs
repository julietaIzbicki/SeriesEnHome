using System.Data.SqlClient;
using Dapper;

public static class BD
{
    public static string _connectionString = @"Server=LOCALHOST;
    Database=Login;Trusted_Connection=True;";

    public static Series ObtenerSeries()
    {
        Series series = null ;
        string sql = "SELECT * FROM Series";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            series = BD.QueryFirstOrDefault<Series>(sql);
        }
        return series;
    }

    public static Actores ObtenerActores()
    {
        Actores actores = null ;
        string sql = "SELECT * FROM Actores";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            actores = BD.QueryFirstOrDefault<Actores>(sql);
        }
        return actores;
    }

    public static Temporadas ObtenerTemporadas()
    {
        Temporadas temporadas = null ;
        string sql = "SELECT * FROM Temporadas";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            temporadas = BD.QueryFirstOrDefault<Temporadas>(sql);
        }
        return temporadas;
    }

}