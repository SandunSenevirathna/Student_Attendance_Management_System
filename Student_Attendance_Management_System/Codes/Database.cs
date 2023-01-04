using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;

namespace Student_Attendance_Management_System.Codes
{
    public class Database
    {
        public static DataTable selectData(string quary)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;database=rusl_sas;Uid=psystem;pwd=psystem123");
                MySqlDataAdapter sda = new MySqlDataAdapter(quary, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error @select data, කලබල වෙන්න එපා. call : 0774941002", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                return null;

            }
        }

        public static void insert(string sqlQuary)
        {
            try
            {
                //MySqlConnection con = new MySqlConnection("server=185.27.134.10;port=3306;database=b9_24859177_sunilpos;Uid=b9_24859177;pwd=#RqgFtd9L@MxL5e;CHARSET=utf8");

                MySqlConnection con = new MySqlConnection("server=localhost;database=rusl_sas;Uid=psystem ;pwd=psystem123");
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = sqlQuary;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Database Error, කලබල වෙන්න එපා. call : 0774941002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


        }
    }
}
