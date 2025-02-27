using Maple.MonoGameAssistant.Core;

namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Game.Script.Common"."Game"]
    /// [Game.Script.Common.SingletonWithOnInstance<Game.Script.Common.Game>]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Game>, Ptr_Game>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "Game.Script.Common", "Game", "Game.Script.Common.Game")]
    public partial class Game
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Game(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_Game(System.IntPtr ptr) => new Ptr_Game(ptr);
            public static implicit operator System.IntPtr(Ptr_Game ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_Game ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Common"."Game"]
        /// </summary>
        partial struct Ptr_Game
        {
            /// <summary>
            /// 0x0 System.Int64 TickMaxTime
            /// struct ["mscorlib.dll"."System"."Int64"]
            /// </summary>
            /// <returns>struct System.Int64</returns>
            /*
           public const System.Int64 TICK_MAX_TIME = 5; 
*/
            /// <summary>
            /// 0x0 System.Action OnQuit
            /// class ["mscorlib.dll"."System"."Action"]
            /// </summary>
            /// <returns>class System.Action</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnQuit", "System.Action")]
           public static partial nint ON_QUIT { get; set; } 
*/

            /// <summary>
            /// 0x0 Game.Script.Common.Game _instance
            /// class ["Assembly-CSharp.dll"."Game.Script.Common"."Game"]
            /// </summary>
            /// <returns>class Game.Script.Common.Game</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_instance", "Game.Script.Common.Game")]
            public static partial Game.Ptr_Game _INSTANCE { get; }


            /// <summary>
            /// 0x10 System.Action<System.String> OnAddDialog
            /// class ["mscorlib.dll"."System"."Action`1"]
            /// </summary>
            /// <returns>class System.Action<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnAddDialog", "System.Action<System.String>")]
           public partial nint ON_ADD_DIALOG { get; set; } 
*/

            /// <summary>
            /// 0x18 Game.Script.Common.OnLineState <OnLineState>k__BackingField
            /// enum ["Assembly-CSharp.dll"."Game.Script.Common"."OnLineState"]
            /// </summary>
            /// <returns>enum Game.Script.Common.OnLineState</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<OnLineState>k__BackingField", "Game.Script.Common.OnLineState")]
           public partial Game.Script.Common.OnLineState ON_LINE_STATE { get; set; } 
*/

            /// <summary>
            /// 0x1C Game.Script.Common.GameMode <Mode>k__BackingField
            /// enum ["Assembly-CSharp.dll"."Game.Script.Common"."GameMode"]
            /// </summary>
            /// <returns>enum Game.Script.Common.GameMode</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Mode>k__BackingField", "Game.Script.Common.GameMode")]
           public partial Game.Script.Common.GameMode MODE { get; set; } 
*/

            /// <summary>
            /// 0x20 Game.Script.Common.GamePlatform <Platform>k__BackingField
            /// enum ["Assembly-CSharp.dll"."Game.Script.Common"."GamePlatform"]
            /// </summary>
            /// <returns>enum Game.Script.Common.GamePlatform</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Platform>k__BackingField", "Game.Script.Common.GamePlatform")]
           public partial Game.Script.Common.GamePlatform PLATFORM { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.Dictionary<System.String , Game.Script.Common.World> _worlds
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , Game.Script.Common.World></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_worlds", "System.Collections.Generic.Dictionary<System.String,Game.Script.Common.World>")]
           public partial nint _WORLDS { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String <LoadMapName>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<LoadMapName>k__BackingField", "System.String")]
           public partial nint LOAD_MAP_NAME { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.Dictionary<System.Type , Game.Script.Subsystem.GameSubsystem> _subsystems
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Type , Game.Script.Subsystem.GameSubsystem></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_subsystems", "System.Collections.Generic.Dictionary<System.Type,Game.Script.Subsystem.GameSubsystem>")]
            public partial PMonoDictionary_OptimizationDefault<PMonoObject, PMonoObject> _SUBSYSTEMS { get; set; }


            /// <summary>
            /// 0x40 Game.Script.Character.FightCharacter _myController
            /// class ["Assembly-CSharp.dll"."Game.Script.Character"."FightCharacter"]
            /// </summary>
            /// <returns>class Game.Script.Character.FightCharacter</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_myController", "Game.Script.Character.FightCharacter")]
           public partial nint _MY_CONTROLLER { get; set; } 
*/

            /// <summary>
            /// 0x48 Game.Script.Map.MapBk _mapBk
            /// class ["Assembly-CSharp.dll"."Game.Script.Map"."MapBk"]
            /// </summary>
            /// <returns>class Game.Script.Map.MapBk</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_mapBk", "Game.Script.Map.MapBk")]
           public partial nint _MAP_BK { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Threading.Thread <MainThread>k__BackingField
            /// class ["mscorlib.dll"."System.Threading"."Thread"]
            /// </summary>
            /// <returns>class System.Threading.Thread</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<MainThread>k__BackingField", "System.Threading.Thread")]
           public partial nint MAIN_THREAD { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Action<System.Type> OnItReflection
            /// class ["mscorlib.dll"."System"."Action`1"]
            /// </summary>
            /// <returns>class System.Action<System.Type></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnItReflection", "System.Action<System.Type>")]
           public partial nint ON_IT_REFLECTION { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Common"."Game"]
        /// </summary>
        partial struct Ptr_Game
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
            ///   System.Void AddDialog(System.String message)
            /// </summary>
            /// <param name = "message">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddDialog", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ADD_DIALOG(nint message); 
*/
            /// <summary>
            ///   System.Void Collect()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Collect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void COLLECT(); 
*/
            /// <summary>
            ///   Game.Script.Common.World CreateWorld(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>class Game.Script.Common.World</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateWorld", "Game.Script.Common.World", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint CREATE_WORLD(nint name); 
*/
            /// <summary>
            ///   System.Void EnterGame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EnterGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ENTER_GAME(); 
*/
            /// <summary>
            ///   System.String get_LoadMapName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_LoadMapName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_LOAD_MAP_NAME(); 
*/
            /// <summary>
            ///   System.Threading.Thread get_MainThread()
            /// </summary>
            /// <returns>class System.Threading.Thread</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MainThread", "System.Threading.Thread", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MAIN_THREAD(); 
*/
            /// <summary>
            ///   Game.Script.Common.GameMode get_Mode()
            /// </summary>
            /// <returns>enum Game.Script.Common.GameMode</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Mode", "Game.Script.Common.GameMode", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Game.Script.Common.GameMode GET_MODE(); 
*/
            /// <summary>
            ///   Game.Script.Character.FightCharacter get_MyController()
            /// </summary>
            /// <returns>class Game.Script.Character.FightCharacter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MyController", "Game.Script.Character.FightCharacter", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MY_CONTROLLER(); 
*/
            /// <summary>
            ///   Game.Script.Common.OnLineState get_OnLineState()
            /// </summary>
            /// <returns>enum Game.Script.Common.OnLineState</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_OnLineState", "Game.Script.Common.OnLineState", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Game.Script.Common.OnLineState GET_ON_LINE_STATE(); 
*/
            /// <summary>
            ///   Game.Script.Common.GamePlatform get_Platform()
            /// </summary>
            /// <returns>enum Game.Script.Common.GamePlatform</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Platform", "Game.Script.Common.GamePlatform", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Game.Script.Common.GamePlatform GET_PLATFORM(); 
*/
            /// <summary>
            ///   Game.Script.Character.FightCharacterController GetController(System.String worldName)
            /// </summary>
            /// <param name = "worldName">class System.String</param>
            /// <returns>class Game.Script.Character.FightCharacterController</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetController", "Game.Script.Character.FightCharacterController", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_CONTROLLER(nint worldName); 
*/
            /// <summary>
            ///   Game.Script.Character.FightCharacterController GetController()
            /// </summary>
            /// <returns>class Game.Script.Character.FightCharacterController</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetController", "Game.Script.Character.FightCharacterController", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CONTROLLER(); 
*/
            /// <summary>
            ///   Game.Script.Map.MapBk GetCurMapBk()
            /// </summary>
            /// <returns>class Game.Script.Map.MapBk</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCurMapBk", "Game.Script.Map.MapBk", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CUR_MAP_BK(); 
*/
            /// <summary>
            ///   T GetSubsystem()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSubsystem", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SUBSYSTEM(); 
*/
            /// <summary>
            ///   Game.Script.Common.World GetWorld(System.String name)
            /// </summary>
            /// <param name = "name">class System.String</param>
            /// <returns>class Game.Script.Common.World</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetWorld", "Game.Script.Common.World", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_WORLD(nint name); 
*/
            /// <summary>
            ///   System.Void InitReflection()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitReflection", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_REFLECTION(); 
*/
            /// <summary>
            ///   System.Void NotifyBeginEnterGame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("NotifyBeginEnterGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void NOTIFY_BEGIN_ENTER_GAME(); 
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
            ///   System.Void OnInstance()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnInstance", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_INSTANCE(); 
*/
            /// <summary>
            ///   System.Void Ready()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Ready", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void READY(); 
*/
            /// <summary>
            ///   System.Void set_LoadMapName(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_LoadMapName", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_LOAD_MAP_NAME(nint value); 
*/
            /// <summary>
            ///   System.Void set_MainThread(System.Threading.Thread value)
            /// </summary>
            /// <param name = "value">class System.Threading.Thread</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_MainThread", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Threading.Thread", 0)]
            public partial void SET_MAIN_THREAD(nint value); 
*/
            /// <summary>
            ///   System.Void set_Mode(Game.Script.Common.GameMode value)
            /// </summary>
            /// <param name = "value">enum Game.Script.Common.GameMode</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Mode", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.GameMode", 0)]
            public partial void SET_MODE(Game.Script.Common.GameMode value); 
*/
            /// <summary>
            ///   System.Void set_MyController(Game.Script.Character.FightCharacter value)
            /// </summary>
            /// <param name = "value">class Game.Script.Character.FightCharacter</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_MyController", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.FightCharacter", 0)]
            public partial void SET_MY_CONTROLLER(nint value); 
*/
            /// <summary>
            ///   System.Void set_OnLineState(Game.Script.Common.OnLineState value)
            /// </summary>
            /// <param name = "value">enum Game.Script.Common.OnLineState</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_OnLineState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.OnLineState", 0)]
            public partial void SET_ON_LINE_STATE(Game.Script.Common.OnLineState value); 
*/
            /// <summary>
            ///   System.Void set_Platform(Game.Script.Common.GamePlatform value)
            /// </summary>
            /// <param name = "value">enum Game.Script.Common.GamePlatform</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Platform", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.GamePlatform", 0)]
            public partial void SET_PLATFORM(Game.Script.Common.GamePlatform value); 
*/
            /// <summary>
            ///   System.Void StartConnect()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartConnect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void START_CONNECT(); 
*/
            /// <summary>
            ///   System.Void StartGame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void START_GAME(); 
*/
            /// <summary>
            ///   System.Void StartServer()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartServer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void START_SERVER(); 
*/
            /// <summary>
            ///   System.Void StartSingle()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartSingle", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void START_SINGLE(); 
*/
        }

        /// <summary>
        /// class ["GameBase.dll"."Game.Script.Common"."SingletonWithOnInstance`1"]
        /// </summary>
        partial struct Ptr_Game
        {
            /// <summary>
            /// static  Game.Script.Common.Game get_Instance()
            /// </summary>
            /// <returns>class Game.Script.Common.Game</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Instance", "Game.Script.Common.Game", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_INSTANCE(); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void OnDestroySingleton()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDestroySingleton", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_DESTROY_SINGLETON(); 
*/
            /// <summary>
            ///   System.Void OnInstance()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnInstance", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_INSTANCE(); 
*/
        }
    }
}