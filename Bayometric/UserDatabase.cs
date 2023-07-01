using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Collections;
using System.IO;

namespace Bayometric
{
    public class UserRecord
    {
        [XmlAttribute("id")]
        public int _id;
        [XmlAttribute("username")]
        public string _username;
        [XmlAttribute("fullname")]
        public string _fullname;
        [XmlAttribute("regno")]
        public string _reg_no;
        [XmlAttribute("password")]
        public string _password;

        public UserRecord()
        {
            _id = 0;
            _username = string.Empty;
        }

        public UserRecord(int id, string name)
        {
            _id = id;
            _username = name;
        }

        public UserRecord(int id, string username, string fullname, string reg_no, string password) :
            this(id, username)
        {
            _fullname = fullname;
            _reg_no = reg_no;
            _password = password;
        }

        #region Fields for users records
        public int ID
        {
            get
            {
                return _id;
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }
        }
        public string FullName
        {
            get
            {
                return _fullname;
            }
        }
        public string RegNo
        {
            get
            {
                return _reg_no;
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
        }
        #endregion
    }

    [XmlRoot("UserDatabase")]
    public class UserDatabase : List<UserRecord>
    {
        public void WriteToFile(string filename)
        {
            TextWriter w = null;
            try
            {
                XmlSerializer s = new XmlSerializer(typeof(UserDatabase));
                w = new StreamWriter(filename);
                s.Serialize(w, this);
                w.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                w?.Close();
            }
        }

        public readonly string FileName = "";
        public static UserDatabase ReadFromFile(string filename)
        {
            UserDatabase newUserDb = null;
            TextReader r = null;
            try
            {
                XmlSerializer s = new XmlSerializer(typeof(UserDatabase));
                r = new StreamReader(filename);
                newUserDb = (UserDatabase)s.Deserialize(r);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                r.Close();
            }

            return newUserDb;
        }

        public UserRecord Lookup(int id)
        {
            foreach (UserRecord userRec in this)
            {
                if (userRec.ID == id)
                {
                    return userRec;
                }
            }

            return null;
        }
    }
}
