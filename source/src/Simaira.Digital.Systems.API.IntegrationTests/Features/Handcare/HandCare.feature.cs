﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Simaira.Digital.Systems.API.IntegrationTests.Features.Handcare
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class HandCareFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = new string[] {
                "TestSuite_Simaira.Digital",
                "HandCare"};
        
#line 1 "HandCare.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Handcare", "Hand Care", "\tThe tests verify Hand Care location data.\r\n\tThis includes:\r\n\t1. OverallPerforman" +
                    "ce Pulse Check\r\n\t2. ShiftLevelPerformance\r\n\t3. DispenserLevelPerformance", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Hand Care")))
            {
                global::Simaira.Digital.Systems.API.IntegrationTests.Features.Handcare.HandCareFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 10
#line hidden
#line 11
testRunner.Given("Get aligned CDM Sites and Accounts for \'ecolab3dcorptest1@mailinator.com\' from CD" +
                    "M API for Hand Care", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "AccountNumber"});
#line 12
 testRunner.And("Set User Accounts", ((string)(null)), table4, "And ");
#line hidden
#line 14
 testRunner.And("Set Service Areas and Devices for Accounts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "AccountNumber"});
#line 15
 testRunner.And("Set Account Info", ((string)(null)), table5, "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simaira.Digital_API Get Hand Care Overall Performance Pulse Check")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Hand Care")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("TestSuite_Simaira.Digital")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("HandCare")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("HandCareOverallPerformancePulseCheck")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Integrationtest")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Simaira.DigitalIntegrationtest")]
        public void Simaira_Digital_APIGetHandCareOverallPerformancePulseCheck()
        {
            string[] tagsOfScenario = new string[] {
                    "HandCareOverallPerformancePulseCheck",
                    "Integrationtest",
                    "Simaira.DigitalIntegrationtest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simaira.Digital_API Get Hand Care Overall Performance Pulse Check", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 22
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
this.FeatureBackground();
#line hidden
#line 23
 testRunner.Given("Hand Care Overall Performance Request Payload", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 24
 testRunner.Then("Get Hand Care Overall Performance for Pulse Check \'true\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Simaira.Digital_API Get Hand Care Overall Performance For All CDMSite Locations")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Hand Care")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("TestSuite_Simaira.Digital")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("HandCare")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("HandCareOverallPerformanceForAllCDMSiteLocation")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Integrationtest")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Simaira.DigitalIntegrationtest")]
        public void Simaira_Digital_APIGetHandCareOverallPerformanceForAllCDMSiteLocations()
        {
            string[] tagsOfScenario = new string[] {
                    "HandCareOverallPerformanceForAllCDMSiteLocation",
                    "Integrationtest",
                    "Simaira.DigitalIntegrationtest"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Simaira.Digital_API Get Hand Care Overall Performance For All CDMSite Locations", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
this.FeatureBackground();
#line hidden
#line 31
 testRunner.Given("Hand Care Overall Performance Request Payload", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
 testRunner.Then("Get Hand Care Overall Performance for Pulse Check \'false\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
