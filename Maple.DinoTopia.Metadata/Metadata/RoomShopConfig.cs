namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."RoomShopConfig"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_RoomShopConfig>, Ptr_RoomShopConfig>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "RoomShopConfig", "RoomShopConfig")]
    public partial class RoomShopConfig
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_RoomShopConfig(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_RoomShopConfig(System.IntPtr ptr) => new Ptr_RoomShopConfig(ptr);
            public static implicit operator System.IntPtr(Ptr_RoomShopConfig ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_RoomShopConfig ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."RoomShopConfig"]
        /// </summary>
        partial struct Ptr_RoomShopConfig
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.String , RoomShopConfig> mDic
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , RoomShopConfig></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mDic", "System.Collections.Generic.Dictionary<System.String,RoomShopConfig>")]
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
            /// 0x18 System.String[] Store1
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Store1", "System.String[]")]
            public partial nint STORE1 { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String[] Store2
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Store2", "System.String[]")]
            public partial nint STORE2 { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String[] Store3
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Store3", "System.String[]")]
            public partial nint STORE3 { get; set; } 
*/

            /// <summary>
            /// 0x30 System.String[] Store4
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Store4", "System.String[]")]
            public partial nint STORE4 { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String[] Store5
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Store5", "System.String[]")]
            public partial nint STORE5 { get; set; } 
*/

            /// <summary>
            /// 0x40 System.String[] Store6
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Store6", "System.String[]")]
            public partial nint STORE6 { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."RoomShopConfig"]
        /// </summary>
        partial struct Ptr_RoomShopConfig
        {
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.String , RoomShopConfig> get_dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , RoomShopConfig></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dic", "System.Collections.Generic.Dictionary<System.String,RoomShopConfig>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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