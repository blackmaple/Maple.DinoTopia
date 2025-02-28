using Maple.MonoGameAssistant.Core;

namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem.Game"."LocalizationSubsystem"]
    /// [Game.Script.Subsystem.GameSubsystem]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_LocalizationSubsystem>, Ptr_LocalizationSubsystem>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "Game.Script.Subsystem.Game", "LocalizationSubsystem", "Game.Script.Subsystem.Game.LocalizationSubsystem")]
    public partial class LocalizationSubsystem
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_LocalizationSubsystem(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_LocalizationSubsystem(System.IntPtr ptr) => new Ptr_LocalizationSubsystem(ptr);
            public static implicit operator System.IntPtr(Ptr_LocalizationSubsystem ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_LocalizationSubsystem ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem.Game"."LocalizationSubsystem"]
        /// </summary>
        partial struct Ptr_LocalizationSubsystem
        {
            /// <summary>
            /// 0x10 System.Collections.Generic.Dictionary<UnityEngine.SystemLanguage , Game.Script.UI.Extern.LanguageData> _languageData
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<UnityEngine.SystemLanguage , Game.Script.UI.Extern.LanguageData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_languageData", "System.Collections.Generic.Dictionary<UnityEngine.SystemLanguage,Game.Script.UI.Extern.LanguageData>")]
            public partial nint _LANGUAGE_DATA { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Action OnLanguageChanged
            /// class ["mscorlib.dll"."System"."Action"]
            /// </summary>
            /// <returns>class System.Action</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OnLanguageChanged", "System.Action")]
            public partial nint ON_LANGUAGE_CHANGED { get; set; } 
*/

            /// <summary>
            /// 0x20 UnityEngine.SystemLanguage _curLanguage
            /// enum ["UnityEngine.CoreModule.dll"."UnityEngine"."SystemLanguage"]
            /// </summary>
            /// <returns>enum UnityEngine.SystemLanguage</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_curLanguage", "UnityEngine.SystemLanguage")]
            public partial UnityEngine.SystemLanguage _CUR_LANGUAGE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem.Game"."LocalizationSubsystem"]
        /// </summary>
        partial struct Ptr_LocalizationSubsystem
        {
            /// <summary>
            /// static  UnityEngine.SystemLanguage get_DefaultLanguage()
            /// </summary>
            /// <returns>enum UnityEngine.SystemLanguage</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_DefaultLanguage", "UnityEngine.SystemLanguage", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial UnityEngine.SystemLanguage GET_DEFAULT_LANGUAGE(); 
*/
            /// <summary>
            /// static  System.String GetLanguage(System.String key)
            /// </summary>
            /// <param name = "key">class System.String</param>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetLanguage", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
           public static partial nint GET_LANGUAGE(nint key); 
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
            ///   System.String Get(System.String key)
            /// </summary>
            /// <param name = "key">class System.String</param>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Get", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial PMonoString GET(PMonoString key);

            /// <summary>
            ///   UnityEngine.SystemLanguage get_CurLanguage()
            /// </summary>
            /// <returns>enum UnityEngine.SystemLanguage</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CurLanguage", "UnityEngine.SystemLanguage", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial UnityEngine.SystemLanguage GET_CUR_LANGUAGE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<UnityEngine.SystemLanguage> get_Languages()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<UnityEngine.SystemLanguage></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Languages", "System.Collections.Generic.List<UnityEngine.SystemLanguage>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint GET_LANGUAGES(); 
*/
            /// <summary>
            ///   System.Boolean IsNeedReplaceSpace(UnityEngine.SystemLanguage language)
            /// </summary>
            /// <param name = "language">enum UnityEngine.SystemLanguage</param>
            /// <returns>struct System.Boolean</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsNeedReplaceSpace", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SystemLanguage", 0)]
           public partial System.Boolean IS_NEED_REPLACE_SPACE(UnityEngine.SystemLanguage language); 
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
            ///   System.Void ReplaceSpace(Game.Script.UI.Extern.LanguageData data)
            /// </summary>
            /// <param name = "data">class Game.Script.UI.Extern.LanguageData</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReplaceSpace", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.UI.Extern.LanguageData", 0)]
           public partial void REPLACE_SPACE(nint data); 
*/
            /// <summary>
            ///   System.Void SetLanguage(UnityEngine.SystemLanguage language)
            /// </summary>
            /// <param name = "language">enum UnityEngine.SystemLanguage</param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetLanguage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SystemLanguage", 0)]
           public partial void SET_LANGUAGE(UnityEngine.SystemLanguage language); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp.dll"."Game.Script.Subsystem"."GameSubsystem"]
        /// </summary>
        partial struct Ptr_LocalizationSubsystem
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