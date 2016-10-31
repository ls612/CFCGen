﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using CivGen.Controls;
using System.Data.Entity;
using System.Diagnostics;
using System.Collections;

namespace CivGen
{
    public partial class Host : Form
    {
        /// <summary>
        /// Host Class.  Creates and manages the GameplayEntities instance.
        /// </summary>


        ///  --  Object clean-up list (added to dispose())--
        ///  Entities

        #region List Declarations
        public List<Adjacency_YieldChanges> adjacency_yieldchanges = null;
        public List<Agenda> agendas = null;
        public List<AiBuildSpecialization> aibuildspecializations = null;
        public List<AiEvent> aievents = null;
        public List<AiFavoredItem> aifavoreditems = null;
        public List<AiList> ailists = null;
        public List<AiListType> ailisttypes = null;
        public List<AiOperationDef> aioperationdefs = null;
        public List<AiOperationLimit> aioperationlimits = null;
        public List<AiOperationList> aioperationlists = null;
        public List<AiOperationTeam> aioperationteams = null;
        public List<AiOperationType> aioperationtypes = null;
        public List<AiTeam> aiteams = null;
        public List<AllowedMove> allowedmoves = null;
        public List<AllowedOperation> allowedoperations = null;
        public List<AppealHousingChanx> appealhousingchanges = null;
        public List<BarbarianTribeName> barbariantribenames = null;
        public List<BarbarianTribe> barbariantribes = null;
        public List<BehaviorTreeNode> behaviortreenodes = null;
        public List<BehaviorTree> behaviortrees = null;
        public List<BeliefClass> beliefclasses = null;
        public List<BeliefModifier> beliefmodifiers = null;
        public List<Belief> beliefs = null;
        public List<BonusMinorStartingUnit> bonusminorstartingunits = null;
        public List<BoostHandler> boosthandlers = null;
        public List<BoostName> boostnames = null;
        public List<Boost> boosts = null;
        public List<Building_GreatPersonPoints> building_greatpersonpoints = null;
        public List<Building_GreatWorks> building_greatworks = null;
        public List<Building_YieldChanges> building_yieldchanges = null;
        public List<Building_YieldDistrictCopies> building_yielddistrictcopies = null;
        public List<BuildingModifier> buildingmodifiers = null;
        public List<Building> buildings = null;
        public List<CityEvent> cityevents = null;
        public List<CityName> citynames = null;
        public List<CivicModifier> civicmodifiers = null;
        public List<CivicQuote> civicquotes = null;
        public List<Civic> civics = null;
        public List<CivilizationCitizenName> civilizationcitizennames = null;
        public List<CivilizationInfo> civilizationinfoes = null;
        public List<CivilizationLeader> civilizationleaders = null;
        public List<CivilizationLevel> civilizationlevels = null;
        public List<Civilization> civilizations = null;
        public List<CivilopediaPageGroupQuery> civilopediapagegroupqueries = null;
        public List<CivilopediaPageGroup> civilopediapagegroups = null;
        public List<CivilopediaPageLayoutChapter> civilopediapagelayoutchapters = null;
        public List<CivilopediaPageLayout> civilopediapagelayouts = null;
        public List<CivilopediaPageQuery> civilopediapagequeries = null;
        public List<CivilopediaPage> civilopediapages = null;
        public List<CivilopediaSection> civilopediasections = null;
        public List<Color> colors = null;
        public List<Continent> continents = null;
        public List<DataType> datatypes = null;
        public List<DealItem> dealitems = null;
        public List<Defeat> defeats = null;
        public List<Difficulty> difficulties = null;
        public List<District_CitizenGreatPersonPoints> district_citizengreatpersonpoints = null;
        public List<District_CitizenYieldChanges> district_citizenyieldchanges = null;
        public List<District_GreatPersonPoints> district_greatpersonpoints = null;
        public List<District_TradeRouteYields> district_traderouteyields = null;
        public List<DistrictModifier> districtmodifiers = null;
        public List<District> districts = null;
        public List<DynamicModifier> dynamicmodifiers = null;
        public List<Era> eras = null;
        public List<FavoredReligion> favoredreligions = null;
        public List<Feature_AdjacentYields> feature_adjacentyields = null;
        public List<Feature_Removes> feature_removes = null;
        public List<Feature_YieldChanges> feature_yieldchanges = null;
        public List<Feature> features = null;
        public List<Flavor> flavors = null;
        public List<GameModifier> gamemodifiers = null;
        public List<GameSpeed_Turns> gamespeed_turns = null;
        public List<GameSpeed> gamespeeds = null;
        public List<GlobalParameter> globalparameters = null;
        public List<GoodyHut> goodyhuts = null;
        public List<GoodyHutSubType> goodyhutsubtypes = null;
        public List<Gossip> gossips = null;
        public List<Government_SlotCounts> government_slotcounts = null;
        public List<GovernmentBonusName> governmentbonusnames = null;
        public List<GovernmentModifier> governmentmodifiers = null;
        public List<Government> governments = null;
        public List<GovernmentSlot> governmentslots = null;
        public List<GreatPersonClass> greatpersonclasses = null;
        public List<GreatPersonIndividualActionModifier> greatpersonindividualactionmodifiers = null;
        public List<GreatPersonIndividualBirthModifier> greatpersonindividualbirthmodifiers = null;
        public List<GreatPersonIndividual> greatpersonindividuals = null;
        public List<GreatWork_YieldChanges> greatwork_yieldchanges = null;
        public List<GreatWorkObjectType> greatworkobjecttypes = null;
        public List<GreatWork> greatworks = null;
        public List<GreatWorkSlotType> greatworkslottypes = null;
        public List<Happiness> happinesses = null;
        public List<HistoricRanking> historicrankings = null;
        public List<Improvement_BonusYieldChanges> improvement_bonusyieldchanges = null;
        public List<Improvement_Tourism> improvement_tourism = null;
        public List<Improvement_ValidResources> improvement_validresources = null;
        public List<Improvement_ValidTerrains> improvement_validterrains = null;
        public List<Improvement_YieldChanges> improvement_yieldchanges = null;
        public List<ImprovementModifier> improvementmodifiers = null;
        public List<Improvement> improvements = null;
        public List<InterfaceMode> interfacemodes = null;
        public List<Kind> kinds = null;
        public List<LeaderAnimation> leaderanimations = null;
        public List<LeaderInfo> leaderinfoes = null;
        public List<LeaderQuote> leaderquotes = null;
        public List<Leader> leaders = null;
        public List<MajorStartingUnit> majorstartingunits = null;
        public List<Map_GreatPersonClasses> map_greatpersonclasses = null;
        public List<Map> maps = null;
        public List<ModifierArgument> modifierarguments = null;
        public List<Modifier> modifiers = null;
        public List<ModifierString> modifierstrings = null;
        public List<Month> months = null;
        public List<NavigationProperty> navigationproperties = null;
        public List<NodeDataDefinition> nodedatadefinitions = null;
        public List<NodeDefinition> nodedefinitions = null;
        public List<Notification> notifications = null;
        public List<ObsoletePolicy> obsoletepolicies = null;
        public List<OpTeamRequirement> opteamrequirements = null;
        public List<PlayerColor> playercolors = null;
        public List<PlotEvalCondition> plotevalconditions = null;
        public List<Policy> policies = null;
        public List<PolicyModifier> policymodifiers = null;
        public List<Project_GreatPersonPoints> project_greatpersonpoints = null;
        public List<Project_YieldConversions> project_yieldconversions = null;
        public List<ProjectCompletionModifier> projectcompletionmodifiers = null;
        public List<ProjectPrereq> projectprereqs = null;
        public List<Project> projects = null;
        public List<PseudoYield> pseudoyields = null;
        public List<Quest> quests = null;
        public List<RandomAgenda> randomagendas = null;
        public List<Religion> religions = null;
        public List<RequirementArgument> requirementarguments = null;
        public List<Requirement> requirements = null;
        public List<RequirementSet> requirementsets = null;
        public List<RequirementString> requirementstrings = null;
        public List<Resource_Distribution> resource_distribution = null;
        public List<Resource_Harvests> resource_harvests = null;
        public List<Resource_TradeRouteYields> resource_traderouteyields = null;
        public List<Resource_YieldChanges> resource_yieldchanges = null;
        public List<Resource> resources = null;
        public List<Route> routes = null;
        public List<SavingType> savingtypes = null;
        public List<ScoringCategory> scoringcategories = null;
        public List<ScoringLineItem> scoringlineitems = null;
        public List<Season> seasons = null;
        public List<SettlementPreference> settlementpreferences = null;
        public List<ShapeDefinition> shapedefinitions = null;
        public List<StartBiasFeature> startbiasfeatures = null;
        public List<StartBiasResource> startbiasresources = null;
        public List<StartBiasRiver> startbiasrivers = null;
        public List<StartBiasTerrain> startbiasterrains = null;
        public List<StartEra> starteras = null;
        public List<StartingBuilding> startingbuildings = null;
        public List<StartingGovernment> startinggovernments = null;
        public List<Strategy> strategies = null;
        public List<Strategy_YieldPriorities> strategy_yieldpriorities = null;
        public List<StrategyCondition> strategyconditions = null;
        public List<Tag> tags = null;
        public List<TargetType> targettypes = null;
        public List<Technology> technologies = null;
        public List<TechnologyModifier> technologymodifiers = null;
        public List<TechnologyQuote> technologyquotes = null;
        public List<Terrain_YieldChanges> terrain_yieldchanges = null;
        public List<Terrain> terrains = null;
        public List<TraitModifier> traitmodifiers = null;
        public List<Trait> traits = null;
        public List<TreeData> treedatas = null;
        public List<TriggeredBehaviorTree> triggeredbehaviortrees = null;
        public List<TurnPhas> turnphases = null;
        public List<TurnSegment> turnsegments = null;
        public List<TurnTimer> turntimers = null;
        public List<TypeProperty> typeproperties = null;
        public List<Type> types = null;
        public List<Unit_BuildingPrereqs> unit_buildingprereqs = null;
        public List<Unit_RebellionTags> unit_rebelliontags = null;
        public List<UnitAbility> unitabilities = null;
        public List<UnitAiType> unitaitypes = null;
        public List<UnitCommand> unitcommands = null;
        public List<UnitFormationClass> unitformationclasses = null;
        public List<UnitName> unitnames = null;
        public List<UnitOperation> unitoperations = null;
        public List<Unit> units = null;
        public List<Victory> victories = null;
        public List<Visibility> visibilities = null;
        public List<Vocabulary> vocabularies = null;
        public List<WMD> wmds = null;
        public List<Yield> yields = null;
        #endregion

        public Dictionary<string, object> ModelClasses = new Dictionary<string, object>();

        public GameplayEntities Entities { get; set; } = null;
        private string DatabasePath { get; set; }


        public Host()
        {
            InitializeComponent();

            //Check the database path, and if found, create the entity.
            if (CheckDataBasePath())
            {
                Entities = new GameplayEntities(DataBaseConnectionString);
                LoadEntityList();
            }
            else
            {
                MessageBox.Show("Database not found.  Application will exit.");
                Application.Exit();
            }
        }


        #region EntityLoader
        private void LoadEntityList()
        {
            PropertyInfo[] properties = Entities.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            #region Code Writers
            //Uncomment this to generate the code... easier than using Reflection!
            /*
            PropertyInfo[] properties = Entities.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            Debug.WriteLine("-------------------Object Declarations-------------------");

            foreach (PropertyInfo property in properties)
            {
                object PropertyObject = property.GetValue(Entities, null);
                
                //If it is a class, add to the EntityList
                if (property.PropertyType.IsClass) 
                {
                    //Don't parse sub items of Char or String
                    if (property.PropertyType == typeof(char) || property.PropertyType == typeof(string)) continue;

                    //This is a terrible hack....
                    //  System.Data.Entity.DbSet
                    string type = PropertyObject.GetType().ToString();
                    if (type.Contains("System.Data.Entity.DbSet"))
                    {
                        string className = type.Substring(type.LastIndexOf('.') + 1);
                        className = className.Substring(0, className.Length - 1);
                        //Debug.WriteLine("public List<" + className + "> " + property.Name.ToLower() + " = null;");
                    }
                }
            }
            */
            /*
            Debug.WriteLine("-------------------Object Assignments-------------------");

            foreach (PropertyInfo property in properties)
            {
                object PropertyObject = property.GetValue(Entities, null);


                //If it is a class, add to the EntityList
                if (property.PropertyType.IsClass)
                {
                    //Don't parse sub items of Char or String
                    if (property.PropertyType == typeof(char) || property.PropertyType == typeof(string)) continue;

                    //Debug.WriteLine(property.Name.ToLower() + " = (Entities." + property.Name + ".Local.Count != 0) ? Entities." + property.Name + ".ToList() : null;");
                    Debug.WriteLine("try { " + property.Name.ToLower() + " = Entities." + property.Name + ".ToList();}catch{}");
                }
            }
            */

            /*
            Debug.WriteLine("-------------------Dictionary Populations-------------------");

            foreach (PropertyInfo property in properties)
            {
                object PropertyObject = property.GetValue(Entities, null);


                //If it is a class, add to the EntityList
                if (property.PropertyType.IsClass)
                {
                    //Don't parse sub items of Char or String
                    if (property.PropertyType == typeof(char) || property.PropertyType == typeof(string)) continue;

                    Debug.WriteLine("if(" + property.Name.ToLower() + " != null ) ModelClasses.Add(\"" + property.Name +"\" ," + property.Name.ToLower() + ");");
                }
            }

            */
            #endregion

            #region Populate Lists
            try { adjacency_yieldchanges = Entities.Adjacency_YieldChanges.ToList(); } catch { }
            try { agendas = Entities.Agendas.ToList(); } catch { }
            try { aibuildspecializations = Entities.AiBuildSpecializations.ToList(); } catch { }
            try { aievents = Entities.AiEvents.ToList(); } catch { }
            try { aifavoreditems = Entities.AiFavoredItems.ToList(); } catch { }
            try { ailists = Entities.AiLists.ToList(); } catch { }
            try { ailisttypes = Entities.AiListTypes.ToList(); } catch { }
            try { aioperationdefs = Entities.AiOperationDefs.ToList(); } catch { }
            try { aioperationlimits = Entities.AiOperationLimits.ToList(); } catch { }
            try { aioperationlists = Entities.AiOperationLists.ToList(); } catch { }
            try { aioperationteams = Entities.AiOperationTeams.ToList(); } catch { }
            try { aioperationtypes = Entities.AiOperationTypes.ToList(); } catch { }
            try { aiteams = Entities.AiTeams.ToList(); } catch { }
            try { allowedmoves = Entities.AllowedMoves.ToList(); } catch { }
            try { allowedoperations = Entities.AllowedOperations.ToList(); } catch { }
            try { appealhousingchanges = Entities.AppealHousingChanges.ToList(); } catch { }
            try { barbariantribenames = Entities.BarbarianTribeNames.ToList(); } catch { }
            try { barbariantribes = Entities.BarbarianTribes.ToList(); } catch { }
            try { behaviortreenodes = Entities.BehaviorTreeNodes.ToList(); } catch { }
            try { behaviortrees = Entities.BehaviorTrees.ToList(); } catch { }
            try { beliefclasses = Entities.BeliefClasses.ToList(); } catch { }
            try { beliefmodifiers = Entities.BeliefModifiers.ToList(); } catch { }
            try { beliefs = Entities.Beliefs.ToList(); } catch { }
            try { bonusminorstartingunits = Entities.BonusMinorStartingUnits.ToList(); } catch { }
            try { boosthandlers = Entities.BoostHandlers.ToList(); } catch { }
            try { boostnames = Entities.BoostNames.ToList(); } catch { }
            try { boosts = Entities.Boosts.ToList(); } catch { }
            try { building_greatpersonpoints = Entities.Building_GreatPersonPoints.ToList(); } catch { }
            try { building_greatworks = Entities.Building_GreatWorks.ToList(); } catch { }
            try { building_yieldchanges = Entities.Building_YieldChanges.ToList(); } catch { }
            try { building_yielddistrictcopies = Entities.Building_YieldDistrictCopies.ToList(); } catch { }
            try { buildingmodifiers = Entities.BuildingModifiers.ToList(); } catch { }
            try { buildings = Entities.Buildings.ToList(); } catch { }
            try { cityevents = Entities.CityEvents.ToList(); } catch { }
            try { citynames = Entities.CityNames.ToList(); } catch { }
            try { civicmodifiers = Entities.CivicModifiers.ToList(); } catch { }
            try { civicquotes = Entities.CivicQuotes.ToList(); } catch { }
            try { civics = Entities.Civics.ToList(); } catch { }
            try { civilizationcitizennames = Entities.CivilizationCitizenNames.ToList(); } catch { }
            try { civilizationinfoes = Entities.CivilizationInfoes.ToList(); } catch { }
            try { civilizationleaders = Entities.CivilizationLeaders.ToList(); } catch { }
            try { civilizationlevels = Entities.CivilizationLevels.ToList(); } catch { }
            try { civilizations = Entities.Civilizations.ToList(); } catch { }
            try { civilopediapagegroupqueries = Entities.CivilopediaPageGroupQueries.ToList(); } catch { }
            try { civilopediapagegroups = Entities.CivilopediaPageGroups.ToList(); } catch { }
            try { civilopediapagelayoutchapters = Entities.CivilopediaPageLayoutChapters.ToList(); } catch { }
            try { civilopediapagelayouts = Entities.CivilopediaPageLayouts.ToList(); } catch { }
            try { civilopediapagequeries = Entities.CivilopediaPageQueries.ToList(); } catch { }
            try { civilopediapages = Entities.CivilopediaPages.ToList(); } catch { }
            try { civilopediasections = Entities.CivilopediaSections.ToList(); } catch { }
            try { colors = Entities.Colors.ToList(); } catch { }
            try { continents = Entities.Continents.ToList(); } catch { }
            try { datatypes = Entities.DataTypes.ToList(); } catch { }
            try { dealitems = Entities.DealItems.ToList(); } catch { }
            try { defeats = Entities.Defeats.ToList(); } catch { }
            try { difficulties = Entities.Difficulties.ToList(); } catch { }
            try { district_citizengreatpersonpoints = Entities.District_CitizenGreatPersonPoints.ToList(); } catch { }
            try { district_citizenyieldchanges = Entities.District_CitizenYieldChanges.ToList(); } catch { }
            try { district_greatpersonpoints = Entities.District_GreatPersonPoints.ToList(); } catch { }
            try { district_traderouteyields = Entities.District_TradeRouteYields.ToList(); } catch { }
            try { districtmodifiers = Entities.DistrictModifiers.ToList(); } catch { }
            try { districts = Entities.Districts.ToList(); } catch { }
            try { dynamicmodifiers = Entities.DynamicModifiers.ToList(); } catch { }
            try { eras = Entities.Eras.ToList(); } catch { }
            try { favoredreligions = Entities.FavoredReligions.ToList(); } catch { }
            try { feature_adjacentyields = Entities.Feature_AdjacentYields.ToList(); } catch { }
            try { feature_removes = Entities.Feature_Removes.ToList(); } catch { }
            try { feature_yieldchanges = Entities.Feature_YieldChanges.ToList(); } catch { }
            try { features = Entities.Features.ToList(); } catch { }
            try { flavors = Entities.Flavors.ToList(); } catch { }
            try { gamemodifiers = Entities.GameModifiers.ToList(); } catch { }
            try { gamespeed_turns = Entities.GameSpeed_Turns.ToList(); } catch { }
            try { gamespeeds = Entities.GameSpeeds.ToList(); } catch { }
            try { globalparameters = Entities.GlobalParameters.ToList(); } catch { }
            try { goodyhuts = Entities.GoodyHuts.ToList(); } catch { }
            try { goodyhutsubtypes = Entities.GoodyHutSubTypes.ToList(); } catch { }
            try { gossips = Entities.Gossips.ToList(); } catch { }
            try { government_slotcounts = Entities.Government_SlotCounts.ToList(); } catch { }
            try { governmentbonusnames = Entities.GovernmentBonusNames.ToList(); } catch { }
            try { governmentmodifiers = Entities.GovernmentModifiers.ToList(); } catch { }
            try { governments = Entities.Governments.ToList(); } catch { }
            try { governmentslots = Entities.GovernmentSlots.ToList(); } catch { }
            try { greatpersonclasses = Entities.GreatPersonClasses.ToList(); } catch { }
            try { greatpersonindividualactionmodifiers = Entities.GreatPersonIndividualActionModifiers.ToList(); } catch { }
            try { greatpersonindividualbirthmodifiers = Entities.GreatPersonIndividualBirthModifiers.ToList(); } catch { }
            try { greatpersonindividuals = Entities.GreatPersonIndividuals.ToList(); } catch { }
            try { greatwork_yieldchanges = Entities.GreatWork_YieldChanges.ToList(); } catch { }
            try { greatworkobjecttypes = Entities.GreatWorkObjectTypes.ToList(); } catch { }
            try { greatworks = Entities.GreatWorks.ToList(); } catch { }
            try { greatworkslottypes = Entities.GreatWorkSlotTypes.ToList(); } catch { }
            try { happinesses = Entities.Happinesses.ToList(); } catch { }
            try { historicrankings = Entities.HistoricRankings.ToList(); } catch { }
            try { improvement_bonusyieldchanges = Entities.Improvement_BonusYieldChanges.ToList(); } catch { }
            try { improvement_tourism = Entities.Improvement_Tourism.ToList(); } catch { }
            try { improvement_validresources = Entities.Improvement_ValidResources.ToList(); } catch { }
            try { improvement_validterrains = Entities.Improvement_ValidTerrains.ToList(); } catch { }
            try { improvement_yieldchanges = Entities.Improvement_YieldChanges.ToList(); } catch { }
            try { improvementmodifiers = Entities.ImprovementModifiers.ToList(); } catch { }
            try { improvements = Entities.Improvements.ToList(); } catch { }
            try { interfacemodes = Entities.InterfaceModes.ToList(); } catch { }
            try { kinds = Entities.Kinds.ToList(); } catch { }
            try { leaderanimations = Entities.LeaderAnimations.ToList(); } catch { }
            try { leaderinfoes = Entities.LeaderInfoes.ToList(); } catch { }
            try { leaderquotes = Entities.LeaderQuotes.ToList(); } catch { }
            try { leaders = Entities.Leaders.ToList(); } catch { }
            try { majorstartingunits = Entities.MajorStartingUnits.ToList(); } catch { }
            try { map_greatpersonclasses = Entities.Map_GreatPersonClasses.ToList(); } catch { }
            try { maps = Entities.Maps.ToList(); } catch { }
            try { modifierarguments = Entities.ModifierArguments.ToList(); } catch { }
            try { modifiers = Entities.Modifiers.ToList(); } catch { }
            try { modifierstrings = Entities.ModifierStrings.ToList(); } catch { }
            try { months = Entities.Months.ToList(); } catch { }
            try { navigationproperties = Entities.NavigationProperties.ToList(); } catch { }
            try { nodedatadefinitions = Entities.NodeDataDefinitions.ToList(); } catch { }
            try { nodedefinitions = Entities.NodeDefinitions.ToList(); } catch { }
            try { notifications = Entities.Notifications.ToList(); } catch { }
            try { obsoletepolicies = Entities.ObsoletePolicies.ToList(); } catch { }
            try { opteamrequirements = Entities.OpTeamRequirements.ToList(); } catch { }
            try { playercolors = Entities.PlayerColors.ToList(); } catch { }
            try { plotevalconditions = Entities.PlotEvalConditions.ToList(); } catch { }
            try { policies = Entities.Policies.ToList(); } catch { }
            try { policymodifiers = Entities.PolicyModifiers.ToList(); } catch { }
            try { project_greatpersonpoints = Entities.Project_GreatPersonPoints.ToList(); } catch { }
            try { project_yieldconversions = Entities.Project_YieldConversions.ToList(); } catch { }
            try { projectcompletionmodifiers = Entities.ProjectCompletionModifiers.ToList(); } catch { }
            try { projectprereqs = Entities.ProjectPrereqs.ToList(); } catch { }
            try { projects = Entities.Projects.ToList(); } catch { }
            try { pseudoyields = Entities.PseudoYields.ToList(); } catch { }
            try { quests = Entities.Quests.ToList(); } catch { }
            try { randomagendas = Entities.RandomAgendas.ToList(); } catch { }
            try { religions = Entities.Religions.ToList(); } catch { }
            try { requirementarguments = Entities.RequirementArguments.ToList(); } catch { }
            try { requirements = Entities.Requirements.ToList(); } catch { }
            try { requirementsets = Entities.RequirementSets.ToList(); } catch { }
            try { requirementstrings = Entities.RequirementStrings.ToList(); } catch { }
            try { resource_distribution = Entities.Resource_Distribution.ToList(); } catch { }
            try { resource_harvests = Entities.Resource_Harvests.ToList(); } catch { }
            try { resource_traderouteyields = Entities.Resource_TradeRouteYields.ToList(); } catch { }
            try { resource_yieldchanges = Entities.Resource_YieldChanges.ToList(); } catch { }
            try { resources = Entities.Resources.ToList(); } catch { }
            try { routes = Entities.Routes.ToList(); } catch { }
            try { savingtypes = Entities.SavingTypes.ToList(); } catch { }
            try { scoringcategories = Entities.ScoringCategories.ToList(); } catch { }
            try { scoringlineitems = Entities.ScoringLineItems.ToList(); } catch { }
            try { seasons = Entities.Seasons.ToList(); } catch { }
            try { settlementpreferences = Entities.SettlementPreferences.ToList(); } catch { }
            try { shapedefinitions = Entities.ShapeDefinitions.ToList(); } catch { }
            try { startbiasfeatures = Entities.StartBiasFeatures.ToList(); } catch { }
            try { startbiasresources = Entities.StartBiasResources.ToList(); } catch { }
            try { startbiasrivers = Entities.StartBiasRivers.ToList(); } catch { }
            try { startbiasterrains = Entities.StartBiasTerrains.ToList(); } catch { }
            try { starteras = Entities.StartEras.ToList(); } catch { }
            try { startingbuildings = Entities.StartingBuildings.ToList(); } catch { }
            try { startinggovernments = Entities.StartingGovernments.ToList(); } catch { }
            try { strategies = Entities.Strategies.ToList(); } catch { }
            try { strategy_yieldpriorities = Entities.Strategy_YieldPriorities.ToList(); } catch { }
            try { strategyconditions = Entities.StrategyConditions.ToList(); } catch { }
            try { tags = Entities.Tags.ToList(); } catch { }
            try { targettypes = Entities.TargetTypes.ToList(); } catch { }
            try { technologies = Entities.Technologies.ToList(); } catch { }
            try { technologymodifiers = Entities.TechnologyModifiers.ToList(); } catch { }
            try { technologyquotes = Entities.TechnologyQuotes.ToList(); } catch { }
            try { terrain_yieldchanges = Entities.Terrain_YieldChanges.ToList(); } catch { }
            try { terrains = Entities.Terrains.ToList(); } catch { }
            try { traitmodifiers = Entities.TraitModifiers.ToList(); } catch { }
            try { traits = Entities.Traits.ToList(); } catch { }
            try { treedatas = Entities.TreeDatas.ToList(); } catch { }
            try { triggeredbehaviortrees = Entities.TriggeredBehaviorTrees.ToList(); } catch { }
            try { turnphases = Entities.TurnPhases.ToList(); } catch { }
            try { turnsegments = Entities.TurnSegments.ToList(); } catch { }
            try { turntimers = Entities.TurnTimers.ToList(); } catch { }
            try { typeproperties = Entities.TypeProperties.ToList(); } catch { }
            try { types = Entities.Types.ToList(); } catch { }
            try { unit_buildingprereqs = Entities.Unit_BuildingPrereqs.ToList(); } catch { }
            try { unit_rebelliontags = Entities.Unit_RebellionTags.ToList(); } catch { }
            try { unitabilities = Entities.UnitAbilities.ToList(); } catch { }
            try { unitaitypes = Entities.UnitAiTypes.ToList(); } catch { }
            try { unitcommands = Entities.UnitCommands.ToList(); } catch { }
            try { unitformationclasses = Entities.UnitFormationClasses.ToList(); } catch { }
            try { unitnames = Entities.UnitNames.ToList(); } catch { }
            try { unitoperations = Entities.UnitOperations.ToList(); } catch { }
            try { units = Entities.Units.ToList(); } catch { }
            try { victories = Entities.Victories.ToList(); } catch { }
            try { visibilities = Entities.Visibilities.ToList(); } catch { }
            try { vocabularies = Entities.Vocabularies.ToList(); } catch { }
            try { wmds = Entities.WMDs.ToList(); } catch { }
            try { yields = Entities.Yields.ToList(); } catch { }
            #endregion

            #region Load into Dictionary

            if (adjacency_yieldchanges != null) ModelClasses.Add("Adjacency_YieldChanges", adjacency_yieldchanges);
            if (agendas != null) ModelClasses.Add("Agendas", agendas);
            if (aibuildspecializations != null) ModelClasses.Add("AiBuildSpecializations", aibuildspecializations);
            if (aievents != null) ModelClasses.Add("AiEvents", aievents);
            if (aifavoreditems != null) ModelClasses.Add("AiFavoredItems", aifavoreditems);
            if (ailists != null) ModelClasses.Add("AiLists", ailists);
            if (ailisttypes != null) ModelClasses.Add("AiListTypes", ailisttypes);
            if (aioperationdefs != null) ModelClasses.Add("AiOperationDefs", aioperationdefs);
            if (aioperationlimits != null) ModelClasses.Add("AiOperationLimits", aioperationlimits);
            if (aioperationlists != null) ModelClasses.Add("AiOperationLists", aioperationlists);
            if (aioperationteams != null) ModelClasses.Add("AiOperationTeams", aioperationteams);
            if (aioperationtypes != null) ModelClasses.Add("AiOperationTypes", aioperationtypes);
            if (aiteams != null) ModelClasses.Add("AiTeams", aiteams);
            if (allowedmoves != null) ModelClasses.Add("AllowedMoves", allowedmoves);
            if (allowedoperations != null) ModelClasses.Add("AllowedOperations", allowedoperations);
            if (appealhousingchanges != null) ModelClasses.Add("AppealHousingChanges", appealhousingchanges);
            if (barbariantribenames != null) ModelClasses.Add("BarbarianTribeNames", barbariantribenames);
            if (barbariantribes != null) ModelClasses.Add("BarbarianTribes", barbariantribes);
            if (behaviortreenodes != null) ModelClasses.Add("BehaviorTreeNodes", behaviortreenodes);
            if (behaviortrees != null) ModelClasses.Add("BehaviorTrees", behaviortrees);
            if (beliefclasses != null) ModelClasses.Add("BeliefClasses", beliefclasses);
            if (beliefmodifiers != null) ModelClasses.Add("BeliefModifiers", beliefmodifiers);
            if (beliefs != null) ModelClasses.Add("Beliefs", beliefs);
            if (bonusminorstartingunits != null) ModelClasses.Add("BonusMinorStartingUnits", bonusminorstartingunits);
            if (boosthandlers != null) ModelClasses.Add("BoostHandlers", boosthandlers);
            if (boostnames != null) ModelClasses.Add("BoostNames", boostnames);
            if (boosts != null) ModelClasses.Add("Boosts", boosts);
            if (building_greatpersonpoints != null) ModelClasses.Add("Building_GreatPersonPoints", building_greatpersonpoints);
            if (building_greatworks != null) ModelClasses.Add("Building_GreatWorks", building_greatworks);
            if (building_yieldchanges != null) ModelClasses.Add("Building_YieldChanges", building_yieldchanges);
            if (building_yielddistrictcopies != null) ModelClasses.Add("Building_YieldDistrictCopies", building_yielddistrictcopies);
            if (buildingmodifiers != null) ModelClasses.Add("BuildingModifiers", buildingmodifiers);
            if (buildings != null) ModelClasses.Add("Buildings", buildings);
            if (cityevents != null) ModelClasses.Add("CityEvents", cityevents);
            if (citynames != null) ModelClasses.Add("CityNames", citynames);
            if (civicmodifiers != null) ModelClasses.Add("CivicModifiers", civicmodifiers);
            if (civicquotes != null) ModelClasses.Add("CivicQuotes", civicquotes);
            if (civics != null) ModelClasses.Add("Civics", civics);
            if (civilizationcitizennames != null) ModelClasses.Add("CivilizationCitizenNames", civilizationcitizennames);
            if (civilizationinfoes != null) ModelClasses.Add("CivilizationInfoes", civilizationinfoes);
            if (civilizationleaders != null) ModelClasses.Add("CivilizationLeaders", civilizationleaders);
            if (civilizationlevels != null) ModelClasses.Add("CivilizationLevels", civilizationlevels);
            if (civilizations != null) ModelClasses.Add("Civilizations", civilizations);
            if (civilopediapagegroupqueries != null) ModelClasses.Add("CivilopediaPageGroupQueries", civilopediapagegroupqueries);
            if (civilopediapagegroups != null) ModelClasses.Add("CivilopediaPageGroups", civilopediapagegroups);
            if (civilopediapagelayoutchapters != null) ModelClasses.Add("CivilopediaPageLayoutChapters", civilopediapagelayoutchapters);
            if (civilopediapagelayouts != null) ModelClasses.Add("CivilopediaPageLayouts", civilopediapagelayouts);
            if (civilopediapagequeries != null) ModelClasses.Add("CivilopediaPageQueries", civilopediapagequeries);
            if (civilopediapages != null) ModelClasses.Add("CivilopediaPages", civilopediapages);
            if (civilopediasections != null) ModelClasses.Add("CivilopediaSections", civilopediasections);
            if (colors != null) ModelClasses.Add("Colors", colors);
            if (continents != null) ModelClasses.Add("Continents", continents);
            if (datatypes != null) ModelClasses.Add("DataTypes", datatypes);
            if (dealitems != null) ModelClasses.Add("DealItems", dealitems);
            if (defeats != null) ModelClasses.Add("Defeats", defeats);
            if (difficulties != null) ModelClasses.Add("Difficulties", difficulties);
            if (district_citizengreatpersonpoints != null) ModelClasses.Add("District_CitizenGreatPersonPoints", district_citizengreatpersonpoints);
            if (district_citizenyieldchanges != null) ModelClasses.Add("District_CitizenYieldChanges", district_citizenyieldchanges);
            if (district_greatpersonpoints != null) ModelClasses.Add("District_GreatPersonPoints", district_greatpersonpoints);
            if (district_traderouteyields != null) ModelClasses.Add("District_TradeRouteYields", district_traderouteyields);
            if (districtmodifiers != null) ModelClasses.Add("DistrictModifiers", districtmodifiers);
            if (districts != null) ModelClasses.Add("Districts", districts);
            if (dynamicmodifiers != null) ModelClasses.Add("DynamicModifiers", dynamicmodifiers);
            if (eras != null) ModelClasses.Add("Eras", eras);
            if (favoredreligions != null) ModelClasses.Add("FavoredReligions", favoredreligions);
            if (feature_adjacentyields != null) ModelClasses.Add("Feature_AdjacentYields", feature_adjacentyields);
            if (feature_removes != null) ModelClasses.Add("Feature_Removes", feature_removes);
            if (feature_yieldchanges != null) ModelClasses.Add("Feature_YieldChanges", feature_yieldchanges);
            if (features != null) ModelClasses.Add("Features", features);
            if (flavors != null) ModelClasses.Add("Flavors", flavors);
            if (gamemodifiers != null) ModelClasses.Add("GameModifiers", gamemodifiers);
            if (gamespeed_turns != null) ModelClasses.Add("GameSpeed_Turns", gamespeed_turns);
            if (gamespeeds != null) ModelClasses.Add("GameSpeeds", gamespeeds);
            if (globalparameters != null) ModelClasses.Add("GlobalParameters", globalparameters);
            if (goodyhuts != null) ModelClasses.Add("GoodyHuts", goodyhuts);
            if (goodyhutsubtypes != null) ModelClasses.Add("GoodyHutSubTypes", goodyhutsubtypes);
            if (gossips != null) ModelClasses.Add("Gossips", gossips);
            if (government_slotcounts != null) ModelClasses.Add("Government_SlotCounts", government_slotcounts);
            if (governmentbonusnames != null) ModelClasses.Add("GovernmentBonusNames", governmentbonusnames);
            if (governmentmodifiers != null) ModelClasses.Add("GovernmentModifiers", governmentmodifiers);
            if (governments != null) ModelClasses.Add("Governments", governments);
            if (governmentslots != null) ModelClasses.Add("GovernmentSlots", governmentslots);
            if (greatpersonclasses != null) ModelClasses.Add("GreatPersonClasses", greatpersonclasses);
            if (greatpersonindividualactionmodifiers != null) ModelClasses.Add("GreatPersonIndividualActionModifiers", greatpersonindividualactionmodifiers);
            if (greatpersonindividualbirthmodifiers != null) ModelClasses.Add("GreatPersonIndividualBirthModifiers", greatpersonindividualbirthmodifiers);
            if (greatpersonindividuals != null) ModelClasses.Add("GreatPersonIndividuals", greatpersonindividuals);
            if (greatwork_yieldchanges != null) ModelClasses.Add("GreatWork_YieldChanges", greatwork_yieldchanges);
            if (greatworkobjecttypes != null) ModelClasses.Add("GreatWorkObjectTypes", greatworkobjecttypes);
            if (greatworks != null) ModelClasses.Add("GreatWorks", greatworks);
            if (greatworkslottypes != null) ModelClasses.Add("GreatWorkSlotTypes", greatworkslottypes);
            if (happinesses != null) ModelClasses.Add("Happinesses", happinesses);
            if (historicrankings != null) ModelClasses.Add("HistoricRankings", historicrankings);
            if (improvement_bonusyieldchanges != null) ModelClasses.Add("Improvement_BonusYieldChanges", improvement_bonusyieldchanges);
            if (improvement_tourism != null) ModelClasses.Add("Improvement_Tourism", improvement_tourism);
            if (improvement_validresources != null) ModelClasses.Add("Improvement_ValidResources", improvement_validresources);
            if (improvement_validterrains != null) ModelClasses.Add("Improvement_ValidTerrains", improvement_validterrains);
            if (improvement_yieldchanges != null) ModelClasses.Add("Improvement_YieldChanges", improvement_yieldchanges);
            if (improvementmodifiers != null) ModelClasses.Add("ImprovementModifiers", improvementmodifiers);
            if (improvements != null) ModelClasses.Add("Improvements", improvements);
            if (interfacemodes != null) ModelClasses.Add("InterfaceModes", interfacemodes);
            if (kinds != null) ModelClasses.Add("Kinds", kinds);
            if (leaderanimations != null) ModelClasses.Add("LeaderAnimations", leaderanimations);
            if (leaderinfoes != null) ModelClasses.Add("LeaderInfoes", leaderinfoes);
            if (leaderquotes != null) ModelClasses.Add("LeaderQuotes", leaderquotes);
            if (leaders != null) ModelClasses.Add("Leaders", leaders);
            if (majorstartingunits != null) ModelClasses.Add("MajorStartingUnits", majorstartingunits);
            if (map_greatpersonclasses != null) ModelClasses.Add("Map_GreatPersonClasses", map_greatpersonclasses);
            if (maps != null) ModelClasses.Add("Maps", maps);
            if (modifierarguments != null) ModelClasses.Add("ModifierArguments", modifierarguments);
            if (modifiers != null) ModelClasses.Add("Modifiers", modifiers);
            if (modifierstrings != null) ModelClasses.Add("ModifierStrings", modifierstrings);
            if (months != null) ModelClasses.Add("Months", months);
            if (navigationproperties != null) ModelClasses.Add("NavigationProperties", navigationproperties);
            if (nodedatadefinitions != null) ModelClasses.Add("NodeDataDefinitions", nodedatadefinitions);
            if (nodedefinitions != null) ModelClasses.Add("NodeDefinitions", nodedefinitions);
            if (notifications != null) ModelClasses.Add("Notifications", notifications);
            if (obsoletepolicies != null) ModelClasses.Add("ObsoletePolicies", obsoletepolicies);
            if (opteamrequirements != null) ModelClasses.Add("OpTeamRequirements", opteamrequirements);
            if (playercolors != null) ModelClasses.Add("PlayerColors", playercolors);
            if (plotevalconditions != null) ModelClasses.Add("PlotEvalConditions", plotevalconditions);
            if (policies != null) ModelClasses.Add("Policies", policies);
            if (policymodifiers != null) ModelClasses.Add("PolicyModifiers", policymodifiers);
            if (project_greatpersonpoints != null) ModelClasses.Add("Project_GreatPersonPoints", project_greatpersonpoints);
            if (project_yieldconversions != null) ModelClasses.Add("Project_YieldConversions", project_yieldconversions);
            if (projectcompletionmodifiers != null) ModelClasses.Add("ProjectCompletionModifiers", projectcompletionmodifiers);
            if (projectprereqs != null) ModelClasses.Add("ProjectPrereqs", projectprereqs);
            if (projects != null) ModelClasses.Add("Projects", projects);
            if (pseudoyields != null) ModelClasses.Add("PseudoYields", pseudoyields);
            if (quests != null) ModelClasses.Add("Quests", quests);
            if (randomagendas != null) ModelClasses.Add("RandomAgendas", randomagendas);
            if (religions != null) ModelClasses.Add("Religions", religions);
            if (requirementarguments != null) ModelClasses.Add("RequirementArguments", requirementarguments);
            if (requirements != null) ModelClasses.Add("Requirements", requirements);
            if (requirementsets != null) ModelClasses.Add("RequirementSets", requirementsets);
            if (requirementstrings != null) ModelClasses.Add("RequirementStrings", requirementstrings);
            if (resource_distribution != null) ModelClasses.Add("Resource_Distribution", resource_distribution);
            if (resource_harvests != null) ModelClasses.Add("Resource_Harvests", resource_harvests);
            if (resource_traderouteyields != null) ModelClasses.Add("Resource_TradeRouteYields", resource_traderouteyields);
            if (resource_yieldchanges != null) ModelClasses.Add("Resource_YieldChanges", resource_yieldchanges);
            if (resources != null) ModelClasses.Add("Resources", resources);
            if (routes != null) ModelClasses.Add("Routes", routes);
            if (savingtypes != null) ModelClasses.Add("SavingTypes", savingtypes);
            if (scoringcategories != null) ModelClasses.Add("ScoringCategories", scoringcategories);
            if (scoringlineitems != null) ModelClasses.Add("ScoringLineItems", scoringlineitems);
            if (seasons != null) ModelClasses.Add("Seasons", seasons);
            if (settlementpreferences != null) ModelClasses.Add("SettlementPreferences", settlementpreferences);
            if (shapedefinitions != null) ModelClasses.Add("ShapeDefinitions", shapedefinitions);
            if (startbiasfeatures != null) ModelClasses.Add("StartBiasFeatures", startbiasfeatures);
            if (startbiasresources != null) ModelClasses.Add("StartBiasResources", startbiasresources);
            if (startbiasrivers != null) ModelClasses.Add("StartBiasRivers", startbiasrivers);
            if (startbiasterrains != null) ModelClasses.Add("StartBiasTerrains", startbiasterrains);
            if (starteras != null) ModelClasses.Add("StartEras", starteras);
            if (startingbuildings != null) ModelClasses.Add("StartingBuildings", startingbuildings);
            if (startinggovernments != null) ModelClasses.Add("StartingGovernments", startinggovernments);
            if (strategies != null) ModelClasses.Add("Strategies", strategies);
            if (strategy_yieldpriorities != null) ModelClasses.Add("Strategy_YieldPriorities", strategy_yieldpriorities);
            if (strategyconditions != null) ModelClasses.Add("StrategyConditions", strategyconditions);
            if (tags != null) ModelClasses.Add("Tags", tags);
            if (targettypes != null) ModelClasses.Add("TargetTypes", targettypes);
            if (technologies != null) ModelClasses.Add("Technologies", technologies);
            if (technologymodifiers != null) ModelClasses.Add("TechnologyModifiers", technologymodifiers);
            if (technologyquotes != null) ModelClasses.Add("TechnologyQuotes", technologyquotes);
            if (terrain_yieldchanges != null) ModelClasses.Add("Terrain_YieldChanges", terrain_yieldchanges);
            if (terrains != null) ModelClasses.Add("Terrains", terrains);
            if (traitmodifiers != null) ModelClasses.Add("TraitModifiers", traitmodifiers);
            if (traits != null) ModelClasses.Add("Traits", traits);
            if (treedatas != null) ModelClasses.Add("TreeDatas", treedatas);
            if (triggeredbehaviortrees != null) ModelClasses.Add("TriggeredBehaviorTrees", triggeredbehaviortrees);
            if (turnphases != null) ModelClasses.Add("TurnPhases", turnphases);
            if (turnsegments != null) ModelClasses.Add("TurnSegments", turnsegments);
            if (turntimers != null) ModelClasses.Add("TurnTimers", turntimers);
            if (typeproperties != null) ModelClasses.Add("TypeProperties", typeproperties);
            if (types != null) ModelClasses.Add("Types", types);
            if (unit_buildingprereqs != null) ModelClasses.Add("Unit_BuildingPrereqs", unit_buildingprereqs);
            if (unit_rebelliontags != null) ModelClasses.Add("Unit_RebellionTags", unit_rebelliontags);
            if (unitabilities != null) ModelClasses.Add("UnitAbilities", unitabilities);
            if (unitaitypes != null) ModelClasses.Add("UnitAiTypes", unitaitypes);
            if (unitcommands != null) ModelClasses.Add("UnitCommands", unitcommands);
            if (unitformationclasses != null) ModelClasses.Add("UnitFormationClasses", unitformationclasses);
            if (unitnames != null) ModelClasses.Add("UnitNames", unitnames);
            if (unitoperations != null) ModelClasses.Add("UnitOperations", unitoperations);
            if (units != null) ModelClasses.Add("Units", units);
            if (victories != null) ModelClasses.Add("Victories", victories);
            if (visibilities != null) ModelClasses.Add("Visibilities", visibilities);
            if (vocabularies != null) ModelClasses.Add("Vocabularies", vocabularies);
            if (wmds != null) ModelClasses.Add("WMDs", wmds);
            if (yields != null) ModelClasses.Add("Yields", yields);

            #endregion

            //Add list to combo
            foreach (KeyValuePair<string, object> pair in ModelClasses)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = pair.Key.ToString();
                item.Value = pair.Value;
                EntityList.Items.Add(item);
            }
        }
        #endregion

        #region Database Path and connection string

        /// <summary>
        /// Reads database path from application settings.  If the file does not exist, prompts user for new file, and saves changes.
        /// </summary>
        /// <returns>True if valid file found (after user has selected it); false otherwise.</returns>
        private bool CheckDataBasePath()
        {
            DatabasePath = Properties.Settings.Default.DataBasePath;
            if (!File.Exists(DatabasePath))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Path.GetDirectoryName(DatabasePath);
                dialog.Filter = "All files (*.*)|*.*|SQLite Databases (*.sqlite)|*.sqlite";
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DatabasePath = dialog.FileName;
                    Properties.Settings.Default.DataBasePath = DatabasePath;
                    Properties.Settings.Default.Save();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Reads the Stored "GameplayEntities" connection string, and updates it for the DatabasePath.
        /// </summary>
        private string DataBaseConnectionString
        {
            get
            {
                var originalConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["GameplayEntities"].ConnectionString;
                var ecsBuilder = new EntityConnectionStringBuilder(originalConnectionString);
                var sqlCsBuilder = new SqlConnectionStringBuilder(ecsBuilder.ProviderConnectionString)
                {
                    DataSource = DatabasePath
                };
                var providerConnectionString = sqlCsBuilder.ToString();
                ecsBuilder.ProviderConnectionString = providerConnectionString;
                return ecsBuilder.ToString();
            }
        }




        #endregion

        private void EntityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem item = (ComboboxItem)EntityList.SelectedItem;
            DisplayObjectData(item.Value);
        }


        //Get the class info and display it....
        private void DisplayObjectData(object item)
        {
            //Make list to allow enumeration
            IEnumerable list = (IEnumerable)item;
            int count = 0;
            foreach (object o in list)
            {
                if (count == 0) SetCivData(o);
                DisplayObjectInformation(o);
                count++;
            }

           


        }

        private void SetCivData(object Object)
        {
            CivData.Rows.Clear();
            CivData.Columns.Clear();
                       
            if (Object == null) return;
            PropertyInfo[] properties = Object.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (PropertyInfo property in properties)
            {
                DataGridViewTextBoxColumn newCol = new DataGridViewTextBoxColumn();
                newCol.HeaderText = property.Name;
                CivData.Columns.Add(newCol);
            }
           
        }


        private void DisplayObjectInformation(object Object)
        {
            if (Object == null) return;
            PropertyInfo[] properties = Object.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            DataGridViewRow row = (DataGridViewRow)CivData.RowTemplate.Clone();
            row.CreateCells(CivData);
            
            int index = 0;
            foreach (PropertyInfo property in properties)
            {
                object PropertyObject = property.GetValue(Object, null);
                string cellValue = "";
                try
                {
                    
                    if (property.PropertyType.IsValueType || property.PropertyType == typeof(string))
                    {
                        cellValue = property.GetValue(Object).ToString();
                        //Debug.WriteLine(property.Name + "\t" + property.GetValue(Object).ToString());
                    }
                }
                catch
                {
                    cellValue = "{NULL}";
                }
                row.Cells[index].Value = cellValue;
                index++;
            }
            CivData.Rows.Add(row);
        }
    }
}