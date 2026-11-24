using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Misión_2_Nexus_V2._0
{
    public class PartidaGuardada
    {
        public int IdPartida { get; set; }
        public string NombreJugador { get; set; } = string.Empty;
        public int Nivel { get; set; }
        public int Puntuacion { get; set; }
        public string EstadoActual { get; set; } = string.Empty;
        public DateTime FechaGuardado { get; set; }
    }

    public class ConexionBD
    {
        private readonly string _cadenaConexion =
            "Server=DEYMAR\\SQLEXPRESS;Database=NexusDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public int GuardarPartida(string nombreJugador, int nivel, int puntuacion, string estadoActual)
        {
            string jugadorLimpio = string.IsNullOrWhiteSpace(nombreJugador) ? "Explorador" : nombreJugador.Trim();
            string estadoLimpio = string.IsNullOrWhiteSpace(estadoActual) ? "Inicio" : estadoActual.Trim();
            int nivelValidado = nivel < 1 ? 1 : nivel;
            int puntuacionValidada = puntuacion < 0 ? 0 : puntuacion;

            const string query = @"
                INSERT INTO dbo.Partidas (NombreJugador, Nivel, Puntuacion, EstadoActual, FechaGuardado)
                OUTPUT INSERTED.IdPartida
                VALUES (@NombreJugador, @Nivel, @Puntuacion, @EstadoActual, GETDATE());";

            using var conn = new SqlConnection(_cadenaConexion);
            using var cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add("@NombreJugador", SqlDbType.NVarChar, 100).Value = jugadorLimpio;
            cmd.Parameters.Add("@Nivel", SqlDbType.Int).Value = nivelValidado;
            cmd.Parameters.Add("@Puntuacion", SqlDbType.Int).Value = puntuacionValidada;
            cmd.Parameters.Add("@EstadoActual", SqlDbType.NVarChar, 100).Value = estadoLimpio;

            conn.Open();
            object? result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public List<PartidaGuardada> ObtenerPartidas()
        {
            var lista = new List<PartidaGuardada>();
            const string query = @"
                SELECT IdPartida, NombreJugador, Nivel, Puntuacion, EstadoActual, FechaGuardado
                FROM dbo.Partidas
                ORDER BY IdPartida DESC;";

            using var conn = new SqlConnection(_cadenaConexion);
            using var cmd = new SqlCommand(query, conn);

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new PartidaGuardada
                {
                    IdPartida = reader.GetInt32(0),
                    NombreJugador = reader.GetString(1),
                    Nivel = reader.GetInt32(2),
                    Puntuacion = reader.GetInt32(3),
                    EstadoActual = reader.GetString(4),
                    FechaGuardado = reader.GetDateTime(5)
                });
            }

            return lista;
        }
    }
}