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

namespace TugasPertemuan6
{
    public partial class Form1 : Form
    {

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

        Koneksi Konn = new Koneksi();

        void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Tabel_Barang", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Tabel_Barang");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Tabel_Barang";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
