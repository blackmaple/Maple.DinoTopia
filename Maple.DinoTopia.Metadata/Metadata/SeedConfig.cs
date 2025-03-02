using Maple.MonoGameAssistant.Core;

namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."SeedConfig"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SeedConfig>, Ptr_SeedConfig>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "SeedConfig", "SeedConfig")]
    public partial class SeedConfig
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SeedConfig(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SeedConfig(System.IntPtr ptr) => new Ptr_SeedConfig(ptr);
            public static implicit operator System.IntPtr(Ptr_SeedConfig ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_SeedConfig ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."SeedConfig"]
        /// </summary>
        partial struct Ptr_SeedConfig
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.String , SeedConfig> mDic
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , SeedConfig></returns>
           
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mDic", "System.Collections.Generic.Dictionary<System.String,SeedConfig>")]
            public static partial PMonoDictionary_OptimizationDefault<PMonoString, SeedConfig.Ptr_SeedConfig> M_DIC { get; set; } 
 

            /// <summary>
            /// 0x10 System.String Id
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
          
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Id", "System.String")]
            public partial PMonoString ID { get; set; } 
 

            /// <summary>
            /// 0x18 System.String Name
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
           
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Name", "System.String")]
            public partial PMonoString NAME { get; set; } 
 

            /// <summary>
            /// 0x20 System.Single MaturityTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaturityTime", "System.Single")]
            public partial System.Single MATURITY_TIME { get; set; } 
*/

            /// <summary>
            /// 0x24 System.Single MidAgeRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MidAgeRate", "System.Single")]
            public partial System.Single MID_AGE_RATE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Single WaterLoad
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("WaterLoad", "System.Single")]
            public partial System.Single WATER_LOAD { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int32 HarvestLoad
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HarvestLoad", "System.Int32")]
            public partial System.Int32 HARVEST_LOAD { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String BabyRes
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BabyRes", "System.String")]
            public partial nint BABY_RES { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String ChildRes
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChildRes", "System.String")]
            public partial nint CHILD_RES { get; set; } 
*/

            /// <summary>
            /// 0x40 System.String MidAgeRes
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MidAgeRes", "System.String")]
            public partial nint MID_AGE_RES { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String OldRes
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OldRes", "System.String")]
            public partial nint OLD_RES { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String DropId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DropId", "System.String")]
            public partial nint DROP_ID { get; set; } 
*/

            /// <summary>
            /// 0x58 System.String Action
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Action", "System.String")]
            public partial nint ACTION { get; set; } 
*/

            /// <summary>
            /// 0x60 System.String ToolType
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ToolType", "System.String")]
            public partial nint TOOL_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x68 System.String EffectGatherPoint
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EffectGatherPoint", "System.String")]
            public partial nint EFFECT_GATHER_POINT { get; set; } 
*/

            /// <summary>
            /// 0x70 System.String EffectGather
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EffectGather", "System.String")]
            public partial nint EFFECT_GATHER { get; set; } 
*/

            /// <summary>
            /// 0x78 System.String EffectDie
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("EffectDie", "System.String")]
            public partial nint EFFECT_DIE { get; set; } 
*/

            /// <summary>
            /// 0x80 System.String SowingSound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SowingSound", "System.String")]
            public partial nint SOWING_SOUND { get; set; } 
*/

            /// <summary>
            /// 0x88 System.String WaterSound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("WaterSound", "System.String")]
            public partial nint WATER_SOUND { get; set; } 
*/

            /// <summary>
            /// 0x90 System.String FertilizeSound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FertilizeSound", "System.String")]
            public partial nint FERTILIZE_SOUND { get; set; } 
*/

            /// <summary>
            /// 0x98 System.String HarvestSound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HarvestSound", "System.String")]
            public partial nint HARVEST_SOUND { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.String BornSound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BornSound", "System.String")]
            public partial nint BORN_SOUND { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.String DestorySound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DestorySound", "System.String")]
            public partial nint DESTORY_SOUND { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."SeedConfig"]
        /// </summary>
        partial struct Ptr_SeedConfig
        {
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.String , SeedConfig> get_dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , SeedConfig></returns>
            
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dic", "System.Collections.Generic.Dictionary<System.String,SeedConfig>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial PMonoDictionary_OptimizationDefault<PMonoString, SeedConfig.Ptr_SeedConfig> GET_DIC(); 
 
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