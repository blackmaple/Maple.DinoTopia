namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."TaskConfig"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_TaskConfig>, Ptr_TaskConfig>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "TaskConfig", "TaskConfig")]
    public partial class TaskConfig
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_TaskConfig(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_TaskConfig(System.IntPtr ptr) => new Ptr_TaskConfig(ptr);
            public static implicit operator System.IntPtr(Ptr_TaskConfig ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_TaskConfig ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TaskConfig"]
        /// </summary>
        partial struct Ptr_TaskConfig
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.String , TaskConfig> mDic
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , TaskConfig></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mDic", "System.Collections.Generic.Dictionary<System.String,TaskConfig>")]
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
            /// 0x20 System.String[] DescInside
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DescInside", "System.String[]")]
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
            /// 0x30 System.String[] Desc
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Desc", "System.String[]")]
            public partial nint DESC { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32[] TaskType
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TaskType", "System.Int32[]")]
            public partial nint TASK_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x40 System.String[] TaskPara
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TaskPara", "System.String[]")]
            public partial nint TASK_PARA { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String[] TaskFinishCondition
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TaskFinishCondition", "System.String[]")]
            public partial nint TASK_FINISH_CONDITION { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Int32 TaskFinishRewardType
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TaskFinishRewardType", "System.Int32")]
            public partial System.Int32 TASK_FINISH_REWARD_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x58 System.String TaskFinishRewardPara
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TaskFinishRewardPara", "System.String")]
            public partial nint TASK_FINISH_REWARD_PARA { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Int32 InitState
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("InitState", "System.Int32")]
            public partial System.Int32 INIT_STATE { get; set; } 
*/

            /// <summary>
            /// 0x64 System.Int32 IsOpenDoor
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("IsOpenDoor", "System.Int32")]
            public partial System.Int32 IS_OPEN_DOOR { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."TaskConfig"]
        /// </summary>
        partial struct Ptr_TaskConfig
        {
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.String , TaskConfig> get_dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , TaskConfig></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dic", "System.Collections.Generic.Dictionary<System.String,TaskConfig>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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