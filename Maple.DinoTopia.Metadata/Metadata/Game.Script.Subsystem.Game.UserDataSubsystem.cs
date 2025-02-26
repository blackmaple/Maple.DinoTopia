namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem.Game"."UserDataSubsystem"]
    /// [Game.Script.Subsystem.GameSubsystem]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_UserDataSubsystem>, Ptr_UserDataSubsystem>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "Game.Script.Subsystem.Game", "UserDataSubsystem", "Game.Script.Subsystem.Game.UserDataSubsystem")]
    public partial class UserDataSubsystem
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_UserDataSubsystem(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_UserDataSubsystem(System.IntPtr ptr) => new Ptr_UserDataSubsystem(ptr);
            public static implicit operator System.IntPtr(Ptr_UserDataSubsystem ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_UserDataSubsystem ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem.Game"."UserDataSubsystem"]
        /// </summary>
        partial struct Ptr_UserDataSubsystem
        {
            /// <summary>
            /// 0x0 System.Single SaveDeltaTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            public const System.Single SAVE_DELTA_TIME = 60000; 
*/
            /// <summary>
            /// 0x0 System.String MapHome
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint MAP_HOME = map_home; 
*/
            /// <summary>
            /// 0x10 Game.Script.User.UserData _userData
            /// class ["Assembly-CSharp.dll"."Game.Script.User"."UserData"]
            /// </summary>
            /// <returns>class Game.Script.User.UserData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_userData", "Game.Script.User.UserData")]
            public partial nint _USER_DATA { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 <SaveIndex>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<SaveIndex>k__BackingField", "System.Int32")]
            public partial System.Int32 SAVE_INDEX { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Action<System.String> OnUnlockPolicy
            /// class ["mscorlib.dll"."System"."Action`1"]
            /// </summary>
            /// <returns>class System.Action<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnUnlockPolicy", "System.Action<System.String>")]
            public partial nint ON_UNLOCK_POLICY { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Action<System.String , System.Int32> OnAddItem
            /// class ["mscorlib.dll"."System"."Action`2"]
            /// </summary>
            /// <returns>class System.Action<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnAddItem", "System.Action<System.String,System.Int32>")]
            public partial nint ON_ADD_ITEM { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Action<Game.Script.User.UserPetData , System.String> OnHatchSuccess
            /// class ["mscorlib.dll"."System"."Action`2"]
            /// </summary>
            /// <returns>class System.Action<Game.Script.User.UserPetData , System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnHatchSuccess", "System.Action<Game.Script.User.UserPetData,System.String>")]
            public partial nint ON_HATCH_SUCCESS { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Action<System.String , System.Int32> OnRemoveItem
            /// class ["mscorlib.dll"."System"."Action`2"]
            /// </summary>
            /// <returns>class System.Action<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnRemoveItem", "System.Action<System.String,System.Int32>")]
            public partial nint ON_REMOVE_ITEM { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Action<System.String> OnKill
            /// class ["mscorlib.dll"."System"."Action`1"]
            /// </summary>
            /// <returns>class System.Action<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnKill", "System.Action<System.String>")]
            public partial nint ON_KILL { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Action<System.String , System.Boolean> OnStageEnd
            /// class ["mscorlib.dll"."System"."Action`2"]
            /// </summary>
            /// <returns>class System.Action<System.String , System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnStageEnd", "System.Action<System.String,System.Boolean>")]
            public partial nint ON_STAGE_END { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Action<System.Boolean> OnFightResult
            /// class ["mscorlib.dll"."System"."Action`1"]
            /// </summary>
            /// <returns>class System.Action<System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnFightResult", "System.Action<System.Boolean>")]
            public partial nint ON_FIGHT_RESULT { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Action<Game.Script.Map.Actor.Home.HomeActor> OnBuildFinish
            /// class ["mscorlib.dll"."System"."Action`1"]
            /// </summary>
            /// <returns>class System.Action<Game.Script.Map.Actor.Home.HomeActor></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnBuildFinish", "System.Action<Game.Script.Map.Actor.Home.HomeActor>")]
            public partial nint ON_BUILD_FINISH { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Action OnCommandStationLvUp
            /// class ["mscorlib.dll"."System"."Action"]
            /// </summary>
            /// <returns>class System.Action</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnCommandStationLvUp", "System.Action")]
            public partial nint ON_COMMAND_STATION_LV_UP { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Action<System.String> OnItemSynthesisEnd
            /// class ["mscorlib.dll"."System"."Action`1"]
            /// </summary>
            /// <returns>class System.Action<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnItemSynthesisEnd", "System.Action<System.String>")]
            public partial nint ON_ITEM_SYNTHESIS_END { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Action<System.String> OnBuildProgressEnd
            /// class ["mscorlib.dll"."System"."Action`1"]
            /// </summary>
            /// <returns>class System.Action<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnBuildProgressEnd", "System.Action<System.String>")]
            public partial nint ON_BUILD_PROGRESS_END { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Action<System.String> OnPlayerSowSeed
            /// class ["mscorlib.dll"."System"."Action`1"]
            /// </summary>
            /// <returns>class System.Action<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnPlayerSowSeed", "System.Action<System.String>")]
            public partial nint ON_PLAYER_SOW_SEED { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Action<Game.Script.User.UserPetData> OnPlayerSowStart
            /// class ["mscorlib.dll"."System"."Action`1"]
            /// </summary>
            /// <returns>class System.Action<Game.Script.User.UserPetData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnPlayerSowStart", "System.Action<Game.Script.User.UserPetData>")]
            public partial nint ON_PLAYER_SOW_START { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Action<Game.Script.Character.CharacterAttribute , System.Single , System.Single> OnTiredChanged
            /// class ["mscorlib.dll"."System"."Action`3"]
            /// </summary>
            /// <returns>class System.Action<Game.Script.Character.CharacterAttribute , System.Single , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnTiredChanged", "System.Action<Game.Script.Character.CharacterAttribute,System.Single,System.Single>")]
            public partial nint ON_TIRED_CHANGED { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Action<Game.Script.Character.CharacterAttribute , System.Single , System.Single> OnSatietyChanged
            /// class ["mscorlib.dll"."System"."Action`3"]
            /// </summary>
            /// <returns>class System.Action<Game.Script.Character.CharacterAttribute , System.Single , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnSatietyChanged", "System.Action<Game.Script.Character.CharacterAttribute,System.Single,System.Single>")]
            public partial nint ON_SATIETY_CHANGED { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Action<Game.Script.Character.CharacterAttribute , System.Single , System.Single> OnHealthChanged
            /// class ["mscorlib.dll"."System"."Action`3"]
            /// </summary>
            /// <returns>class System.Action<Game.Script.Character.CharacterAttribute , System.Single , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnHealthChanged", "System.Action<Game.Script.Character.CharacterAttribute,System.Single,System.Single>")]
            public partial nint ON_HEALTH_CHANGED { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Action OnRefreshSkin
            /// class ["mscorlib.dll"."System"."Action"]
            /// </summary>
            /// <returns>class System.Action</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnRefreshSkin", "System.Action")]
            public partial nint ON_REFRESH_SKIN { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Action OnLoadOk
            /// class ["mscorlib.dll"."System"."Action"]
            /// </summary>
            /// <returns>class System.Action</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnLoadOk", "System.Action")]
            public partial nint ON_LOAD_OK { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Action<Game.Script.User.UserHomePetData> OnCureEnd
            /// class ["mscorlib.dll"."System"."Action`1"]
            /// </summary>
            /// <returns>class System.Action<Game.Script.User.UserHomePetData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnCureEnd", "System.Action<Game.Script.User.UserHomePetData>")]
            public partial nint ON_CURE_END { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Action<System.String , Game.Script.User.UserHomePetData , Game.Script.User.UserHomePetData> OnMatingEnd
            /// class ["mscorlib.dll"."System"."Action`3"]
            /// </summary>
            /// <returns>class System.Action<System.String , Game.Script.User.UserHomePetData , Game.Script.User.UserHomePetData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnMatingEnd", "System.Action<System.String,Game.Script.User.UserHomePetData,Game.Script.User.UserHomePetData>")]
            public partial nint ON_MATING_END { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Action<System.String> OnToiletFull
            /// class ["mscorlib.dll"."System"."Action`1"]
            /// </summary>
            /// <returns>class System.Action<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnToiletFull", "System.Action<System.String>")]
            public partial nint ON_TOILET_FULL { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Action<Game.Script.Map.Actor.Home.ItemMachine> OnItemMachineDestroy
            /// class ["mscorlib.dll"."System"."Action`1"]
            /// </summary>
            /// <returns>class System.Action<Game.Script.Map.Actor.Home.ItemMachine></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnItemMachineDestroy", "System.Action<Game.Script.Map.Actor.Home.ItemMachine>")]
            public partial nint ON_ITEM_MACHINE_DESTROY { get; set; } 
*/

            /// <summary>
            /// 0xD0 Game.Script.Character.FightCharacter _homeFightCharacter
            /// class ["Assembly-CSharp.dll"."Game.Script.Character"."FightCharacter"]
            /// </summary>
            /// <returns>class Game.Script.Character.FightCharacter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_homeFightCharacter", "Game.Script.Character.FightCharacter")]
            public partial nint _HOME_FIGHT_CHARACTER { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem.Game"."UserDataSubsystem"]
        /// </summary>
        partial struct Ptr_UserDataSubsystem
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
            ///   System.Void <OnInitialize>b__35_0(Game.Script.GameEvent.IBaseGameEvent gameEvent)
            /// </summary>
            /// <param name = "gameEvent">interface Game.Script.GameEvent.IBaseGameEvent</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<OnInitialize>b__35_0", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.GameEvent.IBaseGameEvent", 0)]
            public partial void ON_INITIALIZEB__35_0(nint gameEvent); 
*/
            /// <summary>
            ///   System.Int32 get_CanFightNum()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CanFightNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_CAN_FIGHT_NUM(); 
*/
            /// <summary>
            ///   Game.Script.Character.FightCharacter get_HomeFightCharacter()
            /// </summary>
            /// <returns>class Game.Script.Character.FightCharacter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_HomeFightCharacter", "Game.Script.Character.FightCharacter", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HOME_FIGHT_CHARACTER(); 
*/
            /// <summary>
            ///   System.Int32 get_SaveIndex()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SaveIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_SAVE_INDEX(); 
*/
            /// <summary>
            ///   System.String get_SavePath()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SavePath", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SAVE_PATH(); 
*/
            /// <summary>
            ///   Game.Script.User.UserData get_UserData()
            /// </summary>
            /// <returns>class Game.Script.User.UserData</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_UserData", "Game.Script.User.UserData", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_USER_DATA(); 
*/
            /// <summary>
            ///   System.Void InitChapters()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitChapters", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_CHAPTERS(); 
*/
            /// <summary>
            ///   System.Void LoadCharacter()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadCharacter", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_CHARACTER(); 
*/
            /// <summary>
            ///   System.Void LoadData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_DATA(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTaskVoid LoadHatch()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTaskVoid</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadHatch", "Cysharp.Threading.Tasks.UniTaskVoid", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTaskVoid LOAD_HATCH(); 
*/
            /// <summary>
            ///   System.Void LoadHomeActors()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadHomeActors", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_HOME_ACTORS(); 
*/
            /// <summary>
            ///   System.Void LoadMapGlobalEffect()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadMapGlobalEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_MAP_GLOBAL_EFFECT(); 
*/
            /// <summary>
            ///   System.Void LoadMapResource()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadMapResource", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LOAD_MAP_RESOURCE(); 
*/
            /// <summary>
            ///   System.Void OnInitialize()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnInitialize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_INITIALIZE(); 
*/
            /// <summary>
            ///   System.Void SaveData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SAVE_DATA(); 
*/
            /// <summary>
            ///   System.Void SaveToFile()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SaveToFile", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SAVE_TO_FILE(); 
*/
            /// <summary>
            ///   System.Void SerializeActorData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeActorData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SERIALIZE_ACTOR_DATA(); 
*/
            /// <summary>
            ///   System.Void SerializeGatherRes(Game.Script.Subsystem.SearchSubsystem searchSubsystem, Game.Script.Map.MapBk mapBk)
            /// </summary>
            /// <param name = "searchSubsystem">class Game.Script.Subsystem.SearchSubsystem</param>
            /// <param name = "mapBk">class Game.Script.Map.MapBk</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeGatherRes", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Subsystem.SearchSubsystem", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.MapBk", 1)]
            public partial void SERIALIZE_GATHER_RES(nint searchSubsystem, nint mapBk); 
*/
            /// <summary>
            ///   System.Void SerializeGlobalEffect()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeGlobalEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SERIALIZE_GLOBAL_EFFECT(); 
*/
            /// <summary>
            ///   System.Void SerializeHomeActors(Game.Script.Subsystem.MapSubsystem mapSubsystem)
            /// </summary>
            /// <param name = "mapSubsystem">class Game.Script.Subsystem.MapSubsystem</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeHomeActors", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Subsystem.MapSubsystem", 0)]
            public partial void SERIALIZE_HOME_ACTORS(nint mapSubsystem); 
*/
            /// <summary>
            ///   System.Void SerializeHomeItems(Game.Script.Subsystem.SearchSubsystem searchSubsystem)
            /// </summary>
            /// <param name = "searchSubsystem">class Game.Script.Subsystem.SearchSubsystem</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeHomeItems", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Subsystem.SearchSubsystem", 0)]
            public partial void SERIALIZE_HOME_ITEMS(nint searchSubsystem); 
*/
            /// <summary>
            ///   System.Void SerializeHomePets(Game.Script.Map.MapBk mapBk)
            /// </summary>
            /// <param name = "mapBk">class Game.Script.Map.MapBk</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeHomePets", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.MapBk", 0)]
            public partial void SERIALIZE_HOME_PETS(nint mapBk); 
*/
            /// <summary>
            ///   System.Void SerializeTask()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeTask", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SERIALIZE_TASK(); 
*/
            /// <summary>
            ///   System.Void set_SaveIndex(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_SaveIndex", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_SAVE_INDEX(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_UserData(Game.Script.User.UserData value)
            /// </summary>
            /// <param name = "value">class Game.Script.User.UserData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_UserData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.User.UserData", 0)]
            public partial void SET_USER_DATA(nint value); 
*/
            /// <summary>
            ///   System.Void SetCommandStationHasNew()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetCommandStationHasNew", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SET_COMMAND_STATION_HAS_NEW(); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTaskVoid SetUserDataOk(Game.Script.User.UserData userData)
            /// </summary>
            /// <param name = "userData">class Game.Script.User.UserData</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTaskVoid</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetUserDataOk", "Cysharp.Threading.Tasks.UniTaskVoid", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.User.UserData", 0)]
            public partial Cysharp.Threading.Tasks.UniTaskVoid SET_USER_DATA_OK(nint userData); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTaskVoid TickSave()
            /// </summary>
            /// <returns>struct Cysharp.Threading.Tasks.UniTaskVoid</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TickSave", "Cysharp.Threading.Tasks.UniTaskVoid", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Cysharp.Threading.Tasks.UniTaskVoid TICK_SAVE(); 
*/
            /// <summary>
            ///   System.Void UpCommandStationLevel()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpCommandStationLevel", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UP_COMMAND_STATION_LEVEL(); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp.dll"."Game.Script.Subsystem"."GameSubsystem"]
        /// </summary>
        partial struct Ptr_UserDataSubsystem
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
            ///   System.Void OnApplicationQuit()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnApplicationQuit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_APPLICATION_QUIT(); 
*/
            /// <summary>
            ///   System.Void OnBeginEnterGame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnBeginEnterGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_BEGIN_ENTER_GAME(); 
*/
            /// <summary>
            ///   System.Void OnInitialize()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnInitialize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_INITIALIZE(); 
*/
            /// <summary>
            ///   System.Void OnReady()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnReady", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_READY(); 
*/
        }
    }
}