using System;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Security.Cryptography;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace lasthomework
{
    public class UserControler
    {
        public String Login(string login, string password)
        {
            MySqlConnection connect = DBWorker.getMySqlConnection();
            connect.Open();
            string squery = "SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(squery, connect);
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int loginO = reader.GetOrdinal("login");
                        int passwordO = reader.GetOrdinal("password");
                        string templogin = reader.GetString(loginO);
                        string temppassword = reader.GetString(passwordO);
                        command.Dispose();
                        if (login.Equals(templogin) & ValidateWithHash(password, temppassword)) return "success login";
                    }
                }
                command.Dispose();
                return "fail login";
            }
        }
        public String AddUser(string login, string password, string repassword, string name, string address, string age, string sex)
        {
            if (Validate(login, password, repassword, name, address, age, sex).Equals("ok"))
            { 
                MySqlConnection connect = DBWorker.getMySqlConnection();
                connect.Open();
                String query = "INSERT INTO users (login, password, name, address, age, sex) VALUES (@login, @password, @name," +
                    "@address, @age, @sex)";
                MySqlCommand command = new MySqlCommand(query, connect);
                command.Parameters.Add(new MySqlParameter("@name", name));
                command.Parameters.Add(new MySqlParameter("@login", login));
                command.Parameters.Add(new MySqlParameter("@password", GetHash(password)));
                command.Parameters.Add(new MySqlParameter("@address", address));
                command.Parameters.Add(new MySqlParameter("@age", Int32.Parse(age)));
                command.Parameters.Add(new MySqlParameter("@sex", sex));
                command.ExecuteNonQuery();
                command.Dispose();
                connect.Close();
                return "success registration";
            }
            else return Validate(login, password, repassword, name, address, age, sex);
        }
        public String EditUser(string login, string password, string name, string address, string age) 
        {
            MySqlConnection connect = DBWorker.getMySqlConnection();
            connect.Open();
            string validName = ValidateName(name);
            string validAddress = ValidateAddress(address);
            string validAge = ValidateAge(age);
            string validPass = "password not edit";
            if (!password.Equals(""))
            {
                validPass = "New password edit";
                string query = "UPDATE users SET password = @password WHERE login = @login";
                MySqlCommand command = new MySqlCommand(query, connect);
                command.Parameters.Add(new MySqlParameter("@password", GetHash(password)));
                command.Parameters.Add(new MySqlParameter("@login", login));
                command.ExecuteNonQuery();
                command.Dispose();
            }

            if (validName.StartsWith(" N"))
            {
                string query = "UPDATE users SET name = @name WHERE login = @login";
                MySqlCommand command = new MySqlCommand(query, connect);
                command.Parameters.Add(new MySqlParameter("@name", name));
                command.Parameters.Add(new MySqlParameter("@login", login));
                command.ExecuteNonQuery();
                command.Dispose();
            }
            if (validAddress.StartsWith(" N"))
            {
                string query = "UPDATE users SET address = @address WHERE login = @login";
                MySqlCommand command = new MySqlCommand(query, connect);
                command.Parameters.Add(new MySqlParameter("@address", address));
                command.Parameters.Add(new MySqlParameter("@login", login));
                command.ExecuteNonQuery();
                command.Dispose();
            }
            if (validAge.StartsWith(" N"))
            {
                string query = "UPDATE users SET age = @age WHERE login = @login";
                MySqlCommand command = new MySqlCommand(query, connect);
                command.Parameters.Add(new MySqlParameter("@age", age));
                command.Parameters.Add(new MySqlParameter("@login", login));
                command.ExecuteNonQuery();
                command.Dispose();
            }
            connect.Close();
            return validName + "; " + validPass + "; " + validAddress + "; " + validAge + ".";
        }
        String Validate(string login, string password, string repassword, string name, string address, string age, string sex)
        {
            bool intage = Int32.TryParse(age, out int resultage);
            // login(email) check
            if (!IsValidEmail(login)) return "wrong type of login";
            // pass check
            else if (!password.Equals(repassword)) return "wrong repassword";
            // name check
            else if (!IsValidName(name)) return "wrong type of name";
            // address check
            else if (!IsValidAddress(address)) return "wrong name address";
            // age check
            else if (!intage) return "wrong type of age";
            else if (resultage < 0 || resultage > 130) return "wrong age";
            //sex check
            else if (!IsValidSex(sex)) return "wrong gender";
            return "ok";
        }
        String ValidateName(string name)
        {
            if (!IsValidName(name)) return "name not edit";
            return " New name : " + name;
        }
        String ValidateAddress(string address)
        {
            if (!IsValidAddress(address)) return "address not edit";
            return " New address : " + address;
        }
        String ValidateAge(string age)
        {
            bool intage = Int32.TryParse(age, out int resultage);
            if (!intage) return "age not edit";
            if (resultage < 0 || resultage > 130) return "age not edit";
            return " New age : " + resultage;
        }

        string GetHash(string password)
        {
            var md5 = MD5.Create();
            string salt = "1ol2IK3ik4IK";
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(salt + password));
            return Convert.ToBase64String(hash);
        }
        bool ValidateWithHash(string password, string hash)
        {
            return GetHash(password).Equals(hash);
        }

        bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(250));
                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    var domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;
            if (new Regex(@"\d+").IsMatch(name)) return false;
            return true;
        }
        bool IsValidAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address)) return false;
            if (new Regex(@"\d+").IsMatch(address)) return false;
            return true;
        }
        bool IsValidSex(string sex)
        {
            if (string.IsNullOrWhiteSpace(sex)) return false;
            if (new Regex(@"\d+").IsMatch(sex)) return false;
            if (!sex.Equals("male") && !sex.Equals("female")) return false;
            return true;
        }
    }
}
