using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using SQLite.Net.Async;
namespace MyBooks.Database
{
    public class Person
    {
    //    [PrimaryKey, AutoIncrement]
    //    public int ID { get; set; }

    //    public string FirstName { get; set; }

    //    public string LastName { get; set; }

    //    public override string ToString()
    //    {
    //        return string.Format("[Person: ID={0}, FirstName={1}, LastName={2}]", ID, FirstName, LastName);
    //    }

    //    private async Task<string> createDatabase(string path)
    //    {
    //        try
    //        {
    //            var connection = new SQLiteAsyncConnection();
    //            {
    //                await connection.CreateTableAsync<Person>();
    //                return "Database created";
    //            }
    //catch (SQLite.Net.SQLiteException ex)
    //        {
    //            return ex.Message;
    //        }
    //    }
    }
}
