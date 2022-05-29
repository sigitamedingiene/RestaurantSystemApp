using Business_Class;
using System.Collections.Generic;

namespace Repository
{
    public class TablesRepository
    { private List<Table> TableList { get; set; }
        public TablesRepository()
        {
            TableList = new List<Table>();
            TableList.Add(new Table(1, 8, false));
            TableList.Add(new Table(2, 5, true));
            TableList.Add(new Table(3, 4, true));
            TableList.Add(new Table(4, 3, false));
            TableList.Add(new Table(5, 12, false));
        }
        public List<Table> Retrieve()
        {
            return TableList;
        }
    }
}
