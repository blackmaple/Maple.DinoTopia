
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maple.DinoTopia.Metadata
{
    
    
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."HuntingTaskConfig"]
    /// [System.Object]
    /// 
    /// </summary>
    //[Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], 0x02000021U)]
    [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorSettingsAttribute([65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108], [], [72, 117, 110, 116, 105, 110, 103, 84, 97, 115, 107, 67, 111, 110, 102, 105, 103])]
                
    //  class static System.Collections.Generic.Dictionary<System.String,HuntingTaskConfig> mDic
    //  [MonoCollectorSearchFieldAttribute(typeof(nint),"mDic", "M_DIC", true)]
                
    // class 0x10 System.String Id
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"Id", "ID")]
            
    // class 0x18 System.String NameInside
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"NameInside", "NAME_INSIDE")]
            
    // class 0x20 System.String Name
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"Name", "NAME")]
            
    // struct 0x28 System.Int32 Level
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"Level", "LEVEL")]
            
    // struct 0x2C System.Int32 Type
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"Type", "TYPE")]
            
    // struct 0x30 System.Int32 FinishTime
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"FinishTime", "FINISH_TIME")]
            
    // class 0x38 System.Single[] TaskCompletionProbability
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"TaskCompletionProbability", "TASK_COMPLETION_PROBABILITY")]
            
    // class 0x40 System.String[] TaskCompletionReward
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"TaskCompletionReward", "TASK_COMPLETION_REWARD")]
            
    // struct 0x48 System.Int32 Weight
    // [MonoCollectorSearchFieldAttribute(typeof(System.Int32),"Weight", "WEIGHT")]
            
    // class 0x50 System.String DropID
    // [MonoCollectorSearchFieldAttribute(typeof(nint),"DropID", "DROP_ID")]
    public partial class HuntingTaskConfig
    { 
        //public const string Const_ImageName = "Assembly-CSharp.dll";
        //public static byte[] Static_ImageName { get; } = [65, 115, 115, 101, 109, 98, 108, 121, 45, 67, 83, 104, 97, 114, 112, 46, 100, 108, 108];

        //public const string Const_Namespace = "";
        //public static byte[] Static_Namespace { get; } = [];

        //public const string Const_ClassName = "HuntingTaskConfig";
        //public static byte[] Static_ClassName { get; } = [72, 117, 110, 116, 105, 110, 103, 84, 97, 115, 107, 67, 111, 110, 102, 105, 103];

        //public const uint Const_TypeToken = 0x02000021U;



        
            
        

        
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public readonly unsafe partial struct Ptr_HuntingTaskConfig(nint ptr)
        {

            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly nint _ptr = ptr;
            public static implicit operator Ptr_HuntingTaskConfig(nint ptr) => new(ptr);
            public static implicit operator nint(Ptr_HuntingTaskConfig obj) => obj._ptr;
            public static implicit operator bool(Ptr_HuntingTaskConfig obj)=> obj.Valid();
 
            public override string ToString()
            {
                return _ptr.ToString("X8");
            }

            [System.Runtime.CompilerServices.MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public bool Valid() => _ptr != nint.Zero;



        }

    }

        /// <summary>
        /// ["Assembly-CSharp.dll".""."HuntingTaskConfig"]
        /// </summary>
        public partial class HuntingTaskConfig
        { 

            
            
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute(".ctor")]
            ///  extern void .CTOR ();

            
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.String,HuntingTaskConfig> get_dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String,HuntingTaskConfig></returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("get_dic")]
            /// static extern nint GET_DIC ();

            
            /// <summary>
            /// static  System.Void OnLoad(System.Collections.Generic.List<CSVHelper.CsvRow> rows)
            /// </summary>
            /// <param name="rows">class System.Collections.Generic.List<CSVHelper.CsvRow></param>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnLoad")]
            /// static extern void ON_LOAD (nint rows);

            
            /// <summary>
            /// static  System.Void OnQuit()
            /// </summary>
            /// <returns>struct System.Void</returns>
            /// [Maple.MonoGameAssistant.MonoCollectorDataV2.MonoCollectorMethodAttribute("OnQuit")]
            /// static extern void ON_QUIT ();
            
            

            
            /// public static partial class Search_HuntingTaskConfig
            /// {
            /// 
            ///     
            /// 
            /// }

        }


}