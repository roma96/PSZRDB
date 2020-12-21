using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MyInterfaces
{
    public interface IDatabaseMananger
    {
        DataTable GetTable(string query);
        List<string> GetTables();

    }
}
