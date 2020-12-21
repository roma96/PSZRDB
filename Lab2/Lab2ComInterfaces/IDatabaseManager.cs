using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace Lab2ComServerIntefaces
{
    [Guid("E637D6B1-41BA-4A70-952E-9A3D0477044A")]
    public interface IDatabaseManager
    {
        DataTable GetTable(string query);
        List<string> GetTables();
    }
}
