﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Comparing dynamic sets against tables")]
    public partial class ComparingDynamicSetsAgainstTablesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ComparingDynamicSets.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Comparing dynamic sets against tables", "In order to easier and slicker do assertions\r\nAs a SpecFlow developer\r\nI want to " +
                    "be able to compare a list of dynamic items against a table", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Comparing against an identical table should match")]
        public virtual void ComparingAgainstAnIdenticalTableShouldMatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Comparing against an identical table should match", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table1.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table1.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
            table1.AddRow(new string[] {
                        "Gustav",
                        "1",
                        "2010-03-19",
                        "0.84"});
            table1.AddRow(new string[] {
                        "Arvid",
                        "1",
                        "2010-03-19",
                        "0.85"});
#line 8
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table2.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table2.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
            table2.AddRow(new string[] {
                        "Gustav",
                        "1",
                        "2010-03-19",
                        "0.84"});
            table2.AddRow(new string[] {
                        "Arvid",
                        "1",
                        "2010-03-19",
                        "0.85"});
#line 14
 testRunner.When("I compare the set to this table", ((string)(null)), table2, "When ");
#line 20
 testRunner.Then("no set comparison exception should have been thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when 1 column name differ")]
        public virtual void NotMatchingWhen1ColumnNameDiffer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Not matching when 1 column name differ", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table3.AddRow(new string[] {
                        "Marcus"});
            table3.AddRow(new string[] {
                        "Albert"});
            table3.AddRow(new string[] {
                        "Gustav"});
            table3.AddRow(new string[] {
                        "Arvid"});
#line 23
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table3, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "N"});
            table4.AddRow(new string[] {
                        "Marcus"});
            table4.AddRow(new string[] {
                        "Albert"});
            table4.AddRow(new string[] {
                        "Gustav"});
            table4.AddRow(new string[] {
                        "Arvid"});
#line 29
 testRunner.When("I compare the set to this table", ((string)(null)), table4, "When ");
#line 35
 testRunner.Then("an set comparision exception should be thrown with 2 differences", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
  testRunner.And("one set difference should be on the Name field of the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
  testRunner.And("one set difference should be on the N column of the table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when 2 header differ")]
        public virtual void NotMatchingWhen2HeaderDiffer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Not matching when 2 header differ", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table5.AddRow(new string[] {
                        "Marcus",
                        "39"});
            table5.AddRow(new string[] {
                        "Albert",
                        "3"});
            table5.AddRow(new string[] {
                        "Gustav",
                        "1"});
            table5.AddRow(new string[] {
                        "Arvid",
                        "1"});
#line 40
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table5, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Namn",
                        "Ålder"});
            table6.AddRow(new string[] {
                        "Marcus",
                        "39"});
            table6.AddRow(new string[] {
                        "Albert",
                        "3"});
            table6.AddRow(new string[] {
                        "Gustav",
                        "1"});
            table6.AddRow(new string[] {
                        "Arvid",
                        "1"});
#line 46
 testRunner.When("I compare the set to this table", ((string)(null)), table6, "When ");
#line 52
 testRunner.Then("an set comparision exception should be thrown with 4 differences", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
  testRunner.And("one set difference should be on the Name field of the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
  testRunner.And("one set difference should be on the Age field of the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
  testRunner.And("one set difference should be on the Namn column of the table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
  testRunner.And("one set difference should be on the Ålder column of the table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when the number of rows are more in the table")]
        public virtual void NotMatchingWhenTheNumberOfRowsAreMoreInTheTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Not matching when the number of rows are more in the table", ((string[])(null)));
#line 58
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table7.AddRow(new string[] {
                        "Marcus",
                        "39"});
            table7.AddRow(new string[] {
                        "Albert",
                        "3"});
#line 59
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table8.AddRow(new string[] {
                        "Marcus",
                        "39"});
            table8.AddRow(new string[] {
                        "Albert",
                        "3"});
            table8.AddRow(new string[] {
                        "Arvid",
                        "1"});
#line 63
 testRunner.When("I compare the set to this table", ((string)(null)), table8, "When ");
#line 68
 testRunner.Then("an set comparison exception should be thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
  testRunner.And("the error message for different rows should expect 3 rows for table and 2 rows fo" +
                    "r instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Differences on 1 value in 1 row should throw exceptions")]
        public virtual void DifferencesOn1ValueIn1RowShouldThrowExceptions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Differences on 1 value in 1 row should throw exceptions", ((string[])(null)));
#line 71
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table9.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table9.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
#line 72
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table9, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table10.AddRow(new string[] {
                        "Hugo",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table10.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
#line 76
 testRunner.When("I compare the set to this table", ((string)(null)), table10, "When ");
#line 80
 testRunner.Then("an set comparision exception should be thrown with 1 difference", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
  testRunner.And("1 difference should be on row 1 on property Name for the values Marcus and Hugo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Differences on 2 value in 2 different row should throw exceptions")]
        public virtual void DifferencesOn2ValueIn2DifferentRowShouldThrowExceptions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Differences on 2 value in 2 different row should throw exceptions", ((string[])(null)));
#line 83
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table11.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table11.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "0.03"});
#line 84
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table11, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table12.AddRow(new string[] {
                        "Hugo",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table12.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
#line 88
 testRunner.When("I compare the set to this table", ((string)(null)), table12, "When ");
#line 92
 testRunner.Then("an set comparision exception should be thrown with 2 difference", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
  testRunner.And("1 difference should be on row 1 on property Name for the values Marcus and Hugo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
  testRunner.And("2 difference should be on row 2 on property LengthInMeters for the values 0.03 an" +
                    "d 1.03", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Differences on 4 value on 1 row should throw exceptions")]
        public virtual void DifferencesOn4ValueOn1RowShouldThrowExceptions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Differences on 4 value on 1 row should throw exceptions", ((string[])(null)));
#line 96
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table13.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table13.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
#line 97
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table13, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table14.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table14.AddRow(new string[] {
                        "Hugo",
                        "2",
                        "2010-01-24",
                        "0.03"});
#line 101
 testRunner.When("I compare the set to this table", ((string)(null)), table14, "When ");
#line 105
 testRunner.Then("an set comparision exception should be thrown with 4 difference", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
  testRunner.And("1 difference should be on row 2 on property Name for the values Marcus and Hugo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
  testRunner.And("2 difference should be on row 2 on property Age for the values 3 and 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
  testRunner.And("3 difference should be on row 2 on property BirthDate for the values 2008-01-24 1" +
                    "2:00AM and 2010-01-24 12:00AM", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
  testRunner.And("4 difference should be on row 2 on property LengthInMeters for the values 1.03 an" +
                    "d 0.03", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
