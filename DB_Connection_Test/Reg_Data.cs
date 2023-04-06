using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace DB_Connection_Test
{
    public partial class Reg_Data : Form
    {
        public Reg_Data()
        {
            InitializeComponent();
            init_Combobox_instrument();
        }

        private void init_Combobox_instrument()
        {

            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT inst_name ");
            sb.Append(" FROM instrument ");
            var sql_select_expedition = sb.ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {
                    using (var command = new SqlCommand(sql_select_expedition, connection))
                    using (var reader = command.ExecuteReader())
                    {

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {
                            comboBox_Inst.Items.Add(reader.GetString(0)?.Trim());
                        }
                    }
                }
                finally
                {
                    connection.Close();
                }


            }

        }

        private void comboBox_Inst_SelectedIndexChanged(object sender, EventArgs e)
        {
            var inst_name = comboBox_Inst.Text;
            dataGridView_data.Rows.Clear();

            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT method_id, method_name ");
            sb.Append(" FROM method ");
            sb.Append(" WHERE inst_id = ( ");
            sb.Append(string.Format(" SELECT inst_id FROM instrument WHERE inst_name = '{0}' )  ", inst_name));
            var sql_select_method = sb.ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {
                    using (var command = new SqlCommand(sql_select_method, connection))
                    using (var reader = command.ExecuteReader())
                    {

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            string method_id_text = reader[0].ToString();
                            string method_name_text = reader[1].ToString();
                            dataGridView_data.Rows.Add(method_id_text, method_name_text, "");

                        }
                    }
                }
                finally
                {
                    connection.Close();
                }

            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var inst_name = comboBox_Inst.Text;
            var sample_id = textBox_sampleID.Text;

            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT hole.expedition, hole.site, hole.hole, core.core_number, core.core_type, sect.section_id, smpl.sample_depth_top, smpl.sample_depth_bottom ");
            sb.Append(" FROM sample smpl ");
            sb.Append(" JOIN section sect ON smpl.section_id = sect.section_id ");
            sb.Append(" JOIN core core ON sect.core_id = core.core_id ");
            sb.Append(" JOIN hole hole ON core.hole_id = hole.hole_id ");
            sb.Append(string.Format(" WHERE smpl.sample_id = '{0}' ", sample_id));
            var sql_select_sample = sb.ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {
                    using (var command = new SqlCommand(sql_select_sample, connection))
                    using (var reader = command.ExecuteReader())
                    {

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {
                            StringBuilder samplesource = new StringBuilder();
                            for (int i = 0; i < reader.FieldCount - 2; i++)
                            {
                                string reader_value = reader[i].ToString();
                                samplesource.Append(reader_value.Trim());
                                samplesource.Append("-");
                            }

                            string samplesource_text = samplesource.ToString().TrimEnd('-');
                            samplesource_text = samplesource_text + ": " + reader[reader.FieldCount - 2] + "-" + reader[reader.FieldCount - 1] + " cm";
                            label_SampleSource_text.Text = samplesource_text;
                        }
                    }
                }
                finally
                {
                    connection.Close();
                }


            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            int rowcount = dataGridView_data.RowCount;
            string sample_id = textBox_sampleID.Text;
            
            
            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    for (int i = 0; i < rowcount; i++)
                    {
                        string data_value = dataGridView_data[2,i].Value.ToString();
                        string method_id = dataGridView_data[0,i].Value.ToString();

                        StringBuilder sb = new StringBuilder();
                        sb.Append(" INSERT INTO ");
                        sb.Append(" measurement ([sample_id], [timestamp], [data_1], [method_id]) ");
                        sb.Append(" VALUES ");
                        sb.Append(string.Format(" ('{0}', GETDATE(), '{1}', '{2}' ) ", sample_id, data_value, method_id));
                        var sql_insert_data = sb.ToString();
                        
                        using (var command = new SqlCommand(sql_insert_data, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                }
                finally
                {
                    connection.Close();
                }


            }
        }
    }
}
