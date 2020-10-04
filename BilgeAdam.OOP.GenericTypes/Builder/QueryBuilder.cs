using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.GenericTypes.Builder
{
    public class QueryBuilder<T>
    {
        private StringBuilder stringBuilder;
        public QueryBuilder(string tableName)
        {
            Table = new TableInfo { TableName = tableName };
        }

        public QueryBuilder<T> WithColumn(string columnName)
        {
            Table.Columns.Add(columnName);
            return this;
        }

        public QueryBuilder<T> WithOrder(string column, Direction direction)
        {
            Table.OrderBy = new Order
            {
                Column = column,
                Direction = direction.ToString()
            };
            return this;
        }

        public string Build()
        {
            stringBuilder = new StringBuilder("SELECT ");
            var columns = string.Join(",", Table.Columns);
            stringBuilder.Append(columns);
            stringBuilder.Append($" FROM {Table.TableName}");
            
            if (Table.OrderBy != null)
            {
                stringBuilder.Append($" ORDER BY {Table.OrderBy.Column} {Table.OrderBy.Direction}");
            }

            return stringBuilder.ToString();
        }

        private TableInfo Table { get; set; }

        class TableInfo
        {
            public TableInfo()
            {
                Columns = new HashSet<string>();
            }
            public string TableName { get; set; }
            public Order OrderBy { get; set; }
            public HashSet<string> Columns { get; set; }
        }

        class Order
        {
            public string Column { get; set; }
            public string Direction { get; set; }
        }
    }

    public enum Direction
    {
        ASC,
        DESC
    }
}
