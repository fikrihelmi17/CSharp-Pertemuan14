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

namespace prjAkademik
{
    public partial class FRS : Form
    {
        public SqlCommand cmd, cmd2;
        public SqlDataReader reader;

        koneksiDB connDb = new koneksiDB();

        void isiComboNPM()
        {
            connDb.koneksi();

            try
            {
                string sql = "SELECT npm FROM mahasiswa";

               // cmd = new SqlCommand(sql, connDb.conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbNpm.Items.Add(reader[0]);

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

        void isiComboFakultas()
        {
            connDb.koneksi();

            try
            {
                string sql = "SELECT kode_fakultas FROM fakultas";

              //  cmd = new SqlCommand(sql, connDb.conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbFakultas.Items.Add(reader[0]);

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

       void isiComboProdi()
        {
            connDb.koneksi();

            cmbProdi.Items.Clear();

            try
            {
                string sql = "SELECT kode_prodi FROM prodi WHERE kode_fakultas='" + cmbFakultas.Text + "'";

              //  cmd = new SqlCommand(sql, connDb.conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbProdi.Items.Add(reader[0]);

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

        void isidgMatkul()
        {
            connDb.koneksi();

            try
            {
                string sql = "SELECT kode_matkul, nama_matkul, sks FROM matakuliah " +
                             "WHERE semester = '" + cmbSemester.Text + "' AND kode_prodi = '" + cmbProdi.Text + "' " +
                             "AND kode_matkul NOT IN(SELECT m.kode_matkul FROM matakuliah m " +
                             "JOIN detail_frs df ON (m.kode_matkul = df.kode_matkul) " +
                             "JOIN head_frs hf ON(hf.kode_frs = df.kode_frs) " +
                             "WHERE m.semester = '" + cmbSemester.Text + "' AND " +
                             "m.kode_prodi = '" + cmbProdi.Text + "' AND hf.npm = '" + cmbNpm.Text + "')";

               // cmd = new SqlCommand(sql, connDb.conn);

                reader = cmd.ExecuteReader();

                dgMatkul.Rows.Clear();

                while (reader.Read())
                {
                    int rows = dgMatkul.Rows.Add();

                    dgMatkul.Rows[rows].Cells[0].Value = rows + 1;
                    dgMatkul.Rows[rows].Cells[1].Value = reader[0];
                    dgMatkul.Rows[rows].Cells[2].Value = reader[1];
                    dgMatkul.Rows[rows].Cells[3].Value = reader[2];
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

        public FRS()
        {
            InitializeComponent();
            //isiComboNPM();
            //isiComboFakultas();

            connDb.koneksi();
        }

        private void FRS_Load(object sender, EventArgs e)
        {

        }

        private void cmbNpm_SelectedIndexChanged(object sender, EventArgs e)
        {
            connDb.koneksi();

            try
            {
                string sql = "SELECT nama_mahasiswa FROM mahasiswa WHERE npm='" + cmbNpm.Text + "'";

             //   cmd = new SqlCommand(sql, connDb.conn);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                   txtNama.Text = reader[0].ToString();

                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            isidgMatkul();
        }

        private void cmbFakultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            connDb.koneksi();

            try
            {
                string sql = "SELECT nama_fakultas FROM fakultas WHERE kode_fakultas = '" + cmbFakultas.Text + "'";

             //   cmd = new SqlCommand(sql, connDb.conn);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtFakultas.Text =  reader[0].ToString();

                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            isiComboProdi();
        }

        private void cmbProdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            connDb.koneksi();

            try
            {
                string sql = "SELECT nama_prodi FROM prodi WHERE kode_prodi='" + cmbProdi.Text + "'";

             //   cmd = new SqlCommand(sql, connDb.conn);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtProdi.Text = reader[0].ToString();

                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            isidgMatkul();
        }

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            isidgMatkul();
        }

        private void dgMatkul_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            connDb.koneksi();
            string sql = "INSERT INTO head_frs VALUES(" +
                "'" + txtKode.Text + "','" + txtTahun.Text + "'," +
                "'" + cmbSemester.Text + "','" + cmbNpm.Text + "'," +
                "'" + cmbProdi.Text + "')";
            ;

           // cmd = new SqlCommand(sql, connDb.conn);
            try
            {
                cmd.ExecuteNonQuery();

                for (int i = 0; i < dgMatkul.Rows.Count; i++) {
                    if(dgMatkul.Rows[i].Cells[4].Value.ToString() == "1")
                    {
                        string sql2 = "INSERT INTO detail_frs VALUES(" +
                                      "'" + txtKode.Text + "'," +
                                      "'" + dgMatkul.Rows[i].Cells[1].Value + "')";
            //            cmd2 = new SqlCommand(sql2, connDb.conn);

                        cmd2.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Data berhasil tersimpan");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Tidak Berhasil Disimpan" + ex.ToString());
            }
        }
    }
}
