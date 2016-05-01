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
    [NUnit.Framework.DescriptionAttribute("Conversions of values using custom value converters")]
    public partial class ConversionsOfValuesUsingCustomValueConvertersFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ValueConversionsUsingValueConverters.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Conversions of values using custom value converters", "In order to easier compare values of the most common types\r\nAs a user of SpecFlow" +
                    " Dynamic\r\nI want SpecFlow Dynamic to translate strings into real types using cus" +
                    "tom value converters", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        "Name"});
            table1.AddRow(new string[] {
                        "Marcus"});
#line 7
 testRunner.Given("a table Name", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Age"});
            table2.AddRow(new string[] {
                        "39"});
#line 10
 testRunner.And("a table Age", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Length in meters"});
            table3.AddRow(new string[] {
                        "1.96"});
#line 13
 testRunner.And("a table LengthInMeters", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Length in meters"});
            table4.AddRow(new string[] {
                        "4.567"});
#line 16
 testRunner.And("a table StrangeLengthInMeters", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Molecular Weight"});
            table5.AddRow(new string[] {
                        "1000000000.1111991111"});
#line 19
 testRunner.And("a table MolecularWeight", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Birth date"});
            table6.AddRow(new string[] {
                        "1972-10-09"});
#line 22
 testRunner.And("a table BirthDate", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Is developer"});
            table7.AddRow(new string[] {
                        "false"});
#line 25
 testRunner.And("a table IsDeveloper", ((string)(null)), table7, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Strings should be translated to strings using ValueToString converter")]
        public virtual void StringsShouldBeTranslatedToStringsUsingValueToStringConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Strings should be translated to strings using ValueToString converter", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 30
 testRunner.When("I create a dynamic instance using ValueToString converter from table Name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Integers should be translated to strings using ValueToString converter")]
        public virtual void IntegersShouldBeTranslatedToStringsUsingValueToStringConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Integers should be translated to strings using ValueToString converter", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 34
 testRunner.When("I create a dynamic instance using ValueToString converter from table Age", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("the Age property should be of type string and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Doubles should be translated to strings using ValueToString converter")]
        public virtual void DoublesShouldBeTranslatedToStringsUsingValueToStringConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Doubles should be translated to strings using ValueToString converter", ((string[])(null)));
#line 37
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 38
 testRunner.When("I create a dynamic instance using ValueToString converter from table LengthInMete" +
                    "rs", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("the LengthInMeters property should be of type string and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Decimals should be translated to strings using ValueToString converter")]
        public virtual void DecimalsShouldBeTranslatedToStringsUsingValueToStringConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Decimals should be translated to strings using ValueToString converter", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 42
 testRunner.When("I create a dynamic instance using ValueToString converter from table MolecularWei" +
                    "ght", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("the MolecularWeight property should be of type string and equal 1000000000.111199" +
                    "1111", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dates should be translated to strings using ValueToString converter")]
        public virtual void DatesShouldBeTranslatedToStringsUsingValueToStringConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dates should be translated to strings using ValueToString converter", ((string[])(null)));
#line 45
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 46
 testRunner.When("I create a dynamic instance using ValueToString converter from table BirthDate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("the BirthDate property should be of type string and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bools should be translated to strings using ValueToString converter")]
        public virtual void BoolsShouldBeTranslatedToStringsUsingValueToStringConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bools should be translated to strings using ValueToString converter", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 50
 testRunner.When("I create a dynamic instance using ValueToString converter from table IsDeveloper", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("the IsDeveloper property should be of type string and equal false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A strange double should be translated to string shen ValueToString converter")]
        public virtual void AStrangeDoubleShouldBeTranslatedToStringShenValueToStringConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A strange double should be translated to string shen ValueToString converter", ((string[])(null)));
#line 53
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 54
 testRunner.When("I create a dynamic instance using ValueToString converter from table StrangeLengt" +
                    "hInMeters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("the LengthInMeters property should be of type string and equal 4.567", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Strings should fall back to being translated to strings using ValueToDecimal conv" +
            "erter")]
        public virtual void StringsShouldFallBackToBeingTranslatedToStringsUsingValueToDecimalConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Strings should fall back to being translated to strings using ValueToDecimal conv" +
                    "erter", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 58
 testRunner.When("I create a dynamic instance using ValueToDecimal converter from table Name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Integers should be translated to decimals using ValueToDecimal converter")]
        public virtual void IntegersShouldBeTranslatedToDecimalsUsingValueToDecimalConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Integers should be translated to decimals using ValueToDecimal converter", ((string[])(null)));
#line 61
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 62
 testRunner.When("I create a dynamic instance using ValueToDecimal converter from table Age", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then("the Age property should be of type decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Doubles should be translated to decimals using ValueToDecimal converter")]
        public virtual void DoublesShouldBeTranslatedToDecimalsUsingValueToDecimalConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Doubles should be translated to decimals using ValueToDecimal converter", ((string[])(null)));
#line 65
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 66
 testRunner.When("I create a dynamic instance using ValueToDecimal converter from table LengthInMet" +
                    "ers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("the LengthInMeters property should be of type decimal and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Decimals should be translated to decimals using ValueToDecimal converter")]
        public virtual void DecimalsShouldBeTranslatedToDecimalsUsingValueToDecimalConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Decimals should be translated to decimals using ValueToDecimal converter", ((string[])(null)));
#line 69
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 70
 testRunner.When("I create a dynamic instance using ValueToDecimal converter from table MolecularWe" +
                    "ight", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.Then("the MolecularWeight property should be of type decimal and equal 1000000000.11119" +
                    "91111", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dates should fall back to being translated to date times using ValueToDecimal con" +
            "verter")]
        public virtual void DatesShouldFallBackToBeingTranslatedToDateTimesUsingValueToDecimalConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dates should fall back to being translated to date times using ValueToDecimal con" +
                    "verter", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 74
 testRunner.When("I create a dynamic instance using ValueToDecimal converter from table BirthDate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.Then("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bools should fall back to being translated translated to bools using ValueToDecim" +
            "al converter")]
        public virtual void BoolsShouldFallBackToBeingTranslatedTranslatedToBoolsUsingValueToDecimalConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bools should fall back to being translated translated to bools using ValueToDecim" +
                    "al converter", ((string[])(null)));
#line 77
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 78
 testRunner.When("I create a dynamic instance using ValueToDecimal converter from table IsDeveloper" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then("the IsDeveloper property should be of type bool and equal false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A strange double should be translated to decimal using ValueToDecimal converter")]
        public virtual void AStrangeDoubleShouldBeTranslatedToDecimalUsingValueToDecimalConverter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A strange double should be translated to decimal using ValueToDecimal converter", ((string[])(null)));
#line 81
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 82
 testRunner.When("I create a dynamic instance using ValueToDecimal converter from table StrangeLeng" +
                    "thInMeters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.Then("the LengthInMeters property should be of type decimal and equal 4.567", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Strings should be translated to strings when using ValueToDecimal and ValueToStri" +
            "ng converters")]
        public virtual void StringsShouldBeTranslatedToStringsWhenUsingValueToDecimalAndValueToStringConverters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Strings should be translated to strings when using ValueToDecimal and ValueToStri" +
                    "ng converters", ((string[])(null)));
#line 85
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 86
 testRunner.When("I create a dynamic instance using converters ValueToDecimal, ValueToString from t" +
                    "able Name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.Then("the Name property should be of type string and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Integers should be translated to decimals using ValueToDecimal and ValueToString " +
            "converters")]
        public virtual void IntegersShouldBeTranslatedToDecimalsUsingValueToDecimalAndValueToStringConverters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Integers should be translated to decimals using ValueToDecimal and ValueToString " +
                    "converters", ((string[])(null)));
#line 89
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 90
 testRunner.When("I create a dynamic instance using converters ValueToDecimal, ValueToString from t" +
                    "able Age", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.Then("the Age property should be of type decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Doubles should be translated to decimals using ValueToDecimal and ValueToString c" +
            "onverters")]
        public virtual void DoublesShouldBeTranslatedToDecimalsUsingValueToDecimalAndValueToStringConverters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Doubles should be translated to decimals using ValueToDecimal and ValueToString c" +
                    "onverters", ((string[])(null)));
#line 93
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 94
 testRunner.When("I create a dynamic instance using converters ValueToDecimal, ValueToString from t" +
                    "able LengthInMeters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("the LengthInMeters property should be of type decimal and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Decimals should be translated to decimals using ValueToDecimal and ValueToString " +
            "converters")]
        public virtual void DecimalsShouldBeTranslatedToDecimalsUsingValueToDecimalAndValueToStringConverters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Decimals should be translated to decimals using ValueToDecimal and ValueToString " +
                    "converters", ((string[])(null)));
#line 97
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 98
 testRunner.When("I create a dynamic instance using converters ValueToDecimal, ValueToString from t" +
                    "able MolecularWeight", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.Then("the MolecularWeight property should be of type decimal and equal 1000000000.11119" +
                    "91111", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dates should be translated to strings using ValueToDecimal and ValueToString conv" +
            "erters")]
        public virtual void DatesShouldBeTranslatedToStringsUsingValueToDecimalAndValueToStringConverters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dates should be translated to strings using ValueToDecimal and ValueToString conv" +
                    "erters", ((string[])(null)));
#line 101
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 102
 testRunner.When("I create a dynamic instance using converters ValueToDecimal, ValueToString from t" +
                    "able BirthDate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("the BirthDate property should be of type string and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bools should be translated to strings using ValueToDecimal and ValueToString conv" +
            "erters")]
        public virtual void BoolsShouldBeTranslatedToStringsUsingValueToDecimalAndValueToStringConverters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bools should be translated to strings using ValueToDecimal and ValueToString conv" +
                    "erters", ((string[])(null)));
#line 105
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 106
 testRunner.When("I create a dynamic instance using converters ValueToDecimal, ValueToString from t" +
                    "able IsDeveloper", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
 testRunner.Then("the IsDeveloper property should be of type string and equal false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A strange double should be translated to decimal using ValueToDecimal and ValueTo" +
            "String converters")]
        public virtual void AStrangeDoubleShouldBeTranslatedToDecimalUsingValueToDecimalAndValueToStringConverters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A strange double should be translated to decimal using ValueToDecimal and ValueTo" +
                    "String converters", ((string[])(null)));
#line 109
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 110
 testRunner.When("I create a dynamic instance using converters ValueToDecimal, ValueToString from t" +
                    "able StrangeLengthInMeters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
 testRunner.Then("the LengthInMeters property should be of type decimal and equal 4.567", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dates should be translated to DateTime using ValueToDateTime converter is used wi" +
            "th custom date format")]
        public virtual void DatesShouldBeTranslatedToDateTimeUsingValueToDateTimeConverterIsUsedWithCustomDateFormat()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dates should be translated to DateTime using ValueToDateTime converter is used wi" +
                    "th custom date format", ((string[])(null)));
#line 113
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Birth date"});
            table8.AddRow(new string[] {
                        "09/10/1972"});
#line 114
 testRunner.When("I create a dynamic instance using ValueToDateTime converter with date format dd/M" +
                    "M/yyyy from this table", ((string)(null)), table8, "When ");
#line 117
 testRunner.Then("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
