using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DB_Connection_Test
{
    public partial class Reg_Core : Form
    {
        public Reg_Core()
        {
            InitializeComponent();
            init_Combobox_expedition();
        }


        private void init_Combobox_expedition()
        {

            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT expedition ");
            sb.Append(" FROM expedition ");
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
                            comboBox_Exp.Items.Add(reader.GetString(0)?.Trim());
                        }
                    }
                }
                finally
                {
                    connection.Close();
                }


            }

        }




        private void button_Reg_Hole_Click(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            string exp_name = comboBox_ExpName.Text;
            string site = comboBox_Site.Text;
            string hole = comboBox_Hole.Text;
            string core = comboBox_Core.Text;
            string core_type = comboBox_CoreType.Text;
            string section = comboBox_Section.Text;
            int hole_count;

            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT count(*) ");
            sb.Append(" FROM hole ");
            sb.Append(string.Format("WHERE expedition = '{0}' ", exp));
            sb.Append(string.Format(" AND site = '{0}' ", site));
            sb.Append(string.Format(" AND hole = '{0}'", hole));
            var sql_count_hole = sb.ToString();

            sb.Clear();
            sb.Append(" SELECT count(*) ");
            sb.Append(" FROM section ");
            sb.Append(string.Format(" WHERE section_number={0} ", section));
            sb.Append("AND core_id= (");
            sb.Append(string.Format("SELECT core_id FROM core WHERE core_id ={0} ", core));
            sb.Append("AND hole_id = (");
            sb.Append(string.Format("SELECT hole_id FROM hole WHERE expedition='{0}' ", exp));
            sb.Append(string.Format("AND site='{0}' ", site));
            sb.Append(string.Format("AND hole='{0}')) ", hole));
            var sql_count_section = sb.ToString();

            //var sql_count_hole = string.Format("SELECT count(*) from hole where expedition = '{0}' and site = '{1}' and hole = '{2}'", exp, site, hole);
            //var sql_count_section = string.Format("SELECT count(*) from section where expedition = '{0}' and site = '{1}' and hole = '{2}' and core = '{3}' and section= '{4}'", exp, site, hole, core, section);


            sb.Clear();
            sb.Append("INSERT INTO ");
            sb.Append("expedition([expedition], [exp_name]) ");
            sb.Append(string.Format("SELECT '{0}', '{1}' ", exp, exp_name));
            sb.Append(string.Format(" WHERE NOT EXISTS (SELECT expedition FROM expedition WHERE expedition={0})", exp));
            var sql_insert_exp = sb.ToString();

            //var sql_insert_exp = string.Format("INSERT INTO expedition([expedition], [exp_name]) SELECT '{0}', '{1}' WHERE NOT EXISTS (SELECT expedition FROM expedition WHERE expedition={0})", exp, exp_name);

            //INSERT INTO expedition([expedition], [exp_name]) 
            //SELECT '333', 'test333' WHERE NOT EXISTS(SELECT expedition FROM expedition WHERE expedition = '333')

            sb.Clear();
            sb.Append("INSERT INTO ");
            sb.Append("site([site]) ");
            sb.Append(string.Format("SELECT '{0}' ", site));
            sb.Append(string.Format(" WHERE NOT EXISTS (SELECT site FROM site WHERE site='{0}')", site));
            var sql_insert_site = sb.ToString();

            sb.Clear();
            sb.Append("INSERT INTO ");
            sb.Append("hole([expedition], [site], [hole]) ");
            sb.Append(string.Format("VALUES('{0}', '{1}', '{2}')", exp, site, hole));
            var sql_insert_hole = sb.ToString();






            //var sql_count_core　も用意する？



            //var sql_insert_site = string.Format("INSERT INTO site([site]) SELECT '{0}' WHERE NOT EXISTS (SELECT site FROM site WHERE site='{0}')", site);
            //var sql_insert_hole = string.Format("INSERT INTO hole([expedition], [site], [hole]) VALUES ('{0}', '{1}', '{2}')", exp, site, hole);

            //var sql_insert_core = string.Format("insert into core([core]) select ('{0}') where not exists (select core from core where core='{0}'", core);
            //var sql_insert_section = string.Format("insert into section([section]) select ('{0}') where not exists (select section from section where section='{0}'", section);


            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    using (var command = new SqlCommand(sql_count_hole, connection))
                    {
                        hole_count = (int)command.ExecuteScalar();
                        textBox_Status.AppendText(string.Format("hole_count: {0}\r\n", hole_count));
                    }

                    if (hole_count == 0)
                    {
                        using (var command = new SqlCommand(sql_insert_exp, connection))
                        {
                            command.ExecuteNonQuery();
                            textBox_Status.AppendText(" Registered: new expedition. \r\n");
                        }

                        using (var command = new SqlCommand(sql_insert_site, connection))
                        {
                            command.ExecuteNonQuery();
                            textBox_Status.AppendText(" Registered: new site. \r\n");
                        }

                        using (var command = new SqlCommand(sql_insert_hole, connection))
                        {
                            command.ExecuteNonQuery();
                            textBox_Status.AppendText(" Registered: new hole. \r\n");
                        }
                    }

                    //using (var command = new SqlCommand(sql_count_section, connection))
                    //{
                    //    section_count = (int)command.ExecuteScalar();
                    //    textBox_Status.AppendText("section_count: " + hole_count);
                    //}

                    //if (section_count == 0)
                    //{
                    //    using (var command = new SqlCommand(sql_insert_core, connection))
                    //    {
                    //        command.ExecuteNonQuery();
                    //        textBox_Status.AppendText(" Registered: new core");
                    //    }

                    //    using (var command = new SqlCommand(sql_insert_section, connection))
                    //    {
                    //        command.ExecuteNonQuery();
                    //        textBox_Status.AppendText(" Registered: new section");
                    //    }

                    //}

                }
                finally
                {
                    connection.Close();
                }


            }


        }






        private void button_Reg_Core_Click(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            string exp_name = comboBox_ExpName.Text;
            string site = comboBox_Site.Text;
            string hole = comboBox_Hole.Text;
            string core = comboBox_Core.Text;
            string core_type = comboBox_CoreType.Text;
            string section = comboBox_Section.Text;
            int hole_count;
            int core_count;

            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT count(*) ");
            sb.Append(" FROM hole ");
            sb.Append(string.Format("WHERE expedition = '{0}' ", exp));
            sb.Append(string.Format(" AND site = '{0}' ", site));
            sb.Append(string.Format(" AND hole = '{0}'", hole));
            var sql_count_hole = sb.ToString();


            sb.Clear();
            sb.Append(" SELECT count(*) ");
            sb.Append(" FROM core ");
            sb.Append(string.Format("WHERE core_number = '{0}' ", core));
            sb.Append(string.Format(" AND hole_id = (SELECT hole_id FROM hole WHERE expedition = '{0}' AND site = '{1}' AND hole = '{2}') ", exp, site, hole));
            var sql_count_core = sb.ToString();


            sb.Clear();
            sb.Append("INSERT INTO ");
            sb.Append("core ([core_number], [core_type], [hole_id]) ");
            sb.Append(string.Format("SELECT '{0}', '{1}' , hole_id ", core, core_type));
            sb.Append(" FROM hole ");
            sb.Append(string.Format(" WHERE expedition='{0}' AND site='{1}' AND hole='{2}' ", exp, site, hole));
            var sql_insert_core = sb.ToString();




            //var sql_count_core　も用意する？



            //var sql_insert_site = string.Format("INSERT INTO site([site]) SELECT '{0}' WHERE NOT EXISTS (SELECT site FROM site WHERE site='{0}')", site);
            //var sql_insert_hole = string.Format("INSERT INTO hole([expedition], [site], [hole]) VALUES ('{0}', '{1}', '{2}')", exp, site, hole);

            //var sql_insert_core = string.Format("insert into core([core]) select ('{0}') where not exists (select core from core where core='{0}'", core);
            //var sql_insert_section = string.Format("insert into section([section]) select ('{0}') where not exists (select section from section where section='{0}'", section);


            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    using (var command = new SqlCommand(sql_count_hole, connection))
                    {
                        hole_count = (int)command.ExecuteScalar();
                        textBox_Status.AppendText(string.Format("hole_count: {0}\r\n", hole_count));
                    }

                    if (hole_count == 0)
                    {
                        textBox_Status.AppendText("hole_count: " + hole_count);
                        textBox_Status.AppendText("The hole does not exist. Please regisiter hole first.\r\n");
                    }
                    else
                    {


                        using (var command = new SqlCommand(sql_count_core, connection))
                        {
                            core_count = (int)command.ExecuteScalar();
                            textBox_Status.AppendText(string.Format("core_count: {0}\r\n", core_count));
                        }

                        if (core_count == 0)
                        {
                            using (var command = new SqlCommand(sql_insert_core, connection))
                            {
                                command.ExecuteNonQuery();
                                textBox_Status.AppendText(" Registered: new core. \r\n");
                            }


                        }
                    }
                    //using (var command = new SqlCommand(sql_count_section, connection))
                    //{
                    //    section_count = (int)command.ExecuteScalar();
                    //    textBox_Status.AppendText("section_count: " + hole_count);
                    //}

                    //if (section_count == 0)
                    //{
                    //    using (var command = new SqlCommand(sql_insert_core, connection))
                    //    {
                    //        command.ExecuteNonQuery();
                    //        textBox_Status.AppendText(" Registered: new core");
                    //    }

                    //    using (var command = new SqlCommand(sql_insert_section, connection))
                    //    {
                    //        command.ExecuteNonQuery();
                    //        textBox_Status.AppendText(" Registered: new section");
                    //    }

                    //}

                }
                finally
                {
                    connection.Close();
                }


            }

        }

        private void button_Reg_Section_Click(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            string exp_name = comboBox_ExpName.Text;
            string site = comboBox_Site.Text;
            string hole = comboBox_Hole.Text;
            string core = comboBox_Core.Text;
            string core_type = comboBox_CoreType.Text;
            string section = comboBox_Section.Text;
            string curated_length = comboBox_CuratedLength.Text;
            int hole_count;
            int core_count;
            int section_count;

            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT count(*) ");
            sb.Append(" FROM hole ");
            sb.Append(string.Format("WHERE expedition = '{0}' ", exp));
            sb.Append(string.Format(" AND site = '{0}' ", site));
            sb.Append(string.Format(" AND hole = '{0}'", hole));
            var sql_count_hole = sb.ToString();


            sb.Clear();
            sb.Append(" SELECT count(*) ");
            sb.Append(" FROM core ");
            sb.Append(string.Format("WHERE core_number = '{0}' ", core));
            sb.Append(string.Format(" AND hole_id = (SELECT hole_id FROM hole WHERE expedition = '{0}' AND site = '{1}' AND hole = '{2}') ", exp, site, hole));
            var sql_count_core = sb.ToString();

            sb.Clear();
            sb.Append(" SELECT count(*) ");
            sb.Append(" FROM section ");
            sb.Append(string.Format("WHERE section_number = '{0}' ", section));
            sb.Append(string.Format(" AND core_id = (SELECT core_id FROM core WHERE core_number={0} ", core));
            sb.Append(string.Format(" AND hole_id = (SELECT hole_id FROM hole WHERE expedition = '{0}' AND site = '{1}' AND hole = '{2}')) ", exp, site, hole));
            var sql_count_section = sb.ToString();

            sb.Clear();
            sb.Append("INSERT INTO ");
            sb.Append("section ([section_number], [curated_length], [core_id]) ");
            sb.Append(string.Format("SELECT '{0}', '{1}' , core_id ", section, curated_length));
            sb.Append(" FROM core ");
            sb.Append(string.Format(" WHERE core_number= {0} ", core));
            sb.Append(string.Format(" AND hole_id = (SELECT hole_id FROM hole WHERE expedition='{0}' AND site='{1}' AND hole='{2}') ", exp, site, hole));
            var sql_insert_section = sb.ToString();



            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    using (var command = new SqlCommand(sql_count_hole, connection))
                    {
                        hole_count = (int)command.ExecuteScalar();
                        textBox_Status.AppendText(string.Format("hole_count: {0}\r\n", hole_count));
                    }

                    using (var command = new SqlCommand(sql_count_core, connection))
                    {
                        core_count = (int)command.ExecuteScalar();
                        textBox_Status.AppendText(string.Format("core_count: {0}\r\n", core_count));
                    }

                    using (var command = new SqlCommand(sql_count_section, connection))
                    {
                        section_count = (int)command.ExecuteScalar();
                        textBox_Status.AppendText(string.Format("section_count: {0}\r\n", section_count));
                    }


                    if (hole_count == 0 || core_count == 0)
                    {
                        textBox_Status.AppendText("hole_count: " + hole_count);
                        textBox_Status.AppendText("The hole/core does not exist. Please regisiter hole/core first.\r\n");
                    }
                    else
                    {
                        if (section_count == 0)
                        {
                            using (var command = new SqlCommand(sql_insert_section, connection))
                            {
                                command.ExecuteNonQuery();
                                textBox_Status.AppendText(" Registered: new section. \r\n");
                            }


                        }
                    }


                }
                finally
                {
                    connection.Close();
                }


            }

        }

        private void comboBox_Exp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            string exp_name = comboBox_ExpName.Text;


            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT exp_name ");
            sb.Append(" FROM expedition ");
            sb.Append(string.Format("WHERE expedition = '{0}' ", exp));
            var sql_select_exp_name = sb.ToString();


            sb.Clear();
            sb.Append(" SELECT DISTINCT site ");
            sb.Append(" FROM hole ");
            sb.Append(string.Format("WHERE expedition = '{0}' ", exp));
            var sql_select_site = sb.ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {
                    using (var command = new SqlCommand(sql_select_exp_name, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_ExpName.Items.Clear();
                        comboBox_ExpName.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_exp_name = reader[0].ToString();
                            comboBox_ExpName.Items.Add(str_exp_name?.Trim());

                        }

                        comboBox_ExpName.SelectedIndex = 0;
                    }


                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql_select_site, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_Site.Items.Clear();
                        comboBox_Site.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_site = reader[0].ToString();
                            comboBox_Site.Items.Add(str_site?.Trim());

                        }

                    }
                }
                finally
                {
                    connection.Close();
                }


            }
        }

        private void comboBox_Site_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            string exp_name = comboBox_ExpName.Text;
            string site = comboBox_Site.Text;


            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT DISTINCT hole ");
            sb.Append(" FROM hole ");
            sb.Append(string.Format("WHERE expedition = '{0}' AND site = '{1}' ", exp, site));
            var sql_select_site = sb.ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql_select_site, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_Hole.Items.Clear();
                        comboBox_Hole.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_hole = reader[0].ToString();
                            comboBox_Hole.Items.Add(str_hole?.Trim());

                        }

                    }
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void comboBox_Hole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            string exp_name = comboBox_ExpName.Text;
            string site = comboBox_Site.Text;
            string hole = comboBox_Hole.Text;


            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT DISTINCT core_number ");
            sb.Append(" FROM core ");
            sb.Append(" WHERE hole_id = ( ");
            sb.Append(string.Format(" SELECT hole_id from hole WHERE expedition = '{0}' AND site = '{1}' AND hole = '{2}') ", exp, site, hole));
            var sql_select_core = sb.ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql_select_core, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_Core.Items.Clear();
                        comboBox_Core.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_core = reader[0].ToString();
                            comboBox_Core.Items.Add(str_core?.Trim());

                        }

                    }
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void comboBox_Core_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            string exp_name = comboBox_ExpName.Text;
            string site = comboBox_Site.Text;
            string hole = comboBox_Hole.Text;
            string core = comboBox_Core.Text;


            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT core_type ");
            sb.Append(" FROM core ");
            sb.Append(string.Format(" WHERE core_number = '{0}' ", core));
            sb.Append(" AND hole_id = ( ");
            sb.Append(string.Format(" SELECT hole_id from hole WHERE expedition = '{0}' AND site = '{1}' AND hole = '{2}') ", exp, site, hole));
            var sql_select_core_type = sb.ToString();


            sb.Clear();
            sb.Append(" SELECT DISTINCT section_number ");
            sb.Append(" FROM section ");
            sb.Append(" WHERE core_id = ( ");
            sb.Append(string.Format(" SELECT core_id from core WHERE core_number = '{0}' ", core));
            sb.Append(" AND hole_id = ( ");
            sb.Append(string.Format(" SELECT hole_id from hole WHERE expedition = '{0}' AND site = '{1}' AND hole = '{2}')) ", exp, site, hole));
            var sql_select_section = sb.ToString();

            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql_select_core_type, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_CoreType.Items.Clear();
                        comboBox_CoreType.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_core_type = reader[0].ToString();
                            comboBox_CoreType.Items.Add(str_core_type?.Trim());


                        }

                        comboBox_CoreType.SelectedIndex = 0;
                    }
                

                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql_select_section, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_Section.Items.Clear();
                        comboBox_Section.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_section = reader[0].ToString();
                            comboBox_Section.Items.Add(str_section?.Trim());

                        }

                    }
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void comboBox_Section_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exp = comboBox_Exp.Text;
            string exp_name = comboBox_ExpName.Text;
            string site = comboBox_Site.Text;
            string hole = comboBox_Hole.Text;
            string core = comboBox_Core.Text;
            string section = comboBox_Section.Text;


            string connectionString = @"Data Source=KURASAW\SQLEXPRESS;Initial Catalog=Copy_test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT curated_length ");
            sb.Append(" FROM section ");
            sb.Append(string.Format(" WHERE section_number = '{0}' ", section));
            sb.Append(" AND core_id = ( ");
            sb.Append(string.Format(" SELECT core_id from core WHERE core_number = '{0}' ", core));
            sb.Append(" AND hole_id = ( ");
            sb.Append(string.Format(" SELECT hole_id from hole WHERE expedition = '{0}' AND site = '{1}' AND hole = '{2}')) ", exp, site, hole));
            var sql_select_curated_length = sb.ToString();


            using (var connection = new SqlConnection(connectionString))
            {
                // 接続開始
                connection.Open();

                try
                {

                    // SqlCommand：DBにSQL文を送信するためのオブジェクトを生成
                    // SqlDataReader：読み取ったデータを格納するためのオブジェクトを生成
                    using (var command = new SqlCommand(sql_select_curated_length, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        comboBox_CuratedLength.Items.Clear();
                        comboBox_CuratedLength.Text = "";

                        // 1行ごとに読み取る。読み取ったらtrue
                        while (reader.Read())
                        {

                            // 列名を指定して、読み取ったデータをコンソール上に表示
                            // textBox_data.AppendText(reader[0].ToString());

                            var str_curated_length = reader[0].ToString();
                            comboBox_CuratedLength.Items.Add(str_curated_length?.Trim());

                        }

                        comboBox_CuratedLength.SelectedIndex= 0;
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
