namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."TecRuleConfig"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TecRuleConfig>, Ptr_TecRuleConfig>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "TecRuleConfig", "TecRuleConfig")]
    public partial class TecRuleConfig
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TecRuleConfig(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TecRuleConfig(System.IntPtr ptr) => new Ptr_TecRuleConfig(ptr);
            public static implicit operator System.IntPtr(Ptr_TecRuleConfig ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TecRuleConfig ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TecRuleConfig"]
        /// </summary>
        partial struct Ptr_TecRuleConfig
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.String , TecRuleConfig> mDic
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , TecRuleConfig></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mDic", "System.Collections.Generic.Dictionary<System.String,TecRuleConfig>")]
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
            /// 0x18 System.String NameInside
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NameInside", "System.String")]
            public partial nint NAME_INSIDE { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String DescInside
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DescInside", "System.String")]
            public partial nint DESC_INSIDE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String Name
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Name", "System.String")]
            public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String Desc
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Desc", "System.String")]
            public partial nint DESC { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String Icon
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Icon", "System.String")]
            public partial nint ICON { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 Level
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Level", "System.Int32")]
            public partial System.Int32 LEVEL { get; set; } 
*/

            /// <summary>
            /// 0x44 System.Int32 Type
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Type", "System.Int32")]
            public partial System.Int32 TYPE { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Single UnLockLoad
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UnLockLoad", "System.Single")]
            public partial System.Single UN_LOCK_LOAD { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String[] NeedRes
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NeedRes", "System.String[]")]
            public partial nint NEED_RES { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Single CoolDown
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CoolDown", "System.Single")]
            public partial System.Single COOL_DOWN { get; set; } 
*/

            /// <summary>
            /// 0x60 System.String AddEffect
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AddEffect", "System.String")]
            public partial nint ADD_EFFECT { get; set; } 
*/

            /// <summary>
            /// 0x68 System.String SmallImage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SmallImage", "System.String")]
            public partial nint SMALL_IMAGE { get; set; } 
*/

            /// <summary>
            /// 0x70 System.String TimeLineID
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TimeLineID", "System.String")]
            public partial nint TIME_LINE_ID { get; set; } 
*/

            /// <summary>
            /// 0x78 System.String RelationRule
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RelationRule", "System.String")]
            public partial nint RELATION_RULE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TecRuleConfig"]
        /// </summary>
        partial struct Ptr_TecRuleConfig
        {
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.String , TecRuleConfig> get_dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , TecRuleConfig></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dic", "System.Collections.Generic.Dictionary<System.String,TecRuleConfig>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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