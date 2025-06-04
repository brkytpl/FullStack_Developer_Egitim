using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddCustomer("Ahmet Yılmaz", "ahmet@example.com", "05551234567");
            Console.WriteLine("Müşteri eklendi");
            ListCustomer();
            Console.WriteLine("Güncelleme öncesi:");
            ListCustomer();

            // Güncelleme
            UpdateCustomer(1, "Ahmet Yıldız", "yildiz@example.com", "05559998877");

            // Güncellemeden sonra liste
            Console.WriteLine("\nGüncelleme sonrası:");
            ListCustomer();

            Console.WriteLine("Silme öncesi:");
            ListCustomer();
           
           
            DeleteCustomer(3); // ID'si 1 olan müşteri silinir

            Console.WriteLine("\nSilme sonrası:");
            ListCustomer();
        }

        static void AddCustomer(string name, string email, string phone)
        {
            using (SqlConnection baglanti = new SqlConnection("Server=BERKAY\\SQLEXPRESS;Database=Customers;Integrated Security=true;"))
            {
                baglanti.Open();
                string query = "INSERT INTO Customers (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";
                using (SqlCommand komut = new SqlCommand(query, baglanti))
                {
                    komut.Parameters.AddWithValue("@Name", name);
                    komut.Parameters.AddWithValue("@Email", email);
                    komut.Parameters.AddWithValue("@Phone", phone);
                    komut.ExecuteNonQuery();
                }
            }
        }
        static void ListCustomer()
        {
            using (SqlConnection baglanti = new SqlConnection("Server=BERKAY\\SQLEXPRESS;Database=Customers;Integrated Security=true;"))
            {
                {
                    baglanti.Open();
                    string query = "SELECT * FROM Customers";
                    using (SqlCommand komut = new SqlCommand(query, baglanti))
                    {
                        using (SqlDataReader okuyucu = komut.ExecuteReader())
                        {
                            while (okuyucu.Read())
                            {
                                Console.WriteLine($"ID: {okuyucu["Id"]} - Ad: {okuyucu["Name"]} - Email: {okuyucu["Email"]} - Telefon: {okuyucu["Phone"]}");
                            }

                        }


                    }
                }
            }


        }
        static void UpdateCustomer(int id, string name, string email, string phone)
        {
            using (SqlConnection baglanti = new SqlConnection("Server=BERKAY\\SQLEXPRESS;Database=Customers;Integrated Security=true;"))
            {
                baglanti.Open();
                string query = "UPDATE Customers SET Name = @Name, Email = @Email, Phone = @Phone WHERE Id = @Id";
                using (SqlCommand komut = new SqlCommand(query, baglanti))
                {
                    komut.Parameters.AddWithValue("@Name", name);
                    komut.Parameters.AddWithValue("@Email", email);
                    komut.Parameters.AddWithValue("@Phone", phone);
                    komut.Parameters.AddWithValue("@Id", id);
                    int affectedRows = komut.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        Console.WriteLine("Müşteri güncellendi.");
                    }
                    else
                    {
                        Console.WriteLine("Belirtilen ID ile müşteri bulunamadı.");
                    }

                }
            }

        }
        static void DeleteCustomer(int id)
        {
            using (SqlConnection baglanti = new SqlConnection("Server=BERKAY\\SQLEXPRESS;Database=Customers;Integrated Security=true;"))
            {
                baglanti.Open();
                string query = "DELETE FROM Customers WHERE Id = @Id";
                using (SqlCommand komut = new SqlCommand(query, baglanti))
                {
                    komut.Parameters.AddWithValue("@Id", id);
                    int affectedRows = komut.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        Console.WriteLine("Müşteri silindi.");
                    }
                    else
                    {
                        Console.WriteLine("Belirtilen ID ile müşteri bulunamadı.");
                    }
                }
            }
        }
    }
}

