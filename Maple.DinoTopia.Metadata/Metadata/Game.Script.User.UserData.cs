namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Game.Script.User"."UserData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_UserData>, Ptr_UserData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "Game.Script.User", "UserData", "Game.Script.User.UserData")]
    public partial class UserData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_UserData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_UserData(System.IntPtr ptr) => new Ptr_UserData(ptr);
            public static implicit operator System.IntPtr(Ptr_UserData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_UserData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.User"."UserData"]
        /// </summary>
        partial struct Ptr_UserData
        {
            /// <summary>
            /// 0x10 System.Collections.Generic.List<Game.Script.User.FightChapterInfo> ChapterInfos
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Game.Script.User.FightChapterInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChapterInfos", "System.Collections.Generic.List<Game.Script.User.FightChapterInfo>")]
            public partial nint CHAPTER_INFOS { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.List<Game.Script.User.HomeActorData> HomeActors
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Game.Script.User.HomeActorData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HomeActors", "System.Collections.Generic.List<Game.Script.User.HomeActorData>")]
            public partial nint HOME_ACTORS { get; set; } 
*/

            /// <summary>
            /// 0x20 Game.Script.Common.UnOrderDictionary<System.Guid , Game.Script.User.UserHomePetData> HomePetData
            /// class ["Assembly-CSharp.dll"."Game.Script.Common"."UnOrderDictionary`2"]
            /// </summary>
            /// <returns>class Game.Script.Common.UnOrderDictionary<System.Guid , Game.Script.User.UserHomePetData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HomePetData", "Game.Script.Common.UnOrderDictionary<System.Guid,Game.Script.User.UserHomePetData>")]
            public partial nint HOME_PET_DATA { get; set; } 
*/

            /// <summary>
            /// 0x28 Game.Script.Common.UnOrderDictionary<System.Guid , Game.Script.User.UserFightPetData> FightPetData
            /// class ["Assembly-CSharp.dll"."Game.Script.Common"."UnOrderDictionary`2"]
            /// </summary>
            /// <returns>class Game.Script.Common.UnOrderDictionary<System.Guid , Game.Script.User.UserFightPetData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FightPetData", "Game.Script.Common.UnOrderDictionary<System.Guid,Game.Script.User.UserFightPetData>")]
            public partial nint FIGHT_PET_DATA { get; set; } 
*/

            /// <summary>
            /// 0x30 Game.Script.Common.UnOrderDictionary<System.Guid , Game.Script.User.UserStoragePetData> StoragePetData
            /// class ["Assembly-CSharp.dll"."Game.Script.Common"."UnOrderDictionary`2"]
            /// </summary>
            /// <returns>class Game.Script.Common.UnOrderDictionary<System.Guid , Game.Script.User.UserStoragePetData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("StoragePetData", "Game.Script.Common.UnOrderDictionary<System.Guid,Game.Script.User.UserStoragePetData>")]
            public partial nint STORAGE_PET_DATA { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.Dictionary<System.String , System.Int32> ChapterPassed
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChapterPassed", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
            public partial nint CHAPTER_PASSED { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Collections.Generic.List<Game.Script.User.Item> BagItems
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Game.Script.User.Item></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BagItems", "System.Collections.Generic.List<Game.Script.User.Item>")]
            public partial nint BAG_ITEMS { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Collections.Generic.List<Game.Script.User.MapItem> MapItems
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Game.Script.User.MapItem></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MapItems", "System.Collections.Generic.List<Game.Script.User.MapItem>")]
            public partial nint MAP_ITEMS { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Collections.Generic.List<System.String> Tech
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Tech", "System.Collections.Generic.List<System.String>")]
            public partial nint TECH { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Collections.Generic.Dictionary<Game.Script.Character.CharacterSkinDefine , System.ValueTuple<System.String , UnityEngine.Color>> PlayerSkin
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<Game.Script.Character.CharacterSkinDefine , System.ValueTuple<System.String , UnityEngine.Color>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PlayerSkin", "System.Collections.Generic.Dictionary<Game.Script.Character.CharacterSkinDefine,System.ValueTuple<System.String,UnityEngine.Color>>")]
            public partial nint PLAYER_SKIN { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Collections.Generic.List<Game.Script.User.QuestInfo> QuestInfos
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Game.Script.User.QuestInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("QuestInfos", "System.Collections.Generic.List<Game.Script.User.QuestInfo>")]
            public partial nint QUEST_INFOS { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Collections.Generic.Dictionary<System.String , Game.Script.User.PolicyInfo> UnlockPolicy
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , Game.Script.User.PolicyInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UnlockPolicy", "System.Collections.Generic.Dictionary<System.String,Game.Script.User.PolicyInfo>")]
            public partial nint UNLOCK_POLICY { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Single PolicyRefreshLeftTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PolicyRefreshLeftTime", "System.Single")]
            public partial System.Single POLICY_REFRESH_LEFT_TIME { get; set; } 
*/

            /// <summary>
            /// 0x74 System.Int32 AddHomePetNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AddHomePetNum", "System.Int32")]
            public partial System.Int32 ADD_HOME_PET_NUM { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Collections.Generic.List<System.String> UnlockSkins
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UnlockSkins", "System.Collections.Generic.List<System.String>")]
            public partial nint UNLOCK_SKINS { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Collections.Generic.List<System.String> UnlockTotem
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UnlockTotem", "System.Collections.Generic.List<System.String>")]
            public partial nint UNLOCK_TOTEM { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Collections.Generic.List<System.String> UnlockTech
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UnlockTech", "System.Collections.Generic.List<System.String>")]
            public partial nint UNLOCK_TECH { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Collections.Generic.List<System.String> UnlockRelic
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UnlockRelic", "System.Collections.Generic.List<System.String>")]
            public partial nint UNLOCK_RELIC { get; set; } 
*/

            /// <summary>
            /// 0x98 Game.Script.User.StrengthenInfo StrengthenInfo
            /// class ["Assembly-CSharp.dll"."Game.Script.User"."StrengthenInfo"]
            /// </summary>
            /// <returns>class Game.Script.User.StrengthenInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("StrengthenInfo", "Game.Script.User.StrengthenInfo")]
            public partial nint STRENGTHEN_INFO { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Boolean bHasInitRes
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bHasInitRes", "System.Boolean")]
            public partial System.Boolean B_HAS_INIT_RES { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Collections.Generic.List<Game.Script.User.MapResourceData> MapResourceDatas
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Game.Script.User.MapResourceData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MapResourceDatas", "System.Collections.Generic.List<Game.Script.User.MapResourceData>")]
            public partial nint MAP_RESOURCE_DATAS { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Collections.Generic.Dictionary<System.String , Game.Script.User.MapResourceTimeInfo> MapResourceRefreshTime
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , Game.Script.User.MapResourceTimeInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MapResourceRefreshTime", "System.Collections.Generic.Dictionary<System.String,Game.Script.User.MapResourceTimeInfo>")]
            public partial nint MAP_RESOURCE_REFRESH_TIME { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Collections.Generic.List<Game.Script.Subsystem.GlobalEffectData> GlobalEffect
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Game.Script.Subsystem.GlobalEffectData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GlobalEffect", "System.Collections.Generic.List<Game.Script.Subsystem.GlobalEffectData>")]
            public partial nint GLOBAL_EFFECT { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Single CurTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CurTime", "System.Single")]
            public partial System.Single CUR_TIME { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Collections.Generic.List<Game.Script.User.TaskInfo> ProgressingTaskInfos
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Game.Script.User.TaskInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ProgressingTaskInfos", "System.Collections.Generic.List<Game.Script.User.TaskInfo>")]
            public partial nint PROGRESSING_TASK_INFOS { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.Collections.Generic.List<System.String> FinishTask
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FinishTask", "System.Collections.Generic.List<System.String>")]
            public partial nint FINISH_TASK { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.Collections.Generic.List<System.String> PassedGuide
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PassedGuide", "System.Collections.Generic.List<System.String>")]
            public partial nint PASSED_GUIDE { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.Boolean TiredCalculate
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TiredCalculate", "System.Boolean")]
            public partial System.Boolean TIRED_CALCULATE { get; set; } 
*/

            /// <summary>
            /// 0xE1 System.Boolean HealthCalculate
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HealthCalculate", "System.Boolean")]
            public partial System.Boolean HEALTH_CALCULATE { get; set; } 
*/

            /// <summary>
            /// 0xE2 System.Boolean SatietyCalculate
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SatietyCalculate", "System.Boolean")]
            public partial System.Boolean SATIETY_CALCULATE { get; set; } 
*/

            /// <summary>
            /// 0xE3 System.Boolean FightDoorOpen
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FightDoorOpen", "System.Boolean")]
            public partial System.Boolean FIGHT_DOOR_OPEN { get; set; } 
*/

            /// <summary>
            /// 0xE4 System.Boolean HasPlayStartMovie
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HasPlayStartMovie", "System.Boolean")]
            public partial System.Boolean HAS_PLAY_START_MOVIE { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Collections.Generic.List<System.String> NewBuildId
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NewBuildId", "System.Collections.Generic.List<System.String>")]
            public partial nint NEW_BUILD_ID { get; set; } 
*/

            /// <summary>
            /// 0xF0 System.Collections.Generic.List<System.String> NewPolicy
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NewPolicy", "System.Collections.Generic.List<System.String>")]
            public partial nint NEW_POLICY { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Collections.Generic.Dictionary<System.String , System.Int32> ChapterDifficulty
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChapterDifficulty", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
            public partial nint CHAPTER_DIFFICULTY { get; set; } 
*/

            /// <summary>
            /// 0x100 System.Collections.Generic.List<System.Guid> NewPets
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.Guid></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NewPets", "System.Collections.Generic.List<System.Guid>")]
            public partial nint NEW_PETS { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Collections.Generic.List<System.String> HistoryItemNew
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HistoryItemNew", "System.Collections.Generic.List<System.String>")]
            public partial nint HISTORY_ITEM_NEW { get; set; } 
*/

            /// <summary>
            /// 0x110 System.Collections.Generic.List<System.String> NowItemNew
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NowItemNew", "System.Collections.Generic.List<System.String>")]
            public partial nint NOW_ITEM_NEW { get; set; } 
*/

            /// <summary>
            /// 0x118 System.Collections.Generic.List<System.String> PassedStages
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PassedStages", "System.Collections.Generic.List<System.String>")]
            public partial nint PASSED_STAGES { get; set; } 
*/

            /// <summary>
            /// 0x120 System.Collections.Generic.List<System.String> ActiveRelics
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ActiveRelics", "System.Collections.Generic.List<System.String>")]
            public partial nint ACTIVE_RELICS { get; set; } 
*/

            /// <summary>
            /// 0x128 System.Collections.Generic.List<System.String> ActiveTotems
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ActiveTotems", "System.Collections.Generic.List<System.String>")]
            public partial nint ACTIVE_TOTEMS { get; set; } 
*/

            /// <summary>
            /// 0x130 System.Collections.Generic.List<Game.Script.User.KillMonsterInfo> KillMonsterInfos
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Game.Script.User.KillMonsterInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("KillMonsterInfos", "System.Collections.Generic.List<Game.Script.User.KillMonsterInfo>")]
            public partial nint KILL_MONSTER_INFOS { get; set; } 
*/

            /// <summary>
            /// 0x138 System.Collections.Generic.Dictionary<System.String , System.Int32> BuildLimitAdd
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BuildLimitAdd", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
            public partial nint BUILD_LIMIT_ADD { get; set; } 
*/

            /// <summary>
            /// 0x140 System.Int32 UnlockBuildTechLevel
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UnlockBuildTechLevel", "System.Int32")]
            public partial System.Int32 UNLOCK_BUILD_TECH_LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x144 System.Int32 UnlockTotemTechLevel
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UnlockTotemTechLevel", "System.Int32")]
            public partial System.Int32 UNLOCK_TOTEM_TECH_LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x148 System.Collections.Generic.Dictionary<System.String , System.Int32> PetUnlockTotmes
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PetUnlockTotmes", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
            public partial nint PET_UNLOCK_TOTMES { get; set; } 
*/

            /// <summary>
            /// 0x150 System.Collections.Generic.Dictionary<System.String , System.Int32> PetUnlockRelices
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PetUnlockRelices", "System.Collections.Generic.Dictionary<System.String,System.Int32>")]
            public partial nint PET_UNLOCK_RELICES { get; set; } 
*/

            /// <summary>
            /// 0x158 System.Collections.Generic.List<System.String> ActivePets
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ActivePets", "System.Collections.Generic.List<System.String>")]
            public partial nint ACTIVE_PETS { get; set; } 
*/

            /// <summary>
            /// 0x160 System.Boolean <DataOk>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<DataOk>k__BackingField", "System.Boolean")]
            public partial System.Boolean DATA_OK { get; set; } 
*/

            /// <summary>
            /// 0x161 System.Boolean NeedDemoTip
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NeedDemoTip", "System.Boolean")]
            public partial System.Boolean NEED_DEMO_TIP { get; set; } 
*/

            /// <summary>
            /// 0x162 System.Boolean HasUsedDempTip
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HasUsedDempTip", "System.Boolean")]
            public partial System.Boolean HAS_USED_DEMP_TIP { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.User"."UserData"]
        /// </summary>
        partial struct Ptr_UserData
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void ActivePet(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ActivePet", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ACTIVE_PET(nint id); 
*/
            /// <summary>
            ///   System.Void ActiveRelic(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ActiveRelic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ACTIVE_RELIC(nint id); 
*/
            /// <summary>
            ///   System.Void ActiveTotem(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ActiveTotem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ACTIVE_TOTEM(nint id); 
*/
            /// <summary>
            ///   System.Void AddBuildLimit(System.String id, System.Int32 add)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "add">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddBuildLimit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_BUILD_LIMIT(nint id, System.Int32 add); 
*/
            /// <summary>
            ///   System.Void AddItem(System.String id, System.Int32 count, System.String param, System.Boolean withTip)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "param">class System.String</param>
            /// <param name = "withTip">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            public partial void ADD_ITEM(nint id, System.Int32 count, nint param, System.Boolean withTip); 
*/
            /// <summary>
            ///   System.Void AddKillMonster(System.String id, System.Int32 num)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "num">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddKillMonster", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_KILL_MONSTER(nint id, System.Int32 num); 
*/
            /// <summary>
            ///   System.Void AddPetUnlockRelicCount(System.String petId)
            /// </summary>
            /// <param name = "petId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddPetUnlockRelicCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ADD_PET_UNLOCK_RELIC_COUNT(nint petId); 
*/
            /// <summary>
            ///   System.Void AddPetUnlockTotemCount(System.String petId)
            /// </summary>
            /// <param name = "petId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddPetUnlockTotemCount", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ADD_PET_UNLOCK_TOTEM_COUNT(nint petId); 
*/
            /// <summary>
            ///   System.Void AddTech(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddTech", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ADD_TECH(nint id); 
*/
            /// <summary>
            ///   System.Void AddUnlockBuildTechLevel(System.Int32 add)
            /// </summary>
            /// <param name = "add">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddUnlockBuildTechLevel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_UNLOCK_BUILD_TECH_LEVEL(System.Int32 add); 
*/
            /// <summary>
            ///   System.Void AddUnlockTotemTechLevel(System.Int32 add)
            /// </summary>
            /// <param name = "add">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddUnlockTotemTechLevel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ADD_UNLOCK_TOTEM_TECH_LEVEL(System.Int32 add); 
*/
            /// <summary>
            ///   System.Boolean get_DataOk()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_DataOk", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_DATA_OK(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<Game.Script.User.HomeActorData> GetAllByGrid(System.Int32 x, System.Int32 z)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "z">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<Game.Script.User.HomeActorData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAllByGrid", "System.Collections.Generic.List<Game.Script.User.HomeActorData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_ALL_BY_GRID(System.Int32 x, System.Int32 z); 
*/
            /// <summary>
            ///   T GetBuild()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBuild", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BUILD(); 
*/
            /// <summary>
            ///   Game.Script.User.HomeActorData GetBuildData(Game.Script.Map.Actor.Home.HomeActor homeActor)
            /// </summary>
            /// <param name = "homeActor">class Game.Script.Map.Actor.Home.HomeActor</param>
            /// <returns>class Game.Script.User.HomeActorData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBuildData", "Game.Script.User.HomeActorData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.Home.HomeActor", 0)]
            public partial nint GET_BUILD_DATA(nint homeActor); 
*/
            /// <summary>
            ///   System.Int32 GetBuildLimit(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBuildLimit", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_BUILD_LIMIT(nint id); 
*/
            /// <summary>
            ///   System.Int32 GetBuildNum(System.String id, System.Boolean withConstructing)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "withConstructing">struct System.Boolean</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetBuildNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Int32 GET_BUILD_NUM(nint id, System.Boolean withConstructing); 
*/
            /// <summary>
            ///   System.ValueTuple<System.Collections.Generic.List<System.String>,System.Int32> GetCanUseQuest(Game.Script.Map.Actor.Home.HuntingStation station)
            /// </summary>
            /// <param name = "station">class Game.Script.Map.Actor.Home.HuntingStation</param>
            /// <returns>struct System.ValueTuple<System.Collections.Generic.List<System.String>,System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCanUseQuest", "System.ValueTuple<System.Collections.Generic.List<System.String>,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.Home.HuntingStation", 0)]
            public partial System.ValueTuple<System.Collections.Generic.List<System.String>, System.Int32> GET_CAN_USE_QUEST(nint station); 
*/
            /// <summary>
            ///   Game.Script.User.FightChapterInfo GetChapterInfo(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>class Game.Script.User.FightChapterInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetChapterInfo", "Game.Script.User.FightChapterInfo", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_CHAPTER_INFO(nint id); 
*/
            /// <summary>
            ///   Game.Script.User.UserFightPetData GetFightPetData(System.Int32 pos)
            /// </summary>
            /// <param name = "pos">struct System.Int32</param>
            /// <returns>class Game.Script.User.UserFightPetData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetFightPetData", "Game.Script.User.UserFightPetData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_FIGHT_PET_DATA(System.Int32 pos); 
*/
            /// <summary>
            ///   System.Int32 GetItemNum(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_ITEM_NUM(nint id); 
*/
            /// <summary>
            ///   System.Int32 GetKilledMonster(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetKilledMonster", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_KILLED_MONSTER(nint id); 
*/
            /// <summary>
            ///   Game.Script.User.QuestInfo GetMyQuest(System.Guid petGuid)
            /// </summary>
            /// <param name = "petGuid">struct System.Guid</param>
            /// <returns>class Game.Script.User.QuestInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetMyQuest", "Game.Script.User.QuestInfo", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public partial nint GET_MY_QUEST(System.Guid petGuid); 
*/
            /// <summary>
            ///   Game.Script.User.UserPetData GetPetData(System.Guid guid)
            /// </summary>
            /// <param name = "guid">struct System.Guid</param>
            /// <returns>class Game.Script.User.UserPetData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPetData", "Game.Script.User.UserPetData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public partial nint GET_PET_DATA(System.Guid guid); 
*/
            /// <summary>
            ///   System.Int32 GetQuestIndex(System.Guid petGuid)
            /// </summary>
            /// <param name = "petGuid">struct System.Guid</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetQuestIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public partial System.Int32 GET_QUEST_INDEX(System.Guid petGuid); 
*/
            /// <summary>
            ///   System.Boolean HasPassStage(System.String stageId)
            /// </summary>
            /// <param name = "stageId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HasPassStage", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean HAS_PASS_STAGE(nint stageId); 
*/
            /// <summary>
            ///   System.Boolean IsBuildNew(System.String buildId)
            /// </summary>
            /// <param name = "buildId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsBuildNew", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean IS_BUILD_NEW(nint buildId); 
*/
            /// <summary>
            ///   System.Boolean IsBuildNumLimit(BuildConfig buildConfig)
            /// </summary>
            /// <param name = "buildConfig">class BuildConfig</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsBuildNumLimit", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("BuildConfig", 0)]
            public partial System.Boolean IS_BUILD_NUM_LIMIT(nint buildConfig); 
*/
            /// <summary>
            ///   System.Boolean IsBuildUnlock(System.String buildId)
            /// </summary>
            /// <param name = "buildId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsBuildUnlock", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean IS_BUILD_UNLOCK(nint buildId); 
*/
            /// <summary>
            ///   System.Boolean IsPetDoQuest(System.Guid guid)
            /// </summary>
            /// <param name = "guid">struct System.Guid</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsPetDoQuest", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public partial System.Boolean IS_PET_DO_QUEST(System.Guid guid); 
*/
            /// <summary>
            ///   System.Boolean IsPetUnlockRelicLimit(System.String petId)
            /// </summary>
            /// <param name = "petId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsPetUnlockRelicLimit", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean IS_PET_UNLOCK_RELIC_LIMIT(nint petId); 
*/
            /// <summary>
            ///   System.Boolean IsPetUnlockTotemLimit(System.String petId)
            /// </summary>
            /// <param name = "petId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsPetUnlockTotemLimit", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean IS_PET_UNLOCK_TOTEM_LIMIT(nint petId); 
*/
            /// <summary>
            ///   System.Void ProcessPetCalculate(System.Int32 type)
            /// </summary>
            /// <param name = "type">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ProcessPetCalculate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void PROCESS_PET_CALCULATE(System.Int32 type); 
*/
            /// <summary>
            ///   System.Void RefreshAllQuest(Game.Script.Map.Actor.Home.HuntingStation station)
            /// </summary>
            /// <param name = "station">class Game.Script.Map.Actor.Home.HuntingStation</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshAllQuest", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.Home.HuntingStation", 0)]
            public partial void REFRESH_ALL_QUEST(nint station); 
*/
            /// <summary>
            ///   System.Void RefreshQuestFinish(Game.Script.Map.Actor.Home.HuntingStation station)
            /// </summary>
            /// <param name = "station">class Game.Script.Map.Actor.Home.HuntingStation</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshQuestFinish", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.Home.HuntingStation", 0)]
            public partial void REFRESH_QUEST_FINISH(nint station); 
*/
            /// <summary>
            ///   System.Void RemoveHomeActor(Game.Script.Map.Actor.Home.HomeActor actor)
            /// </summary>
            /// <param name = "actor">class Game.Script.Map.Actor.Home.HomeActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveHomeActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.Home.HomeActor", 0)]
            public partial void REMOVE_HOME_ACTOR(nint actor); 
*/
            /// <summary>
            ///   System.Void RemoveItem(Game.Script.User.Item item, System.Int32 count)
            /// </summary>
            /// <param name = "item">class Game.Script.User.Item</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.User.Item", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void REMOVE_ITEM(nint item, System.Int32 count); 
*/
            /// <summary>
            ///   System.Void RemoveItem(System.String id, System.Int32 count)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void REMOVE_ITEM(nint id, System.Int32 count); 
*/
            /// <summary>
            ///   System.Void RemovePet(System.Guid guid)
            /// </summary>
            /// <param name = "guid">struct System.Guid</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemovePet", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public partial void REMOVE_PET(System.Guid guid); 
*/
            /// <summary>
            ///   System.Void RestGuids()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RestGuids", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void REST_GUIDS(); 
*/
            /// <summary>
            ///   System.Void set_DataOk(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_DataOk", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_DATA_OK(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void UpdateNewBuildIdByTech(System.String techId)
            /// </summary>
            /// <param name = "techId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateNewBuildIdByTech", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void UPDATE_NEW_BUILD_ID_BY_TECH(nint techId); 
*/
        }
    }
}