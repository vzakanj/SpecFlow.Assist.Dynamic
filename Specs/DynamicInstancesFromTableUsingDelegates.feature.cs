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
    [NUnit.Framework.DescriptionAttribute("Create dynamic objects from SpecFlow table using delegates")]
    public partial class CreateDynamicObjectsFromSpecFlowTableUsingDelegatesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DynamicInstancesFromTableUsingDelegates.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Create dynamic objects from SpecFlow table using delegates", "In order to write only code that matters\r\nAs a SpecFlow developer\r\nI want SpecFlo" +
                    "w to create dynamic objects from a table row using conversion delegates", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row using ValueToString delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowUsingValueToStringDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row using ValueToString delegate", ((string[])(null)));
#line 6
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
#line 7
 testRunner.When("I create a dynamic instance with only ValueToString delegate from this table", ((string)(null)), table1, "When ");
#line 10
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
  testRunner.And("the Age property should be of type string and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
  testRunner.And("the BirthDate property should be of type string and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
  testRunner.And("the LengthInMeters property should be of type string and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row and 2 columns using ValueToString" +
            " delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowAnd2ColumnsUsingValueToStringDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row and 2 columns using ValueToString" +
                    " delegate", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table2.AddRow(new string[] {
                        "Marcus",
                        "39"});
#line 16
 testRunner.When("I create a dynamic instance with only ValueToString delegate from this table", ((string)(null)), table2, "When ");
#line 19
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
  testRunner.And("the Age property should be of type string and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with Field and Values using ValueToString dele" +
            "gate")]
        public virtual void CreateDynamicInstanceFromTableWithFieldAndValuesUsingValueToStringDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with Field and Values using ValueToString dele" +
                    "gate", ((string[])(null)));
#line 22
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "Name",
                        "Marcus"});
            table3.AddRow(new string[] {
                        "Age",
                        "39"});
            table3.AddRow(new string[] {
                        "Birth date",
                        "1972-10-09"});
            table3.AddRow(new string[] {
                        "Length in meters",
                        "1.96"});
#line 23
 testRunner.When("I create a dynamic instance with only ValueToString delegate from this table", ((string)(null)), table3, "When ");
#line 29
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
  testRunner.And("the Age property should be of type string and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
  testRunner.And("the BirthDate property should be of type string and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
  testRunner.And("the LengthInMeters property should be of type string and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row using ValueToDouble delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowUsingValueToDoubleDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row using ValueToDouble delegate", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table4.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
#line 35
 testRunner.When("I create a dynamic instance with only ValueToDouble delegate from this table", ((string)(null)), table4, "When ");
#line 38
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
  testRunner.And("the Age property should be of type double and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
  testRunner.And("the LengthInMeters property should be of type double and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row and 2 columns using ValueToDouble" +
            " delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowAnd2ColumnsUsingValueToDoubleDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row and 2 columns using ValueToDouble" +
                    " delegate", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table5.AddRow(new string[] {
                        "Marcus",
                        "39"});
#line 44
 testRunner.When("I create a dynamic instance with only ValueToDouble delegate from this table", ((string)(null)), table5, "When ");
#line 47
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
  testRunner.And("the Age property should be of type double and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with Field and Values using ValueToDouble dele" +
            "gate")]
        public virtual void CreateDynamicInstanceFromTableWithFieldAndValuesUsingValueToDoubleDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with Field and Values using ValueToDouble dele" +
                    "gate", ((string[])(null)));
#line 50
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "Name",
                        "Marcus"});
            table6.AddRow(new string[] {
                        "Age",
                        "39"});
            table6.AddRow(new string[] {
                        "Birth date",
                        "1972-10-09"});
            table6.AddRow(new string[] {
                        "Length in meters",
                        "1.96"});
#line 51
 testRunner.When("I create a dynamic instance with only ValueToDouble delegate from this table", ((string)(null)), table6, "When ");
#line 57
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
  testRunner.And("the Age property should be of type double and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
  testRunner.And("the LengthInMeters property should be of type double and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row using ValueToDecimal delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowUsingValueToDecimalDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row using ValueToDecimal delegate", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table7.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
#line 63
 testRunner.When("I create a dynamic instance with only ValueToDecimal delegate from this table", ((string)(null)), table7, "When ");
#line 66
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
  testRunner.And("the Age property should be of type decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
  testRunner.And("the LengthInMeters property should be of type decimal and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row and 2 columns using ValueToDecima" +
            "l delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowAnd2ColumnsUsingValueToDecimalDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row and 2 columns using ValueToDecima" +
                    "l delegate", ((string[])(null)));
#line 71
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table8.AddRow(new string[] {
                        "Marcus",
                        "39"});
#line 72
 testRunner.When("I create a dynamic instance with only ValueToDecimal delegate from this table", ((string)(null)), table8, "When ");
#line 75
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 76
  testRunner.And("the Age property should be of type decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with Field and Values using ValueToDecimal del" +
            "egate")]
        public virtual void CreateDynamicInstanceFromTableWithFieldAndValuesUsingValueToDecimalDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with Field and Values using ValueToDecimal del" +
                    "egate", ((string[])(null)));
#line 78
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "Name",
                        "Marcus"});
            table9.AddRow(new string[] {
                        "Age",
                        "39"});
            table9.AddRow(new string[] {
                        "Birth date",
                        "1972-10-09"});
            table9.AddRow(new string[] {
                        "Length in meters",
                        "1.96"});
#line 79
 testRunner.When("I create a dynamic instance with only ValueToDecimal delegate from this table", ((string)(null)), table9, "When ");
#line 85
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
  testRunner.And("the Age property should be of type decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
  testRunner.And("the LengthInMeters property should be of type decimal and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row using ValueToInt delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowUsingValueToIntDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row using ValueToInt delegate", ((string[])(null)));
#line 90
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table10.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
#line 91
 testRunner.When("I create a dynamic instance with only ValueToInt delegate from this table", ((string)(null)), table10, "When ");
#line 94
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
  testRunner.And("the Age property should be of type int and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
  testRunner.And("the LengthInMeters property should be of type double and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row and 2 columns using ValueToInt de" +
            "legate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowAnd2ColumnsUsingValueToIntDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row and 2 columns using ValueToInt de" +
                    "legate", ((string[])(null)));
#line 99
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table11.AddRow(new string[] {
                        "Marcus",
                        "39"});
#line 100
 testRunner.When("I create a dynamic instance with only ValueToInt delegate from this table", ((string)(null)), table11, "When ");
#line 103
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
  testRunner.And("the Age property should be of type int and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with Field and Values using ValueToInt delegat" +
            "e")]
        public virtual void CreateDynamicInstanceFromTableWithFieldAndValuesUsingValueToIntDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with Field and Values using ValueToInt delegat" +
                    "e", ((string[])(null)));
#line 106
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "Name",
                        "Marcus"});
            table12.AddRow(new string[] {
                        "Age",
                        "39"});
            table12.AddRow(new string[] {
                        "Birth date",
                        "1972-10-09"});
            table12.AddRow(new string[] {
                        "Length in meters",
                        "1.96"});
#line 107
 testRunner.When("I create a dynamic instance with only ValueToInt delegate from this table", ((string)(null)), table12, "When ");
#line 113
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
  testRunner.And("the Age property should be of type int and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
  testRunner.And("the LengthInMeters property should be of type double and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row using ValueToDateTime delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowUsingValueToDateTimeDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row using ValueToDateTime delegate", ((string[])(null)));
#line 118
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
#line 119
 testRunner.When("I create a dynamic instance with only ValueToDateTime delegate from this table", ((string)(null)), table13, "When ");
#line 122
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 123
  testRunner.And("the Age property should be of type int and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
  testRunner.And("the LengthInMeters property should be of type double and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row and 2 columns using ValueToDateTi" +
            "me delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowAnd2ColumnsUsingValueToDateTimeDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row and 2 columns using ValueToDateTi" +
                    "me delegate", ((string[])(null)));
#line 127
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "BirthDate"});
            table14.AddRow(new string[] {
                        "Marcus",
                        "1972-10-09"});
#line 128
 testRunner.When("I create a dynamic instance with only ValueToDateTime delegate from this table", ((string)(null)), table14, "When ");
#line 131
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with Field and Values using ValueToDateTime de" +
            "legate")]
        public virtual void CreateDynamicInstanceFromTableWithFieldAndValuesUsingValueToDateTimeDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with Field and Values using ValueToDateTime de" +
                    "legate", ((string[])(null)));
#line 134
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table15.AddRow(new string[] {
                        "Name",
                        "Marcus"});
            table15.AddRow(new string[] {
                        "Age",
                        "39"});
            table15.AddRow(new string[] {
                        "Birth date",
                        "1972-10-09"});
            table15.AddRow(new string[] {
                        "Length in meters",
                        "1.96"});
#line 135
 testRunner.When("I create a dynamic instance with only ValueToDateTime delegate from this table", ((string)(null)), table15, "When ");
#line 141
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
  testRunner.And("the Age property should be of type int and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
  testRunner.And("the LengthInMeters property should be of type double and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row using ValueToDateTime delegate wi" +
            "th custom date format")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowUsingValueToDateTimeDelegateWithCustomDateFormat()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row using ValueToDateTime delegate wi" +
                    "th custom date format", ((string[])(null)));
#line 146
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table16.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "09/10/1972",
                        "1.96"});
#line 147
 testRunner.When("I create a dynamic instance with only ValueToDateTime delegate using date format " +
                    "dd/MM/yyyy from this table", ((string)(null)), table16, "When ");
#line 150
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
  testRunner.And("the Age property should be of type int and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
  testRunner.And("the LengthInMeters property should be of type double and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row and 2 columns using ValueToDateTi" +
            "me delegate with custom date format")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowAnd2ColumnsUsingValueToDateTimeDelegateWithCustomDateFormat()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row and 2 columns using ValueToDateTi" +
                    "me delegate with custom date format", ((string[])(null)));
#line 155
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "BirthDate"});
            table17.AddRow(new string[] {
                        "Marcus",
                        "09/10/1972"});
#line 156
 testRunner.When("I create a dynamic instance with only ValueToDateTime delegate using date format " +
                    "dd/MM/yyyy from this table", ((string)(null)), table17, "When ");
#line 159
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 160
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with Field and Values using ValueToDateTime de" +
            "legate with custom date format")]
        public virtual void CreateDynamicInstanceFromTableWithFieldAndValuesUsingValueToDateTimeDelegateWithCustomDateFormat()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with Field and Values using ValueToDateTime de" +
                    "legate with custom date format", ((string[])(null)));
#line 163
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table18.AddRow(new string[] {
                        "Name",
                        "Marcus"});
            table18.AddRow(new string[] {
                        "Age",
                        "39"});
            table18.AddRow(new string[] {
                        "Birth date",
                        "09/10/1972"});
            table18.AddRow(new string[] {
                        "Length in meters",
                        "1.96"});
#line 164
 testRunner.When("I create a dynamic instance with only ValueToDateTime delegate using date format " +
                    "dd/MM/yyyy from this table", ((string)(null)), table18, "When ");
#line 170
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 171
  testRunner.And("the Age property should be of type int and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 173
  testRunner.And("the LengthInMeters property should be of type double and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row using ValueToDecimal and ValueToS" +
            "tring delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowUsingValueToDecimalAndValueToStringDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row using ValueToDecimal and ValueToS" +
                    "tring delegate", ((string[])(null)));
#line 175
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table19.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
#line 176
 testRunner.When("I create a dynamic instance with delegates ValueToDecimal, ValueToString from thi" +
                    "s table", ((string)(null)), table19, "When ");
#line 179
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 180
  testRunner.And("the Age property should be of type decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 181
  testRunner.And("the BirthDate property should be of type string and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 182
  testRunner.And("the LengthInMeters property should be of type decimal and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row and 2 columns using ValueToDecima" +
            "l and ValueToString delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowAnd2ColumnsUsingValueToDecimalAndValueToStringDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row and 2 columns using ValueToDecima" +
                    "l and ValueToString delegate", ((string[])(null)));
#line 184
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table20.AddRow(new string[] {
                        "Marcus",
                        "39"});
#line 185
 testRunner.When("I create a dynamic instance with delegates ValueToDecimal, ValueToString from thi" +
                    "s table", ((string)(null)), table20, "When ");
#line 188
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 189
  testRunner.And("the Age property should be of type decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with Field and Values using ValueToDecimal and" +
            " ValueToString delegate")]
        public virtual void CreateDynamicInstanceFromTableWithFieldAndValuesUsingValueToDecimalAndValueToStringDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with Field and Values using ValueToDecimal and" +
                    " ValueToString delegate", ((string[])(null)));
#line 191
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table21.AddRow(new string[] {
                        "Name",
                        "Marcus"});
            table21.AddRow(new string[] {
                        "Age",
                        "39"});
            table21.AddRow(new string[] {
                        "Birth date",
                        "1972-10-09"});
            table21.AddRow(new string[] {
                        "Length in meters",
                        "1.96"});
#line 192
 testRunner.When("I create a dynamic instance with delegates ValueToDecimal, ValueToString from thi" +
                    "s table", ((string)(null)), table21, "When ");
#line 198
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 199
  testRunner.And("the Age property should be of type decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
  testRunner.And("the BirthDate property should be of type string and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 201
  testRunner.And("the LengthInMeters property should be of type decimal and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
