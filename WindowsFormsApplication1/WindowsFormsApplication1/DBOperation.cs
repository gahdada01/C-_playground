using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class Client
    {
        int id, zipcode;
        string cocno;
        string firstname,middlename,lastname;
        string street,barangay,city;
        string company,position,gender,civilstatus;
        string dateReceived;
        string birthdate;
        string bloodtype, group;
        bool status;
        int phone, mobile, units;
        double amount;

        public Client() // default constructor
        { }

        public Client(int _id, string _cocno, string _firstname, string _middlename, string _lastname, string _dateReceived, string _street, string _barangay, string _city, int _zipcode, string _company, string _position, string _gender, string _civilstatus, string _bloodtype, string _group, double _amount, bool _status, string _birthdate, int _mobile, int _phone, int _units) // constructor overloading
        {
            id = _id;
            dateReceived = _dateReceived;
            cocno = _cocno;
            firstname = _firstname;
            middlename = _middlename;
            lastname = _lastname;
            street = _street;
            barangay = _barangay;
            city = _city;
            company = _company;
            position = _position;
            gender = _gender;
            civilstatus = _civilstatus;
            bloodtype = _bloodtype;
            phone = _phone;
            mobile = _mobile;
            units = _units;
            amount = _amount;
            status = _status;
            group = _group;
            zipcode = _zipcode;
            birthdate = _birthdate;
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

        public string COCNo
        {
            get { return cocno; }
            set { cocno = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string Barangay
        {
            get { return barangay; }
            set { barangay = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public int Zipcode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string DateReceived
        {
            get { return dateReceived; }
            set { dateReceived = value; }
        }

        public string BirthDate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public Boolean Status
        {
            get { return status; }
            set { status = value; }
        }

        public string CivilStatus
        {
            get { return civilstatus; }
            set { civilstatus = value; }
        }
        public string BloodType
        {
            get { return bloodtype; }
            set { bloodtype = value; }
        }
        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public int Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        public int Units
        {
            get { return units; }
            set { units = value; }
        }
        public Double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public String Group
        {
            get { return group; }
            set { group = value; }
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
            String cmdText = "INSERT INTO tblclient VALUES(0,@cocno,STR_TO_DATE(@date_received,'%m/%d/%Y'),@street,@barangay,@city,@zipcode,@firstname,@lastname,@middlename,@company,@position,STR_TO_DATE(@birthdate,'%m/%d/%Y'),@gender,@civilstatus,@bloodtype,@phone,@mobile,@units,@amount,@status,@group)";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            cmd.Prepare();

            //we will bound a value to the placeholder
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

        public void Edit()
        {
            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();

            String cmdText = "UPDATE tblclient SET street=@street, barangay=@barangay,city=@city,zipcode=@zipcode,firstname=@firstname,lastname=@lastname,middlename=@middlename,company=@company,position=@position,birthdate=@birthdate,gender=@gender,civilstatus=@civilstatus, bloodtype=@bloodtype,phone=@phone,mobile=@mobile,units=@units,amount=@amount,status=@status,group=@group";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            cmd.Prepare();

            //we will bound a value to the placeholder
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
        }

        public static Client GetUser(int personId)
        {
            Client p = null;
            string cmdText;
            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();


            cmdText = "SELECT * FROM tblclient ";
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
                    p = new Client(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetInt32(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetDouble(16), reader.GetBoolean(17), reader.GetString(18),reader.GetInt32(19),reader.GetInt32(20),reader.GetInt32(21));

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

        public static List<Client> GetUsers()
        {
            List<Client> users = new List<Client>();
            String cmdText;
            MySqlDataReader reader = null;

            MySqlConnection con = null;

            con = DBConnection.GetDBConnection();

            //get data from db and load...

            //To query data from the database using MySqlDataReader
            cmdText = "SELECT id,cocno,firstname,middlename,lastname,DATE_FORMAT(date_received,'%m-%d-%y'),street,barangay,city,zipcode,company,position,gender,civilstatus,bloodtype,groupp,amount,status,DATE_FORMAT(birthdate,'%m-%d-%y'),mobile,phone,units from tblclient";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                    while (reader.Read())
                    {
                        Client s = new Client(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetInt32(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetDouble(16), reader.GetBoolean(17), reader.GetString(18),reader.GetInt32(19),reader.GetInt32(20),reader.GetInt32(21));
                        //Console.WriteLine(reader.GetString(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2));
                        users.Add(s);

                    }

            }
            reader.Close();
            return users;
        }
    }

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
    }
}
