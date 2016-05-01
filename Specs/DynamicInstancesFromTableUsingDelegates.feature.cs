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
        
        public virtual void FeatureBackground()
        {
#line 6
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
 testRunner.Given("a table MarcusOneRow", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table2.AddRow(new string[] {
                        "Marcus",
                        "39"});
#line 10
 testRunner.And("a table MarcusTwoColumns", ((string)(null)), table2, "And ");
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
#line 13
 testRunner.And("a table Marcus", ((string)(null)), table3, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row using ValueToString delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowUsingValueToStringDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row using ValueToString delegate", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 21
 testRunner.When("I create a dynamic instance using ValueToString delegate from table MarcusOneRow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
  testRunner.And("the Age property should be of type string and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
  testRunner.And("the BirthDate property should be of type string and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
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
#line 27
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 28
 testRunner.When("I create a dynamic instance using ValueToString delegate from table MarcusTwoColu" +
                    "mns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
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
#line 32
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 33
 testRunner.When("I create a dynamic instance using ValueToString delegate from table Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
  testRunner.And("the Age property should be of type string and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
  testRunner.And("the BirthDate property should be of type string and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
  testRunner.And("the LengthInMeters property should be of type string and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row using ValueToDouble delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowUsingValueToDoubleDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row using ValueToDouble delegate", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 40
 testRunner.When("I create a dynamic instance using ValueToDouble delegate from table MarcusOneRow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
  testRunner.And("the Age property should be of type double and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
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
#line 46
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 47
 testRunner.When("I create a dynamic instance using ValueToDouble delegate from table MarcusTwoColu" +
                    "mns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
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
#line 51
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 52
 testRunner.When("I create a dynamic instance using ValueToDouble delegate from table Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
  testRunner.And("the Age property should be of type double and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
  testRunner.And("the LengthInMeters property should be of type double and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row using ValueToDecimal delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowUsingValueToDecimalDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row using ValueToDecimal delegate", ((string[])(null)));
#line 58
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 59
 testRunner.When("I create a dynamic instance using ValueToDecimal delegate from table MarcusOneRow" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
  testRunner.And("the Age property should be of type decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
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
#line 65
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 66
 testRunner.When("I create a dynamic instance using ValueToDecimal delegate from table MarcusTwoCol" +
                    "umns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
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
#line 70
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 71
 testRunner.When("I create a dynamic instance using ValueToDecimal delegate from table Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
  testRunner.And("the Age property should be of type decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
  testRunner.And("the LengthInMeters property should be of type decimal and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row using ValueToInt delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowUsingValueToIntDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row using ValueToInt delegate", ((string[])(null)));
#line 77
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 78
 testRunner.When("I create a dynamic instance using ValueToInt delegate from table MarcusOneRow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 80
  testRunner.And("the Age property should be of type int and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
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
#line 84
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 85
 testRunner.When("I create a dynamic instance using ValueToInt delegate from table MarcusTwoColumns" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 86
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
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
#line 89
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 90
 testRunner.When("I create a dynamic instance using ValueToInt delegate from table Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
  testRunner.And("the Age property should be of type int and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
  testRunner.And("the LengthInMeters property should be of type double and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create dynamic instance from table with one row using ValueToDateTime delegate")]
        public virtual void CreateDynamicInstanceFromTableWithOneRowUsingValueToDateTimeDelegate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create dynamic instance from table with one row using ValueToDateTime delegate", ((string[])(null)));
#line 96
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 97
 testRunner.When("I create a dynamic instance using ValueToDateTime delegate from table MarcusOneRo" +
                    "w", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
  testRunner.And("the Age property should be of type int and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
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
#line 103
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "BirthDate"});
            table4.AddRow(new string[] {
                        "Marcus",
                        "1972-10-09"});
#line 104
 testRunner.When("I create a dynamic instance using ValueToDateTime delegate from this table", ((string)(null)), table4, "When ");
#line 107
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
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
#line 110
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 111
 testRunner.When("I create a dynamic instance using ValueToDateTime delegate from table Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 112
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
  testRunner.And("the Age property should be of type int and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
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
#line 117
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table5.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "09/10/1972",
                        "1.96"});
#line 118
 testRunner.When("I create a dynamic instance using ValueToDateTime delegate using date format dd/M" +
                    "M/yyyy from this table", ((string)(null)), table5, "When ");
#line 121
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 122
  testRunner.And("the Age property should be of type int and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
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
#line 126
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "BirthDate"});
            table6.AddRow(new string[] {
                        "Marcus",
                        "09/10/1972"});
#line 127
 testRunner.When("I create a dynamic instance using ValueToDateTime delegate using date format dd/M" +
                    "M/yyyy from this table", ((string)(null)), table6, "When ");
#line 130
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
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
#line 133
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "Name",
                        "Marcus"});
            table7.AddRow(new string[] {
                        "Age",
                        "39"});
            table7.AddRow(new string[] {
                        "Birth date",
                        "09/10/1972"});
            table7.AddRow(new string[] {
                        "Length in meters",
                        "1.96"});
#line 134
 testRunner.When("I create a dynamic instance using ValueToDateTime delegate using date format dd/M" +
                    "M/yyyy from this table", ((string)(null)), table7, "When ");
#line 140
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 141
  testRunner.And("the Age property should be of type int and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
  testRunner.And("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
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
#line 145
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 146
 testRunner.When("I create a dynamic instance using delegates ValueToDecimal, ValueToString from ta" +
                    "ble MarcusOneRow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 148
  testRunner.And("the Age property should be of type decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
  testRunner.And("the BirthDate property should be of type string and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
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
#line 152
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 153
 testRunner.When("I create a dynamic instance using delegates ValueToDecimal, ValueToString from ta" +
                    "ble MarcusTwoColumns", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 154
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 155
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
#line 157
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 158
 testRunner.When("I create a dynamic instance using delegates ValueToDecimal, ValueToString from ta" +
                    "ble Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 159
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 160
  testRunner.And("the Age property should be of type decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
  testRunner.And("the BirthDate property should be of type string and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
  testRunner.And("the LengthInMeters property should be of type decimal and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
