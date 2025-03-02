using Maple.MonoGameAssistant.Core;

namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll".""."SkillConfig"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SkillConfig>, Ptr_SkillConfig>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "", "SkillConfig", "SkillConfig")]
    public partial class SkillConfig
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SkillConfig(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SkillConfig(System.IntPtr ptr) => new Ptr_SkillConfig(ptr);
            public static implicit operator System.IntPtr(Ptr_SkillConfig ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_SkillConfig ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."SkillConfig"]
        /// </summary>
        partial struct Ptr_SkillConfig
        {
            /// <summary>
            /// 0x0 System.Collections.Generic.Dictionary<System.String , SkillConfig> mDic
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , SkillConfig></returns>
          
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("mDic", "System.Collections.Generic.Dictionary<System.String,SkillConfig>")]
            public static partial PMonoDictionary_OptimizationDefault<PMonoString, SkillConfig.Ptr_SkillConfig> M_DIC { get; set; } 
 

            /// <summary>
            /// 0x10 System.String id
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
           
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.String")]
            public partial PMonoString ID { get; set; } 
 

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
            /// 0x28 System.String name
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
          
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
            public partial PMonoString NAME { get; set; } 
 

            /// <summary>
            /// 0x30 System.String Simpledescription
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Simpledescription", "System.String")]
            public partial nint SIMPLEDESCRIPTION { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String description
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
         
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("description", "System.String")]
            public partial PMonoString DESCRIPTION { get; set; } 
 

            /// <summary>
            /// 0x40 System.String[] Parameter
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Parameter", "System.String[]")]
            public partial nint PARAMETER { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32[] Parameter1
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Parameter1", "System.Int32[]")]
            public partial nint PARAMETER1 { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String behavior
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("behavior", "System.String")]
            public partial nint BEHAVIOR { get; set; } 
*/

            /// <summary>
            /// 0x58 System.String skillIcon
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillIcon", "System.String")]
            public partial nint SKILL_ICON { get; set; } 
*/

            /// <summary>
            /// 0x60 System.Int32 skillBelong
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillBelong", "System.Int32")]
            public partial System.Int32 SKILL_BELONG { get; set; } 
*/

            /// <summary>
            /// 0x68 System.String PassiveBuffId
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PassiveBuffId", "System.String")]
            public partial nint PASSIVE_BUFF_ID { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Single cooldown
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("cooldown", "System.Single")]
            public partial System.Single COOLDOWN { get; set; } 
*/

            /// <summary>
            /// 0x74 System.Single ActionCost
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ActionCost", "System.Single")]
            public partial System.Single ACTION_COST { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Int32 CostLayers
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CostLayers", "System.Int32")]
            public partial System.Int32 COST_LAYERS { get; set; } 
*/

            /// <summary>
            /// 0x7C System.Int32 MaxLayers
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("MaxLayers", "System.Int32")]
            public partial System.Int32 MAX_LAYERS { get; set; } 
*/

            /// <summary>
            /// 0x80 System.String hitParticle
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hitParticle", "System.String")]
            public partial nint HIT_PARTICLE { get; set; } 
*/

            /// <summary>
            /// 0x88 System.String hitSound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("hitSound", "System.String")]
            public partial nint HIT_SOUND { get; set; } 
*/

            /// <summary>
            /// 0x90 System.String RicochetParticle
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RicochetParticle", "System.String")]
            public partial nint RICOCHET_PARTICLE { get; set; } 
*/

            /// <summary>
            /// 0x98 System.String RicochetSound
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RicochetSound", "System.String")]
            public partial nint RICOCHET_SOUND { get; set; } 
*/

            /// <summary>
            /// 0xA0 System.String HitShakeScreen
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HitShakeScreen", "System.String")]
            public partial nint HIT_SHAKE_SCREEN { get; set; } 
*/

            /// <summary>
            /// 0xA8 System.String[] DamageBuffIdToMe
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DamageBuffIdToMe", "System.String[]")]
            public partial nint DAMAGE_BUFF_ID_TO_ME { get; set; } 
*/

            /// <summary>
            /// 0xB0 System.String[] DamageBuffId
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DamageBuffId", "System.String[]")]
            public partial nint DAMAGE_BUFF_ID { get; set; } 
*/

            /// <summary>
            /// 0xB8 System.Int32 InVisual
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("InVisual", "System.Int32")]
            public partial System.Int32 IN_VISUAL { get; set; } 
*/

            /// <summary>
            /// 0xBC System.Int32 RangeType
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RangeType", "System.Int32")]
            public partial System.Int32 RANGE_TYPE { get; set; } 
*/

            /// <summary>
            /// 0xC0 System.Single attackDistance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("attackDistance", "System.Single")]
            public partial System.Single ATTACK_DISTANCE { get; set; } 
*/

            /// <summary>
            /// 0xC4 System.Int32 LimitAngle
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LimitAngle", "System.Int32")]
            public partial System.Int32 LIMIT_ANGLE { get; set; } 
*/

            /// <summary>
            /// 0xC8 System.Single RectangularLength
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RectangularLength", "System.Single")]
            public partial System.Single RECTANGULAR_LENGTH { get; set; } 
*/

            /// <summary>
            /// 0xCC System.Single RectangularWidth
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("RectangularWidth", "System.Single")]
            public partial System.Single RECTANGULAR_WIDTH { get; set; } 
*/

            /// <summary>
            /// 0xD0 System.String[] SkillStartBuffIdToMe
            /// class ["mscorlib.dll"."System"."String[]"]
            /// </summary>
            /// <returns>class System.String[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkillStartBuffIdToMe", "System.String[]")]
            public partial nint SKILL_START_BUFF_ID_TO_ME { get; set; } 
*/

            /// <summary>
            /// 0xD8 System.Int32 HitKnockback
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HitKnockback", "System.Int32")]
            public partial System.Int32 HIT_KNOCKBACK { get; set; } 
*/

            /// <summary>
            /// 0xDC System.Single HitKnockbackDistance
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HitKnockbackDistance", "System.Single")]
            public partial System.Single HIT_KNOCKBACK_DISTANCE { get; set; } 
*/

            /// <summary>
            /// 0xE0 System.Int32 DamageType
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DamageType", "System.Int32")]
            public partial System.Int32 DAMAGE_TYPE { get; set; } 
*/

            /// <summary>
            /// 0xE4 System.Int32 ShieldPenetration
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ShieldPenetration", "System.Int32")]
            public partial System.Int32 SHIELD_PENETRATION { get; set; } 
*/

            /// <summary>
            /// 0xE8 System.Int32 IsBaseAttack
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("IsBaseAttack", "System.Int32")]
            public partial System.Int32 IS_BASE_ATTACK { get; set; } 
*/

            /// <summary>
            /// 0xEC System.Int32 skillTargetSelect
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("skillTargetSelect", "System.Int32")]
            public partial System.Int32 SKILL_TARGET_SELECT { get; set; } 
*/

            /// <summary>
            /// 0xF0 System.Int32 bShowAttackDistance
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bShowAttackDistance", "System.Int32")]
            public partial System.Int32 B_SHOW_ATTACK_DISTANCE { get; set; } 
*/

            /// <summary>
            /// 0xF4 System.Int32 AffectedByTotem
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AffectedByTotem", "System.Int32")]
            public partial System.Int32 AFFECTED_BY_TOTEM { get; set; } 
*/

            /// <summary>
            /// 0xF8 System.Single UltSpeed
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UltSpeed", "System.Single")]
            public partial System.Single ULT_SPEED { get; set; } 
*/

            /// <summary>
            /// 0xFC System.Single UltLifeTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UltLifeTime", "System.Single")]
            public partial System.Single ULT_LIFE_TIME { get; set; } 
*/

            /// <summary>
            /// 0x100 System.Single DamageRadius
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DamageRadius", "System.Single")]
            public partial System.Single DAMAGE_RADIUS { get; set; } 
*/

            /// <summary>
            /// 0x104 System.Single UltSkillWide
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("UltSkillWide", "System.Single")]
            public partial System.Single ULT_SKILL_WIDE { get; set; } 
*/

            /// <summary>
            /// 0x108 System.Int32[] CampDamageList
            /// class ["mscorlib.dll"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("CampDamageList", "System.Int32[]")]
            public partial nint CAMP_DAMAGE_LIST { get; set; } 
*/

            /// <summary>
            /// 0x110 System.String ChainLinghtingEffect
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChainLinghtingEffect", "System.String")]
            public partial nint CHAIN_LINGHTING_EFFECT { get; set; } 
*/

            /// <summary>
            /// 0x118 System.String ChainLinghtingHitEffect
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ChainLinghtingHitEffect", "System.String")]
            public partial nint CHAIN_LINGHTING_HIT_EFFECT { get; set; } 
*/

            /// <summary>
            /// 0x120 System.String SkillDamage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkillDamage", "System.String")]
            public partial nint SKILL_DAMAGE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll".""."SkillConfig"]
        /// </summary>
        partial struct Ptr_SkillConfig
        {
            /// <summary>
            /// static  System.Collections.Generic.Dictionary<System.String , SkillConfig> get_dic()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , SkillConfig></returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_dic", "System.Collections.Generic.Dictionary<System.String,SkillConfig>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial PMonoDictionary_OptimizationDefault<PMonoString, SkillConfig.Ptr_SkillConfig> GET_DIC(); 
 
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