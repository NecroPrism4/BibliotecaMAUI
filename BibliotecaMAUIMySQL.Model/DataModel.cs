using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMAUIMySQL.Model
{
    public class Book
    {
        public int BookId { get; set; }//primary key, autoincrement,notnull,
        public int ISBN { get; set; }
        public string Author { get; set; }
        public int Published_Year { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public string Remarks { get; set; }

    }

    public class Category
    {
        public int Category_ID { get; set; }//primarykey, not null
        public string Description { get; set; }
    }

    public class Member
    {
        public int Member_ID { get; set; }//primarykey, not null
        public string First_Name { get; set; }
        public string Second_Name { get; set; }
        public string Carrera { get; set; }
        public string Email { get; set; }
        public bool Deudor { get; set; }//Boolean
        public int Prestamos { get; set; }
    }

    public class Lending
    {
        public int Lending_ID { get; set; }
        public int Book_ID { get; set; }
        public int Member_ID { get; set; }
        public string Date_Time_Barrowed { get; set; }///Convert.ToDateTime(txtDate.Text).ToString("yyyy-MM-dd")
        public string Username_Lent { get; set; }
        public string Date_Time_Returned { get; set; }///Convert.ToDateTime(txtDate.Text).ToString("yyyy-MM-dd"
        public string Username_Returned { get; set; }
        public string Fined_Aumount { get; set; }
        public string Remarks { get; set; }
    }

    public class User {

        public int Username_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string User_Type { get; set; }



    }
}
