using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class Beneficiaries
    {
        int id;
        string cid,phone, mobile,firstname, middlename, lastname,gender,birthdate,relationship,address;

        public Beneficiaries() // default constructor
        { }

        public Beneficiaries(int _id, string _firstname, string _lastname, string _middlename, string _relationship, string _address, string _birthdate, string _gender, string _phone, string _mobile, string _cid) // constructor overloading
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

        public void AddNew()
        {
            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();

            //DateTime dr = Convert.ToDateTime(dateReceived);
            //DateTime bd = Convert.ToDateTime(birthdate);

            //This is the mysql command that we will query into the db.
            //It uses Prepared statements and the Placeholder is @name.
            //Using prepared statements is faster and secure.
            //TO INSERT values into the database using prepares statements
            String cmdText = "INSERT INTO tblbeneficiaries VALUES(0,@cid,@firstname,@middlename,@lastname,@relationship,@address,STR_TO_DATE(@birthdate,'%m-%d-%Y'),@gender,@phone,@mobile)";
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
        /*
        public void Edit()
        {
            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();

            String cmdText = "UPDATE tblclient SET cocno=@cocno,date_received=STR_TO_DATE(@date_received,'%m/%d/%Y'),street=@street,barangay=@barangay,city=@city,zipcode=@zipcode,firstname=@firstname,lastname=@lastname,middlename=@middlename,company=@company,position=@position,birthdate=STR_TO_DATE(@birthdate,'%m/%d/%Y'),gender=@gender,civilstatus=@civilstatus,bloodtype=@bloodtype,phone=@phone,mobile=@mobile,units=@units,amount=@amount,status=@status,groupp=@group WHERE id =@id";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            cmd.Prepare();

            //we will bound a value to the placeholder
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@cocno", cocno);
            cmd.Parameters.AddWithValue("@date_received", dateReceived);
            cmd.Parameters.AddWithValue("@street", street);
            cmd.Parameters.AddWithValue("@barangay", barangay);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@zipcode", zipcode);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@middlename", middlename);
            cmd.Parameters.AddWithValue("@company", company);
            cmd.Parameters.AddWithValue("@position", position);
            cmd.Parameters.AddWithValue("@birthdate", birthdate);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@civilstatus", civilstatus);
            cmd.Parameters.AddWithValue("@bloodtype", bloodtype);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@mobile", mobile);
            cmd.Parameters.AddWithValue("@units", units);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@group", group);
            cmd.ExecuteNonQuery(); //execute the mysql command

            con.Close();
        }

        public void Delete()
        {
            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();

            try
            {
                string cmdText = "DELETE FROM tblclient WHERE id = @id";
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
        }*/

        public static Beneficiaries GetUser(int personId)
        {
            Beneficiaries p = null;
            string cmdText;
            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();


            cmdText = "SELECT * FROM tblbeneficiaries";
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
                    p = new Beneficiaries(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));

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

        public static List<Beneficiaries> GetUsers()
        {
            List<Beneficiaries> users = new List<Beneficiaries>();
            String cmdText;
            MySqlDataReader reader = null;

            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();

            //get data from db and load...

            //To query data from the database using MySqlDataReader
            cmdText = "SELECT * from tblbeneficiaries";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Beneficiaries s = new Beneficiaries(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10));
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
