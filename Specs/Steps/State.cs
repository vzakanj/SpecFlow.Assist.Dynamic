using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Specs.Steps
{
    public class State
    {
        public static dynamic OriginalInstance
        {
            get
            {
                return ScenarioContext.Current["OriginalInstance"];
            }
            set
            {
                ScenarioContext.Current.Add("OriginalInstance", value);
            }
        }

        public static IList<dynamic> OriginalSet
        {
            get
            {
                return ScenarioContext.Current["OriginalSet"] as IList<dynamic>;
            }
            set
            {
                ScenarioContext.Current.Add("OriginalSet", value);
            }
        }

        public static Table GetTable(string tableName)
        {
            return ScenarioContext.Current.Get<Table>("Table-" + tableName);
        }

        public static void SetTable(string tableName, Table table)
        {
            ScenarioContext.Current.Set(table, "Table-" + tableName);
        }


    }
}
