﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QUANLYSINHVIEN6.DAL
{
    public class KetNoi
    {
        // chuỗi kết nối cơ sở dữ liệu
        private string connectionString = "Data Source=DESKTOP-S4CDCSE\\\\XOAN;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True;Encrypt=False\";


        private static KetNoi instance; // ctr + r + e
        public static KetNoi Instace
        {
            get { if (instance == null) instance = new KetNoi(); return instance; }
            private set => instance = value;
        }
        private KetNoi() { }

        //Lấy Danh Sách
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParams = query.Split(' ');

                    int i = 0;
                    foreach (string item in listParams)
                    {
                        if (item.Contains('@Data Source=DESKTOP-S4CDCSE\\XOAN;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True;Encrypt=False")
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        //Thêm, Sửa, Xóa 
        public bool ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listParams = query.Split(' ');

                    int i = 0;
                    foreach (string item in listParams)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }

                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data > 0;
        }
    }
}