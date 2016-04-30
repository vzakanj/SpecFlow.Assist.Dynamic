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
    [NUnit.Framework.DescriptionAttribute("Conversions of values using delegates")]
    public partial class ConversionsOfValuesUsingDelegatesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ValueConversionsUsingDelegates.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Conversions of values using delegates", "In order to easier compare values of the most common types\r\nAs a user of SpecFlow" +
                    " Dynamic\r\nI want SpecFlow Dynamic to translate strings into real types using spe" +
                    "cified delegates", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Strings should be translated to strings when only ValueToString delegate is used")]
        public virtual void StringsShouldBeTranslatedToStringsWhenOnlyValueToStringDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Strings should be translated to strings when only ValueToString delegate is used", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table1.AddRow(new string[] {
                        "Marcus"});
#line 7
 testRunner.When("I create a dynamic instance with only ValueToString delegate from this table", ((string)(null)), table1, "When ");
#line 10
 testRunner.Then("the Name property should be of type String and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Integers should be translated to strings when only ValueToString delegate is used" +
            "")]
        public virtual void IntegersShouldBeTranslatedToStringsWhenOnlyValueToStringDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Integers should be translated to strings when only ValueToString delegate is used" +
                    "", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Age"});
            table2.AddRow(new string[] {
                        "39"});
#line 13
 testRunner.When("I create a dynamic instance with only ValueToString delegate from this table", ((string)(null)), table2, "When ");
#line 16
 testRunner.Then("the Age property should be of type String and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Doubles should be translated to strings when only ValueToString delegate is used")]
        public virtual void DoublesShouldBeTranslatedToStringsWhenOnlyValueToStringDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Doubles should be translated to strings when only ValueToString delegate is used", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Length in meters"});
            table3.AddRow(new string[] {
                        "1.96"});
#line 19
 testRunner.When("I create a dynamic instance with only ValueToString delegate from this table", ((string)(null)), table3, "When ");
#line 22
 testRunner.Then("the LengthInMeters property should be of type String and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Decimals should be translated to strings when only ValueToString delegate is used" +
            "")]
        public virtual void DecimalsShouldBeTranslatedToStringsWhenOnlyValueToStringDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Decimals should be translated to strings when only ValueToString delegate is used" +
                    "", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Molecular Weight"});
            table4.AddRow(new string[] {
                        "1000000000.1111991111"});
#line 25
 testRunner.When("I create a dynamic instance with only ValueToString delegate from this table", ((string)(null)), table4, "When ");
#line 28
 testRunner.Then("the MolecularWeight property should be of type String and equal 1000000000.111199" +
                    "1111", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dates should be translated to strings when only ValueToString delegate is used")]
        public virtual void DatesShouldBeTranslatedToStringsWhenOnlyValueToStringDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dates should be translated to strings when only ValueToString delegate is used", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Birth date"});
            table5.AddRow(new string[] {
                        "1972-10-09"});
#line 31
 testRunner.When("I create a dynamic instance with only ValueToString delegate from this table", ((string)(null)), table5, "When ");
#line 34
 testRunner.Then("the BirthDate property should be of type String and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bools should be translated to strings when only ValueToString delegate is used")]
        public virtual void BoolsShouldBeTranslatedToStringsWhenOnlyValueToStringDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bools should be translated to strings when only ValueToString delegate is used", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Is developer"});
            table6.AddRow(new string[] {
                        "false"});
#line 37
 testRunner.When("I create a dynamic instance with only ValueToString delegate from this table", ((string)(null)), table6, "When ");
#line 40
 testRunner.Then("the IsDeveloper property should be of type String and equal false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A strange double should be translated to string shen only ValueToString delegate " +
            "is used")]
        public virtual void AStrangeDoubleShouldBeTranslatedToStringShenOnlyValueToStringDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A strange double should be translated to string shen only ValueToString delegate " +
                    "is used", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Length in meters"});
            table7.AddRow(new string[] {
                        "4.567"});
#line 43
 testRunner.When("I create a dynamic instance with only ValueToString delegate from this table", ((string)(null)), table7, "When ");
#line 46
 testRunner.Then("the LengthInMeters property should be of type String and equal 4.567", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Strings should fall back to being translated to strings when only ValueToDecimal " +
            "delegate is used")]
        public virtual void StringsShouldFallBackToBeingTranslatedToStringsWhenOnlyValueToDecimalDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Strings should fall back to being translated to strings when only ValueToDecimal " +
                    "delegate is used", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table8.AddRow(new string[] {
                        "Marcus"});
#line 49
 testRunner.When("I create a dynamic instance with only ValueToDecimal delegate from this table", ((string)(null)), table8, "When ");
#line 52
 testRunner.Then("the Name property should be of type String and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Integers should be translated to decimals when only ValueToDecimal delegate is us" +
            "ed")]
        public virtual void IntegersShouldBeTranslatedToDecimalsWhenOnlyValueToDecimalDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Integers should be translated to decimals when only ValueToDecimal delegate is us" +
                    "ed", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Age"});
            table9.AddRow(new string[] {
                        "39"});
#line 55
 testRunner.When("I create a dynamic instance with only ValueToDecimal delegate from this table", ((string)(null)), table9, "When ");
#line 58
 testRunner.Then("the Age property should be of type Decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Doubles should be translated to decimals when only ValueToDecimal delegate is use" +
            "d")]
        public virtual void DoublesShouldBeTranslatedToDecimalsWhenOnlyValueToDecimalDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Doubles should be translated to decimals when only ValueToDecimal delegate is use" +
                    "d", ((string[])(null)));
#line 60
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Length in meters"});
            table10.AddRow(new string[] {
                        "1.96"});
#line 61
 testRunner.When("I create a dynamic instance with only ValueToDecimal delegate from this table", ((string)(null)), table10, "When ");
#line 64
 testRunner.Then("the LengthInMeters property should be of type Decimal and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Decimals should be translated to decimals when only ValueToDecimal delegate is us" +
            "ed")]
        public virtual void DecimalsShouldBeTranslatedToDecimalsWhenOnlyValueToDecimalDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Decimals should be translated to decimals when only ValueToDecimal delegate is us" +
                    "ed", ((string[])(null)));
#line 66
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Molecular Weight"});
            table11.AddRow(new string[] {
                        "1000000000.1111991111"});
#line 67
 testRunner.When("I create a dynamic instance with only ValueToDecimal delegate from this table", ((string)(null)), table11, "When ");
#line 70
 testRunner.Then("the MolecularWeight property should be of type Decimal and equal 1000000000.11119" +
                    "91111", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dates should fall back to being translated to date times when only ValueToDecimal" +
            " delegate is used")]
        public virtual void DatesShouldFallBackToBeingTranslatedToDateTimesWhenOnlyValueToDecimalDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dates should fall back to being translated to date times when only ValueToDecimal" +
                    " delegate is used", ((string[])(null)));
#line 72
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Birth date"});
            table12.AddRow(new string[] {
                        "1972-10-09"});
#line 73
 testRunner.When("I create a dynamic instance with only ValueToDecimal delegate from this table", ((string)(null)), table12, "When ");
#line 76
 testRunner.Then("the BirthDate property should be of type DateTime and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bools should fall back to being translated translated to bools when only ValueToD" +
            "ecimal delegate is used")]
        public virtual void BoolsShouldFallBackToBeingTranslatedTranslatedToBoolsWhenOnlyValueToDecimalDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bools should fall back to being translated translated to bools when only ValueToD" +
                    "ecimal delegate is used", ((string[])(null)));
#line 78
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Is developer"});
            table13.AddRow(new string[] {
                        "false"});
#line 79
 testRunner.When("I create a dynamic instance with only ValueToDecimal delegate from this table", ((string)(null)), table13, "When ");
#line 82
 testRunner.Then("the IsDeveloper property should be of type Boolean and equal false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A strange double should be translated to decimal when only ValueToDecimal delegat" +
            "e is used")]
        public virtual void AStrangeDoubleShouldBeTranslatedToDecimalWhenOnlyValueToDecimalDelegateIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A strange double should be translated to decimal when only ValueToDecimal delegat" +
                    "e is used", ((string[])(null)));
#line 84
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Length in meters"});
            table14.AddRow(new string[] {
                        "4.567"});
#line 85
 testRunner.When("I create a dynamic instance with only ValueToDecimal delegate from this table", ((string)(null)), table14, "When ");
#line 88
 testRunner.Then("the LengthInMeters property should be of type Decimal and equal 4.567", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Strings should be translated to strings when ValueToDecimal and ValueToString del" +
            "egates are used")]
        public virtual void StringsShouldBeTranslatedToStringsWhenValueToDecimalAndValueToStringDelegatesAreUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Strings should be translated to strings when ValueToDecimal and ValueToString del" +
                    "egates are used", ((string[])(null)));
#line 90
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table15.AddRow(new string[] {
                        "Marcus"});
#line 91
 testRunner.When("I create a dynamic instance with delegates ValueToDecimal, ValueToString from thi" +
                    "s table", ((string)(null)), table15, "When ");
#line 94
 testRunner.Then("the Name property should be of type String and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Integers should be translated to decimals when ValueToDecimal and ValueToString d" +
            "elegates are used")]
        public virtual void IntegersShouldBeTranslatedToDecimalsWhenValueToDecimalAndValueToStringDelegatesAreUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Integers should be translated to decimals when ValueToDecimal and ValueToString d" +
                    "elegates are used", ((string[])(null)));
#line 96
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Age"});
            table16.AddRow(new string[] {
                        "39"});
#line 97
 testRunner.When("I create a dynamic instance with delegates ValueToDecimal, ValueToString from thi" +
                    "s table", ((string)(null)), table16, "When ");
#line 100
 testRunner.Then("the Age property should be of type Decimal and equal 39.00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Doubles should be translated to decimals when ValueToDecimal and ValueToString de" +
            "legates are used")]
        public virtual void DoublesShouldBeTranslatedToDecimalsWhenValueToDecimalAndValueToStringDelegatesAreUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Doubles should be translated to decimals when ValueToDecimal and ValueToString de" +
                    "legates are used", ((string[])(null)));
#line 102
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Length in meters"});
            table17.AddRow(new string[] {
                        "1.96"});
#line 103
 testRunner.When("I create a dynamic instance with delegates ValueToDecimal, ValueToString from thi" +
                    "s table", ((string)(null)), table17, "When ");
#line 106
 testRunner.Then("the LengthInMeters property should be of type Decimal and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Decimals should be translated to decimals when ValueToDecimal and ValueToString d" +
            "elegates are used")]
        public virtual void DecimalsShouldBeTranslatedToDecimalsWhenValueToDecimalAndValueToStringDelegatesAreUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Decimals should be translated to decimals when ValueToDecimal and ValueToString d" +
                    "elegates are used", ((string[])(null)));
#line 108
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Molecular Weight"});
            table18.AddRow(new string[] {
                        "1000000000.1111991111"});
#line 109
 testRunner.When("I create a dynamic instance with delegates ValueToDecimal, ValueToString from thi" +
                    "s table", ((string)(null)), table18, "When ");
#line 112
 testRunner.Then("the MolecularWeight property should be of type Decimal and equal 1000000000.11119" +
                    "91111", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dates should be translated to strings when ValueToDecimal and ValueToString deleg" +
            "ates are used")]
        public virtual void DatesShouldBeTranslatedToStringsWhenValueToDecimalAndValueToStringDelegatesAreUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dates should be translated to strings when ValueToDecimal and ValueToString deleg" +
                    "ates are used", ((string[])(null)));
#line 114
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Birth date"});
            table19.AddRow(new string[] {
                        "1972-10-09"});
#line 115
 testRunner.When("I create a dynamic instance with delegates ValueToDecimal, ValueToString from thi" +
                    "s table", ((string)(null)), table19, "When ");
#line 118
 testRunner.Then("the BirthDate property should be of type String and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bools should be translated to strings when ValueToDecimal and ValueToString deleg" +
            "ates are used")]
        public virtual void BoolsShouldBeTranslatedToStringsWhenValueToDecimalAndValueToStringDelegatesAreUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bools should be translated to strings when ValueToDecimal and ValueToString deleg" +
                    "ates are used", ((string[])(null)));
#line 120
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Is developer"});
            table20.AddRow(new string[] {
                        "false"});
#line 121
 testRunner.When("I create a dynamic instance with delegates ValueToDecimal, ValueToString from thi" +
                    "s table", ((string)(null)), table20, "When ");
#line 124
 testRunner.Then("the IsDeveloper property should be of type String and equal false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A strange double should be translated to decimal when ValueToDecimal and ValueToS" +
            "tring delegates are used")]
        public virtual void AStrangeDoubleShouldBeTranslatedToDecimalWhenValueToDecimalAndValueToStringDelegatesAreUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A strange double should be translated to decimal when ValueToDecimal and ValueToS" +
                    "tring delegates are used", ((string[])(null)));
#line 126
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Length in meters"});
            table21.AddRow(new string[] {
                        "4.567"});
#line 127
 testRunner.When("I create a dynamic instance with delegates ValueToDecimal, ValueToString from thi" +
                    "s table", ((string)(null)), table21, "When ");
#line 130
 testRunner.Then("the LengthInMeters property should be of type Decimal and equal 4.567", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
