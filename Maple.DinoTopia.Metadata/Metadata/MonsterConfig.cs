namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."MonsterConfig"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_MonsterConfig>, Ptr_MonsterConfig>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "MonsterConfig", "MonsterConfig")]
    public partial class MonsterConfig
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_MonsterConfig(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_MonsterConfig(System.IntPtr ptr) => new Ptr_MonsterConfig(ptr);
            public static implicit operator System.IntPtr(Ptr_MonsterConfig ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_MonsterConfig ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."MonsterConfig"]
        /// </summary>
        partial struct Ptr_MonsterConfig
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.String , MonsterConfig> mDic
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , MonsterConfig></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mDic", "System.Collections.Generic.Dictionary<System.String,MonsterConfig>")]
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
            /// 0x18 System.String path
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("path", "System.String")]
            public partial nint PATH { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String name
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
            public partial nint NAME { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 Camp
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Camp", "System.Int32")]
            public partial System.Int32 CAMP { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int32 IsTrap
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("IsTrap", "System.Int32")]
            public partial System.Int32 IS_TRAP { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Int32 PetSummoner
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PetSummoner", "System.Int32")]
            public partial System.Int32 PET_SUMMONER { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 PetSummonerTotemClass
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PetSummonerTotemClass", "System.Int32")]
            public partial System.Int32 PET_SUMMONER_TOTEM_CLASS { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Int32 PetSummonerNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PetSummonerNum", "System.Int32")]
            public partial System.Int32 PET_SUMMONER_NUM { get; set; } 
*/

            /// <summary>
            /// 0x3C System.Int32 PetSummonerToNextRoom
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PetSummonerToNextRoom", "System.Int32")]
            public partial System.Int32 PET_SUMMONER_TO_NEXT_ROOM { get; set; } 
*/

            /// <summary>
            /// 0x40 System.Int32 BeActiveAttack
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BeActiveAttack", "System.Int32")]
            public partial System.Int32 BE_ACTIVE_ATTACK { get; set; } 
*/

            /// <summary>
            /// 0x48 System.String[] SkillId
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkillId", "System.String[]")]
            public partial nint SKILL_ID { get; set; } 
*/

            /// <summary>
            /// 0x50 System.Single SecondHpPercent
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SecondHpPercent", "System.Single")]
            public partial System.Single SECOND_HP_PERCENT { get; set; } 
*/

            /// <summary>
            /// 0x58 System.String[] SecondSkillId
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SecondSkillId", "System.String[]")]
            public partial nint SECOND_SKILL_ID { get; set; } 
*/

            /// <summary>
            /// 0x60 System.String BornSkillId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BornSkillId", "System.String")]
            public partial nint BORN_SKILL_ID { get; set; } 
*/

            /// <summary>
            /// 0x68 System.String behavior
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("behavior", "System.String")]
            public partial nint BEHAVIOR { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Single AttackWaitTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AttackWaitTime", "System.Single")]
            public partial System.Single ATTACK_WAIT_TIME { get; set; } 
*/

            /// <summary>
            /// 0x74 System.Single AlertDistance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AlertDistance", "System.Single")]
            public partial System.Single ALERT_DISTANCE { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Single AlertDistanceLength
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AlertDistanceLength", "System.Single")]
            public partial System.Single ALERT_DISTANCE_LENGTH { get; set; } 
*/

            /// <summary>
            /// 0x7C System.Single AlertDistanceWidth
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AlertDistanceWidth", "System.Single")]
            public partial System.Single ALERT_DISTANCE_WIDTH { get; set; } 
*/

            /// <summary>
            /// 0x80 System.String Icon
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Icon", "System.String")]
            public partial nint ICON { get; set; } 
*/

            /// <summary>
            /// 0x88 System.Int32 IsBoss
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("IsBoss", "System.Int32")]
            public partial System.Int32 IS_BOSS { get; set; } 
*/

            /// <summary>
            /// 0x90 System.String AttriId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AttriId", "System.String")]
            public partial nint ATTRI_ID { get; set; } 
*/

            /// <summary>
            /// 0x98 System.String DropId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DropId", "System.String")]
            public partial nint DROP_ID { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.Int32 DropRange
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DropRange", "System.Int32")]
            public partial System.Int32 DROP_RANGE { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.String DieEffect
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DieEffect", "System.String")]
            public partial nint DIE_EFFECT { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.Single DissolveTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DissolveTime", "System.Single")]
            public partial System.Single DISSOLVE_TIME { get; set; } 
*/

            /// <summary>
            /// 0xB4 System.Int32 FindPointType
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FindPointType", "System.Int32")]
            public partial System.Int32 FIND_POINT_TYPE { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.String FindPointPara
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("FindPointPara", "System.String")]
            public partial nint FIND_POINT_PARA { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.String BornEffect
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BornEffect", "System.String")]
            public partial nint BORN_EFFECT { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Single BornDelayTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BornDelayTime", "System.Single")]
            public partial System.Single BORN_DELAY_TIME { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.String BornAction
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BornAction", "System.String")]
            public partial nint BORN_ACTION { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.String[] BornBuffId
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BornBuffId", "System.String[]")]
            public partial nint BORN_BUFF_ID { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.Single BornToDieTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BornToDieTime", "System.Single")]
            public partial System.Single BORN_TO_DIE_TIME { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.String DieSummonId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DieSummonId", "System.String")]
            public partial nint DIE_SUMMON_ID { get; set; } 
*/

            /// <summary>
            /// 0xF0 System.Int32 DieSummonNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DieSummonNum", "System.Int32")]
            public partial System.Int32 DIE_SUMMON_NUM { get; set; } 
*/

            /// <summary>
            /// 0xF4 System.Single DieSummonRadius
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DieSummonRadius", "System.Single")]
            public partial System.Single DIE_SUMMON_RADIUS { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Int32 ShowDamage
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ShowDamage", "System.Int32")]
            public partial System.Int32 SHOW_DAMAGE { get; set; } 
*/

            /// <summary>
            /// 0xFC System.Int32 ShowBlood
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ShowBlood", "System.Int32")]
            public partial System.Int32 SHOW_BLOOD { get; set; } 
*/

            /// <summary>
            /// 0x100 System.Int32 AffectSettlement
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AffectSettlement", "System.Int32")]
            public partial System.Int32 AFFECT_SETTLEMENT { get; set; } 
*/

            /// <summary>
            /// 0x104 System.Int32 ShowDPS
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ShowDPS", "System.Int32")]
            public partial System.Int32 SHOW_DPS { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Int32 DirectionNotChange
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DirectionNotChange", "System.Int32")]
            public partial System.Int32 DIRECTION_NOT_CHANGE { get; set; } 
*/

            /// <summary>
            /// 0x10C System.Int32 RotationAngle
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RotationAngle", "System.Int32")]
            public partial System.Int32 ROTATION_ANGLE { get; set; } 
*/

            /// <summary>
            /// 0x110 System.Single DeathDelayTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DeathDelayTime", "System.Single")]
            public partial System.Single DEATH_DELAY_TIME { get; set; } 
*/

            /// <summary>
            /// 0x118 System.String HurtSound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HurtSound", "System.String")]
            public partial nint HURT_SOUND { get; set; } 
*/

            /// <summary>
            /// 0x120 System.String DieSound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DieSound", "System.String")]
            public partial nint DIE_SOUND { get; set; } 
*/

            /// <summary>
            /// 0x128 System.Single BuffEffectRate
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BuffEffectRate", "System.Single")]
            public partial System.Single BUFF_EFFECT_RATE { get; set; } 
*/

            /// <summary>
            /// 0x12C System.Single PathfindingDistance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PathfindingDistance", "System.Single")]
            public partial System.Single PATHFINDING_DISTANCE { get; set; } 
*/

            /// <summary>
            /// 0x130 System.Int32 HurtType
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HurtType", "System.Int32")]
            public partial System.Int32 HURT_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x134 System.Int32 NotWashedByRiver
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NotWashedByRiver", "System.Int32")]
            public partial System.Int32 NOT_WASHED_BY_RIVER { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."MonsterConfig"]
        /// </summary>
        partial struct Ptr_MonsterConfig
        {
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.String , MonsterConfig> get_dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , MonsterConfig></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dic", "System.Collections.Generic.Dictionary<System.String,MonsterConfig>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
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