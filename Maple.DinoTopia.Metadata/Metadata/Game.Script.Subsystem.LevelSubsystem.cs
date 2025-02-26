namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem"."LevelSubsystem"]
    /// [Game.Script.Subsystem.GameSubsystem]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_LevelSubsystem>, Ptr_LevelSubsystem>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "Game.Script.Subsystem", "LevelSubsystem", "Game.Script.Subsystem.LevelSubsystem")]
    public partial class LevelSubsystem
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_LevelSubsystem(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_LevelSubsystem(System.IntPtr ptr) => new Ptr_LevelSubsystem(ptr);
            public static implicit operator System.IntPtr(Ptr_LevelSubsystem ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_LevelSubsystem ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem"."LevelSubsystem"]
        /// </summary>
        partial struct Ptr_LevelSubsystem
        {
            /// <summary>
            /// 0x10 System.Action<Game.Script.Subsystem.LevelType , Game.Script.Subsystem.LevelType> PreLevelChange
            /// class ["mscorlib.dll"."System"."Action`2"]
            /// </summary>
            /// <returns>class System.Action<Game.Script.Subsystem.LevelType , Game.Script.Subsystem.LevelType></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PreLevelChange", "System.Action<Game.Script.Subsystem.LevelType,Game.Script.Subsystem.LevelType>")]
            public partial nint PRE_LEVEL_CHANGE { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.Dictionary<Game.Script.Subsystem.LevelType , Game.Script.Level.Level> _levels
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<Game.Script.Subsystem.LevelType , Game.Script.Level.Level></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_levels", "System.Collections.Generic.Dictionary<Game.Script.Subsystem.LevelType,Game.Script.Level.Level>")]
            public partial nint _LEVELS { get; set; } 
*/

            /// <summary>
            /// 0x20 UnityEngine.Camera _mainCamera
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Camera"]
            /// </summary>
            /// <returns>class UnityEngine.Camera</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_mainCamera", "UnityEngine.Camera")]
            public partial nint _MAIN_CAMERA { get; set; } 
*/

            /// <summary>
            /// 0x28 Game.Script.Subsystem.LevelType _curLevel
            /// enum ["Assembly-CSharp.dll"."Game.Script.Subsystem"."LevelType"]
            /// </summary>
            /// <returns>enum Game.Script.Subsystem.LevelType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_curLevel", "Game.Script.Subsystem.LevelType")]
            public partial Game.Script.Subsystem.LevelType _CUR_LEVEL { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem"."LevelSubsystem"]
        /// </summary>
        partial struct Ptr_LevelSubsystem
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
            ///   Cysharp.Threading.Tasks.UniTaskVoid DoEnter(Game.Script.Subsystem.LevelType levelType)
            /// </summary>
            /// <param name = "levelType">enum Game.Script.Subsystem.LevelType</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTaskVoid</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoEnter", "Cysharp.Threading.Tasks.UniTaskVoid", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Subsystem.LevelType", 0)]
            public partial Cysharp.Threading.Tasks.UniTaskVoid DO_ENTER(Game.Script.Subsystem.LevelType levelType); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTaskVoid Enter(Game.Script.Subsystem.LevelType levelType)
            /// </summary>
            /// <param name = "levelType">enum Game.Script.Subsystem.LevelType</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTaskVoid</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Enter", "Cysharp.Threading.Tasks.UniTaskVoid", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Subsystem.LevelType", 0)]
            public partial Cysharp.Threading.Tasks.UniTaskVoid ENTER(Game.Script.Subsystem.LevelType levelType); 
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
            ///   System.Void OnItReflection(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnItReflection", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public partial void ON_IT_REFLECTION(nint type); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp.dll"."Game.Script.Subsystem"."GameSubsystem"]
        /// </summary>
        partial struct Ptr_LevelSubsystem
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