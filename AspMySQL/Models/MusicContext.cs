using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace AspMySQL.Models
{
    /**
     * Context class that contains connections and music data entities
     * See: hhttps://www.c-sharpcorner.com/article/how-to-connect-mysql-with-asp-net-core/
     */
    public class MusicContext
    {
        private string _connectionString { get; set; }
        public MusicContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }



        public List<Album> GetAllAlbums()
        {
            List<Album> albums = new List<Album>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string stmt = "SELECT * FROM album";
                MySqlCommand selectAllCmd = new MySqlCommand(stmt, conn);

                using (var reader = selectAllCmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        albums.Add(new Album()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            name = reader["name"].ToString(),
                            artist = reader["artist"].ToString()
                        });
                    }
                }
                return albums;
            }
        }
    }
}
