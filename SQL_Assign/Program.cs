using System;
using System.Data;
using System.Data.SqlClient;

namespace SQL_
{
    class Program
    {
       static SqlConnection connection = new SqlConnection();
        
        static void Main(string[] args)
        {

            //ShowPlaylist("sbPlaylistSongs");
            PlayListLength("sbGetTotalLength");
            //AddArtist(7, "Jonh", "NOO");
        }
        public static void ShowPlaylist(string sReader)
        {
           
            try
            {
                connection.ConnectionString = "Data Source = (local)\\sqlexpress; initial Catalog = thembe; integrated security = true;";
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = sReader;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                string s = "";
                while(reader.Read())
                {

                    s += "\t"+reader["SongTitle"]+"\n";
                }
                Console.WriteLine("\tPlayList\n\t==========\n"+s);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            finally
            {
                connection.Close();
                Console.ReadKey();
            }
        }

        public static void PlayListLength(string sStored)
        {
            try
            {
               
                connection.ConnectionString = "Data Source = (local)\\sqlexpress; initial Catalog = thembe; integrated security = true;";
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = sStored;
                cmd.CommandType = CommandType.StoredProcedure;

                float fLength = default;
                TimeSpan timespan = TimeSpan.FromSeconds(fLength);
                sStored = timespan.ToString("hh:mm:ss");

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            finally
            {
                connection.Close();
                Console.ReadKey();
            }
        }
        public static void AddArtist(int iArtistId, string sArtistName, string sArtistSurname)
        {

            try
            {
                connection.ConnectionString = "Data Source = (local)\\sqlexpress; initial Catalog = thembe; integrated security = true;";
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sbAddArtist";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ArtistId", iArtistId);
                cmd.Parameters.AddWithValue("@ArtisName", sArtistName);
                cmd.Parameters.AddWithValue("@ArtistSurname", sArtistSurname);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            finally
            {
                connection.Close();
                Console.ReadKey();
            }
        }
    }

}
