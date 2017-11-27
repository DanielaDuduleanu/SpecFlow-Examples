﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Bowling.SpecFlow.Bindings.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ScoreCalculationFeature : Xunit.IClassFixture<ScoreCalculationFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ScoreCalculationFeature.feature"
#line hidden
        
        public ScoreCalculationFeature(ScoreCalculationFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Score Calculation", "  In order to know my performance\r\n  As a player\r\n  I want the system to calculat" +
                    "e my total score", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Gutter game")]
        [Xunit.TraitAttribute("FeatureTitle", "Score Calculation")]
        [Xunit.TraitAttribute("Description", "Gutter game")]
        public virtual void GutterGame()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Gutter game", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
  testRunner.Given("a new bowling game", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
  testRunner.When("all of my balls are landing in the gutter", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
  testRunner.Then("my total score should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Beginners game")]
        [Xunit.TraitAttribute("FeatureTitle", "Score Calculation")]
        [Xunit.TraitAttribute("Description", "Beginners game")]
        public virtual void BeginnersGame()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Beginners game", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
  testRunner.Given("a new bowling game", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
  testRunner.When("I roll 2 and 7", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
  testRunner.And("I roll 3 and 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
  testRunner.And("I roll 8 times 1 and 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
  testRunner.Then("my total score should be 32", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Another beginners game")]
        [Xunit.TraitAttribute("FeatureTitle", "Score Calculation")]
        [Xunit.TraitAttribute("Description", "Another beginners game")]
        public virtual void AnotherBeginnersGame()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Another beginners game", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
  testRunner.Given("a new bowling game", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
  testRunner.When("I roll the following series:\t2,7,3,4,1,1,5,1,1,1,1,1,1,1,1,1,1,1,5,1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
  testRunner.Then("my total score should be 40", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="All Strikes")]
        [Xunit.TraitAttribute("FeatureTitle", "Score Calculation")]
        [Xunit.TraitAttribute("Description", "All Strikes")]
        public virtual void AllStrikes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All Strikes", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
  testRunner.Given("a new bowling game", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
  testRunner.When("all of my rolls are strikes", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
  testRunner.Then("my total score should be 300", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="One single spare")]
        [Xunit.TraitAttribute("FeatureTitle", "Score Calculation")]
        [Xunit.TraitAttribute("Description", "One single spare")]
        public virtual void OneSingleSpare()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("One single spare", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
   testRunner.Given("a new bowling game", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
   testRunner.When("I roll the following series: 2,8,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
   testRunner.Then("my total score should be 29", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="All spares")]
        [Xunit.TraitAttribute("FeatureTitle", "Score Calculation")]
        [Xunit.TraitAttribute("Description", "All spares")]
        public virtual void AllSpares()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All spares", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 34
  testRunner.Given("a new bowling game", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
  testRunner.When("I roll 10 times 1 and 9", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
  testRunner.And("I roll 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
  testRunner.Then("my total score should be 110", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ScoreCalculationFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ScoreCalculationFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
