using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;

namespace Maple.DinoTopia.Metadata
{
    public partial class DinoTopiaGameEnv
    {
        public DinoTopiaGameContext Context { get; }
        public ILogger Logger => Context.Logger;
        public Game.Ptr_Game Ptr_Game { get; }

        public UserDataSubsystem.Ptr_UserDataSubsystem Ptr_UserDataSubsystem { get; private set; }
        public LocalizationSubsystem.Ptr_LocalizationSubsystem Ptr_LocalizationSubsystem { get; private set; }
        public DinoTopiaGameEnv(DinoTopiaGameContext gameContext)
        {
            this.Context = gameContext;
            this.Ptr_Game = Game.Ptr_Game._INSTANCE;
            InitSubSystem();
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
                ////    var monoclass = dic.Value.MonoClass;
                //;

                //var classtype = this.Context.RuntimeContext.RuntiemProvider.GetMonoClassType(monoclass);

                //var classfullname = this.Context.RuntimeContext.RuntiemProvider.GetMonoTypeName(classtype).ToString();

                //this.Logger.LogInformation("Key:{Key},Value:{Value},monoclass:{monoclass} classtype:{classtype},classfullname:{classfullname}",
                //    dic.Key.ToString(), dic.Value.ToString(),
                //      monoclass, classtype, classfullname);

            }

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
        public void LoadBuffConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in BuffConfig.Ptr_BuffConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


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
        public void LoadCharacterStrengthenConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in CharacterStrengthenConfig.Ptr_CharacterStrengthenConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


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
        public void LoadItemConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in ItemConfig.Ptr_ItemConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


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
        public void LoadPet_Config()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in Pet_Config.Ptr_Pet_Config.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);

                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

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
        public void LoadTalentConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in TalentConfig.Ptr_TalentConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


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
        public void LoadTotemConfig()
        {
            using var _ = this.Logger.Running();
            foreach (var dic in TotemConfig.Ptr_TotemConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());


            }
        }

        //
        public static void ReadActorConfig()
        {
            _ = ActorConfig.Ptr_ActorConfig.GET_DIC();
        }
        public static void ReadBuffConfig()
        {
            _ = BuffConfig.Ptr_BuffConfig.GET_DIC();
        }
        public static void ReadBuffEffectConfig()
        {
            _ = BuffEffectConfig.Ptr_BuffEffectConfig.GET_DIC();
        }
        public static void ReadBuildConfig()
        {
            _ = BuildConfig.Ptr_BuildConfig.GET_DIC();
        }
        public static void ReadChapter_Config()
        {
            _ = Chapter_Config.Ptr_Chapter_Config.GET_DIC();
        }
        public static void ReadCharacterDIYConfig()
        {
            _ = CharacterDIYConfig.Ptr_CharacterDIYConfig.GET_DIC();
        }
        public static void ReadCharacterStrengthenConfig()
        {
            _ = CharacterStrengthenConfig.Ptr_CharacterStrengthenConfig.GET_DIC();
        }
        public static void ReadDropConfig()
        {
            _ = DropConfig.Ptr_DropConfig.GET_DIC();
        }
        public static void ReadGatherRes_Config()
        {
            _ = GatherRes_Config.Ptr_GatherRes_Config.GET_DIC();
        }
        public static void ReadGlobalEffectConfig()
        {
            _ = GlobalEffectConfig.Ptr_GlobalEffectConfig.GET_DIC();
        }
        public static void ReadGuideConfig()
        {
            _ = GuideConfig.Ptr_GuideConfig.GET_DIC();
        }
        public static void ReadHomeUpdateConfig()
        {
            _ = HomeUpdateConfig.Ptr_HomeUpdateConfig.GET_DIC();
        }
        public static void ReadHuntingTaskConfig()
        {
            _ = HuntingTaskConfig.Ptr_HuntingTaskConfig.GET_DIC();
        }
        public static void ReadInputManagerConfig()
        {
            _ = InputManagerConfig.Ptr_InputManagerConfig.GET_DIC();
        }
        public static void ReadItemConfig()
        {
            _ = ItemConfig.Ptr_ItemConfig.GET_DIC();
        }
        public static void ReadLevel_Config()
        {
            _ = Level_Config.Ptr_Level_Config.GET_DIC();
        }
        public static void ReadMapBKConfig()
        {
            _ = MapBKConfig.Ptr_MapBKConfig.GET_DIC();
        }
        public static void ReadMap_Group_Config()
        {
            _ = Map_Group_Config.Ptr_Map_Group_Config.GET_DIC();
        }
        public static void ReadMap_Type_Config()
        {
            _ = Map_Type_Config.Ptr_Map_Type_Config.GET_DIC();
        }
        public static void ReadMonsterConfig()
        {
            _ = MonsterConfig.Ptr_MonsterConfig.GET_DIC();
        }
        public static void ReadMonsterRandomConfig()
        {
            _ = MonsterRandomConfig.Ptr_MonsterRandomConfig.GET_DIC();
        }
        public static void ReadPet_Config()
        {
            _ = Pet_Config.Ptr_Pet_Config.GET_DIC();
        }
        public static void ReadRandomSpawnMonsterConfig()
        {
            _ = RandomSpawnMonsterConfig.Ptr_RandomSpawnMonsterConfig.GET_DIC();
        }
        public static void ReadRelicConfig()
        {
            _ = RelicConfig.Ptr_RelicConfig.GET_DIC();
        }
        public static void ReadRoomShopConfig()
        {
            _ = RoomShopConfig.Ptr_RoomShopConfig.GET_DIC();
        }
        public static void ReadRoomShopItemConfig()
        {
            _ = RoomShopItemConfig.Ptr_RoomShopItemConfig.GET_DIC();
        }
        public static void ReadRoom_Config()
        {
            _ = Room_Config.Ptr_Room_Config.GET_DIC();
        }
        public static void ReadSeedConfig()
        {
            _ = SeedConfig.Ptr_SeedConfig.GET_DIC();
        }
        public static void ReadShopItemConfig()
        {
            _ = ShopItemConfig.Ptr_ShopItemConfig.GET_DIC();
        }
        public static void ReadSkillConfig()
        {
            _ = SkillConfig.Ptr_SkillConfig.GET_DIC();
        }
        public static void ReadSkinColorConfig()
        {
            _ = SkinColorConfig.Ptr_SkinColorConfig.GET_DIC();
        }
        public static void ReadSkinPresetConfig()
        {
            _ = SkinPresetConfig.Ptr_SkinPresetConfig.GET_DIC();
        }
        public static void ReadStage_Config()
        {
            _ = Stage_Config.Ptr_Stage_Config.GET_DIC();
        }
        public static void ReadStatusConfig()
        {
            _ = StatusConfig.Ptr_StatusConfig.GET_DIC();
        }
        public static void ReadTalentConfig()
        {
            _ = TalentConfig.Ptr_TalentConfig.GET_DIC();
        }
        public static void ReadTaskConfig()
        {
            _ = TaskConfig.Ptr_TaskConfig.GET_DIC();
        }
        public static void ReadTecBuildConfig()
        {
            _ = TecBuildConfig.Ptr_TecBuildConfig.GET_DIC();
        }
        public static void ReadTecRuleConfig()
        {
            _ = TecRuleConfig.Ptr_TecRuleConfig.GET_DIC();
        }
        public static void ReadTecTotemConfig()
        {
            _ = TecTotemConfig.Ptr_TecTotemConfig.GET_DIC();
        }
        public static void ReadToolConfig()
        {
            _ = ToolConfig.Ptr_ToolConfig.GET_DIC();
        }
        public static void ReadTotemConfig()
        {
            _ = TotemConfig.Ptr_TotemConfig.GET_DIC();
        }



        public static List<GameCurrencyDisplayDTO> CurrencyDisplayDTOs { get; } = [];
        public static List<GameInventoryDisplayDTO> InventoryDisplayDTOs { get; } = [];

    }
}
