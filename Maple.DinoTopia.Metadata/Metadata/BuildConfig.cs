using Maple.MonoGameAssistant.Core;

namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."BuildConfig"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_BuildConfig>, Ptr_BuildConfig>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "BuildConfig", "BuildConfig")]
    public partial class BuildConfig
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_BuildConfig(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_BuildConfig(System.IntPtr ptr) => new Ptr_BuildConfig(ptr);
            public static implicit operator System.IntPtr(Ptr_BuildConfig ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_BuildConfig ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BuildConfig"]
        /// </summary>
        partial struct Ptr_BuildConfig
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.String , BuildConfig> mDic
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , BuildConfig></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mDic", "System.Collections.Generic.Dictionary<System.String,BuildConfig>")]
            public static partial PMonoDictionary_OptimizationDefault<PMonoString, BuildConfig.Ptr_BuildConfig> M_DIC { get; set; }


            /// <summary>
            /// 0x10 System.String id
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.String")]
            public partial PMonoString ID { get; }


            /// <summary>
            /// 0x18 System.String name
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
            public partial PMonoString NAME { get; }


            /// <summary>
            /// 0x20 System.String des
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("des", "System.String")]
            public partial PMonoString DES { get; }


            /// <summary>
            /// 0x28 System.String NameInside
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NameInside", "System.String")]
           public partial nint NAME_INSIDE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String DesInside
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DesInside", "System.String")]
           public partial nint DES_INSIDE { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String res
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("res", "System.String")]
           public partial nint RES { get; set; } 
*/

            /// <summary>
            /// 0x40 System.String icon
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("icon", "System.String")]
           public partial nint ICON { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 BuilType
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BuilType", "System.Int32")]
           public partial System.Int32 BUIL_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x4C System.Int32 SortType
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SortType", "System.Int32")]
           public partial System.Int32 SORT_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int32 CanDelete
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CanDelete", "System.Int32")]
           public partial System.Int32 CAN_DELETE { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Int32 Limit
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Limit", "System.Int32")]
           public partial System.Int32 LIMIT { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Single ConstructionLoad
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ConstructionLoad", "System.Single")]
           public partial System.Single CONSTRUCTION_LOAD { get; set; } 
*/

            /// <summary>
            /// 0x60 System.String[] NeedItem
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NeedItem", "System.String[]")]
           public partial nint NEED_ITEM { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Single BuildTiredResume
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BuildTiredResume", "System.Single")]
           public partial System.Single BUILD_TIRED_RESUME { get; set; } 
*/

            /// <summary>
            /// 0x6C System.Single BuildHealthResume
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BuildHealthResume", "System.Single")]
           public partial System.Single BUILD_HEALTH_RESUME { get; set; } 
*/

            /// <summary>
            /// 0x70 System.String[] RelationItem
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RelationItem", "System.String[]")]
           public partial nint RELATION_ITEM { get; set; } 
*/

            /// <summary>
            /// 0x78 System.String SmallImage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SmallImage", "System.String")]
           public partial nint SMALL_IMAGE { get; set; } 
*/

            /// <summary>
            /// 0x80 System.String GetherSmallImage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GetherSmallImage", "System.String")]
           public partial nint GETHER_SMALL_IMAGE { get; set; } 
*/

            /// <summary>
            /// 0x88 System.String Action
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Action", "System.String")]
           public partial nint ACTION { get; set; } 
*/

            /// <summary>
            /// 0x90 System.String ToolType
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ToolType", "System.String")]
           public partial nint TOOL_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x98 System.String EffectGatherPoint
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EffectGatherPoint", "System.String")]
           public partial nint EFFECT_GATHER_POINT { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.String EffectGather
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EffectGather", "System.String")]
           public partial nint EFFECT_GATHER { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.String DropItemId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DropItemId", "System.String")]
           public partial nint DROP_ITEM_ID { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Int32 Life
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Life", "System.Int32")]
           public partial System.Int32 LIFE { get; set; } 
*/

            /// <summary>
            /// 0xB4 System.Int32 DropItemLimit
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DropItemLimit", "System.Int32")]
           public partial System.Int32 DROP_ITEM_LIMIT { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.String[] HealthResumeNeedItem
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HealthResumeNeedItem", "System.String[]")]
           public partial nint HEALTH_RESUME_NEED_ITEM { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.String TimeLineID
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TimeLineID", "System.String")]
           public partial nint TIME_LINE_ID { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.String WorkBuildSound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("WorkBuildSound", "System.String")]
           public partial nint WORK_BUILD_SOUND { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."BuildConfig"]
        /// </summary>
        partial struct Ptr_BuildConfig
        {
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.String , BuildConfig> get_dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , BuildConfig></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dic", "System.Collections.Generic.Dictionary<System.String,BuildConfig>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial PMonoDictionary_OptimizationDefault<PMonoString, BuildConfig.Ptr_BuildConfig> GET_DIC();

            /// <summary>
            /// static  System.Void OnLoad(System.Collections.Generic.List<CSVHelper.CsvRow> rows)
            /// </summary>
            /// <param name = "rows">class System.Collections.Generic.List<CSVHelper.CsvRow></param>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnLoad", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<CSVHelper.CsvRow>", 0)]
           public static partial void ON_LOAD(nint rows); 
*/
            /// <summary>
            /// static  System.Void OnQuit()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnQuit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public static partial void ON_QUIT(); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial void CTOR(); 
*/
        }
    }
}