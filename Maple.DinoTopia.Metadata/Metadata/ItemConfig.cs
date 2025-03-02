using Maple.MonoGameAssistant.Core;

namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."ItemConfig"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ItemConfig>, Ptr_ItemConfig>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "ItemConfig", "ItemConfig")]
    public partial class ItemConfig
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ItemConfig(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ItemConfig(System.IntPtr ptr) => new Ptr_ItemConfig(ptr);
            public static implicit operator System.IntPtr(Ptr_ItemConfig ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_ItemConfig ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ItemConfig"]
        /// </summary>
        partial struct Ptr_ItemConfig
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.String , ItemConfig> mDic
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , ItemConfig></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mDic", "System.Collections.Generic.Dictionary<System.String,ItemConfig>")]
            public static partial PMonoDictionary_OptimizationDefault<PMonoString, ItemConfig.Ptr_ItemConfig> M_DIC { get; }


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
            /// 0x20 System.String Desc
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Desc", "System.String")]
            public partial PMonoString DESC { get; }


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
            /// 0x30 System.String DescInside
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DescInside", "System.String")]
           public partial nint DESC_INSIDE { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String icon
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("icon", "System.String")]
           public partial nint ICON { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 Type
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Type", "System.Int32")]
           public partial System.Int32 TYPE { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String HatchPetId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HatchPetId", "System.String")]
           public partial nint HATCH_PET_ID { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Single FoodSatietyResume
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FoodSatietyResume", "System.Single")]
           public partial System.Single FOOD_SATIETY_RESUME { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Single MakeLoad
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MakeLoad", "System.Single")]
           public partial System.Single MAKE_LOAD { get; set; } 
*/

            /// <summary>
            /// 0x58 System.String[] NeedItem
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NeedItem", "System.String[]")]
           public partial nint NEED_ITEM { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Single ReduceGrowthTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ReduceGrowthTime", "System.Single")]
           public partial System.Single REDUCE_GROWTH_TIME { get; set; } 
*/

            /// <summary>
            /// 0x64 System.Int32 HatchTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HatchTime", "System.Int32")]
           public partial System.Int32 HATCH_TIME { get; set; } 
*/

            /// <summary>
            /// 0x68 System.Int32 BagType
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BagType", "System.Int32")]
           public partial System.Int32 BAG_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x70 System.String SmallImage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SmallImage", "System.String")]
           public partial nint SMALL_IMAGE { get; set; } 
*/

            /// <summary>
            /// 0x78 System.String QualityIconSmall
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("QualityIconSmall", "System.String")]
           public partial nint QUALITY_ICON_SMALL { get; set; } 
*/

            /// <summary>
            /// 0x80 System.String FoodAddBuff
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FoodAddBuff", "System.String")]
           public partial nint FOOD_ADD_BUFF { get; set; } 
*/

            /// <summary>
            /// 0x88 System.String FoodTired
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FoodTired", "System.String")]
           public partial nint FOOD_TIRED { get; set; } 
*/

            /// <summary>
            /// 0x90 System.String FoodHealth
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FoodHealth", "System.String")]
           public partial nint FOOD_HEALTH { get; set; } 
*/

            /// <summary>
            /// 0x98 System.Single FoodShitPro
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FoodShitPro", "System.Single")]
           public partial System.Single FOOD_SHIT_PRO { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.String FoodDropItem
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FoodDropItem", "System.String")]
           public partial nint FOOD_DROP_ITEM { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.Int32 DisplayIndex
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DisplayIndex", "System.Int32")]
           public partial System.Int32 DISPLAY_INDEX { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.String GroundColor
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("GroundColor", "System.String")]
           public partial nint GROUND_COLOR { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."ItemConfig"]
        /// </summary>
        partial struct Ptr_ItemConfig
        {
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.String , ItemConfig> get_dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , ItemConfig></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dic", "System.Collections.Generic.Dictionary<System.String,ItemConfig>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial PMonoDictionary_OptimizationDefault<PMonoString, ItemConfig.Ptr_ItemConfig> GET_DIC();

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