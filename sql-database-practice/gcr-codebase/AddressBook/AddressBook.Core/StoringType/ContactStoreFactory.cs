using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Core.senario_based.AddressBook.StoringType
{
    public enum StoreType
    {
        PipeText = 1,
        Csv = 2,
        JsonFile = 3,
        SqlServer = 4
    }

    public static class ContactStoreFactory
    {
        public static IContactStore Create(StoreType type, string pathOrConnString)
        {
            return type switch
            {
                StoreType.PipeText => new PipeTextContactStore(pathOrConnString),
                StoreType.Csv => new CsvContactStore(pathOrConnString),
                StoreType.JsonFile => new JsonFileContactStore(pathOrConnString),
                StoreType.SqlServer => new SqlServerContactStore(pathOrConnString),
                _ => throw new ArgumentOutOfRangeException(nameof(type), "Unknown store type")
            };
        }
    }
}
