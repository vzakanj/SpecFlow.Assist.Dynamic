using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Specs.Steps
{
    [Binding]
    public class FeatureBackgroundSteps
    {
        [Given(@"a table (.*)")]
        public void GivenATable(string tableName, Table table)
        {
            State.SetTable(tableName, table);
        }
    }
}
