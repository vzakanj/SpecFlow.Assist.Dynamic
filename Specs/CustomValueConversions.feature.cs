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
    [NUnit.Framework.DescriptionAttribute("Custom value conversion")]
    public partial class CustomValueConversionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CustomValueConversions.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Custom value conversion", "In order to easier compare values of types\r\nAs a user of SpecFlow Dynamic\r\nI want" +
                    " to specify custom logic for converting strings into types", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Strings should be translated to strings when only ValueToString converter is used" +
            "")]
        public virtual void StringsShouldBeTranslatedToStringsWhenOnlyValueToStringConverterIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Strings should be translated to strings when only ValueToString converter is used" +
                    "", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table1.AddRow(new string[] {
                        "Marcus"});
#line 7
 testRunner.When("I create a dynamic instance with only ValueToString converter from this table", ((string)(null)), table1, "When ");
#line 10
 testRunner.Then("the Name property should be of type String and equal Marcus", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Integers should be translated to strings when only ValueToString converter is use" +
            "d")]
        public virtual void IntegersShouldBeTranslatedToStringsWhenOnlyValueToStringConverterIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Integers should be translated to strings when only ValueToString converter is use" +
                    "d", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Age"});
            table2.AddRow(new string[] {
                        "39"});
#line 13
 testRunner.When("I create a dynamic instance with only ValueToString converter from this table", ((string)(null)), table2, "When ");
#line 16
 testRunner.Then("the Age property should be of type String and equal 39", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Doubles should be translated to strings when only ValueToString converter is used" +
            "")]
        public virtual void DoublesShouldBeTranslatedToStringsWhenOnlyValueToStringConverterIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Doubles should be translated to strings when only ValueToString converter is used" +
                    "", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Length in meters"});
            table3.AddRow(new string[] {
                        "1.96"});
#line 19
 testRunner.When("I create a dynamic instance with only ValueToString converter from this table", ((string)(null)), table3, "When ");
#line 22
 testRunner.Then("the LengthInMeters property should be of type String and equal 1.96", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Decimals should be translated to strings when only ValueToString converter is use" +
            "d")]
        public virtual void DecimalsShouldBeTranslatedToStringsWhenOnlyValueToStringConverterIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Decimals should be translated to strings when only ValueToString converter is use" +
                    "d", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Molecular Weight"});
            table4.AddRow(new string[] {
                        "1000000000.1111991111"});
#line 25
 testRunner.When("I create a dynamic instance with only ValueToString converter from this table", ((string)(null)), table4, "When ");
#line 28
 testRunner.Then("the MolecularWeight property should be of type String and equal 1000000000.111199" +
                    "1111", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Dates should be translated to strings when only ValueToString converter is used")]
        public virtual void DatesShouldBeTranslatedToStringsWhenOnlyValueToStringConverterIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Dates should be translated to strings when only ValueToString converter is used", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Birth date"});
            table5.AddRow(new string[] {
                        "1972-10-09"});
#line 31
 testRunner.When("I create a dynamic instance with only ValueToString converter from this table", ((string)(null)), table5, "When ");
#line 34
 testRunner.Then("the BirthDate property should be of type String and equal 1972-10-09", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Bools should be translated to strings when only ValueToString converter is used")]
        public virtual void BoolsShouldBeTranslatedToStringsWhenOnlyValueToStringConverterIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Bools should be translated to strings when only ValueToString converter is used", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Is developer"});
            table6.AddRow(new string[] {
                        "false"});
#line 37
 testRunner.When("I create a dynamic instance with only ValueToString converter from this table", ((string)(null)), table6, "When ");
#line 40
 testRunner.Then("the IsDeveloper property should be of type String and equal false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A strange double should be translated to string shen only ValueToString converter" +
            " is used")]
        public virtual void AStrangeDoubleShouldBeTranslatedToStringShenOnlyValueToStringConverterIsUsed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A strange double should be translated to string shen only ValueToString converter" +
                    " is used", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Length in meters"});
            table7.AddRow(new string[] {
                        "4.567"});
#line 43
 testRunner.When("I create a dynamic instance with only ValueToString converter from this table", ((string)(null)), table7, "When ");
#line 46
 testRunner.Then("the LengthInMeters property should be of type String and equal 4.567", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion