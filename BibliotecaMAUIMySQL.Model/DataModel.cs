using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMAUIMySQL.Model
{
    public class Book
    {
        public int BookId { get; set; }         //primary key, autoincrement,notnull, INT
        public int ISBN { get; set; }           //INT
        public string Author { get; set; }      //VARCHAR(45)
        public int Published_Year { get; set; } //YEAR  Note it is aumtomatically in a format of 4 digits by default("0000"), that goes from 1901 to 2155
        public string Color { get; set; }       //VARCHAR(12)
        public string Category { get; set; }    //VARCHAR(45)
        public string Remarks { get; set; }     //VARCHAR(255)

    }

    public class Category
    {
        public int Category_ID { get; set; }    //primarykey, not null, INT
        public string Description { get; set; } //VARCHAR(45)
    }

    public class Member
    {
        public int Member_ID { get; set; }      //primarykey, not null
        public string First_Name { get; set; }  //VARCHAR(45)
        public string Second_Name { get; set; } //VARCHAR(45)
        public string Carrera { get; set; }     //VARCHAR(45)
        public string Email { get; set; }       //VARCHAR(75)
        Public string Phone_Number { get; set; }//VARCHAR(10)
        public bool Deudor { get; set; }        //PENDING TO CHANGE IN THE DATBASE
        public int Prestamos { get; set; }      //INT
    }

    public class Lending
    {
        public int Lending_ID { get; set; }             //INT, Prymary Key, NON-NULL, Auto-Increment
        public int Book_ID { get; set; }                //INT (PENDING TO RELATE ON DB )
        public int Member_ID { get; set; }              //INT (PENDING TO RELATE ON DB )
        public string Date_Time_Barrowed { get; set; }  //Convert.ToDateTime(txtDate.Text).ToString("yyyy-MM-dd")
        public string Username_Lent { get; set; }       //VARCHAR (PENDING TO RELATE ON DB )
        public string Date_Time_Returned { get; set; }  //Convert.ToDateTime(txtDate.Text).ToString("yyyy-MM-dd")
        public string Username_Returned { get; set; }   //VARCHAR (PENDING TO RELATE ON DB )
        public string Fined_Aumount { get; set; }       //INT
        public string Remarks { get; set; }             //VARCHAR(45)
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
