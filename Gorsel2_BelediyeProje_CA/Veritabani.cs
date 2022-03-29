using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace VTI
{
    public class Veritabani
    {
        public Veritabani()
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Gorsel2_Belediye_Proje_CA;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
        SqlDataAdapter adtr = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public DataTable Select(string sorgu)
        {
            dt = new DataTable();
            baglanti.Open();
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            adtr.SelectCommand = komut;
            adtr.Fill(dt);
            baglanti.Close();
            return dt;
        }

        public int UpdateDelete(string sorgu)
        {
            baglanti.Open();
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            int kayitSayisi =komut.ExecuteNonQuery();
            baglanti.Close();
            return kayitSayisi;
        }

        public int Insert(string sorgu)
        {
            baglanti.Open();
            komut.CommandText = sorgu;
            komut.Connection = baglanti;
            int kayitSayisi = komut.ExecuteNonQuery();
            baglanti.Close();
            return kayitSayisi;
        }
        public string MD5Sifrele(string sifrelenecekMetin)
        {

            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }

    }



}

