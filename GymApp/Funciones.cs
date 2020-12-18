using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GymApp
{
    public class Productos
    {
        public static bool newProduct(string name, double price, string desc, int amount, string cat, string img) {
            bool check = false;
            string sql = "INSERT INTO product VALUE(null, '" + name + "', " + price + ", '" + desc + "', " + amount + ", '" + cat + "', '" + img + "')";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static bool deleteProduct(int id) {
            bool check = false;
            string sql = "DELETE FROM product WHERE id_product=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static DataTable getProduct(string name) {
            string query;
            if (name != null)
                query = "SELECT id_product as 'ID', name as 'Nombre',  price as 'Precio', description as 'Descripcion', amount as 'Stock', category as 'Categoria' FROM product WHERE name ='" + name + "'";
            else
                query = "SELECT id_product as 'ID', name as 'Nombre',  price as 'Precio', description as 'Descripcion', amount as 'Stock', category as 'Categoria' FROM product";

            MySqlDataAdapter sentencia = new MySqlDataAdapter(query, Conexion.connector());
            DataTable consulta = new DataTable();
            sentencia.Fill(consulta);
            return consulta;
        }
        public static bool upProduct(int id, string name, double price, string desc, int amount, string cat, string img) {
            bool check = false;
            string sql = "UPDATE product SET name='" + name + "', price=" + price + ", description='" + desc + "', amount=" + amount + ", category='" + cat + "', img='" + img + "' WHERE id_product=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
    }

    public class usuario {
        public static string getUser(string user, string pass)
        {
            string tUser = null;
            MySqlCommand vr = new MySqlCommand("SELECT user, passw, rol FROM users WHERE user = '"+user+"' ", Conexion.connector());
            MySqlDataReader rd = null;

            rd = vr.ExecuteReader();
            while (rd.Read())
            {
                if (rd.GetString(0) == user && seguridad.Desencriptar(rd.GetString(1)) == pass)
                {
                    tUser = rd.GetString(2);
                    break;
                }
            }
            rd.Close();
            return tUser;
        }

        public static bool newUser(string name, string lastname, string user, string pwd, string rol, string img)
        {
            bool check = false;
            string date = System.DateTime.Today.ToString("yyyy-MM-dd");
            string sql = "INSERT INTO users VALUE(null, '" + name + "', '" + lastname + "', '" + user + "', '" + pwd + "', '" + rol + "', '" + img + "', '" + date + "')";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static bool deleteUser(int id)
        {
            bool check = false;
            string sql = "DELETE FROM users WHERE id_user=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static DataTable getUsers(string name)
        {
            string query;
            if (name != null)
                query = "SELECT id_user as 'ID', name as 'Nombre', lastname as 'Apellidos', user as 'Usuario', " +
                    "rol, admission_date as 'Fecha de ingreso' FROM users WHERE name ='" + name + "'";
            else
                query = "SELECT id_user as 'ID', name as 'Nombre', lastname as 'Apellidos', user as 'Usuario', " +
                    "rol, admission_date as 'Fecha de ingreso' FROM users ";
            MySqlDataAdapter sentencia = new MySqlDataAdapter(query, Conexion.connector());
            DataTable consulta = new DataTable();
            sentencia.Fill(consulta);
            return consulta;
        }
        public static bool upUser(int id, string name, string lastname, string user, string pwd, string rol, string img)
        {
            bool check = false;
            string sql = "UPDATE users SET name='" + name + "', lastname=" + lastname + ", user = '" + user + "', passw=" + pwd + ", rol='" + rol + "', img='" + img + "' WHERE id_user=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
    }
    public class cliente {
        public static bool newClient(string name, string lastname, string img)
        {
            bool check = false;
            string date = System.DateTime.Today.ToString("yyyy-MM-dd");
            string sql = "INSERT INTO client VALUE(null, '" + name + "', '" + lastname + "', '" + date + "', '" + img + "')";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static bool deleteClient(int id)
        {
            bool check = false;
            string sql = "DELETE FROM client WHERE id_client=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
        public static DataTable getClient(string name)
        {
            string query;
            if (name != null)
                query = "SELECT id_client as 'ID',name as 'Nombre', admission_date as 'Fecha de ingreso' FROM client WHERE name ='" + name + "'";
            else
                query = "SELECT id_client as 'ID',name as 'Nombre', admission_date as 'Fecha de ingreso' FROM client";

            MySqlDataAdapter sentencia = new MySqlDataAdapter(query, Conexion.connector());
            DataTable consulta = new DataTable();
            sentencia.Fill(consulta);
            return consulta;
        }
        public static bool upClient(int id, string name, string lastname, string img)
        {
            bool check = false;
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            string sql = "UPDATE client SET name='" + name + "', lastname=" + lastname + ", admission_date ='" + date + "', img='" + img + "' WHERE id_client=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
    }
    public class ventas {
        public static bool newSell(int id_product, int id_membership, int amount, double price, string exp, int seller)
        {
            bool check = false;
            string sql = "INSERT INTO users VALUE(null, " + id_product + ", " + id_membership + ",  " + amount + ",  " + price + ",  '" + exp + "', " + seller + ")";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion.connector());
            MySqlDataReader adp = cmd.ExecuteReader();
            if (adp.RecordsAffected > 0)
                check = true;
            else
                check = false;

            return check;
        }
    }
    public class reportes {
        public static DataTable getVArticulos()
        {
            string query;
            query = "SELECT s.id_product as 'ID', s.amount as 'Cantidad vendida', u.name + ' ' + u.lastname as 'Vendedor', FROM sales as s INNER JOIN users as u ON u.id_user = s.seller WHERE id_product != null";


            MySqlDataAdapter sentencia = new MySqlDataAdapter(query, Conexion.connector());
            DataTable consulta = new DataTable();
            sentencia.Fill(consulta);
            return consulta;
        }

        public static DataTable getVMembresias()
        {
            string query;
            query = "SELECT s.id_membership as 'ID', s.expiration as 'Dia de vencimiento', u.name  + ' ' + u.lastname as 'Vendedor', FROM sales as s INNER JOIN users as u ON u.id_user = s.seller WHERE id_membership != null";


            MySqlDataAdapter sentencia = new MySqlDataAdapter(query, Conexion.connector());
            DataTable consulta = new DataTable();
            sentencia.Fill(consulta);
            return consulta;
        }
    }
    public class seguridad {
        public static string Encriptar(string cadena)
        {
            string result;
            byte[] encriptar = Encoding.Unicode.GetBytes(cadena);
            result = Convert.ToBase64String(encriptar);
            return result;
        }
        public static string Desencriptar(string cadena)
        {
            string result;
            byte[] encriptar = Convert.FromBase64String(cadena);
            result = Encoding.Unicode.GetString(encriptar);
            return result;
        }
    }
}
