namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."HomeUpdateConfig"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_HomeUpdateConfig>, Ptr_HomeUpdateConfig>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "HomeUpdateConfig", "HomeUpdateConfig")]
    public partial class HomeUpdateConfig
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_HomeUpdateConfig(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_HomeUpdateConfig(System.IntPtr ptr) => new Ptr_HomeUpdateConfig(ptr);
            public static implicit operator System.IntPtr(Ptr_HomeUpdateConfig ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_HomeUpdateConfig ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."HomeUpdateConfig"]
        /// </summary>
        partial struct Ptr_HomeUpdateConfig
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.String , HomeUpdateConfig> mDic
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , HomeUpdateConfig></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mDic", "System.Collections.Generic.Dictionary<System.String,HomeUpdateConfig>")]
            public static partial nint M_DIC { get; set; } 
*/

            /// <summary>
            /// 0x10 System.String Id
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Id", "System.String")]
            public partial nint ID { get; set; } 
*/

            /// <summary>
            /// 0x18 System.String[] DescInside
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DescInside", "System.String[]")]
            public partial nint DESC_INSIDE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32[] ConditionType
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ConditionType", "System.Int32[]")]
            public partial nint CONDITION_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String[] ConditionPara
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ConditionPara", "System.String[]")]
            public partial nint CONDITION_PARA { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32[] RewardType
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RewardType", "System.Int32[]")]
            public partial nint REWARD_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String[] RewardPara
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RewardPara", "System.String[]")]
            public partial nint REWARD_PARA { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."HomeUpdateConfig"]
        /// </summary>
        partial struct Ptr_HomeUpdateConfig
        {
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.String , HomeUpdateConfig> get_dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , HomeUpdateConfig></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dic", "System.Collections.Generic.Dictionary<System.String,HomeUpdateConfig>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint GET_DIC(); 
*/
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