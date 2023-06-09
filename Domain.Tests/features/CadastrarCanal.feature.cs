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
namespace Domain.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class GerenciarCanaisDeComunicacaoFeature : object, Xunit.IClassFixture<GerenciarCanaisDeComunicacaoFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CadastrarCanal.feature"
#line hidden
        
        public GerenciarCanaisDeComunicacaoFeature(GerenciarCanaisDeComunicacaoFeature.FixtureData fixtureData, Domain_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "features", "Gerenciar canais de comunicação", "  Como usuário do sistema\r\n  Eu quero cadastrar um novo canal de comunicação espe" +
                    "cificando o seu tipo\r\n  video ou audio", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Cadastrar novo canal de video ou audio")]
        [Xunit.TraitAttribute("FeatureTitle", "Gerenciar canais de comunicação")]
        [Xunit.TraitAttribute("Description", "Cadastrar novo canal de video ou audio")]
        public void CadastrarNovoCanalDeVideoOuAudio()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Cadastrar novo canal de video ou audio", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
    testRunner.Given("que preciso cadastrar um canal de audio ou video", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 10
    testRunner.When("preencho o campo Nome com \"Canal de Video\" e o tipo como 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
#line 11
    testRunner.And("recebo os dados preenchidos pela tela", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 12
    testRunner.Then("cadastro um novo Canal de video", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
#line 13
    testRunner.And("o canal \"Canal de Video\" aparece na listagem de canais cadastrados", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                GerenciarCanaisDeComunicacaoFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                GerenciarCanaisDeComunicacaoFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
