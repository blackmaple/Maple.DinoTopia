using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace Maple.DinoTopia.Metadata
{
    public partial class DinoTopiaGameEnv
    {
        public DinoTopiaGameContext Context { get; }
        public ILogger Logger => Context.Logger;
        public Game.Ptr_Game Ptr_Game { get; }

        public UserDataSubsystem.Ptr_UserDataSubsystem Ptr_UserDataSubsystem { get; private set; }
        public LocalizationSubsystem.Ptr_LocalizationSubsystem Ptr_LocalizationSubsystem { get; private set; }
        public ActorStateSubsystem.Ptr_ActorStateSubsystem Ptr_ActorStateSubsystem { get; private set; }

        public DinoTopiaGameEnv(DinoTopiaGameContext gameContext)
        {
            this.Context = gameContext;
            this.Ptr_Game = Game.Ptr_Game._INSTANCE;
            InitSubSystem();
            InitWorldSystem();
        }

        public void InitSubSystem()
        {
            //this.Logger.LogInformation("userdataSubSystem:{s}", this.Context.UserDataSubsystem.ClassMetadata.ClassInfo.Pointer.ToString("X8"));
            foreach (var dic in Ptr_Game._SUBSYSTEMS.AsRefArray())
            {



                var pObject = dic.Value;
                var monoclass = this.Context.RuntimeContext.RuntiemProvider.GetMonoClass(pObject);

                if (monoclass == this.Context.UserDataSubsystem.ClassMetadata.ClassInfo.Pointer)
                {
                    this.Ptr_UserDataSubsystem = pObject.To<UserDataSubsystem.Ptr_UserDataSubsystem>();
                }
                else if (monoclass == this.Context.LocalizationSubsystem.ClassMetadata.ClassInfo.Pointer)
                {
                    this.Ptr_LocalizationSubsystem = pObject.To<LocalizationSubsystem.Ptr_LocalizationSubsystem>();
                }

                var classtype = this.Context.RuntimeContext.RuntiemProvider.GetMonoClassType(monoclass);
                var classfullname = this.Context.RuntimeContext.RuntiemProvider.GetMonoTypeName(classtype);
                this.Logger.LogInformation("{classfullname}:{pObject}", classfullname, pObject.ToString());

            }

        }


        public void InitWorldSystem()
        {
            foreach (var world_dic in Ptr_Game._WORLDS.AsRefArray())
            {

                foreach (var dic in world_dic.Value._SUBSYSTEMS.AsRefArray())
                {
                    var pObject = dic.Value;
                    var monoclass = this.Context.RuntimeContext.RuntiemProvider.GetMonoClass(pObject);

                    if (world_dic.Value.NAME.AsReadOnlySpan().Contains("home".AsSpan(), StringComparison.OrdinalIgnoreCase))
                    {
                        if (monoclass == this.Context.ActorStateSubsystem.ClassMetadata.ClassInfo.Pointer)
                        {
                            this.Ptr_ActorStateSubsystem = pObject.To<ActorStateSubsystem.Ptr_ActorStateSubsystem>();
                        }
                    }

                    var classtype = this.Context.RuntimeContext.RuntiemProvider.GetMonoClassType(monoclass);
                    var classfullname = this.Context.RuntimeContext.RuntiemProvider.GetMonoTypeName(classtype);
                    this.Logger.LogInformation("world:{world}={classfullname}:{pObject}", world_dic.Value.NAME.ToString(), classfullname, pObject.ToString());

                }

            }
        }

        #region actor
        public void LoadActor()
        {
            foreach (var actor in this.Ptr_ActorStateSubsystem.ACTORS)
            {
                var pObject = actor;
                var monoclass = this.Context.RuntimeContext.RuntiemProvider.GetMonoClass(pObject);
                if (monoclass == this.Context.ItemActor.ClassMetadata.ClassInfo.Pointer)
                {
                    var itemActor = pObject.To<ItemActor.Ptr_ItemActor>();
                    if (itemActor.GET_CAN_PICK())
                    {
                        itemActor.DO_PICK_UP(this.Ptr_Game._MY_CONTROLLER);
                    }
                    itemActor.CLEAR();
                }
                var classtype = this.Context.RuntimeContext.RuntiemProvider.GetMonoClassType(monoclass);
                var classfullname = this.Context.RuntimeContext.RuntiemProvider.GetMonoTypeName(classtype);
                this.Logger.LogInformation("{classfullname}:{pObject}", classfullname, pObject.ToString());

            }

        }
        #endregion

        #region LoadConfig
        public void LoadConfig()
        {
            InventoryDisplayDTOs.AddRange(
                [
                    ..LoadBuffConfig(),
                    ..LoadItemConfig(),
                    ..LoadPet_Config(),
                    ..LoadTalentConfig(),
                    ..LoadTotemConfig(),
                ]);

            CurrencyDisplayDTOs.AddRange([.. LoadCharacterStrengthenConfig()]);
        }

        public void LoadActorConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in ActorConfig.Ptr_ActorConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public IEnumerable<GameInventoryDisplayDTO> LoadBuffConfig()
        {
            var cfg_dic = BuffConfig.Ptr_BuffConfig.M_DIC;
            if (cfg_dic == nint.Zero)
            {
                yield break;
            }
            foreach (var dic in cfg_dic.AsRefArray())
            {
                var config = dic.Value;
                var objId = config.ID.ToString()!;
                var displayName = this.Ptr_LocalizationSubsystem.GET(config.NAME).ToString();
                var displayDesc = this.Ptr_LocalizationSubsystem.GET(config.DESCRIPTION).ToString();
                yield return new GameInventoryDisplayDTO() { ObjectId = objId, DisplayName = displayName, DisplayDesc = displayDesc, DisplayCategory = nameof(BuffConfig) };
            }
        }
        public void LoadBuffEffectConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in BuffEffectConfig.Ptr_BuffEffectConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadBuildConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in BuildConfig.Ptr_BuildConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadChapter_Config()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in Chapter_Config.Ptr_Chapter_Config.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadCharacterDIYConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in CharacterDIYConfig.Ptr_CharacterDIYConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public IEnumerable<GameCurrencyDisplayDTO> LoadCharacterStrengthenConfig()
        {
            var cfg_dic = CharacterStrengthenConfig.Ptr_CharacterStrengthenConfig.M_DIC;
            if (cfg_dic == nint.Zero)
            {
                yield break;


            }
            foreach (var dic in cfg_dic.AsRefArray())
            {
                var config = dic.Value;
                var objId = config.ID.ToString()!;
                var displayName = this.Ptr_LocalizationSubsystem.GET(config.NAME).ToString();
                var displayDesc = this.Ptr_LocalizationSubsystem.GET(config.DES).ToString();
                yield return new GameCurrencyDisplayDTO() { ObjectId = objId, DisplayName = displayName, DisplayDesc = displayDesc, DisplayCategory = nameof(CharacterStrengthenConfig) };
            }
        }
        public void LoadDropConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in DropConfig.Ptr_DropConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.CONFIG_ID;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadGatherRes_Config()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in GatherRes_Config.Ptr_GatherRes_Config.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadGlobalEffectConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in GlobalEffectConfig.Ptr_GlobalEffectConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadGuideConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in GuideConfig.Ptr_GuideConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadHomeUpdateConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in HomeUpdateConfig.Ptr_HomeUpdateConfig.GET_DIC().AsRefArray())
            {
                var name = string.Empty;
                var localName = string.Empty;
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadHuntingTaskConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in HuntingTaskConfig.Ptr_HuntingTaskConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadInputManagerConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in InputManagerConfig.Ptr_InputManagerConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public IEnumerable<GameInventoryDisplayDTO> LoadItemConfig()
        {
            var cfg_dic = ItemConfig.Ptr_ItemConfig.M_DIC;
            if (cfg_dic == nint.Zero)
            {
                yield break;
            }
            foreach (var dic in cfg_dic.AsRefArray())
            {
                var config = dic.Value;
                var objId = config.ID.ToString()!;
                var displayName = this.Ptr_LocalizationSubsystem.GET(config.NAME).ToString();
                var displayDesc = this.Ptr_LocalizationSubsystem.GET(config.DESC).ToString();
                yield return new GameInventoryDisplayDTO() { ObjectId = objId, DisplayName = displayName, DisplayDesc = displayDesc, DisplayCategory = nameof(ItemConfig) };
            }
        }
        public void LoadLevel_Config()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in Level_Config.Ptr_Level_Config.GET_DIC().AsRefArray())
            {
                var name = dic.Value.CONFIG_ID;
                var localName = string.Empty;
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadMapBKConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in MapBKConfig.Ptr_MapBKConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadMap_Group_Config()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in Map_Group_Config.Ptr_Map_Group_Config.GET_DIC().AsRefArray())
            {
                var name = string.Empty;
                var localName = string.Empty;

                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public void LoadMap_Type_Config()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in Map_Type_Config.Ptr_Map_Type_Config.GET_DIC().AsRefArray())
            {
                var name = string.Empty;
                var localName = string.Empty;

                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public void LoadMonsterConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in MonsterConfig.Ptr_MonsterConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);

                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public void LoadMonsterRandomConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in MonsterRandomConfig.Ptr_MonsterRandomConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.DESC;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);

                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public IEnumerable<GameInventoryDisplayDTO> LoadPet_Config()
        {
            var cfg_dic = Pet_Config.Ptr_Pet_Config.M_DIC;
            if (cfg_dic == nint.Zero)
            {
                yield break;
            }
            foreach (var dic in cfg_dic.AsRefArray())
            {
                var config = dic.Value;
                var objId = config.ID.ToString()!;
                var displayName = this.Ptr_LocalizationSubsystem.GET(config.NAME).ToString();
                var displayDesc = this.Ptr_LocalizationSubsystem.GET(config.NAME_INSIDE).ToString();
                yield return new GameInventoryDisplayDTO() { ObjectId = objId, DisplayName = displayName, DisplayDesc = displayDesc, DisplayCategory = nameof(ItemConfig) };
            }
        }
        public void LoadRandomSpawnMonsterConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in RandomSpawnMonsterConfig.Ptr_RandomSpawnMonsterConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.ROOM_ID;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);

                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public void LoadRelicConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in RelicConfig.Ptr_RelicConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);

                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public void LoadRoomShopConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in RoomShopConfig.Ptr_RoomShopConfig.GET_DIC().AsRefArray())
            {
                var name = string.Empty;
                var localName = string.Empty;

                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public void LoadRoomShopItemConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in RoomShopItemConfig.Ptr_RoomShopItemConfig.GET_DIC().AsRefArray())
            {
                var name = string.Empty;
                var localName = string.Empty;

                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public void LoadRoom_Config()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in Room_Config.Ptr_Room_Config.GET_DIC().AsRefArray())
            {
                var name = string.Empty;
                var localName = string.Empty; ;

                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public void LoadSeedConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in SeedConfig.Ptr_SeedConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);

                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public void LoadShopItemConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in ShopItemConfig.Ptr_ShopItemConfig.GET_DIC().AsRefArray())
            {
                var name = string.Empty; ;
                var localName = string.Empty; ;
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadSkillConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in SkillConfig.Ptr_SkillConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadSkinColorConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in SkinColorConfig.Ptr_SkinColorConfig.GET_DIC().AsRefArray())
            {
                var name = string.Empty; ;
                var localName = string.Empty; ;
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadSkinPresetConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in SkinPresetConfig.Ptr_SkinPresetConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadStage_Config()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in Stage_Config.Ptr_Stage_Config.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadStatusConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in StatusConfig.Ptr_StatusConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public IEnumerable<GameInventoryDisplayDTO> LoadTalentConfig()
        {
            var cfg_dic = TalentConfig.Ptr_TalentConfig.M_DIC;
            if (cfg_dic == nint.Zero)
            {
                yield break;
            }
            foreach (var dic in cfg_dic.AsRefArray())
            {
                var config = dic.Value;
                var objId = config.ID.ToString()!;
                var displayName = this.Ptr_LocalizationSubsystem.GET(config.NAME).ToString();
                var displayDesc = this.Ptr_LocalizationSubsystem.GET(config.DESC).ToString();
                yield return new GameInventoryDisplayDTO() { ObjectId = objId, DisplayName = displayName, DisplayDesc = displayDesc, DisplayCategory = nameof(TalentConfig) };
            }
        }
        public void LoadTaskConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in TaskConfig.Ptr_TaskConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadTecBuildConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in TecBuildConfig.Ptr_TecBuildConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);

                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public void LoadTecRuleConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in TecRuleConfig.Ptr_TecRuleConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);

                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public void LoadTecTotemConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in TecTotemConfig.Ptr_TecTotemConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public void LoadToolConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in ToolConfig.Ptr_ToolConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }
        public IEnumerable<GameInventoryDisplayDTO> LoadTotemConfig()
        {
            var cfg_dic = TotemConfig.Ptr_TotemConfig.M_DIC;
            if (cfg_dic == nint.Zero)
            {
                yield break;
            }
            foreach (var dic in cfg_dic.AsRefArray())
            {
                var config = dic.Value;
                var objId = config.ID.ToString()!;
                var displayName = this.Ptr_LocalizationSubsystem.GET(config.NAME).ToString();
                var displayDesc = this.Ptr_LocalizationSubsystem.GET(config.DESC).ToString();
                yield return new GameInventoryDisplayDTO() { ObjectId = objId, DisplayName = displayName, DisplayDesc = displayDesc, DisplayCategory = nameof(TotemConfig) };
            }
        }
        #endregion

        //
        #region InitConfig
        public static void InitConfig()
        {
            InitBuffConfig();
            InitItemConfig();
            InitPet_Config();
            InitTalentConfig();
            InitTotemConfig();
            InitCharacterStrengthenConfig();
        }


        public static void InitActorConfig()
        {
            _ = ActorConfig.Ptr_ActorConfig.GET_DIC();
        }
        public static void InitBuffConfig()
        {
            _ = BuffConfig.Ptr_BuffConfig.GET_DIC();
        }
        public static void InitBuffEffectConfig()
        {
            _ = BuffEffectConfig.Ptr_BuffEffectConfig.GET_DIC();
        }
        public static void InitBuildConfig()
        {
            _ = BuildConfig.Ptr_BuildConfig.GET_DIC();
        }
        public static void InitChapter_Config()
        {
            _ = Chapter_Config.Ptr_Chapter_Config.GET_DIC();
        }
        public static void InitCharacterDIYConfig()
        {
            _ = CharacterDIYConfig.Ptr_CharacterDIYConfig.GET_DIC();
        }
        public static void InitCharacterStrengthenConfig()
        {
            _ = CharacterStrengthenConfig.Ptr_CharacterStrengthenConfig.GET_DIC();
        }
        public static void InitDropConfig()
        {
            _ = DropConfig.Ptr_DropConfig.GET_DIC();
        }
        public static void InitGatherRes_Config()
        {
            _ = GatherRes_Config.Ptr_GatherRes_Config.GET_DIC();
        }
        public static void InitGlobalEffectConfig()
        {
            _ = GlobalEffectConfig.Ptr_GlobalEffectConfig.GET_DIC();
        }
        public static void InitGuideConfig()
        {
            _ = GuideConfig.Ptr_GuideConfig.GET_DIC();
        }
        public static void InitHomeUpdateConfig()
        {
            _ = HomeUpdateConfig.Ptr_HomeUpdateConfig.GET_DIC();
        }
        public static void InitHuntingTaskConfig()
        {
            _ = HuntingTaskConfig.Ptr_HuntingTaskConfig.GET_DIC();
        }
        public static void InitInputManagerConfig()
        {
            _ = InputManagerConfig.Ptr_InputManagerConfig.GET_DIC();
        }
        public static void InitItemConfig()
        {
            _ = ItemConfig.Ptr_ItemConfig.GET_DIC();
        }
        public static void InitLevel_Config()
        {
            _ = Level_Config.Ptr_Level_Config.GET_DIC();
        }
        public static void InitMapBKConfig()
        {
            _ = MapBKConfig.Ptr_MapBKConfig.GET_DIC();
        }
        public static void InitMap_Group_Config()
        {
            _ = Map_Group_Config.Ptr_Map_Group_Config.GET_DIC();
        }
        public static void InitMap_Type_Config()
        {
            _ = Map_Type_Config.Ptr_Map_Type_Config.GET_DIC();
        }
        public static void InitMonsterConfig()
        {
            _ = MonsterConfig.Ptr_MonsterConfig.GET_DIC();
        }
        public static void InitMonsterRandomConfig()
        {
            _ = MonsterRandomConfig.Ptr_MonsterRandomConfig.GET_DIC();
        }
        public static void InitPet_Config()
        {
            _ = Pet_Config.Ptr_Pet_Config.GET_DIC();
        }
        public static void InitRandomSpawnMonsterConfig()
        {
            _ = RandomSpawnMonsterConfig.Ptr_RandomSpawnMonsterConfig.GET_DIC();
        }
        public static void InitRelicConfig()
        {
            _ = RelicConfig.Ptr_RelicConfig.GET_DIC();
        }
        public static void InitRoomShopConfig()
        {
            _ = RoomShopConfig.Ptr_RoomShopConfig.GET_DIC();
        }
        public static void InitRoomShopItemConfig()
        {
            _ = RoomShopItemConfig.Ptr_RoomShopItemConfig.GET_DIC();
        }
        public static void InitRoom_Config()
        {
            _ = Room_Config.Ptr_Room_Config.GET_DIC();
        }
        public static void InitSeedConfig()
        {
            _ = SeedConfig.Ptr_SeedConfig.GET_DIC();
        }
        public static void InitShopItemConfig()
        {
            _ = ShopItemConfig.Ptr_ShopItemConfig.GET_DIC();
        }
        public static void InitSkillConfig()
        {
            _ = SkillConfig.Ptr_SkillConfig.GET_DIC();
        }
        public static void InitSkinColorConfig()
        {
            _ = SkinColorConfig.Ptr_SkinColorConfig.GET_DIC();
        }
        public static void InitSkinPresetConfig()
        {
            _ = SkinPresetConfig.Ptr_SkinPresetConfig.GET_DIC();
        }
        public static void InitStage_Config()
        {
            _ = Stage_Config.Ptr_Stage_Config.GET_DIC();
        }
        public static void InitStatusConfig()
        {
            _ = StatusConfig.Ptr_StatusConfig.GET_DIC();
        }
        public static void InitTalentConfig()
        {
            _ = TalentConfig.Ptr_TalentConfig.GET_DIC();
        }
        public static void InitTaskConfig()
        {
            _ = TaskConfig.Ptr_TaskConfig.GET_DIC();
        }
        public static void InitTecBuildConfig()
        {
            _ = TecBuildConfig.Ptr_TecBuildConfig.GET_DIC();
        }
        public static void InitTecRuleConfig()
        {
            _ = TecRuleConfig.Ptr_TecRuleConfig.GET_DIC();
        }
        public static void InitTecTotemConfig()
        {
            _ = TecTotemConfig.Ptr_TecTotemConfig.GET_DIC();
        }
        public static void InitToolConfig()
        {
            _ = ToolConfig.Ptr_ToolConfig.GET_DIC();
        }
        public static void InitTotemConfig()
        {
            _ = TotemConfig.Ptr_TotemConfig.GET_DIC();
        }

        #endregion


        public static List<GameCurrencyDisplayDTO> CurrencyDisplayDTOs { get; } = [];
        public static List<GameInventoryDisplayDTO> InventoryDisplayDTOs { get; } = [];

    }
}
