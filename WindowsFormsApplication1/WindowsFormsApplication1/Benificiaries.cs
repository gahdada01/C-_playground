using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class Benificiaries
    {
        int id;
        string cid,phone, mobile,firstname, middlename, lastname,gender,birthdate,relationship,address;

        public Benificiaries(int _id) // default constructor
        {
            id = _id;
        }

        public Benificiaries(int _id,  string _cid,string _firstname, string _middlename, string _lastname, string _relationship, string _address, string _birthdate, string _gender, string _phone, string _mobile) // constructor overloading
        {
            id = _id;
            firstname = _firstname;
            lastname = _lastname;
            middlename = _middlename;
            relationship = _relationship;
            address = _address;
            birthdate = _birthdate;
            gender = _gender;
            phone = _phone;
            mobile = _mobile;
            cid = _cid;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Firstname
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }

        public string Middlename
        {
            get { return middlename; }
            set { middlename = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string CID
        {
            get { return cid; }
            set { cid = value; }
        }

        public string Relationship
        {
            get { return relationship; }
            set { relationship = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string BirthDate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public void AddNewB()
        {
            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();

            //DateTime dr = Convert.ToDateTime(dateReceived);
            //DateTime bd = Convert.ToDateTime(birthdate);

            //This is the mysql command that we will query into the db.
            //It uses Prepared statements and the Placeholder is @name.
            //Using prepared statements is faster and secure.
            //TO INSERT values into the database using prepares statements
            String cmdText = "INSERT INTO tblbenificiaries VALUES(0,@cid,@firstname,@middlename,@lastname,@relationship,@address,STR_TO_DATE(@birthdate,'%m/%d/%Y'),@gender,@phone,@mobile)";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            cmd.Prepare();

            //we will bound a value to the placeholder
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@middlename", middlename);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@relationship", relationship);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@birthdate", birthdate);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@mobile", mobile);

            cmd.ExecuteNonQuery(); //execute the mysql command

            con.Close();
        }
        
        public void EditB()
        {
            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();

            String cmdText = "UPDATE tblbenificiaries SET cid=@cid,firstname=@firstname,middlename=@middlename,lastname=@lastname,relationship=@relationship,address=@address,birthdate=STR_TO_DATE(@birthdate,'%m/%d/%Y'),gender=@gender,phone=@phone,mobile=@mobile WHERE id =@id";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            cmd.Prepare();

            //we will bound a value to the placeholder
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@middlename", middlename);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@relationship", relationship);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@birthdate", birthdate);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@mobile", mobile);
            cmd.ExecuteNonQuery(); //execute the mysql command

            con.Close();
        }       
        public void DeleteB()
        {
            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();

            try
            {
                string cmdText = "DELETE FROM tblbenificiaries WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
                cmd.Parameters.AddWithValue("@id", Id);

                int result = cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        public static Benificiaries GetUser(int personId)
        {
            Benificiaries p = null;
            string cmdText;
            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();


            cmdText = "SELECT * FROM tblbenificiaries";
            cmdText += "WHERE id=" + personId;

            MySqlCommand cmd = new MySqlCommand(cmdText, con);

            MySqlDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    //call sproc and load from database...
                    p = new Benificiaries(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));

                }

                reader.Close();

            }
            catch (Exception err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }
            finally
            {
                con.Close();
            }

            return p;
        }

        public static List<Benificiaries> GetUsers(string _cocno)
        {
            List<Benificiaries> users = new List<Benificiaries>();
            String cmdText;
            MySqlDataReader reader = null;

            MySqlConnection con = null;
            
            con = DBConnection.GetDBConnection();

            //get data from db and load...

            //To query data from the database using MySqlDataReader
            cmdText = "SELECT id,cid,firstname,middlename,lastname, relationship, address,DATE_FORMAT(birthdate,'%m-%d-%Y'),gender,phone, mobile FROM tblbenificiaries WHERE cid=@cocno";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);

            cmd.Parameters.AddWithValue("@cocno", _cocno);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Benificiaries s = new Benificiaries(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));
                    //Console.WriteLine(reader.GetString(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2));
                    users.Add(s);

                }

            }
            reader.Close();
            return users;
        }
    }
    /*
    class DBConnection
    {
        public static MySqlConnection GetDBConnection()
        {
            String str = @"server=localhost;database=elect2;userid=root;password=;";
            MySqlConnection con = null;

            try
            {
                con = new MySqlConnection(str);
                con.Open(); //open the connection
            }
            catch (MySqlException err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }

            return con;
        }
    }*/
}
