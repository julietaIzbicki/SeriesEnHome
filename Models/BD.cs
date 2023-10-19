using System.Data.SqlClient;
using Dapper;

public static class BD
{
    public static string _connectionString = @"Server=LOCALHOST;
    Database=BDSeries;Trusted_Connection=True;";

    public static List<Series> ObtenerSeries()
    {
        List<Series> series = new List<Series>();
        string sql = "SELECT * FROM Series";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            series = BD.Query<Series>(sql).ToList();
        }
        return series;
    }

    public static List<Actores> ObtenerActores(int id)
    {
        List<Actores> actores = new List<Actores>();
        string sql = "SELECT * FROM Actores WHERE IdSerie = @id";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            actores = BD.Query<Actores>(sql, new { id }).ToList();
        }
        return actores;
    }

    public static List<Temporadas> ObtenerTemporadas(int id)
    {
        List<Temporadas> temporadas = new List<Temporadas>();
        string sql = "SELECT * FROM Temporadas WHERE IdSerie = @id";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            temporadas = BD.Query<Temporadas>(sql, new { id }).ToList();
        }
        return temporadas;
    }

    public static List<Series> ObtenerSerie(int id)
    {
        List<Series> serie = new List<Series>();
        string sql = "SELECT * FROM Series WHERE IdSerie = @id";
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            serie = BD.Query<Series>(sql, new { id }).ToList();
        }
        return serie;
    }
}