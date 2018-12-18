using System;
using System.Collections.Generic;
using System.Text;

namespace ATicket.DB
{
    public interface IDataBaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
