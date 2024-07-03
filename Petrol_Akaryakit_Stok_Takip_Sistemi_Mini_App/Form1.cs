using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Petrol_Akaryakit_Stok_Takip_Sistemi_Mini_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3JI920O\SQLEXPRESS;Initial Catalog=PetrolAkaryakitStokTakip;Integrated Security=True");

        void Listele()
        {
            //Kurşunsuz 95
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLYAKIT where PETROLTUR = 'Kursunsuz95'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblKur95.Text = dr[3].ToString();
                pgbK95.Value = int.Parse(dr[4].ToString());
                lblStokK95.Text = dr[4].ToString();
            }
            conn.Close();

            //Kurşunsuz 97
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM TBLYAKIT where PETROLTUR = 'Kursunsuz97'", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                lblKur97.Text = dr2[3].ToString();
                pgbK97.Value = int.Parse(dr2[4].ToString());
                lblStokK97.Text = dr2[4].ToString();
            }
            conn.Close();

            //Diesel Max
            conn.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT * FROM TBLYAKIT where PETROLTUR = 'DieselMax'", conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                lblDieMax.Text = dr3[3].ToString();
                pgbDieM.Value = int.Parse(dr3[4].ToString());
                lblStokDieM.Text = dr3[4].ToString();
            }
            conn.Close();

            //Diesel Pro
            conn.Open();
            SqlCommand cmd4 = new SqlCommand("SELECT * FROM TBLYAKIT where PETROLTUR = 'DieselPro'", conn);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                lblDiePro.Text = dr4[3].ToString();
                pgbDieP.Value = int.Parse(dr4[4].ToString());
                lblStokDieP.Text = dr4[4].ToString();
            }
            conn.Close();

            //Otogaz
            conn.Open();
            SqlCommand cmd5 = new SqlCommand("SELECT * FROM TBLYAKIT where PETROLTUR = 'Otogaz'", conn);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                lblOtogaz.Text = dr5[3].ToString();
                pgbOtogaz.Value = int.Parse(dr5[4].ToString());
                lblStokOtogaz.Text = dr5[4].ToString();
            }
            conn.Close();

            //Kasa Miktarı Güncelemesi
            conn.Open();
            SqlCommand cmd6 = new SqlCommand("SELECT * FROM TBLKASA", conn);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                lblKasa.Text = dr6[0].ToString();
            }
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void numKur95_ValueChanged(object sender, EventArgs e)
        {
            double kur95, litre, tutar;
            kur95 = Convert.ToDouble(lblKur95.Text);
            litre = Convert.ToDouble(numKur95.Value);
            tutar = kur95 * litre;
            txtTutK95.Text = tutar.ToString();
        }

        private void numKur97_ValueChanged(object sender, EventArgs e)
        {
            double kur97, litre, tutar;
            kur97 = Convert.ToDouble(lblKur97.Text);
            litre = Convert.ToDouble(numKur97.Value);
            tutar = kur97 * litre;
            txtTutK97.Text = tutar.ToString();
        }

        private void numDieM_ValueChanged(object sender, EventArgs e)
        {
            double dieM, litre, tutar;
            dieM = Convert.ToDouble(lblDieMax.Text);
            litre = Convert.ToDouble(numDieM.Value);
            tutar = dieM * litre;
            txtTutDieM.Text = tutar.ToString();
        }

        private void numDieP_ValueChanged(object sender, EventArgs e)
        {
            double dieP, litre, tutar;
            dieP = Convert.ToDouble(lblDiePro.Text);
            litre = Convert.ToDouble(numDieP.Value);
            tutar = dieP * litre;
            txtTutDieP.Text = tutar.ToString();
        }

        private void numOtogaz_ValueChanged(object sender, EventArgs e)
        {
            double otogaz, litre, tutar;
            otogaz = Convert.ToDouble(lblOtogaz.Text);
            litre = Convert.ToDouble(numOtogaz.Value);
            tutar = otogaz * litre;
            txtTutOtogaz.Text = tutar.ToString();
        }

        private void btnDepoDoldur_Click(object sender, EventArgs e)
        {
            if (numKur95.Value != 0)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TBLHAREKET (PLAKA, YAKITTURU, LITRE, TUTAR) values (@p1, @p2, @p3, @p4)", conn);
                cmd.Parameters.AddWithValue("@p1", txtPlaka.Text);
                cmd.Parameters.AddWithValue("@p2", "Kurşunsuz 95");
                cmd.Parameters.AddWithValue("@p3", numKur95.Value);
                cmd.Parameters.AddWithValue("@p4", decimal.Parse(txtTutK95.Text));
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("update TBLKASA set MIKTAR = MIKTAR + @p1", conn);
                cmd2.Parameters.AddWithValue("@p1", decimal.Parse(txtTutK95.Text));
                cmd2.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd3 = new SqlCommand("update TBLYAKIT set STOK = STOK - @p1 where PETROLTUR = 'Kursunsuz95'", conn);
                cmd3.Parameters.AddWithValue("@p1", numKur95.Value);
                cmd3.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Satış Yapıldı");
                Listele();
            }
            if (numKur97.Value != 0)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TBLHAREKET (PLAKA, YAKITTURU, LITRE, TUTAR) values (@p1, @p2, @p3, @p4)", conn);
                cmd.Parameters.AddWithValue("@p1", txtPlaka.Text);
                cmd.Parameters.AddWithValue("@p2", "Kurşunsuz 97");
                cmd.Parameters.AddWithValue("@p3", numKur97.Value);
                cmd.Parameters.AddWithValue("@p4", decimal.Parse(txtTutK97.Text));
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("update TBLKASA set MIKTAR = MIKTAR + @p1", conn);
                cmd2.Parameters.AddWithValue("@p1", decimal.Parse(txtTutK97.Text));
                cmd2.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd3 = new SqlCommand("update TBLYAKIT set STOK = STOK - @p1 where PETROLTUR = 'Kursunsuz97'", conn);
                cmd3.Parameters.AddWithValue("@p1", numKur97.Value);
                cmd3.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Satış Yapıldı");
                Listele();
            }
            if (numDieM.Value != 0)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TBLHAREKET (PLAKA, YAKITTURU, LITRE, TUTAR) values (@p1, @p2, @p3, @p4)", conn);
                cmd.Parameters.AddWithValue("@p1", txtPlaka.Text);
                cmd.Parameters.AddWithValue("@p2", "Diesel Max");
                cmd.Parameters.AddWithValue("@p3", numDieM.Value);
                cmd.Parameters.AddWithValue("@p4", decimal.Parse(txtTutDieM.Text));
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("update TBLKASA set MIKTAR = MIKTAR + @p1", conn);
                cmd2.Parameters.AddWithValue("@p1", decimal.Parse(txtTutDieM.Text));
                cmd2.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd3 = new SqlCommand("update TBLYAKIT set STOK = STOK - @p1 where PETROLTUR = 'DieselMax'", conn);
                cmd3.Parameters.AddWithValue("@p1", numDieM.Value);
                cmd3.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Satış Yapıldı");
                Listele();
            }
            if (numDieP.Value != 0)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TBLHAREKET (PLAKA, YAKITTURU, LITRE, TUTAR) values (@p1, @p2, @p3, @p4)", conn);
                cmd.Parameters.AddWithValue("@p1", txtPlaka.Text);
                cmd.Parameters.AddWithValue("@p2", "Diesel Pro");
                cmd.Parameters.AddWithValue("@p3", numDieP.Value);
                cmd.Parameters.AddWithValue("@p4", decimal.Parse(txtTutDieP.Text));
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("update TBLKASA set MIKTAR = MIKTAR + @p1", conn);
                cmd2.Parameters.AddWithValue("@p1", decimal.Parse(txtTutDieP.Text));
                cmd2.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd3 = new SqlCommand("update TBLYAKIT set STOK = STOK - @p1 where PETROLTUR = 'DieselPro'", conn);
                cmd3.Parameters.AddWithValue("@p1", numDieP.Value);
                cmd3.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Satış Yapıldı");
                Listele();
            }
            if (numOtogaz.Value != 0)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TBLHAREKET (PLAKA, YAKITTURU, LITRE, TUTAR) values (@p1, @p2, @p3, @p4)", conn);
                cmd.Parameters.AddWithValue("@p1", txtPlaka.Text);
                cmd.Parameters.AddWithValue("@p2", "Otogaz");
                cmd.Parameters.AddWithValue("@p3", numOtogaz.Value);
                cmd.Parameters.AddWithValue("@p4", decimal.Parse(txtTutOtogaz.Text));
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("update TBLKASA set MIKTAR = MIKTAR + @p1", conn);
                cmd2.Parameters.AddWithValue("@p1", decimal.Parse(txtTutOtogaz.Text));
                cmd2.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                SqlCommand cmd3 = new SqlCommand("update TBLYAKIT set STOK = STOK - @p1 where PETROLTUR = 'Otogaz'", conn);
                cmd3.Parameters.AddWithValue("@p1", numOtogaz.Value);
                cmd3.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Satış Yapıldı");
                Listele();
            }
        }
    }
}
