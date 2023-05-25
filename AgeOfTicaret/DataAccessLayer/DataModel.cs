using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConnectionString.ConStr);
            cmd = con.CreateCommand();
        }
        public List<Category> GetCategories()
        {
            List<Category> kategoriler = new List<Category>();
            try
            {
                cmd.CommandText = "select CategoryID,CategoryName,Description from Categories";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Category c = new Category();
                    c.CategoryID = reader.GetInt32(0);
                    c.CategoryName = reader.GetString(1);
                    c.description = reader.GetString(2);
                    kategoriler.Add(c);
                }
                return kategoriler;
            }
            catch
            {
                return null;

            }
            finally
            {
                con.Close();
            }
        }
        public Category AddCategory(Category model)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Categories(CategoryName,Description) values (@categoryname,@desc) select @@IDENTITY";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@categoryname", model.CategoryName);
                cmd.Parameters.AddWithValue("@desc", model.description);
                con.Open();
                model.CategoryID = Convert.ToInt32(cmd.ExecuteScalar());
                return model;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public Category GetCategory(int id)
        {

            try
            {
                cmd.CommandText = "select CategoryID,CategoryName,Description from Categories where CategoryID=@id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Category c = new Category();
                while (reader.Read())
                {

                    c.CategoryID = reader.GetInt32(0);
                    c.CategoryName = reader.GetString(1);
                    c.description = reader.GetString(2);

                }
                return c;

            }
            catch
            {
                return null;

            }
            finally
            {
                con.Close();
            }
        }
        public bool UptadeCategory(Category model)
        {
            try
            {
                cmd.CommandText = "update categories set CategoryName = @CategoryName,Description = @description where CategoryId=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", model.CategoryID);
                cmd.Parameters.AddWithValue("@CategoryName", model.CategoryName);
                cmd.Parameters.AddWithValue("@description", model.description);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }



        }
        public void removercategory(int id)
        {

        }

        #region Employee functions
        public Employee GetEmployee(int id)
        {
            try
            {
                Employee model = new Employee();
                cmd.CommandText = "SELECT EmployeeID, UserName, Password, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo, PhotoPath, TitleOfCourtesy + ' ' + FirstName + ' ' + LastName AS FullName FROM Employees WHERE EmployeeID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    model.EmployeeID = reader.GetInt32(0);
                    model.UserName = reader.GetString(1);
                    model.Password = reader.GetString(2);
                    model.LastName = reader.GetString(3);
                    model.FirstName = reader.GetString(4);
                    model.Title = reader.GetString(5);
                    model.TitleOfCourtesy = reader.GetString(6);
                    model.BirthDate = reader.GetDateTime(7);
                    model.HireDate = reader.GetDateTime(8);
                    model.Address = reader.GetString(9);
                    model.City = reader.GetString(10);
                    model.Region = reader.IsDBNull(11) ? reader.GetString(11) : "";
                    model.PostalCode = reader.GetString(12);
                    model.Country = reader.GetString(13);
                    model.HomePhone = reader.GetString(14);
                    model.Extension = reader.GetString(15);
                    model.Notes = reader.GetString(16);
                    model.ReportsTo = !reader.IsDBNull(17) ? reader.GetInt32(17) : 0;
                    model.PhotoPath = reader.GetString(18);
                    model.FullName = reader.GetString(19);
                }
                return model;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public Employee emoployeelogin(string usurname,string password)
        {
            try
            {
                Employee model = new Employee();
                cmd.CommandText = "Select EmployeeID from Employees where UserName = @usurname and Password = @password";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@usurname", usurname);
                cmd.Parameters.AddWithValue("@Password", password);
                con.Open();
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                if (id > 0)
                {
                    model = GetEmployee(id);

                }
                return model;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
           
        }
        #endregion
    }

}
