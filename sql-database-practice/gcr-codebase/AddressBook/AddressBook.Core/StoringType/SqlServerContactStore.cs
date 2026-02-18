using BridgelabzTraining.senario_based.AddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BridgeLabzTraining.Core.senario_based.AddressBook.StoringType
{
    public sealed class SqlServerContactStore:IContactStore
    {
        private readonly string _connectionString;

        public SqlServerContactStore(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string cannot be empty.");

            _connectionString = connectionString;
        }

        public void Save(string ownerName, List<UserContact> contacts)
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            using var tx = conn.BeginTransaction();

            // replace strategy: delete owner rows then insert
            using (var del = new SqlCommand( "DELETE FROM AddressBookContacts WHERE OwnerName = @OwnerName", conn, tx))
            {
                del.Parameters.AddWithValue("@OwnerName", ownerName);
                del.ExecuteNonQuery();
            }

            foreach (var c in contacts)
            {
                using var ins = new SqlCommand(@" INSERT INTO AddressBookContacts (OwnerName, FirstName, LastName, Address, City, State, Zip, Phone, Email) VALUES (@OwnerName, @FirstName, @LastName, @Address, @City, @State, @Zip, @Phone, @Email);", conn, tx);

                ins.Parameters.AddWithValue("@OwnerName", ownerName);
                ins.Parameters.AddWithValue("@FirstName", c.FirstName());
                ins.Parameters.AddWithValue("@LastName", c.LastName());
                ins.Parameters.AddWithValue("@Address", (object?)c.Address() ?? DBNull.Value);
                ins.Parameters.AddWithValue("@City", (object?)c.City() ?? DBNull.Value);
                ins.Parameters.AddWithValue("@State", (object?)c.State() ?? DBNull.Value);
                ins.Parameters.AddWithValue("@Zip", (object?)c.Zip() ?? DBNull.Value);
                ins.Parameters.AddWithValue("@Phone", (object?)c.PhoneNumber() ?? DBNull.Value);
                ins.Parameters.AddWithValue("@Email", (object?)c.Email() ?? DBNull.Value);

                ins.ExecuteNonQuery();
            }

            tx.Commit();
        }

        public List<UserContact> Load(string ownerName)
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            using var cmd = new SqlCommand(@"SELECT FirstName, LastName, Address, City, State, Zip, Phone, Email FROM AddressBookContacts WHERE OwnerName = @OwnerName ORDER BY FirstName, LastName;", conn);

            cmd.Parameters.AddWithValue("@OwnerName", ownerName);

            var list = new List<UserContact>();
            using var r = cmd.ExecuteReader();

            while (r.Read())
            {
                list.Add(new UserContact(
                    r.GetString(0),
                    r.GetString(1),
                    r.IsDBNull(2) ? "" : r.GetString(2),
                    r.IsDBNull(3) ? "" : r.GetString(3),
                    r.IsDBNull(4) ? "" : r.GetString(4),
                    r.IsDBNull(5) ? "" : r.GetString(5),
                    r.IsDBNull(6) ? "" : r.GetString(6),
                    r.IsDBNull(7) ? "" : r.GetString(7)
                ));
            }

            return list;
        }
    }
}
