using Maple.MonoGameAssistant.Core;

namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."GatherRes_Config"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_GatherRes_Config>, Ptr_GatherRes_Config>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "GatherRes_Config", "GatherRes_Config")]
    public partial class GatherRes_Config
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_GatherRes_Config(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_GatherRes_Config(System.IntPtr ptr) => new Ptr_GatherRes_Config(ptr);
            public static implicit operator System.IntPtr(Ptr_GatherRes_Config ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_GatherRes_Config ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."GatherRes_Config"]
        /// </summary>
        partial struct Ptr_GatherRes_Config
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.String , GatherRes_Config> mDic
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , GatherRes_Config></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mDic", "System.Collections.Generic.Dictionary<System.String,GatherRes_Config>")]
            public static partial PMonoDictionary_OptimizationDefault<PMonoString, GatherRes_Config.Ptr_GatherRes_Config> M_DIC { get; set; }


            /// <summary>
            /// 0x10 System.String Id
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Id", "System.String")]
            public partial PMonoString ID { get; set; }


            /// <summary>
            /// 0x18 System.String NameEditor
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NameEditor", "System.String")]
           public partial nint NAME_EDITOR { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String Name
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Name", "System.String")]
            public partial PMonoString NAME { get; set; }


            /// <summary>
            /// 0x28 System.Int32 filter
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("filter", "System.Int32")]
           public partial System.Int32 FILTER { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String Res
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Res", "System.String")]
           public partial nint RES { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String DropId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DropId", "System.String")]
           public partial nint DROP_ID { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 Life
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Life", "System.Int32")]
           public partial System.Int32 LIFE { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String Action
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Action", "System.String")]
           public partial nint ACTION { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String ToolType
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ToolType", "System.String")]
           public partial nint TOOL_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x58 System.String EffectGatherPoint
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EffectGatherPoint", "System.String")]
           public partial nint EFFECT_GATHER_POINT { get; set; } 
*/

            /// <summary>
            /// 0x60 System.String EffectGather
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EffectGather", "System.String")]
           public partial nint EFFECT_GATHER { get; set; } 
*/

            /// <summary>
            /// 0x68 System.String EffectDie
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EffectDie", "System.String")]
           public partial nint EFFECT_DIE { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Int32 ReFreshTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ReFreshTime", "System.Int32")]
           public partial System.Int32 RE_FRESH_TIME { get; set; } 
*/

            /// <summary>
            /// 0x78 System.String ReFreshNum
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ReFreshNum", "System.String")]
           public partial nint RE_FRESH_NUM { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Int32 LimitNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LimitNum", "System.Int32")]
           public partial System.Int32 LIMIT_NUM { get; set; } 
*/

            /// <summary>
            /// 0x84 System.Int32 GrowUpTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GrowUpTime", "System.Int32")]
           public partial System.Int32 GROW_UP_TIME { get; set; } 
*/

            /// <summary>
            /// 0x88 System.String LelationGaterh
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LelationGaterh", "System.String")]
           public partial nint LELATION_GATERH { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Int32 Land
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Land", "System.Int32")]
           public partial System.Int32 LAND { get; set; } 
*/

            /// <summary>
            /// 0x94 System.Int32 BulletCollision
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BulletCollision", "System.Int32")]
           public partial System.Int32 BULLET_COLLISION { get; set; } 
*/

            /// <summary>
            /// 0x98 System.String SmallImage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SmallImage", "System.String")]
           public partial nint SMALL_IMAGE { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Int32 GatherMask
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GatherMask", "System.Int32")]
           public partial System.Int32 GATHER_MASK { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.String GatherResSound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GatherResSound", "System.String")]
           public partial nint GATHER_RES_SOUND { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.String BornResSound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BornResSound", "System.String")]
           public partial nint BORN_RES_SOUND { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.String DestoryResSound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DestoryResSound", "System.String")]
           public partial nint DESTORY_RES_SOUND { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."GatherRes_Config"]
        /// </summary>
        partial struct Ptr_GatherRes_Config
        {
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.String , GatherRes_Config> get_dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , GatherRes_Config></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dic", "System.Collections.Generic.Dictionary<System.String,GatherRes_Config>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial PMonoDictionary_OptimizationDefault<PMonoString, GatherRes_Config.Ptr_GatherRes_Config> GET_DIC();

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