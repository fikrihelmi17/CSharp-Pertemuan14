using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace prjAkademik
{
    public partial class Form1 : Form
    {

        //public SqlCommand cmd;
        //public SqlDataReader reader;

        public MySqlCommand cmd1;
        public MySqlDataReader reader1;

        string jnsKelamin;

        koneksiDB connDb = new koneksiDB();

        void viewDataMahasiswa()
        {
            connDb.koneksi();

            dgView.Rows.Clear();

            int i = 0;

            try
            {
                string sql = "SELECT * FROM mahasiswa";

                //cmd = new SqlCommand(sql, connDb.conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int rows = dgView.Rows.Add();

                    dgView.Rows[rows].Cells[0].Value = rows + 1;
                    dgView.Rows[rows].Cells[1].Value = reader[0];
                    dgView.Rows[rows].Cells[2].Value = reader[1];
                    dgView.Rows[rows].Cells[3].Value = reader[2];
                    dgView.Rows[rows].Cells[4].Value = reader[3];
                    dgView.Rows[rows].Cells[5].Value = reader[4];
                    dgView.Rows[rows].Cells[6].Value = reader[5];

                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            viewDataMahasiswa();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            viewDataMahasiswa();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            connDb.koneksi();
            string sql = "INSERT INTO mahasiswa VALUES(" +
                "'" + txtNpm.Text + "','" + txtNama.Text + "'," +
                "'" + jnsKelamin + "','" + txtAlamat.Text + "'," +
                "'" + txtTelepon.Text + "','" + txtEmail.Text + "')";
            ;

           // cmd = new SqlCommand(sql, connDb.conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil tersimpan");
                viewDataMahasiswa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Tidak Berhasil Disimpan" + ex.ToString());
            }
        }

        private void rbLaki_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLaki.Checked == true)
            {
                jnsKelamin = rbLaki.Text;
            }
            else
            {
                jnsKelamin = "";
            }
        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPerempuan.Checked == true)
            {
                jnsKelamin = rbPerempuan.Text;
            }
            else
            {
                jnsKelamin = "";
            }
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgView.CurrentCell.RowIndex;

            txtNpm.Text = dgView.Rows[row].Cells[1].Value.ToString();
            txtNama.Text = dgView.Rows[row].Cells[2].Value.ToString();

            if (dgView.Rows[row].Cells[3].Value.ToString() == "Laki-laki")
            {
                rbLaki.Checked = true;
            }
            else if (dgView.Rows[row].Cells[3].Value.ToString() == "Perempuan")
            {
                rbPerempuan.Checked = true;
            }

            txtAlamat.Text = dgView.Rows[row].Cells[4].Value.ToString();
            txtTelepon.Text = dgView.Rows[row].Cells[5].Value.ToString();
            txtEmail.Text = dgView.Rows[row].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connDb.koneksi();
            string sql = "UPDATE mahasiswa SET " +
                "nama_mahasiswa='" + txtNama.Text + "'," +
                "jenis_kelamin='" + jnsKelamin + "', alamat = '" + txtAlamat.Text + "'," +
                "telepon = '" + txtTelepon.Text + "', email = '" + txtEmail.Text + "' " +
                "WHERE npm = '" + txtNpm.Text + "'";
            ;

           // cmd = new SqlCommand(sql, connDb.conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diperbaharui");
                viewDataMahasiswa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Tidak Berhasil diperbaharui" + ex.ToString());
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            connDb.koneksi();
            string sql = "DELETE FROM mahasiswa " +
                "WHERE npm = '" + txtNpm.Text + "'";
            ;

          //  cmd = new SqlCommand(sql, connDb.conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
                viewDataMahasiswa();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Tidak Berhasil dihapus" + ex.ToString());
            }
        }
    }
}
