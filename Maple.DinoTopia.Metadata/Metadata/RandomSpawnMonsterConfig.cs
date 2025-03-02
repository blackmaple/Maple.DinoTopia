using Maple.MonoGameAssistant.Core;

namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."RandomSpawnMonsterConfig"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_RandomSpawnMonsterConfig>, Ptr_RandomSpawnMonsterConfig>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "RandomSpawnMonsterConfig", "RandomSpawnMonsterConfig")]
    public partial class RandomSpawnMonsterConfig
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_RandomSpawnMonsterConfig(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_RandomSpawnMonsterConfig(System.IntPtr ptr) => new Ptr_RandomSpawnMonsterConfig(ptr);
            public static implicit operator System.IntPtr(Ptr_RandomSpawnMonsterConfig ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_RandomSpawnMonsterConfig ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."RandomSpawnMonsterConfig"]
        /// </summary>
        partial struct Ptr_RandomSpawnMonsterConfig
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.Int32 , RandomSpawnMonsterConfig> mDic
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , RandomSpawnMonsterConfig></returns>
            
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mDic", "System.Collections.Generic.Dictionary<System.Int32,RandomSpawnMonsterConfig>")]
            public static partial PMonoDictionary_OptimizationDefault<int, RandomSpawnMonsterConfig.Ptr_RandomSpawnMonsterConfig> M_DIC { get; set; } 
 

            /// <summary>
            /// 0x10 System.Int32 Id
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
          
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Id", "System.Int32")]
            public partial System.Int32 ID { get; set; } 
 

            /// <summary>
            /// 0x18 System.String RoomId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RoomId", "System.String")]
            public partial PMonoString ROOM_ID { get; set; } 
 

            /// <summary>
            /// 0x20 System.Int32 Round
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Round", "System.Int32")]
            public partial System.Int32 ROUND { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String[] MonsterId
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MonsterId", "System.String[]")]
            public partial nint MONSTER_ID { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String[] MonsterNum
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MonsterNum", "System.String[]")]
            public partial nint MONSTER_NUM { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32 MonsterTypeNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MonsterTypeNum", "System.Int32")]
            public partial System.Int32 MONSTER_TYPE_NUM { get; set; } 
*/

            /// <summary>
            /// 0x40 System.String MonsterLocation
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MonsterLocation", "System.String")]
            public partial nint MONSTER_LOCATION { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String[] TrapId
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TrapId", "System.String[]")]
            public partial nint TRAP_ID { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String[] TrapNum
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TrapNum", "System.String[]")]
            public partial nint TRAP_NUM { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Int32 TrapTypeNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TrapTypeNum", "System.Int32")]
            public partial System.Int32 TRAP_TYPE_NUM { get; set; } 
*/

            /// <summary>
            /// 0x60 System.String TrapLocation
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TrapLocation", "System.String")]
            public partial nint TRAP_LOCATION { get; set; } 
*/

            /// <summary>
            /// 0x68 System.String[] GatherId
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GatherId", "System.String[]")]
            public partial nint GATHER_ID { get; set; } 
*/

            /// <summary>
            /// 0x70 System.String[] GatherNum
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GatherNum", "System.String[]")]
            public partial nint GATHER_NUM { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Int32 GatherTypeNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GatherTypeNum", "System.Int32")]
            public partial System.Int32 GATHER_TYPE_NUM { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."RandomSpawnMonsterConfig"]
        /// </summary>
        partial struct Ptr_RandomSpawnMonsterConfig
        {
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.Int32 , RandomSpawnMonsterConfig> get_dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , RandomSpawnMonsterConfig></returns>
           
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dic", "System.Collections.Generic.Dictionary<System.Int32,RandomSpawnMonsterConfig>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial PMonoDictionary_OptimizationDefault<int, RandomSpawnMonsterConfig.Ptr_RandomSpawnMonsterConfig> GET_DIC(); 
 
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