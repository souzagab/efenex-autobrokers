using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Efenex.model
{
    // Template
    public class BaseModel : IBaseModel
    {
        public Int64 Id { get; set; }

        protected IDbConnection Connection = DatabaseConnection.Instance;

        public bool Save(object model)
        {
            throw new NotImplementedException();
        }
        public bool Update(int id, object parametros)
        {
            throw new NotImplementedException();
        }

        public Object Find(int id)
        {
            return Connection.QueryFirst($"SELECT * FROM { TableName() } WHERE Id=@Id", new { Id = id });
        }

        public bool Destroy(int id)
        {
            string query = $"DELETE FROM { TableName() } WHERE Id=@Id";
            var con = Connection.Execute(query, new { Id=id});
            return con == 1;
        }
        public object Klass()
        {
            return this.GetType();
        }
        public string TableName()
        {
            
            string TableName;
            var Klass = this.Klass();
            TableName = Klass.ToString();
            var split= TableName.Split(".").Last().ToLower();
            return split.Insert(split.Length, "s");
            
        }
    }
}
