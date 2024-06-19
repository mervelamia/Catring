﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace yemek
{

    


    public class Veritabanı
        {
            private string connectionString;

            public Veritabanı(string connectionString)
            {
                this.connectionString = connectionString;
            }





        public bool LoginKontrol(string username, string password)
        {
            bool loginSuccess = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM login WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    loginSuccess = true;
                    string updateQuery = "UPDATE login SET Songiris = @Songiris WHERE Username = @Username";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@Songiris", DateTime.Now);
                    updateCommand.Parameters.AddWithValue("@Username", username);
                    updateCommand.ExecuteNonQuery();
                }
            }
            return loginSuccess;
        }

        public DateTime? GetSonGirisTarihi(string username)
        {
            DateTime? sonGirisTarihi = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Songiris FROM login WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    sonGirisTarihi = (DateTime?)result;
                }
            }
            return sonGirisTarihi;
        }




        public bool KullanıcıKayıtKontrol(string username)
        {
            // Varsayılan olarak kullanıcı adının mevcut olmadığını işaretleyelim
            bool result = false;

            // Veritabanı bağlantısını oluştur
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL sorgusu
                    string sql = "SELECT COUNT(*) FROM [dbo].[login] WHERE [Username] = @Username";

                    // Komut oluştur
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Parametreleri ekle
                        command.Parameters.AddWithValue("@Username", username);

                        // Sorguyu çalıştır ve sonucu al
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            result = true; // Kullanıcı adı mevcut
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Veritabanı bağlantı hatası: " + ex.Message);
                    // Hata durumunda false döndürelim
                    result = false;
                }
            }

            // Sonucu döndürelim
            return result;
        }


        public bool KullanıcıEkle(string username, string password, string role)
        {
            bool success = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "INSERT INTO login (Username, Password, Role) VALUES (@Username, @Password, @Role)";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Role", role);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                            success = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Kullanıcı eklenirken bir hata oluştu: " + ex.Message);
                }
            }

            return success;
        }
        public bool ŞifreGüncelle(string username, string newPassword)
        {
            bool success = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string sql = "UPDATE [login] SET [Password] = @Password WHERE [Username] = @Username";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", newPassword);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            success = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Veritabanı bağlantı hatası: " + ex.Message);
                }
            }

            return success;
        }
        public bool IsAdminPasswordCorrect(string adminPassword)
        {
            bool isCorrect = false;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM login WHERE Username = 'Admin' AND Password = @Password", con))
                {
                    cmd.Parameters.AddWithValue("@Password", adminPassword);
                    int count = (int)cmd.ExecuteScalar();
                    isCorrect = (count > 0);
                }
            }

            return isCorrect;
        }

        public void DeleteUser(string username)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM login WHERE Username = @Username", con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void TeslimatEkle(string teslimatAdi, string teslimatSorumlusu, string telefonNo, decimal teslimatTutari, DateTime baslangicTarihi, string teslimatGunleri, DateTime bitisTarihi, string teslimatSaati, string sehir, string ilce, string adres)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Teslimatlar (TeslimatAdi, TeslimatSorumlusu, TelefonNo, TeslimatTutari, BaslangicTarihi, TeslimatGunleri, BitisTarihi, TeslimatSaati, Sehir, Ilce, Adres) " +
                               "VALUES (@TeslimatAdi, @TeslimatSorumlusu, @TelefonNo, @TeslimatTutari, @BaslangicTarihi, @TeslimatGunleri, @BitisTarihi, @TeslimatSaati, @Sehir, @Ilce, @Adres)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@TeslimatAdi", teslimatAdi);
                    cmd.Parameters.AddWithValue("@TeslimatSorumlusu", teslimatSorumlusu);
                    cmd.Parameters.AddWithValue("@TelefonNo", telefonNo);
                    cmd.Parameters.AddWithValue("@TeslimatTutari", teslimatTutari);
                    cmd.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                    cmd.Parameters.AddWithValue("@TeslimatGunleri", teslimatGunleri);
                    cmd.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);
                    cmd.Parameters.AddWithValue("@TeslimatSaati", teslimatSaati);
                    cmd.Parameters.AddWithValue("@Sehir", sehir);
                    cmd.Parameters.AddWithValue("@Ilce", ilce);
                    cmd.Parameters.AddWithValue("@Adres", adres);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        
        }
        public DataTable TeslimatlariGetir()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Teslimatlar";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public void TeslimatGuncelle(int teslimatID, string teslimatAdi, string teslimatSorumlusu, string telefonNo, decimal teslimatTutari, DateTime baslangicTarihi, string teslimatGunleri, DateTime bitisTarihi, string teslimatSaati, string sehir, string ilce, string adres)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Teslimatlar SET TeslimatAdi=@TeslimatAdi, TeslimatSorumlusu=@TeslimatSorumlusu, TelefonNo=@TelefonNo, TeslimatTutari=@TeslimatTutari, BaslangicTarihi=@BaslangicTarihi, TeslimatGunleri=@TeslimatGunleri, BitisTarihi=@BitisTarihi, TeslimatSaati=@TeslimatSaati, Sehir=@Sehir, Ilce=@Ilce, Adres=@Adres WHERE TeslimatID=@TeslimatID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeslimatID", teslimatID);
                    command.Parameters.AddWithValue("@TeslimatAdi", teslimatAdi);
                    command.Parameters.AddWithValue("@TeslimatSorumlusu", teslimatSorumlusu);
                    command.Parameters.AddWithValue("@TelefonNo", telefonNo);
                    command.Parameters.AddWithValue("@TeslimatTutari", teslimatTutari);
                    command.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                    command.Parameters.AddWithValue("@TeslimatGunleri", teslimatGunleri);
                    command.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);
                    command.Parameters.AddWithValue("@TeslimatSaati", teslimatSaati);
                    command.Parameters.AddWithValue("@Sehir", sehir);
                    command.Parameters.AddWithValue("@Ilce", ilce);
                    command.Parameters.AddWithValue("@Adres", adres);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void TeslimatSil(int teslimatID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Teslimatlar WHERE TeslimatID = @TeslimatID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TeslimatID", teslimatID);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    
    public DataTable YaklasanTeslimatlariGetir()
        {
            DataTable yaklasanTeslimatlar = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT TeslimatAdi, TelefonNo, BaslangicTarihi, BitisTarihi, TeslimatSaati, Sehir, Ilce, Adres
            FROM Teslimatlar
            WHERE 
                (
                    TRY_CONVERT(DATETIME, CONCAT(CONVERT(date, GETDATE()), ' ', TeslimatSaati), 120)
                    BETWEEN GETDATE() AND DATEADD(hour, 24, GETDATE())
                )";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(yaklasanTeslimatlar);
                    }
                }
            }
            return yaklasanTeslimatlar;
        }
        public DataTable SonBesGelirGiderleriGetir()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT TOP 5  [IslemTipi], [Tarih], [GelirGiderTipi], [Tutar], [Aciklama] FROM [GelirGider] ORDER BY [Tarih] DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
        public DataTable GetAzalanStokMalzemeler()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT [MalzemeAdi], [Adet], [MinimumStok] FROM [Malzemeler] WHERE [Adet] < [MinimumStok]";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        public static DataTable VeritabaniSorgusuCalistir(string query)
        {
            DataTable dataTable = new DataTable();

            string connectionString = "Server=HALIL;Database=Catring;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }


        public static DataTable GetSehirler()
        {
            string query = "SELECT SehirID, SehirAdi FROM Sehirler";
            return VeritabaniSorgusuCalistir(query);
        }

        public static DataTable GetIlcelerBySehir(int sehirID)
        {
            string query = $"SELECT IlceID, IlceAdi FROM Ilceler WHERE SehirID = {sehirID}";
            return VeritabaniSorgusuCalistir(query);
        }






    }


}



