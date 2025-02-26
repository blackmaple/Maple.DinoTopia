namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."Pet_Config"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_Pet_Config>, Ptr_Pet_Config>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "Pet_Config", "Pet_Config")]
    public partial class Pet_Config
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_Pet_Config(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_Pet_Config(System.IntPtr ptr) => new Ptr_Pet_Config(ptr);
            public static implicit operator System.IntPtr(Ptr_Pet_Config ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_Pet_Config ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."Pet_Config"]
        /// </summary>
        partial struct Ptr_Pet_Config
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.String , Pet_Config> mDic
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , Pet_Config></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mDic", "System.Collections.Generic.Dictionary<System.String,Pet_Config>")]
            public static partial nint M_DIC { get; set; } 
*/

            /// <summary>
            /// 0x10 System.String id
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.String")]
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
            /// 0x20 System.String path
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("path", "System.String")]
            public partial nint PATH { get; set; } 
*/

            /// <summary>
            /// 0x28 System.String name
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
            public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 IsOfficialPet
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("IsOfficialPet", "System.Int32")]
            public partial System.Int32 IS_OFFICIAL_PET { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String[] Skill
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Skill", "System.String[]")]
            public partial nint SKILL { get; set; } 
*/

            /// <summary>
            /// 0x40 System.String BaseAtkSkill
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BaseAtkSkill", "System.String")]
            public partial nint BASE_ATK_SKILL { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String MonsterAi
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MonsterAi", "System.String")]
            public partial nint MONSTER_AI { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Single AlertDistance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AlertDistance", "System.Single")]
            public partial System.Single ALERT_DISTANCE { get; set; } 
*/

            /// <summary>
            /// 0x54 System.Single FollowDistance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FollowDistance", "System.Single")]
            public partial System.Single FOLLOW_DISTANCE { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Single SideDistance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SideDistance", "System.Single")]
            public partial System.Single SIDE_DISTANCE { get; set; } 
*/

            /// <summary>
            /// 0x5C System.Single FollowSpeedRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FollowSpeedRate", "System.Single")]
            public partial System.Single FOLLOW_SPEED_RATE { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Single WalkSpeed
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("WalkSpeed", "System.Single")]
            public partial System.Single WALK_SPEED { get; set; } 
*/

            /// <summary>
            /// 0x68 System.String AttriId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AttriId", "System.String")]
            public partial nint ATTRI_ID { get; set; } 
*/

            /// <summary>
            /// 0x70 System.String Icon
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Icon", "System.String")]
            public partial nint ICON { get; set; } 
*/

            /// <summary>
            /// 0x78 System.String HomeAi
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HomeAi", "System.String")]
            public partial nint HOME_AI { get; set; } 
*/

            /// <summary>
            /// 0x80 System.String[] Shit
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Shit", "System.String[]")]
            public partial nint SHIT { get; set; } 
*/

            /// <summary>
            /// 0x88 System.String ToolWateringCan
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ToolWateringCan", "System.String")]
            public partial nint TOOL_WATERING_CAN { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Int32[] TalentNumWeight
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("TalentNumWeight", "System.Int32[]")]
            public partial nint TALENT_NUM_WEIGHT { get; set; } 
*/

            /// <summary>
            /// 0x98 System.String[] Talent
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Talent", "System.String[]")]
            public partial nint TALENT { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Int32[] AiOrder
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AiOrder", "System.Int32[]")]
            public partial nint AI_ORDER { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.String[] SlaughterDropItem
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SlaughterDropItem", "System.String[]")]
            public partial nint SLAUGHTER_DROP_ITEM { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.String[] Gene
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Gene", "System.String[]")]
            public partial nint GENE { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.String FeaturePath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FeaturePath", "System.String")]
            public partial nint FEATURE_PATH { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.String MatingDropItem
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MatingDropItem", "System.String")]
            public partial nint MATING_DROP_ITEM { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Int32 MatingTired
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MatingTired", "System.Int32")]
            public partial System.Int32 MATING_TIRED { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.String[] MatingNeedItem
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MatingNeedItem", "System.String[]")]
            public partial nint MATING_NEED_ITEM { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.Int32 MatingTime
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MatingTime", "System.Int32")]
            public partial System.Int32 MATING_TIME { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.String MatingSmallImage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MatingSmallImage", "System.String")]
            public partial nint MATING_SMALL_IMAGE { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Int32 LvUpNeedExp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LvUpNeedExp", "System.Int32")]
            public partial System.Int32 LV_UP_NEED_EXP { get; set; } 
*/

            /// <summary>
            /// 0xEC System.Int32 NextLvUpNeedExp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NextLvUpNeedExp", "System.Int32")]
            public partial System.Int32 NEXT_LV_UP_NEED_EXP { get; set; } 
*/

            /// <summary>
            /// 0xF0 System.Int32 AbsorbedForExp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AbsorbedForExp", "System.Int32")]
            public partial System.Int32 ABSORBED_FOR_EXP { get; set; } 
*/

            /// <summary>
            /// 0xF4 System.Int32 NextAbsorbedForExp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NextAbsorbedForExp", "System.Int32")]
            public partial System.Int32 NEXT_ABSORBED_FOR_EXP { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.String RideAction
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RideAction", "System.String")]
            public partial nint RIDE_ACTION { get; set; } 
*/

            /// <summary>
            /// 0x100 System.String RideNoIdleAction
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RideNoIdleAction", "System.String")]
            public partial nint RIDE_NO_IDLE_ACTION { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Int32 IsFlyPet
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("IsFlyPet", "System.Int32")]
            public partial System.Int32 IS_FLY_PET { get; set; } 
*/

            /// <summary>
            /// 0x10C System.Int32 FindPointType
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FindPointType", "System.Int32")]
            public partial System.Int32 FIND_POINT_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x110 System.String FindPointPara
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FindPointPara", "System.String")]
            public partial nint FIND_POINT_PARA { get; set; } 
*/

            /// <summary>
            /// 0x118 System.String StrokeDropID
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("StrokeDropID", "System.String")]
            public partial nint STROKE_DROP_ID { get; set; } 
*/

            /// <summary>
            /// 0x120 System.String RunSpeedInterval
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RunSpeedInterval", "System.String")]
            public partial nint RUN_SPEED_INTERVAL { get; set; } 
*/

            /// <summary>
            /// 0x128 System.String WalkSpeedInterval
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("WalkSpeedInterval", "System.String")]
            public partial nint WALK_SPEED_INTERVAL { get; set; } 
*/

            /// <summary>
            /// 0x130 System.String AttackInterval
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AttackInterval", "System.String")]
            public partial nint ATTACK_INTERVAL { get; set; } 
*/

            /// <summary>
            /// 0x138 System.String WorkAbilityInterval
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("WorkAbilityInterval", "System.String")]
            public partial nint WORK_ABILITY_INTERVAL { get; set; } 
*/

            /// <summary>
            /// 0x140 System.String MaxActionInterval
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxActionInterval", "System.String")]
            public partial nint MAX_ACTION_INTERVAL { get; set; } 
*/

            /// <summary>
            /// 0x148 System.String UnlockDesc
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UnlockDesc", "System.String")]
            public partial nint UNLOCK_DESC { get; set; } 
*/

            /// <summary>
            /// 0x150 System.String[] UnlockTotem
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UnlockTotem", "System.String[]")]
            public partial nint UNLOCK_TOTEM { get; set; } 
*/

            /// <summary>
            /// 0x158 System.String[] UnlockRelic
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UnlockRelic", "System.String[]")]
            public partial nint UNLOCK_RELIC { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."Pet_Config"]
        /// </summary>
        partial struct Ptr_Pet_Config
        {
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.String , Pet_Config> get_dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , Pet_Config></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dic", "System.Collections.Generic.Dictionary<System.String,Pet_Config>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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