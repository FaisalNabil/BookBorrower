using System;
using System.Collections.Generic;
using BookBorrower.entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BookBorrower.data
{
    public class TypesDataAccess
    {
        public int Add(Types types)
        {
            string query = string.Format("INSERT INTO Types(BookType) VALUES('{0}')", types.BookType);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(int typeId)
        {
            string query = string.Format("DELETE FROM Types WHERE TypeId='{0}'", typeId);
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Types types)
        {
            string query = string.Format("UPDATE Types SET BookType='{0}' WHERE TypeId={1}", types.BookType, types.TypeId);
            return DataAccess.ExecuteQuery(query);
        }
        
        public List<Types> GetAll()
        {
            string query = "SELECT TypeId, BookType FROM Types";
            SqlDataReader reader = DataAccess.GetData(query);

            Types types = null;
            List<Types> typesList = new List<Types>();
            while (reader.Read())
            {
                types = new Types();
                types.TypeId = Convert.ToInt32(reader["TypeId"].ToString());
                types.BookType = reader["BookType"].ToString();

                typesList.Add(types);
            }
            return typesList;
        }

        public Types GetById(int typeId)
        {
            string query = string.Format("SELECT TypeId, BookType FROM Types WHERE TypeId={0}", typeId);
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Types types = null;
            if (reader.HasRows)
            {
                types = new Types();
                types.TypeId = Convert.ToInt32(reader["TypeId"].ToString());
                types.BookType = reader["BookType"].ToString();
            }
            return types;
        }

        public Types GetByName(string typesName)
        {
            string query = string.Format("SELECT TypeId, BookType FROM Types WHERE BookType='{0}'", typesName);
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Types types = null;
            if (reader.HasRows)
            {
                types = new Types();
                types.TypeId = Convert.ToInt32(reader["TypeId"].ToString());
                types.BookType = reader["BookType"].ToString();
            }
            return types;
        }
    }
}
