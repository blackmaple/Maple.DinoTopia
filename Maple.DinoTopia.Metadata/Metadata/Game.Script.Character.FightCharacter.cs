namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Game.Script.Character"."FightCharacter"]
    /// [Game.Script.Character.Character]=>[Game.Script.Character.Pawn]=>[Game.Script.Common.Actor]=>[Mirror.NetworkBehaviour]=>[UnityEngine.MonoBehaviour]=>[UnityEngine.Behaviour]=>[UnityEngine.Component]=>[UnityEngine.Object]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_FightCharacter>, Ptr_FightCharacter>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "Game.Script.Character", "FightCharacter", "Game.Script.Character.FightCharacter")]
    public partial class FightCharacter
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_FightCharacter(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_FightCharacter(System.IntPtr ptr) => new Ptr_FightCharacter(ptr);
            public static implicit operator System.IntPtr(Ptr_FightCharacter ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_FightCharacter ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Character"."FightCharacter"]
        /// </summary>
        partial struct Ptr_FightCharacter
        {
            /// <summary>
            /// 0x0 System.String PickUpEffectPath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint PICK_UP_EFFECT_PATH = Assets/Game/Res/Actor/Common/ResEffects/FX_Collect_Item.prefab; 
*/
            /// <summary>
            /// 0x0 System.String objectIsNullMessage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint OBJECT_IS_NULL_MESSAGE = The Object you want to instantiate is null.; 
*/
            /// <summary>
            /// 0x0 System.String cloneDestroyedMessage
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            public const nint CLONE_DESTROYED_MESSAGE = Instantiate failed because the clone was destroyed during creati; 
*/
            /// <summary>
            /// 0x0 System.Int32 BlendOpacity
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BlendOpacity", "System.Int32")]
            public static partial System.Int32 BLEND_OPACITY { get; set; } 
*/

            /// <summary>
            /// 0x0 System.Int32 OffsetOfInstanceIDInCPlusPlusObject
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("OffsetOfInstanceIDInCPlusPlusObject", "System.Int32")]
            public static partial System.Int32 OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT { get; set; } 
*/

            /// <summary>
            /// 0x4 System.Int32 ColorMuti
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ColorMuti", "System.Int32")]
            public static partial System.Int32 COLOR_MUTI { get; set; } 
*/

            /// <summary>
            /// 0x10 System.IntPtr m_CachedPtr
            /// struct ["mscorlib.dll"."System"."IntPtr"]
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_CachedPtr", "System.IntPtr")]
            public partial System.IntPtr M_CACHED_PTR { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Threading.CancellationTokenSource m_CancellationTokenSource
            /// class ["mscorlib.dll"."System.Threading"."CancellationTokenSource"]
            /// </summary>
            /// <returns>class System.Threading.CancellationTokenSource</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_CancellationTokenSource", "System.Threading.CancellationTokenSource")]
            public partial nint M_CANCELLATION_TOKEN_SOURCE { get; set; } 
*/

            /// <summary>
            /// 0x20 Mirror.SyncDirection syncDirection
            /// enum ["Mirror.dll"."Mirror"."SyncDirection"]
            /// </summary>
            /// <returns>enum Mirror.SyncDirection</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("syncDirection", "Mirror.SyncDirection")]
            public partial Mirror.SyncDirection SYNC_DIRECTION { get; set; } 
*/

            /// <summary>
            /// 0x24 Mirror.SyncMode syncMode
            /// enum ["Mirror.dll"."Mirror"."SyncMode"]
            /// </summary>
            /// <returns>enum Mirror.SyncMode</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("syncMode", "Mirror.SyncMode")]
            public partial Mirror.SyncMode SYNC_MODE { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Single syncInterval
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("syncInterval", "System.Single")]
            public partial System.Single SYNC_INTERVAL { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Double lastSyncTime
            /// struct ["mscorlib.dll"."System"."Double"]
            /// </summary>
            /// <returns>struct System.Double</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lastSyncTime", "System.Double")]
            public partial System.Double LAST_SYNC_TIME { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Guid <UnNetGuid>k__BackingField
            /// struct ["mscorlib.dll"."System"."Guid"]
            /// </summary>
            /// <returns>struct System.Guid</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<UnNetGuid>k__BackingField", "System.Guid")]
            public partial System.Guid UN_NET_GUID { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Collections.Generic.List<Mirror.SyncObject> syncObjects
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Mirror.SyncObject></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("syncObjects", "System.Collections.Generic.List<Mirror.SyncObject>")]
            public partial nint SYNC_OBJECTS { get; set; } 
*/

            /// <summary>
            /// 0x50 Mirror.NetworkIdentity <netIdentity>k__BackingField
            /// class ["Mirror.dll"."Mirror"."NetworkIdentity"]
            /// </summary>
            /// <returns>class Mirror.NetworkIdentity</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<netIdentity>k__BackingField", "Mirror.NetworkIdentity")]
            public partial nint NET_IDENTITY { get; set; } 
*/

            /// <summary>
            /// 0x58 System.Byte <ComponentIndex>k__BackingField
            /// struct ["mscorlib.dll"."System"."Byte"]
            /// </summary>
            /// <returns>struct System.Byte</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<ComponentIndex>k__BackingField", "System.Byte")]
            public partial System.Byte COMPONENT_INDEX { get; set; } 
*/

            /// <summary>
            /// 0x60 System.UInt64 syncVarDirtyBits
            /// struct ["mscorlib.dll"."System"."UInt64"]
            /// </summary>
            /// <returns>struct System.UInt64</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("syncVarDirtyBits", "System.UInt64")]
            public partial System.UInt64 SYNC_VAR_DIRTY_BITS { get; set; } 
*/

            /// <summary>
            /// 0x68 System.UInt64 syncObjectDirtyBits
            /// struct ["mscorlib.dll"."System"."UInt64"]
            /// </summary>
            /// <returns>struct System.UInt64</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("syncObjectDirtyBits", "System.UInt64")]
            public partial System.UInt64 SYNC_OBJECT_DIRTY_BITS { get; set; } 
*/

            /// <summary>
            /// 0x70 System.UInt64 syncVarHookGuard
            /// struct ["mscorlib.dll"."System"."UInt64"]
            /// </summary>
            /// <returns>struct System.UInt64</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("syncVarHookGuard", "System.UInt64")]
            public partial System.UInt64 SYNC_VAR_HOOK_GUARD { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Boolean <IsUpdateHideEnvironment>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<IsUpdateHideEnvironment>k__BackingField", "System.Boolean")]
            public partial System.Boolean IS_UPDATE_HIDE_ENVIRONMENT { get; set; } 
*/

            /// <summary>
            /// 0x79 System.Boolean <IsSetData>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<IsSetData>k__BackingField", "System.Boolean")]
            public partial System.Boolean IS_SET_DATA { get; set; } 
*/

            /// <summary>
            /// 0x80 Game.Script.Common.World _world
            /// class ["Assembly-CSharp.dll"."Game.Script.Common"."World"]
            /// </summary>
            /// <returns>class Game.Script.Common.World</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_world", "Game.Script.Common.World")]
            public partial nint _WORLD { get; set; } 
*/

            /// <summary>
            /// 0x88 System.String <Id>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Id>k__BackingField", "System.String")]
            public partial nint ID { get; set; } 
*/

            /// <summary>
            /// 0x90 System.Boolean <bIsDestroyed>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<bIsDestroyed>k__BackingField", "System.Boolean")]
            public partial System.Boolean B_IS_DESTROYED { get; set; } 
*/

            /// <summary>
            /// 0x98 Mirror.NetworkTransformReliable NetworkTransform
            /// class ["Mirror.Components.dll"."Mirror"."NetworkTransformReliable"]
            /// </summary>
            /// <returns>class Mirror.NetworkTransformReliable</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("NetworkTransform", "Mirror.NetworkTransformReliable")]
            public partial nint NETWORK_TRANSFORM { get; set; } 
*/

            /// <summary>
            /// 0xA0 SearchFilterType <FilterType>k__BackingField
            /// enum ["Assembly-CSharp.dll".""."SearchFilterType"]
            /// </summary>
            /// <returns>enum SearchFilterType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<FilterType>k__BackingField", "SearchFilterType")]
            public partial SearchFilterType FILTER_TYPE { get; set; } 
*/

            /// <summary>
            /// 0xA4 Game.Script.Common.ActorType ActorType
            /// enum ["Assembly-CSharp.dll"."Game.Script.Common"."ActorType"]
            /// </summary>
            /// <returns>enum Game.Script.Common.ActorType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("ActorType", "Game.Script.Common.ActorType")]
            public partial Game.Script.Common.ActorType ACTOR_TYPE { get; set; } 
*/

            /// <summary>
            /// 0xA8 UnityEngine.Vector3 <Position>k__BackingField
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Position>k__BackingField", "UnityEngine.Vector3")]
            public partial UnityEngine.Vector3 POSITION { get; set; } 
*/

            /// <summary>
            /// 0xB4 UnityEngine.Vector3 <Scale>k__BackingField
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Scale>k__BackingField", "UnityEngine.Vector3")]
            public partial UnityEngine.Vector3 SCALE { get; set; } 
*/

            /// <summary>
            /// 0xC0 UnityEngine.Quaternion <Rotation>k__BackingField
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Quaternion"]
            /// </summary>
            /// <returns>struct UnityEngine.Quaternion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Rotation>k__BackingField", "UnityEngine.Quaternion")]
            public partial UnityEngine.Quaternion ROTATION { get; set; } 
*/

            /// <summary>
            /// 0xD0 UnityEngine.Matrix4x4 <LocalToWorldMat>k__BackingField
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Matrix4x4"]
            /// </summary>
            /// <returns>struct UnityEngine.Matrix4x4</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<LocalToWorldMat>k__BackingField", "UnityEngine.Matrix4x4")]
            public partial UnityEngine.Matrix4x4 LOCAL_TO_WORLD_MAT { get; set; } 
*/

            /// <summary>
            /// 0x110 UnityEngine.Transform <CacheTransform>k__BackingField
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Transform"]
            /// </summary>
            /// <returns>class UnityEngine.Transform</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CacheTransform>k__BackingField", "UnityEngine.Transform")]
            public partial nint CACHE_TRANSFORM { get; set; } 
*/

            /// <summary>
            /// 0x118 System.Boolean bBlock
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bBlock", "System.Boolean")]
            public partial System.Boolean B_BLOCK { get; set; } 
*/

            /// <summary>
            /// 0x11C System.Int32 _gridIndex
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_gridIndex", "System.Int32")]
            public partial System.Int32 _GRID_INDEX { get; set; } 
*/

            /// <summary>
            /// 0x120 System.Collections.Generic.List<System.ValueTuple<System.Int32 , System.Int32>> _nowLandGrid
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.ValueTuple<System.Int32 , System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_nowLandGrid", "System.Collections.Generic.List<System.ValueTuple<System.Int32,System.Int32>>")]
            public partial nint _NOW_LAND_GRID { get; set; } 
*/

            /// <summary>
            /// 0x128 System.Collections.Generic.List<System.ValueTuple<System.Int32 , System.Int32>> _nowCollistionGrid
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.ValueTuple<System.Int32 , System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_nowCollistionGrid", "System.Collections.Generic.List<System.ValueTuple<System.Int32,System.Int32>>")]
            public partial nint _NOW_COLLISTION_GRID { get; set; } 
*/

            /// <summary>
            /// 0x130 System.Collections.Generic.List<System.ValueTuple<System.Int32 , System.Int32>> _tempGrid
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.ValueTuple<System.Int32 , System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_tempGrid", "System.Collections.Generic.List<System.ValueTuple<System.Int32,System.Int32>>")]
            public partial nint _TEMP_GRID { get; set; } 
*/

            /// <summary>
            /// 0x138 System.Action positionChanged
            /// class ["mscorlib.dll"."System"."Action"]
            /// </summary>
            /// <returns>class System.Action</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("positionChanged", "System.Action")]
            public partial nint POSITION_CHANGED { get; set; } 
*/

            /// <summary>
            /// 0x140 UnityEngine.Vector3 _lastPosition
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_lastPosition", "UnityEngine.Vector3")]
            public partial UnityEngine.Vector3 _LAST_POSITION { get; set; } 
*/

            /// <summary>
            /// 0x14C System.Int32 collisionReduce
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("collisionReduce", "System.Int32")]
            public partial System.Int32 COLLISION_REDUCE { get; set; } 
*/

            /// <summary>
            /// 0x150 System.Int32 landRadius
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("landRadius", "System.Int32")]
            public partial System.Int32 LAND_RADIUS { get; set; } 
*/

            /// <summary>
            /// 0x154 System.Boolean bEnter
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("bEnter", "System.Boolean")]
            public partial System.Boolean B_ENTER { get; set; } 
*/

            /// <summary>
            /// 0x155 System.Boolean IsStart
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("IsStart", "System.Boolean")]
            public partial System.Boolean IS_START { get; set; } 
*/

            /// <summary>
            /// 0x158 System.Action<System.String , System.String> _Mirror_SyncVarHookDelegate_<Id>k__BackingField
            /// class ["mscorlib.dll"."System"."Action`2"]
            /// </summary>
            /// <returns>class System.Action<System.String , System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Mirror_SyncVarHookDelegate_<Id>k__BackingField", "System.Action<System.String,System.String>")]
            public partial nint ID__MIRROR_SYNC_VAR_HOOK_DELEGATE_ { get; set; } 
*/

            /// <summary>
            /// 0x160 UnityEngine.Vector3 <AniPosition>k__BackingField
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AniPosition>k__BackingField", "UnityEngine.Vector3")]
            public partial UnityEngine.Vector3 ANI_POSITION { get; set; } 
*/

            /// <summary>
            /// 0x16C UnityEngine.Vector3 <AniScale>k__BackingField
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Vector3"]
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AniScale>k__BackingField", "UnityEngine.Vector3")]
            public partial UnityEngine.Vector3 ANI_SCALE { get; set; } 
*/

            /// <summary>
            /// 0x178 UnityEngine.Quaternion <AniRotation>k__BackingField
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Quaternion"]
            /// </summary>
            /// <returns>struct UnityEngine.Quaternion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AniRotation>k__BackingField", "UnityEngine.Quaternion")]
            public partial UnityEngine.Quaternion ANI_ROTATION { get; set; } 
*/

            /// <summary>
            /// 0x188 Game.Script.Common.UIHeadInfo <HeadInfo>k__BackingField
            /// class ["Assembly-CSharp.dll"."Game.Script.Common"."UIHeadInfo"]
            /// </summary>
            /// <returns>class Game.Script.Common.UIHeadInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<HeadInfo>k__BackingField", "Game.Script.Common.UIHeadInfo")]
            public partial nint HEAD_INFO { get; set; } 
*/

            /// <summary>
            /// 0x190 Game.Script.Character.FightCharacter <Owner>k__BackingField
            /// class ["Assembly-CSharp.dll"."Game.Script.Character"."FightCharacter"]
            /// </summary>
            /// <returns>class Game.Script.Character.FightCharacter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Owner>k__BackingField", "Game.Script.Character.FightCharacter")]
            public partial nint OWNER { get; set; } 
*/

            /// <summary>
            /// 0x198 Game.Script.Character.Character <CreateOwner>k__BackingField
            /// class ["Assembly-CSharp.dll"."Game.Script.Character"."Character"]
            /// </summary>
            /// <returns>class Game.Script.Character.Character</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CreateOwner>k__BackingField", "Game.Script.Character.Character")]
            public partial nint CREATE_OWNER { get; set; } 
*/

            /// <summary>
            /// 0x1A0 Game.Script.Character.CharacterMovement <CharacterMovement>k__BackingField
            /// class ["Assembly-CSharp.dll"."Game.Script.Character"."CharacterMovement"]
            /// </summary>
            /// <returns>class Game.Script.Character.CharacterMovement</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CharacterMovement>k__BackingField", "Game.Script.Character.CharacterMovement")]
            public partial nint CHARACTER_MOVEMENT { get; set; } 
*/

            /// <summary>
            /// 0x1A8 Game.Script.Map.Actor.Home.HomeActor <BuildOwner>k__BackingField
            /// class ["Assembly-CSharp.dll"."Game.Script.Map.Actor.Home"."HomeActor"]
            /// </summary>
            /// <returns>class Game.Script.Map.Actor.Home.HomeActor</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BuildOwner>k__BackingField", "Game.Script.Map.Actor.Home.HomeActor")]
            public partial nint BUILD_OWNER { get; set; } 
*/

            /// <summary>
            /// 0x1B0 Mirror.SyncList<System.String> _skills
            /// class ["Mirror.dll"."Mirror"."SyncList`1"]
            /// </summary>
            /// <returns>class Mirror.SyncList<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_skills", "Mirror.SyncList<System.String>")]
            public partial nint _SKILLS { get; set; } 
*/

            /// <summary>
            /// 0x1B8 System.Collections.Generic.Dictionary<System.String , Skill.Skill> _instanceSkills
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , Skill.Skill></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_instanceSkills", "System.Collections.Generic.Dictionary<System.String,Skill.Skill>")]
            public partial nint _INSTANCE_SKILLS { get; set; } 
*/

            /// <summary>
            /// 0x1C0 Mirror.SyncDictionary<System.String , System.Single> _skillCds
            /// class ["Mirror.dll"."Mirror"."SyncDictionary`2"]
            /// </summary>
            /// <returns>class Mirror.SyncDictionary<System.String , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_skillCds", "Mirror.SyncDictionary<System.String,System.Single>")]
            public partial nint _SKILL_CDS { get; set; } 
*/

            /// <summary>
            /// 0x1C8 Mirror.SyncDictionary<System.String , System.Int32> _skillLayers
            /// class ["Mirror.dll"."Mirror"."SyncDictionary`2"]
            /// </summary>
            /// <returns>class Mirror.SyncDictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_skillLayers", "Mirror.SyncDictionary<System.String,System.Int32>")]
            public partial nint _SKILL_LAYERS { get; set; } 
*/

            /// <summary>
            /// 0x1D0 Skill.Skill <CurUseSkill>k__BackingField
            /// class ["Assembly-CSharp.dll"."Skill"."Skill"]
            /// </summary>
            /// <returns>class Skill.Skill</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CurUseSkill>k__BackingField", "Skill.Skill")]
            public partial nint CUR_USE_SKILL { get; set; } 
*/

            /// <summary>
            /// 0x1D8 System.Boolean _isHurting
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_isHurting", "System.Boolean")]
            public partial System.Boolean _IS_HURTING { get; set; } 
*/

            /// <summary>
            /// 0x1D9 System.Boolean _isSkillLockMoveState
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_isSkillLockMoveState", "System.Boolean")]
            public partial System.Boolean _IS_SKILL_LOCK_MOVE_STATE { get; set; } 
*/

            /// <summary>
            /// 0x1DA System.Boolean _isSkillLockAction
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_isSkillLockAction", "System.Boolean")]
            public partial System.Boolean _IS_SKILL_LOCK_ACTION { get; set; } 
*/

            /// <summary>
            /// 0x1DB System.Boolean _isLockSkillRelease
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_isLockSkillRelease", "System.Boolean")]
            public partial System.Boolean _IS_LOCK_SKILL_RELEASE { get; set; } 
*/

            /// <summary>
            /// 0x1DC System.Boolean _isSkillLockFace
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_isSkillLockFace", "System.Boolean")]
            public partial System.Boolean _IS_SKILL_LOCK_FACE { get; set; } 
*/

            /// <summary>
            /// 0x1E0 System.Collections.Generic.Dictionary<System.String , UnityEngine.GameObject> SkillEffect
            /// class ["mscorlib.dll"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , UnityEngine.GameObject></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SkillEffect", "System.Collections.Generic.Dictionary<System.String,UnityEngine.GameObject>")]
            public partial nint SKILL_EFFECT { get; set; } 
*/

            /// <summary>
            /// 0x1E8 Mirror.SyncList<Game.Script.Character.Buff.BuffBase> _buffs
            /// class ["Mirror.dll"."Mirror"."SyncList`1"]
            /// </summary>
            /// <returns>class Mirror.SyncList<Game.Script.Character.Buff.BuffBase></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_buffs", "Mirror.SyncList<Game.Script.Character.Buff.BuffBase>")]
            public partial nint _BUFFS { get; set; } 
*/

            /// <summary>
            /// 0x1F0 System.Int32 totemMaxBagNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("totemMaxBagNum", "System.Int32")]
            public partial System.Int32 TOTEM_MAX_BAG_NUM { get; set; } 
*/

            /// <summary>
            /// 0x1F8 Mirror.SyncDictionary<System.Int32 , System.String> _totemItems
            /// class ["Mirror.dll"."Mirror"."SyncDictionary`2"]
            /// </summary>
            /// <returns>class Mirror.SyncDictionary<System.Int32 , System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_totemItems", "Mirror.SyncDictionary<System.Int32,System.String>")]
            public partial nint _TOTEM_ITEMS { get; set; } 
*/

            /// <summary>
            /// 0x200 Game.Script.Character.Character.BuffEffect _buffEffect
            /// class ["Assembly-CSharp.dll".""."BuffEffect"]
            /// </summary>
            /// <returns>class Game.Script.Character.Character.BuffEffect</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_buffEffect", "Game.Script.Character.Character.BuffEffect")]
            public partial nint _BUFF_EFFECT { get; set; } 
*/

            /// <summary>
            /// 0x208 UnityEngine.Color damageColor
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine"."Color"]
            /// </summary>
            /// <returns>struct UnityEngine.Color</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("damageColor", "UnityEngine.Color")]
            public partial UnityEngine.Color DAMAGE_COLOR { get; set; } 
*/

            /// <summary>
            /// 0x218 System.Boolean _death
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_death", "System.Boolean")]
            public partial System.Boolean _DEATH { get; set; } 
*/

            /// <summary>
            /// 0x21C Game.Script.Character.CharacterState <CharacterState>k__BackingField
            /// enum ["Assembly-CSharp.dll"."Game.Script.Character"."CharacterState"]
            /// </summary>
            /// <returns>enum Game.Script.Character.CharacterState</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CharacterState>k__BackingField", "Game.Script.Character.CharacterState")]
            public partial Game.Script.Character.CharacterState CHARACTER_STATE { get; set; } 
*/

            /// <summary>
            /// 0x220 Game.Script.Character.CharacterAttribute <AttributeComponent>k__BackingField
            /// class ["Assembly-CSharp.dll"."Game.Script.Character"."CharacterAttribute"]
            /// </summary>
            /// <returns>class Game.Script.Character.CharacterAttribute</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AttributeComponent>k__BackingField", "Game.Script.Character.CharacterAttribute")]
            public partial nint ATTRIBUTE_COMPONENT { get; set; } 
*/

            /// <summary>
            /// 0x228 Game.Script.Character.CharacterAnimation <AnimationComponent>k__BackingField
            /// abstract class ["Assembly-CSharp.dll"."Game.Script.Character"."CharacterAnimation"]
            /// </summary>
            /// <returns>abstract class Game.Script.Character.CharacterAnimation</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AnimationComponent>k__BackingField", "Game.Script.Character.CharacterAnimation")]
            public partial nint ANIMATION_COMPONENT { get; set; } 
*/

            /// <summary>
            /// 0x230 System.Collections.Generic.List<UnityEngine.GameObject> _weaponEffect
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<UnityEngine.GameObject></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_weaponEffect", "System.Collections.Generic.List<UnityEngine.GameObject>")]
            public partial nint _WEAPON_EFFECT { get; set; } 
*/

            /// <summary>
            /// 0x238 Mirror.SyncList<Game.Script.User.Item> _items
            /// class ["Mirror.dll"."Mirror"."SyncList`1"]
            /// </summary>
            /// <returns>class Mirror.SyncList<Game.Script.User.Item></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_items", "Mirror.SyncList<Game.Script.User.Item>")]
            public partial nint _ITEMS { get; set; } 
*/

            /// <summary>
            /// 0x240 System.String <BaseAtkSkill>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BaseAtkSkill>k__BackingField", "System.String")]
            public partial nint BASE_ATK_SKILL { get; set; } 
*/

            /// <summary>
            /// 0x248 System.String HomeRushSkill
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HomeRushSkill", "System.String")]
            public partial nint HOME_RUSH_SKILL { get; set; } 
*/

            /// <summary>
            /// 0x250 Game.Script.Character.ECharacterSkillState <CharacterSkillState>k__BackingField
            /// enum ["Assembly-CSharp.dll"."Game.Script.Character"."ECharacterSkillState"]
            /// </summary>
            /// <returns>enum Game.Script.Character.ECharacterSkillState</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<CharacterSkillState>k__BackingField", "Game.Script.Character.ECharacterSkillState")]
            public partial Game.Script.Character.ECharacterSkillState CHARACTER_SKILL_STATE { get; set; } 
*/

            /// <summary>
            /// 0x254 System.Int32 <Camp>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<Camp>k__BackingField", "System.Int32")]
            public partial System.Int32 CAMP { get; set; } 
*/

            /// <summary>
            /// 0x258 System.Int32 <IsDiscovery>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<IsDiscovery>k__BackingField", "System.Int32")]
            public partial System.Int32 IS_DISCOVERY { get; set; } 
*/

            /// <summary>
            /// 0x25C System.Single <BornTime>k__BackingField
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BornTime>k__BackingField", "System.Single")]
            public partial System.Single BORN_TIME { get; set; } 
*/

            /// <summary>
            /// 0x260 Mirror.NetworkBehaviourSyncVar ___<Owner>k__BackingFieldNetId
            /// struct ["Mirror.dll"."Mirror"."NetworkBehaviourSyncVar"]
            /// </summary>
            /// <returns>struct Mirror.NetworkBehaviourSyncVar</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("___<Owner>k__BackingFieldNetId", "Mirror.NetworkBehaviourSyncVar")]
            public partial Mirror.NetworkBehaviourSyncVar OWNER____ { get; set; } 
*/

            /// <summary>
            /// 0x268 Mirror.NetworkBehaviourSyncVar ___<CreateOwner>k__BackingFieldNetId
            /// struct ["Mirror.dll"."Mirror"."NetworkBehaviourSyncVar"]
            /// </summary>
            /// <returns>struct Mirror.NetworkBehaviourSyncVar</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("___<CreateOwner>k__BackingFieldNetId", "Mirror.NetworkBehaviourSyncVar")]
            public partial Mirror.NetworkBehaviourSyncVar CREATE_OWNER____ { get; set; } 
*/

            /// <summary>
            /// 0x270 System.Action<System.Boolean , System.Boolean> _Mirror_SyncVarHookDelegate__death
            /// class ["mscorlib.dll"."System"."Action`2"]
            /// </summary>
            /// <returns>class System.Action<System.Boolean , System.Boolean></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Mirror_SyncVarHookDelegate__death", "System.Action<System.Boolean,System.Boolean>")]
            public partial nint _MIRROR_SYNC_VAR_HOOK_DELEGATE__DEATH { get; set; } 
*/

            /// <summary>
            /// 0x278 System.Action<Game.Script.Character.CharacterState , Game.Script.Character.CharacterState> _Mirror_SyncVarHookDelegate_<CharacterState>k__BackingField
            /// class ["mscorlib.dll"."System"."Action`2"]
            /// </summary>
            /// <returns>class System.Action<Game.Script.Character.CharacterState , Game.Script.Character.CharacterState></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Mirror_SyncVarHookDelegate_<CharacterState>k__BackingField", "System.Action<Game.Script.Character.CharacterState,Game.Script.Character.CharacterState>")]
            public partial nint CHARACTER_STATE__MIRROR_SYNC_VAR_HOOK_DELEGATE_ { get; set; } 
*/

            /// <summary>
            /// 0x280 System.Action<Game.Script.Character.ECharacterSkillState , Game.Script.Character.ECharacterSkillState> _Mirror_SyncVarHookDelegate_<CharacterSkillState>k__BackingField
            /// class ["mscorlib.dll"."System"."Action`2"]
            /// </summary>
            /// <returns>class System.Action<Game.Script.Character.ECharacterSkillState , Game.Script.Character.ECharacterSkillState></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Mirror_SyncVarHookDelegate_<CharacterSkillState>k__BackingField", "System.Action<Game.Script.Character.ECharacterSkillState,Game.Script.Character.ECharacterSkillState>")]
            public partial nint CHARACTER_SKILL_STATE__MIRROR_SYNC_VAR_HOOK_DELEGATE_ { get; set; } 
*/

            /// <summary>
            /// 0x288 System.Boolean <IsInHome>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<IsInHome>k__BackingField", "System.Boolean")]
            public partial System.Boolean IS_IN_HOME { get; set; } 
*/

            /// <summary>
            /// 0x290 System.String <PersonName>k__BackingField
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<PersonName>k__BackingField", "System.String")]
            public partial nint PERSON_NAME { get; set; } 
*/

            /// <summary>
            /// 0x298 System.String recoverHpEffectPath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("recoverHpEffectPath", "System.String")]
            public partial nint RECOVER_HP_EFFECT_PATH { get; set; } 
*/

            /// <summary>
            /// 0x2A0 System.String cameraShakeProfilePath
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("cameraShakeProfilePath", "System.String")]
            public partial nint CAMERA_SHAKE_PROFILE_PATH { get; set; } 
*/

            /// <summary>
            /// 0x2A8 System.String recoverHpEffectBindPoint
            /// class ["mscorlib.dll"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("recoverHpEffectBindPoint", "System.String")]
            public partial nint RECOVER_HP_EFFECT_BIND_POINT { get; set; } 
*/

            /// <summary>
            /// 0x2B0 System.Single recoverHpEffectShowTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("recoverHpEffectShowTime", "System.Single")]
            public partial System.Single RECOVER_HP_EFFECT_SHOW_TIME { get; set; } 
*/

            /// <summary>
            /// 0x2B4 System.Single pickEffectDelta
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("pickEffectDelta", "System.Single")]
            public partial System.Single PICK_EFFECT_DELTA { get; set; } 
*/

            /// <summary>
            /// 0x2B8 UnityEngine.Transform pickPoint
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Transform"]
            /// </summary>
            /// <returns>class UnityEngine.Transform</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("pickPoint", "UnityEngine.Transform")]
            public partial nint PICK_POINT { get; set; } 
*/

            /// <summary>
            /// 0x2C0 Mirror.SyncDictionary<System.String , System.Int32> _usedTotem
            /// class ["Mirror.dll"."Mirror"."SyncDictionary`2"]
            /// </summary>
            /// <returns>class Mirror.SyncDictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_usedTotem", "Mirror.SyncDictionary<System.String,System.Int32>")]
            public partial nint _USED_TOTEM { get; set; } 
*/

            /// <summary>
            /// 0x2C8 System.Int32 SelectTotemNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SelectTotemNum", "System.Int32")]
            public partial System.Int32 SELECT_TOTEM_NUM { get; set; } 
*/

            /// <summary>
            /// 0x2CC System.Int32 SelectRelicNum
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("SelectRelicNum", "System.Int32")]
            public partial System.Int32 SELECT_RELIC_NUM { get; set; } 
*/

            /// <summary>
            /// 0x2D0 Mirror.SyncList<Game.Script.Character.RelicData> _relics
            /// class ["Mirror.dll"."Mirror"."SyncList`1"]
            /// </summary>
            /// <returns>class Mirror.SyncList<Game.Script.Character.RelicData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_relics", "Mirror.SyncList<Game.Script.Character.RelicData>")]
            public partial nint _RELICS { get; set; } 
*/

            /// <summary>
            /// 0x2D8 System.Collections.Generic.List<Game.Script.Common.Actor> <AwardActor>k__BackingField
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Game.Script.Common.Actor></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<AwardActor>k__BackingField", "System.Collections.Generic.List<Game.Script.Common.Actor>")]
            public partial nint AWARD_ACTOR { get; set; } 
*/

            /// <summary>
            /// 0x2E0 Mirror.SyncList<System.UInt32> _pets
            /// class ["Mirror.dll"."Mirror"."SyncList`1"]
            /// </summary>
            /// <returns>class Mirror.SyncList<System.UInt32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_pets", "Mirror.SyncList<System.UInt32>")]
            public partial nint _PETS { get; set; } 
*/

            /// <summary>
            /// 0x2E8 System.Single _lastPickEffectTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_lastPickEffectTime", "System.Single")]
            public partial System.Single _LAST_PICK_EFFECT_TIME { get; set; } 
*/

            /// <summary>
            /// 0x2F0 System.Action DeadEvent
            /// class ["mscorlib.dll"."System"."Action"]
            /// </summary>
            /// <returns>class System.Action</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("DeadEvent", "System.Action")]
            public partial nint DEAD_EVENT { get; set; } 
*/

            /// <summary>
            /// 0x2F8 System.Boolean <BossActing>k__BackingField
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<BossActing>k__BackingField", "System.Boolean")]
            public partial System.Boolean BOSS_ACTING { get; set; } 
*/

            /// <summary>
            /// 0x2FC System.UInt32 _myHorse
            /// struct ["mscorlib.dll"."System"."UInt32"]
            /// </summary>
            /// <returns>struct System.UInt32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_myHorse", "System.UInt32")]
            public partial System.UInt32 _MY_HORSE { get; set; } 
*/

            /// <summary>
            /// 0x300 System.Single _lastDamageTime
            /// struct ["mscorlib.dll"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_lastDamageTime", "System.Single")]
            public partial System.Single _LAST_DAMAGE_TIME { get; set; } 
*/

            /// <summary>
            /// 0x304 System.Int32 <OpenAwardBoxs>k__BackingField
            /// struct ["mscorlib.dll"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<OpenAwardBoxs>k__BackingField", "System.Int32")]
            public partial System.Int32 OPEN_AWARD_BOXS { get; set; } 
*/

            /// <summary>
            /// 0x308 System.Action<System.UInt32 , System.UInt32> _Mirror_SyncVarHookDelegate__myHorse
            /// class ["mscorlib.dll"."System"."Action`2"]
            /// </summary>
            /// <returns>class System.Action<System.UInt32 , System.UInt32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Mirror_SyncVarHookDelegate__myHorse", "System.Action<System.UInt32,System.UInt32>")]
            public partial nint _MIRROR_SYNC_VAR_HOOK_DELEGATE__MY_HORSE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Character"."FightCharacter"]
        /// </summary>
        partial struct Ptr_FightCharacter
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Client_PlayEffect__String__Vector3(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Client_PlayEffect__String__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_PLAY_EFFECT__STRING__VECTOR3(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Client_PlayPickUpEffect(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Client_PlayPickUpEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_PLAY_PICK_UP_EFFECT(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Client_SyncTime__Single__WeatherType(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Client_SyncTime__Single__WeatherType", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_SYNC_TIME__SINGLE__WEATHER_TYPE(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_BeginAttack__Int32__String__Vector3(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_BeginAttack__Int32__String__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_BEGIN_ATTACK__INT32__STRING__VECTOR3(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_BuyShopItem__ShopCellActor__Boolean(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_BuyShopItem__ShopCellActor__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_BUY_SHOP_ITEM__SHOP_CELL_ACTOR__BOOLEAN(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_DropTotemData__SearchFilterType__Int32__Int32__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_DropTotemData__SearchFilterType__Int32__Int32__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_DROP_TOTEM_DATA__SEARCH_FILTER_TYPE__INT32__INT32__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_ExchangeTotemItem__SearchFilterType__Int32__Int32__String__SearchFilterType__Int32__Int32__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_ExchangeTotemItem__SearchFilterType__Int32__Int32__String__SearchFilterType__Int32__Int32__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_EXCHANGE_TOTEM_ITEM__SEARCH_FILTER_TYPE__INT32__INT32__STRING__SEARCH_FILTER_TYPE__INT32__INT32__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_ExecuteCheat__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_ExecuteCheat__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_EXECUTE_CHEAT__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_OpenAwardItem__FightEndActor(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_OpenAwardItem__FightEndActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_OPEN_AWARD_ITEM__FIGHT_END_ACTOR(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_OpenTreasureBox__TreasureBoxActor(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_OpenTreasureBox__TreasureBoxActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_OPEN_TREASURE_BOX__TREASURE_BOX_ACTOR(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_PickUpEgg__EggNestActor(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_PickUpEgg__EggNestActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_PICK_UP_EGG__EGG_NEST_ACTOR(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_RandomRelic(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_RandomRelic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_RANDOM_RELIC(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_RandomTotem(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_RandomTotem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_RANDOM_TOTEM(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_RequestEnterInfo(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_RequestEnterInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_REQUEST_ENTER_INFO(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_RestoreLift__RestoreLifeActor(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_RestoreLift__RestoreLifeActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_RESTORE_LIFT__RESTORE_LIFE_ACTOR(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_SelectRelic__FightEndActor__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_SelectRelic__FightEndActor__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_SELECT_RELIC__FIGHT_END_ACTOR__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_SelectRelic__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_SelectRelic__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_SELECT_RELIC__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_SelectTotem__String__FightEndActor(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_SelectTotem__String__FightEndActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_SELECT_TOTEM__STRING__FIGHT_END_ACTOR(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_SetInHome__Boolean(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_SetInHome__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_SET_IN_HOME__BOOLEAN(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_TotemUpgrade__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_TotemUpgrade__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_TOTEM_UPGRADE__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Cmd_ViewAward__Boolean__FightEndActor(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Cmd_ViewAward__Boolean__FightEndActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CMD_VIEW_AWARD__BOOLEAN__FIGHT_END_ACTOR(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_RefreshRelicFrame__Int32__Boolean(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_RefreshRelicFrame__Int32__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_REFRESH_RELIC_FRAME__INT32__BOOLEAN(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_RefreshTotemFrame__Int32__Boolean(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_RefreshTotemFrame__Int32__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_REFRESH_TOTEM_FRAME__INT32__BOOLEAN(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Target_AddItem__String__Int32__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Target_AddItem__String__Int32__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_TARGET_ADD_ITEM__STRING__INT32__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Target_AddKillNum__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Target_AddKillNum__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_TARGET_ADD_KILL_NUM__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_TargetRpc_CheckAttributeFrame__Int32(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_TargetRpc_CheckAttributeFrame__Int32", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_TARGET_RPC_CHECK_ATTRIBUTE_FRAME__INT32(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_TargetRpc_FightResult__Boolean(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_TargetRpc_FightResult__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_TARGET_RPC_FIGHT_RESULT__BOOLEAN(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_TargetRpc_HideLoadingFrame(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_TargetRpc_HideLoadingFrame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_TARGET_RPC_HIDE_LOADING_FRAME(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_TargetRpc_SetInStage__Boolean(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_TargetRpc_SetInStage__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_TARGET_RPC_SET_IN_STAGE__BOOLEAN(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_TargetRpc_SetStartFightLeftTime__Single(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_TargetRpc_SetStartFightLeftTime__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_TARGET_RPC_SET_START_FIGHT_LEFT_TIME__SINGLE(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_TargetRpc_ShowLoadingFrame(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_TargetRpc_ShowLoadingFrame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_TARGET_RPC_SHOW_LOADING_FRAME(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_TargetRpc_StageEnd__Byte[]__String__Boolean(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_TargetRpc_StageEnd__Byte[]__String__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_TARGET_RPC_STAGE_END__BYTE[]__STRING__BOOLEAN(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_TargetRpc_Vibrate__Single__Single__Single__Single(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_TargetRpc_Vibrate__Single__Single__Single__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_TARGET_RPC_VIBRATE__SINGLE__SINGLE__SINGLE__SINGLE(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void AddPet(Game.Script.Character.AICharacter pet)
            /// </summary>
            /// <param name = "pet">class Game.Script.Character.AICharacter</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddPet", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.AICharacter", 0)]
            public partial void ADD_PET(nint pet); 
*/
            /// <summary>
            ///   System.Void AddRelic(System.String relicId)
            /// </summary>
            /// <param name = "relicId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddRelic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ADD_RELIC(nint relicId); 
*/
            /// <summary>
            ///   System.Void AddTotemItem(System.String totemId)
            /// </summary>
            /// <param name = "totemId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddTotemItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ADD_TOTEM_ITEM(nint totemId); 
*/
            /// <summary>
            ///   System.Void Awake()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Awake", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void AWAKE(); 
*/
            /// <summary>
            ///   System.Single CalculateFightPower()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CalculateFightPower", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single CALCULATE_FIGHT_POWER(); 
*/
            /// <summary>
            ///   System.Boolean CanExchangeTotemItemData(SearchFilterType ObjType, System.Int32 objIndex, System.Int32 pos)
            /// </summary>
            /// <param name = "ObjType">enum SearchFilterType</param>
            /// <param name = "objIndex">struct System.Int32</param>
            /// <param name = "pos">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CanExchangeTotemItemData", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SearchFilterType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Boolean CAN_EXCHANGE_TOTEM_ITEM_DATA(SearchFilterType ObjType, System.Int32 objIndex, System.Int32 pos); 
*/
            /// <summary>
            ///   System.Void CheckSkillEnd(Game.Script.Character.AICharacter pet)
            /// </summary>
            /// <param name = "pet">class Game.Script.Character.AICharacter</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckSkillEnd", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.AICharacter", 0)]
            public partial void CHECK_SKILL_END(nint pet); 
*/
            /// <summary>
            ///   System.Void ClearPets()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearPets", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR_PETS(); 
*/
            /// <summary>
            ///   System.Void Client_PlayEffect(System.String path, UnityEngine.Vector3 position)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Client_PlayEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public partial void CLIENT_PLAY_EFFECT(nint path, UnityEngine.Vector3 position); 
*/
            /// <summary>
            ///   System.Void Client_PlayPickUpEffect()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Client_PlayPickUpEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLIENT_PLAY_PICK_UP_EFFECT(); 
*/
            /// <summary>
            ///   System.Void Client_SyncTime(System.Single curTime, Game.Script.Subsystem.WeatherType weatherType)
            /// </summary>
            /// <param name = "curTime">struct System.Single</param>
            /// <param name = "weatherType">enum Game.Script.Subsystem.WeatherType</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Client_SyncTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Subsystem.WeatherType", 1)]
            public partial void CLIENT_SYNC_TIME(System.Single curTime, Game.Script.Subsystem.WeatherType weatherType); 
*/
            /// <summary>
            ///   System.Void Cmd_BeginAttack(System.Int32 petIndex, System.String skillId, UnityEngine.Vector3 point)
            /// </summary>
            /// <param name = "petIndex">struct System.Int32</param>
            /// <param name = "skillId">class System.String</param>
            /// <param name = "point">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_BeginAttack", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            public partial void CMD_BEGIN_ATTACK(System.Int32 petIndex, nint skillId, UnityEngine.Vector3 point); 
*/
            /// <summary>
            ///   System.Void Cmd_BuyShopItem(Game.Script.Map.Actor.ShopCellActor shopCellActor, System.Boolean isAll)
            /// </summary>
            /// <param name = "shopCellActor">class Game.Script.Map.Actor.ShopCellActor</param>
            /// <param name = "isAll">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_BuyShopItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.ShopCellActor", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void CMD_BUY_SHOP_ITEM(nint shopCellActor, System.Boolean isAll); 
*/
            /// <summary>
            ///   System.Void Cmd_DropTotemData(SearchFilterType filterType, System.Int32 petIndex, System.Int32 posIndex, System.String dropTotemId)
            /// </summary>
            /// <param name = "filterType">enum SearchFilterType</param>
            /// <param name = "petIndex">struct System.Int32</param>
            /// <param name = "posIndex">struct System.Int32</param>
            /// <param name = "dropTotemId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_DropTotemData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SearchFilterType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            public partial void CMD_DROP_TOTEM_DATA(SearchFilterType filterType, System.Int32 petIndex, System.Int32 posIndex, nint dropTotemId); 
*/
            /// <summary>
            ///   System.Void Cmd_ExchangeTotemItem(SearchFilterType selectObjType, System.Int32 selectIndex, System.Int32 selectPos, System.String selectTotemId, SearchFilterType targetObjType, System.Int32 targetIndex, System.Int32 targetPos, System.String targetTotemId)
            /// </summary>
            /// <param name = "selectObjType">enum SearchFilterType</param>
            /// <param name = "selectIndex">struct System.Int32</param>
            /// <param name = "selectPos">struct System.Int32</param>
            /// <param name = "selectTotemId">class System.String</param>
            /// <param name = "targetObjType">enum SearchFilterType</param>
            /// <param name = "targetIndex">struct System.Int32</param>
            /// <param name = "targetPos">struct System.Int32</param>
            /// <param name = "targetTotemId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_ExchangeTotemItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SearchFilterType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SearchFilterType", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 7)]
            public partial void CMD_EXCHANGE_TOTEM_ITEM(SearchFilterType selectObjType, System.Int32 selectIndex, System.Int32 selectPos, nint selectTotemId, SearchFilterType targetObjType, System.Int32 targetIndex, System.Int32 targetPos, nint targetTotemId); 
*/
            /// <summary>
            ///   System.Void Cmd_ExecuteCheat(System.String str)
            /// </summary>
            /// <param name = "str">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_ExecuteCheat", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CMD_EXECUTE_CHEAT(nint str); 
*/
            /// <summary>
            ///   System.Void Cmd_OpenAwardItem(Game.Script.Map.Actor.FightEndActor awardItemActor)
            /// </summary>
            /// <param name = "awardItemActor">class Game.Script.Map.Actor.FightEndActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_OpenAwardItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.FightEndActor", 0)]
            public partial void CMD_OPEN_AWARD_ITEM(nint awardItemActor); 
*/
            /// <summary>
            ///   System.Void Cmd_OpenTreasureBox(Game.Script.Map.Actor.TreasureBoxActor treasureBoxActor)
            /// </summary>
            /// <param name = "treasureBoxActor">class Game.Script.Map.Actor.TreasureBoxActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_OpenTreasureBox", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.TreasureBoxActor", 0)]
            public partial void CMD_OPEN_TREASURE_BOX(nint treasureBoxActor); 
*/
            /// <summary>
            ///   System.Void Cmd_PickUpEgg(Game.Script.Map.Actor.EggNestActor eggNestActor)
            /// </summary>
            /// <param name = "eggNestActor">class Game.Script.Map.Actor.EggNestActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_PickUpEgg", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.EggNestActor", 0)]
            public partial void CMD_PICK_UP_EGG(nint eggNestActor); 
*/
            /// <summary>
            ///   System.Void Cmd_RandomRelic()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_RandomRelic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CMD_RANDOM_RELIC(); 
*/
            /// <summary>
            ///   System.Void Cmd_RandomTotem()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_RandomTotem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CMD_RANDOM_TOTEM(); 
*/
            /// <summary>
            ///   System.Void Cmd_RequestEnterInfo()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_RequestEnterInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CMD_REQUEST_ENTER_INFO(); 
*/
            /// <summary>
            ///   System.Void Cmd_RestoreLift(Game.Script.Map.Actor.RestoreLifeActor restoreLifeActor)
            /// </summary>
            /// <param name = "restoreLifeActor">class Game.Script.Map.Actor.RestoreLifeActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_RestoreLift", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.RestoreLifeActor", 0)]
            public partial void CMD_RESTORE_LIFT(nint restoreLifeActor); 
*/
            /// <summary>
            ///   System.Void Cmd_SelectRelic(Game.Script.Map.Actor.FightEndActor relicActor, System.String relicId)
            /// </summary>
            /// <param name = "relicActor">class Game.Script.Map.Actor.FightEndActor</param>
            /// <param name = "relicId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_SelectRelic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.FightEndActor", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void CMD_SELECT_RELIC(nint relicActor, nint relicId); 
*/
            /// <summary>
            ///   System.Void Cmd_SelectRelic(System.String relicId)
            /// </summary>
            /// <param name = "relicId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_SelectRelic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CMD_SELECT_RELIC(nint relicId); 
*/
            /// <summary>
            ///   System.Void Cmd_SelectTotem(System.String totem, Game.Script.Map.Actor.FightEndActor totemActor)
            /// </summary>
            /// <param name = "totem">class System.String</param>
            /// <param name = "totemActor">class Game.Script.Map.Actor.FightEndActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_SelectTotem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.FightEndActor", 1)]
            public partial void CMD_SELECT_TOTEM(nint totem, nint totemActor); 
*/
            /// <summary>
            ///   System.Void Cmd_SetInHome(System.Boolean inHome)
            /// </summary>
            /// <param name = "inHome">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_SetInHome", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void CMD_SET_IN_HOME(System.Boolean inHome); 
*/
            /// <summary>
            ///   System.Void Cmd_TotemUpgrade(System.String upgradeTotemId)
            /// </summary>
            /// <param name = "upgradeTotemId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_TotemUpgrade", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CMD_TOTEM_UPGRADE(nint upgradeTotemId); 
*/
            /// <summary>
            ///   System.Void Cmd_ViewAward(System.Boolean view, Game.Script.Map.Actor.FightEndActor fightEndActor)
            /// </summary>
            /// <param name = "view">struct System.Boolean</param>
            /// <param name = "fightEndActor">class Game.Script.Map.Actor.FightEndActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_ViewAward", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.FightEndActor", 1)]
            public partial void CMD_VIEW_AWARD(System.Boolean view, nint fightEndActor); 
*/
            /// <summary>
            ///   System.Void DeserializeSyncVars(Mirror.NetworkReader reader, System.Boolean initialState)
            /// </summary>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "initialState">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeserializeSyncVars", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void DESERIALIZE_SYNC_VARS(nint reader, System.Boolean initialState); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<Game.Script.Common.Actor> get_AwardActor()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Game.Script.Common.Actor></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AwardActor", "System.Collections.Generic.List<Game.Script.Common.Actor>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_AWARD_ACTOR(); 
*/
            /// <summary>
            ///   System.Boolean get_BossActing()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BossActing", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_BOSS_ACTING(); 
*/
            /// <summary>
            ///   SearchFilterType get_FilterType()
            /// </summary>
            /// <returns>enum SearchFilterType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_FilterType", "SearchFilterType", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial SearchFilterType GET_FILTER_TYPE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsInHome()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsInHome", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_IN_HOME(); 
*/
            /// <summary>
            ///   Game.Script.Character.AICharacter get_MyHorse()
            /// </summary>
            /// <returns>class Game.Script.Character.AICharacter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_MyHorse", "Game.Script.Character.AICharacter", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_MY_HORSE(); 
*/
            /// <summary>
            ///   System.UInt32 get_Network_myHorse()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network_myHorse", "System.UInt32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.UInt32 GET_NETWORK_MY_HORSE(); 
*/
            /// <summary>
            ///   System.Boolean get_Network<BossActing>k__BackingField()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network<BossActing>k__BackingField", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_NETWORK_BOSS_ACTINGK__BACKING_FIELD(); 
*/
            /// <summary>
            ///   System.Boolean get_Network<IsInHome>k__BackingField()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network<IsInHome>k__BackingField", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_NETWORK_IS_IN_HOMEK__BACKING_FIELD(); 
*/
            /// <summary>
            ///   System.String get_Network<PersonName>k__BackingField()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network<PersonName>k__BackingField", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NETWORK_PERSON_NAMEK__BACKING_FIELD(); 
*/
            /// <summary>
            ///   System.Int32 get_OpenAwardBoxs()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_OpenAwardBoxs", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_OPEN_AWARD_BOXS(); 
*/
            /// <summary>
            ///   System.String get_PersonName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_PersonName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PERSON_NAME(); 
*/
            /// <summary>
            ///   Mirror.SyncList<System.UInt32> get_Pets()
            /// </summary>
            /// <returns>class Mirror.SyncList<System.UInt32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Pets", "Mirror.SyncList<System.UInt32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PETS(); 
*/
            /// <summary>
            ///   Mirror.SyncList<Game.Script.Character.RelicData> get_Relics()
            /// </summary>
            /// <returns>class Mirror.SyncList<Game.Script.Character.RelicData></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Relics", "Mirror.SyncList<Game.Script.Character.RelicData>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_RELICS(); 
*/
            /// <summary>
            ///   Mirror.SyncDictionary<System.String , System.Int32> get_UsedTotem()
            /// </summary>
            /// <returns>class Mirror.SyncDictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_UsedTotem", "Mirror.SyncDictionary<System.String,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_USED_TOTEM(); 
*/
            /// <summary>
            ///   System.Int32 GetCurrRelicLevel(System.String relicId)
            /// </summary>
            /// <param name = "relicId">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCurrRelicLevel", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_CURR_RELIC_LEVEL(nint relicId); 
*/
            /// <summary>
            ///   System.Void HandleBeatBackEffect(Game.Script.Common.DamageInfo damageInfo)
            /// </summary>
            /// <param name = "damageInfo">class Game.Script.Common.DamageInfo</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HandleBeatBackEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.DamageInfo", 0)]
            public partial void HANDLE_BEAT_BACK_EFFECT(nint damageInfo); 
*/
            /// <summary>
            ///   System.Boolean IsMaxLevelRelic(System.String relicId)
            /// </summary>
            /// <param name = "relicId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsMaxLevelRelic", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean IS_MAX_LEVEL_RELIC(nint relicId); 
*/
            /// <summary>
            ///   System.Void OnDead(System.Boolean oldValue, System.Boolean newValue)
            /// </summary>
            /// <param name = "oldValue">struct System.Boolean</param>
            /// <param name = "newValue">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDead", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ON_DEAD(System.Boolean oldValue, System.Boolean newValue); 
*/
            /// <summary>
            ///   System.Void OnDestroy()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDestroy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_DESTROY(); 
*/
            /// <summary>
            ///   System.Void OnHorseChange(System.UInt32 oldValue, System.UInt32 newValue)
            /// </summary>
            /// <param name = "oldValue">struct System.UInt32</param>
            /// <param name = "newValue">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnHorseChange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 1)]
            public partial void ON_HORSE_CHANGE(System.UInt32 oldValue, System.UInt32 newValue); 
*/
            /// <summary>
            ///   System.Void OnHPChange(System.Single oldHp, System.Single newHp)
            /// </summary>
            /// <param name = "oldHp">struct System.Single</param>
            /// <param name = "newHp">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnHPChange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void ON_HP_CHANGE(System.Single oldHp, System.Single newHp); 
*/
            /// <summary>
            ///   System.Void OnHpChangeForAll(System.Single oldHp, System.Single newHp)
            /// </summary>
            /// <param name = "oldHp">struct System.Single</param>
            /// <param name = "newHp">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnHpChangeForAll", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void ON_HP_CHANGE_FOR_ALL(System.Single oldHp, System.Single newHp); 
*/
            /// <summary>
            ///   System.Void OnStartAuthority()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStartAuthority", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_START_AUTHORITY(); 
*/
            /// <summary>
            ///   System.Void OnStartClient()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStartClient", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_START_CLIENT(); 
*/
            /// <summary>
            ///   System.Void OnStartServer()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStartServer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_START_SERVER(); 
*/
            /// <summary>
            ///   System.Void OnStopServer()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStopServer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_STOP_SERVER(); 
*/
            /// <summary>
            ///   System.Void PlayEffect(System.String path, UnityEngine.Vector3 position)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PlayEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public partial void PLAY_EFFECT(nint path, UnityEngine.Vector3 position); 
*/
            /// <summary>
            ///   System.Void PlayPickUpEffect()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PlayPickUpEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void PLAY_PICK_UP_EFFECT(); 
*/
            /// <summary>
            ///   System.Void RefreshRelicFrame(System.Int32 refreshTimes, System.Boolean isHide)
            /// </summary>
            /// <param name = "refreshTimes">struct System.Int32</param>
            /// <param name = "isHide">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshRelicFrame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void REFRESH_RELIC_FRAME(System.Int32 refreshTimes, System.Boolean isHide); 
*/
            /// <summary>
            ///   System.Void RefreshTotemFrame(System.Int32 refreshTimes, System.Boolean IsHide)
            /// </summary>
            /// <param name = "refreshTimes">struct System.Int32</param>
            /// <param name = "IsHide">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshTotemFrame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void REFRESH_TOTEM_FRAME(System.Int32 refreshTimes, System.Boolean IsHide); 
*/
            /// <summary>
            ///   System.Void RelicsItemChanges(Mirror.SyncList.Operation<Game.Script.Character.RelicData> op, System.Int32 itemindex, Game.Script.Character.RelicData olditem, Game.Script.Character.RelicData newitem)
            /// </summary>
            /// <param name = "op">enum Mirror.SyncList.Operation<Game.Script.Character.RelicData></param>
            /// <param name = "itemindex">struct System.Int32</param>
            /// <param name = "olditem">class Game.Script.Character.RelicData</param>
            /// <param name = "newitem">class Game.Script.Character.RelicData</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RelicsItemChanges", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.SyncList.Operation<Game.Script.Character.RelicData>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.RelicData", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.RelicData", 3)]
            public partial void RELICS_ITEM_CHANGES(Mirror.SyncList.Operation<Game.Script.Character.RelicData> op, System.Int32 itemindex, nint olditem, nint newitem); 
*/
            /// <summary>
            ///   System.Void RemovePet(Game.Script.Character.AICharacter pet)
            /// </summary>
            /// <param name = "pet">class Game.Script.Character.AICharacter</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemovePet", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.AICharacter", 0)]
            public partial void REMOVE_PET(nint pet); 
*/
            /// <summary>
            ///   System.Void RemoveRelic(System.String relicId)
            /// </summary>
            /// <param name = "relicId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveRelic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void REMOVE_RELIC(nint relicId); 
*/
            /// <summary>
            ///   System.Void RemoveRelicById(System.String relicsId)
            /// </summary>
            /// <param name = "relicsId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveRelicById", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void REMOVE_RELIC_BY_ID(nint relicsId); 
*/
            /// <summary>
            ///   System.Void RemoveTotemItem(System.String totemId)
            /// </summary>
            /// <param name = "totemId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveTotemItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void REMOVE_TOTEM_ITEM(nint totemId); 
*/
            /// <summary>
            ///   System.Void SerializeSyncVars(Mirror.NetworkWriter writer, System.Boolean forceAll)
            /// </summary>
            /// <param name = "writer">class Mirror.NetworkWriter</param>
            /// <param name = "forceAll">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeSyncVars", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkWriter", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SERIALIZE_SYNC_VARS(nint writer, System.Boolean forceAll); 
*/
            /// <summary>
            ///   System.Void set_AwardActor(System.Collections.Generic.List<Game.Script.Common.Actor> value)
            /// </summary>
            /// <param name = "value">class System.Collections.Generic.List<Game.Script.Common.Actor></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AwardActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<Game.Script.Common.Actor>", 0)]
            public partial void SET_AWARD_ACTOR(nint value); 
*/
            /// <summary>
            ///   System.Void set_BossActing(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BossActing", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_BOSS_ACTING(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_IsInHome(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsInHome", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_IN_HOME(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Network_myHorse(System.UInt32 value)
            /// </summary>
            /// <param name = "value">struct System.UInt32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network_myHorse", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 0)]
            public partial void SET_NETWORK_MY_HORSE(System.UInt32 value); 
*/
            /// <summary>
            ///   System.Void set_Network<BossActing>k__BackingField(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network<BossActing>k__BackingField", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_NETWORK_BOSS_ACTINGK__BACKING_FIELD(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Network<IsInHome>k__BackingField(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network<IsInHome>k__BackingField", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_NETWORK_IS_IN_HOMEK__BACKING_FIELD(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Network<PersonName>k__BackingField(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network<PersonName>k__BackingField", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_NETWORK_PERSON_NAMEK__BACKING_FIELD(nint value); 
*/
            /// <summary>
            ///   System.Void set_OpenAwardBoxs(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_OpenAwardBoxs", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_OPEN_AWARD_BOXS(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_PersonName(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_PersonName", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_PERSON_NAME(nint value); 
*/
            /// <summary>
            ///   System.Void SetHorse(Game.Script.Character.AICharacter horse)
            /// </summary>
            /// <param name = "horse">class Game.Script.Character.AICharacter</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetHorse", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.AICharacter", 0)]
            public partial void SET_HORSE(nint horse); 
*/
            /// <summary>
            ///   System.Void ShowAttributeFrame(System.Int32 no)
            /// </summary>
            /// <param name = "no">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ShowAttributeFrame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SHOW_ATTRIBUTE_FRAME(System.Int32 no); 
*/
            /// <summary>
            ///   System.Void Start()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Start", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void START(); 
*/
            /// <summary>
            ///   System.Void TakeDamage(Game.Script.Common.Actor srcActor, Game.Script.Common.DamageInfo info)
            /// </summary>
            /// <param name = "srcActor">class Game.Script.Common.Actor</param>
            /// <param name = "info">class Game.Script.Common.DamageInfo</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TakeDamage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.Actor", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.DamageInfo", 1)]
            public partial void TAKE_DAMAGE(nint srcActor, nint info); 
*/
            /// <summary>
            ///   System.Void Target_AddItem(System.String id, System.Int32 count, System.String param)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "param">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Target_AddItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            public partial void TARGET_ADD_ITEM(nint id, System.Int32 count, nint param); 
*/
            /// <summary>
            ///   System.Void Target_AddKillNum(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Target_AddKillNum", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void TARGET_ADD_KILL_NUM(nint id); 
*/
            /// <summary>
            ///   System.Void TargetRpc_CheckAttributeFrame(System.Int32 no)
            /// </summary>
            /// <param name = "no">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TargetRpc_CheckAttributeFrame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void TARGET_RPC_CHECK_ATTRIBUTE_FRAME(System.Int32 no); 
*/
            /// <summary>
            ///   System.Void TargetRpc_FightResult(System.Boolean success)
            /// </summary>
            /// <param name = "success">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TargetRpc_FightResult", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void TARGET_RPC_FIGHT_RESULT(System.Boolean success); 
*/
            /// <summary>
            ///   System.Void TargetRpc_HideLoadingFrame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TargetRpc_HideLoadingFrame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void TARGET_RPC_HIDE_LOADING_FRAME(); 
*/
            /// <summary>
            ///   System.Void TargetRpc_SetInStage(System.Boolean inStage)
            /// </summary>
            /// <param name = "inStage">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TargetRpc_SetInStage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void TARGET_RPC_SET_IN_STAGE(System.Boolean inStage); 
*/
            /// <summary>
            ///   System.Void TargetRpc_SetStartFightLeftTime(System.Single leftTime)
            /// </summary>
            /// <param name = "leftTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TargetRpc_SetStartFightLeftTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void TARGET_RPC_SET_START_FIGHT_LEFT_TIME(System.Single leftTime); 
*/
            /// <summary>
            ///   System.Void TargetRpc_ShowLoadingFrame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TargetRpc_ShowLoadingFrame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void TARGET_RPC_SHOW_LOADING_FRAME(); 
*/
            /// <summary>
            ///   System.Void TargetRpc_StageEnd(System.Byte[] data, System.String id, System.Boolean success)
            /// </summary>
            /// <param name = "data">class System.Byte[]</param>
            /// <param name = "id">class System.String</param>
            /// <param name = "success">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TargetRpc_StageEnd", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Byte[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void TARGET_RPC_STAGE_END(nint data, nint id, System.Boolean success); 
*/
            /// <summary>
            ///   System.Void TargetRpc_Vibrate(System.Single leftLevel, System.Single rightLevel, System.Single leftDuration, System.Single rightDuration)
            /// </summary>
            /// <param name = "leftLevel">struct System.Single</param>
            /// <param name = "rightLevel">struct System.Single</param>
            /// <param name = "leftDuration">struct System.Single</param>
            /// <param name = "rightDuration">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TargetRpc_Vibrate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public partial void TARGET_RPC_VIBRATE(System.Single leftLevel, System.Single rightLevel, System.Single leftDuration, System.Single rightDuration); 
*/
            /// <summary>
            ///   System.Void UpdateHideEffect()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateHideEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_HIDE_EFFECT(); 
*/
            /// <summary>
            ///   System.Void UserCode_Client_PlayEffect__String__Vector3(System.String path, UnityEngine.Vector3 position)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Client_PlayEffect__String__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public partial void USER_CODE_CLIENT_PLAY_EFFECT__STRING__VECTOR3(nint path, UnityEngine.Vector3 position); 
*/
            /// <summary>
            ///   System.Void UserCode_Client_PlayPickUpEffect()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Client_PlayPickUpEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void USER_CODE_CLIENT_PLAY_PICK_UP_EFFECT(); 
*/
            /// <summary>
            ///   System.Void UserCode_Client_SyncTime__Single__WeatherType(System.Single curTime, Game.Script.Subsystem.WeatherType weatherType)
            /// </summary>
            /// <param name = "curTime">struct System.Single</param>
            /// <param name = "weatherType">enum Game.Script.Subsystem.WeatherType</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Client_SyncTime__Single__WeatherType", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Subsystem.WeatherType", 1)]
            public partial void USER_CODE_CLIENT_SYNC_TIME__SINGLE__WEATHER_TYPE(System.Single curTime, Game.Script.Subsystem.WeatherType weatherType); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_BeginAttack__Int32__String__Vector3(System.Int32 petIndex, System.String skillId, UnityEngine.Vector3 point)
            /// </summary>
            /// <param name = "petIndex">struct System.Int32</param>
            /// <param name = "skillId">class System.String</param>
            /// <param name = "point">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_BeginAttack__Int32__String__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            public partial void USER_CODE_CMD_BEGIN_ATTACK__INT32__STRING__VECTOR3(System.Int32 petIndex, nint skillId, UnityEngine.Vector3 point); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_BuyShopItem__ShopCellActor__Boolean(Game.Script.Map.Actor.ShopCellActor shopCellActor, System.Boolean isAll)
            /// </summary>
            /// <param name = "shopCellActor">class Game.Script.Map.Actor.ShopCellActor</param>
            /// <param name = "isAll">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_BuyShopItem__ShopCellActor__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.ShopCellActor", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void USER_CODE_CMD_BUY_SHOP_ITEM__SHOP_CELL_ACTOR__BOOLEAN(nint shopCellActor, System.Boolean isAll); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_DropTotemData__SearchFilterType__Int32__Int32__String(SearchFilterType filterType, System.Int32 petIndex, System.Int32 posIndex, System.String dropTotemId)
            /// </summary>
            /// <param name = "filterType">enum SearchFilterType</param>
            /// <param name = "petIndex">struct System.Int32</param>
            /// <param name = "posIndex">struct System.Int32</param>
            /// <param name = "dropTotemId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_DropTotemData__SearchFilterType__Int32__Int32__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SearchFilterType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            public partial void USER_CODE_CMD_DROP_TOTEM_DATA__SEARCH_FILTER_TYPE__INT32__INT32__STRING(SearchFilterType filterType, System.Int32 petIndex, System.Int32 posIndex, nint dropTotemId); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_ExchangeTotemItem__SearchFilterType__Int32__Int32__String__SearchFilterType__Int32__Int32__String(SearchFilterType selectObjType, System.Int32 selectIndex, System.Int32 selectPos, System.String selectTotemId, SearchFilterType targetObjType, System.Int32 targetIndex, System.Int32 targetPos, System.String targetTotemId)
            /// </summary>
            /// <param name = "selectObjType">enum SearchFilterType</param>
            /// <param name = "selectIndex">struct System.Int32</param>
            /// <param name = "selectPos">struct System.Int32</param>
            /// <param name = "selectTotemId">class System.String</param>
            /// <param name = "targetObjType">enum SearchFilterType</param>
            /// <param name = "targetIndex">struct System.Int32</param>
            /// <param name = "targetPos">struct System.Int32</param>
            /// <param name = "targetTotemId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_ExchangeTotemItem__SearchFilterType__Int32__Int32__String__SearchFilterType__Int32__Int32__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SearchFilterType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SearchFilterType", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 7)]
            public partial void USER_CODE_CMD_EXCHANGE_TOTEM_ITEM__SEARCH_FILTER_TYPE__INT32__INT32__STRING__SEARCH_FILTER_TYPE__INT32__INT32__STRING(SearchFilterType selectObjType, System.Int32 selectIndex, System.Int32 selectPos, nint selectTotemId, SearchFilterType targetObjType, System.Int32 targetIndex, System.Int32 targetPos, nint targetTotemId); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_ExecuteCheat__String(System.String str)
            /// </summary>
            /// <param name = "str">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_ExecuteCheat__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void USER_CODE_CMD_EXECUTE_CHEAT__STRING(nint str); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_OpenAwardItem__FightEndActor(Game.Script.Map.Actor.FightEndActor awardItemActor)
            /// </summary>
            /// <param name = "awardItemActor">class Game.Script.Map.Actor.FightEndActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_OpenAwardItem__FightEndActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.FightEndActor", 0)]
            public partial void USER_CODE_CMD_OPEN_AWARD_ITEM__FIGHT_END_ACTOR(nint awardItemActor); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_OpenTreasureBox__TreasureBoxActor(Game.Script.Map.Actor.TreasureBoxActor treasureBoxActor)
            /// </summary>
            /// <param name = "treasureBoxActor">class Game.Script.Map.Actor.TreasureBoxActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_OpenTreasureBox__TreasureBoxActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.TreasureBoxActor", 0)]
            public partial void USER_CODE_CMD_OPEN_TREASURE_BOX__TREASURE_BOX_ACTOR(nint treasureBoxActor); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_PickUpEgg__EggNestActor(Game.Script.Map.Actor.EggNestActor eggNestActor)
            /// </summary>
            /// <param name = "eggNestActor">class Game.Script.Map.Actor.EggNestActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_PickUpEgg__EggNestActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.EggNestActor", 0)]
            public partial void USER_CODE_CMD_PICK_UP_EGG__EGG_NEST_ACTOR(nint eggNestActor); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_RandomRelic()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_RandomRelic", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void USER_CODE_CMD_RANDOM_RELIC(); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_RandomTotem()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_RandomTotem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void USER_CODE_CMD_RANDOM_TOTEM(); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_RequestEnterInfo()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_RequestEnterInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void USER_CODE_CMD_REQUEST_ENTER_INFO(); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_RestoreLift__RestoreLifeActor(Game.Script.Map.Actor.RestoreLifeActor restoreLifeActor)
            /// </summary>
            /// <param name = "restoreLifeActor">class Game.Script.Map.Actor.RestoreLifeActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_RestoreLift__RestoreLifeActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.RestoreLifeActor", 0)]
            public partial void USER_CODE_CMD_RESTORE_LIFT__RESTORE_LIFE_ACTOR(nint restoreLifeActor); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_SelectRelic__FightEndActor__String(Game.Script.Map.Actor.FightEndActor relicActor, System.String relicId)
            /// </summary>
            /// <param name = "relicActor">class Game.Script.Map.Actor.FightEndActor</param>
            /// <param name = "relicId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_SelectRelic__FightEndActor__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.FightEndActor", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void USER_CODE_CMD_SELECT_RELIC__FIGHT_END_ACTOR__STRING(nint relicActor, nint relicId); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_SelectRelic__String(System.String relicId)
            /// </summary>
            /// <param name = "relicId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_SelectRelic__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void USER_CODE_CMD_SELECT_RELIC__STRING(nint relicId); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_SelectTotem__String__FightEndActor(System.String totem, Game.Script.Map.Actor.FightEndActor totemActor)
            /// </summary>
            /// <param name = "totem">class System.String</param>
            /// <param name = "totemActor">class Game.Script.Map.Actor.FightEndActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_SelectTotem__String__FightEndActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.FightEndActor", 1)]
            public partial void USER_CODE_CMD_SELECT_TOTEM__STRING__FIGHT_END_ACTOR(nint totem, nint totemActor); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_SetInHome__Boolean(System.Boolean inHome)
            /// </summary>
            /// <param name = "inHome">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_SetInHome__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void USER_CODE_CMD_SET_IN_HOME__BOOLEAN(System.Boolean inHome); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_TotemUpgrade__String(System.String upgradeTotemId)
            /// </summary>
            /// <param name = "upgradeTotemId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_TotemUpgrade__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void USER_CODE_CMD_TOTEM_UPGRADE__STRING(nint upgradeTotemId); 
*/
            /// <summary>
            ///   System.Void UserCode_Cmd_ViewAward__Boolean__FightEndActor(System.Boolean view, Game.Script.Map.Actor.FightEndActor fightEndActor)
            /// </summary>
            /// <param name = "view">struct System.Boolean</param>
            /// <param name = "fightEndActor">class Game.Script.Map.Actor.FightEndActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Cmd_ViewAward__Boolean__FightEndActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.FightEndActor", 1)]
            public partial void USER_CODE_CMD_VIEW_AWARD__BOOLEAN__FIGHT_END_ACTOR(System.Boolean view, nint fightEndActor); 
*/
            /// <summary>
            ///   System.Void UserCode_RefreshRelicFrame__Int32__Boolean(System.Int32 refreshTimes, System.Boolean isHide)
            /// </summary>
            /// <param name = "refreshTimes">struct System.Int32</param>
            /// <param name = "isHide">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_RefreshRelicFrame__Int32__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void USER_CODE_REFRESH_RELIC_FRAME__INT32__BOOLEAN(System.Int32 refreshTimes, System.Boolean isHide); 
*/
            /// <summary>
            ///   System.Void UserCode_RefreshTotemFrame__Int32__Boolean(System.Int32 refreshTimes, System.Boolean IsHide)
            /// </summary>
            /// <param name = "refreshTimes">struct System.Int32</param>
            /// <param name = "IsHide">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_RefreshTotemFrame__Int32__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void USER_CODE_REFRESH_TOTEM_FRAME__INT32__BOOLEAN(System.Int32 refreshTimes, System.Boolean IsHide); 
*/
            /// <summary>
            ///   System.Void UserCode_Target_AddItem__String__Int32__String(System.String id, System.Int32 count, System.String param)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "param">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Target_AddItem__String__Int32__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 2)]
            public partial void USER_CODE_TARGET_ADD_ITEM__STRING__INT32__STRING(nint id, System.Int32 count, nint param); 
*/
            /// <summary>
            ///   System.Void UserCode_Target_AddKillNum__String(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Target_AddKillNum__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void USER_CODE_TARGET_ADD_KILL_NUM__STRING(nint id); 
*/
            /// <summary>
            ///   System.Void UserCode_TargetRpc_CheckAttributeFrame__Int32(System.Int32 no)
            /// </summary>
            /// <param name = "no">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_TargetRpc_CheckAttributeFrame__Int32", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void USER_CODE_TARGET_RPC_CHECK_ATTRIBUTE_FRAME__INT32(System.Int32 no); 
*/
            /// <summary>
            ///   System.Void UserCode_TargetRpc_FightResult__Boolean(System.Boolean success)
            /// </summary>
            /// <param name = "success">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_TargetRpc_FightResult__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void USER_CODE_TARGET_RPC_FIGHT_RESULT__BOOLEAN(System.Boolean success); 
*/
            /// <summary>
            ///   System.Void UserCode_TargetRpc_HideLoadingFrame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_TargetRpc_HideLoadingFrame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void USER_CODE_TARGET_RPC_HIDE_LOADING_FRAME(); 
*/
            /// <summary>
            ///   System.Void UserCode_TargetRpc_SetInStage__Boolean(System.Boolean inStage)
            /// </summary>
            /// <param name = "inStage">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_TargetRpc_SetInStage__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void USER_CODE_TARGET_RPC_SET_IN_STAGE__BOOLEAN(System.Boolean inStage); 
*/
            /// <summary>
            ///   System.Void UserCode_TargetRpc_SetStartFightLeftTime__Single(System.Single leftTime)
            /// </summary>
            /// <param name = "leftTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_TargetRpc_SetStartFightLeftTime__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void USER_CODE_TARGET_RPC_SET_START_FIGHT_LEFT_TIME__SINGLE(System.Single leftTime); 
*/
            /// <summary>
            ///   System.Void UserCode_TargetRpc_ShowLoadingFrame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_TargetRpc_ShowLoadingFrame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void USER_CODE_TARGET_RPC_SHOW_LOADING_FRAME(); 
*/
            /// <summary>
            ///   System.Void UserCode_TargetRpc_StageEnd__Byte[]__String__Boolean(System.Byte[] data, System.String id, System.Boolean success)
            /// </summary>
            /// <param name = "data">class System.Byte[]</param>
            /// <param name = "id">class System.String</param>
            /// <param name = "success">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_TargetRpc_StageEnd__Byte[]__String__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Byte[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void USER_CODE_TARGET_RPC_STAGE_END__BYTE[]__STRING__BOOLEAN(nint data, nint id, System.Boolean success); 
*/
            /// <summary>
            ///   System.Void UserCode_TargetRpc_Vibrate__Single__Single__Single__Single(System.Single leftLevel, System.Single rightLevel, System.Single leftDuration, System.Single rightDuration)
            /// </summary>
            /// <param name = "leftLevel">struct System.Single</param>
            /// <param name = "rightLevel">struct System.Single</param>
            /// <param name = "leftDuration">struct System.Single</param>
            /// <param name = "rightDuration">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_TargetRpc_Vibrate__Single__Single__Single__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public partial void USER_CODE_TARGET_RPC_VIBRATE__SINGLE__SINGLE__SINGLE__SINGLE(System.Single leftLevel, System.Single rightLevel, System.Single leftDuration, System.Single rightDuration); 
*/
            /// <summary>
            ///   System.Boolean Weaved()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Weaved", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean WEAVED(); 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Character"."Pawn"]
        /// </summary>
        partial struct Ptr_FightCharacter
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Boolean get_IsAddToSearch()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsAddToSearch", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_ADD_TO_SEARCH(); 
*/
            /// <summary>
            ///   System.Boolean Weaved()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Weaved", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean WEAVED(); 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Character"."Character"]
        /// </summary>
        partial struct Ptr_FightCharacter
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Client_PlayGhostEffect__Single(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Client_PlayGhostEffect__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_PLAY_GHOST_EFFECT__SINGLE(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Client_PlaySound__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Client_PlaySound__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_PLAY_SOUND__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Client_RemoteChangeWeapon__String__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Client_RemoteChangeWeapon__String__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_REMOTE_CHANGE_WEAPON__STRING__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Client_SetVisible__Boolean(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Client_SetVisible__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_SET_VISIBLE__BOOLEAN(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Client_SetVisualEffectFloatValue__String__String__Single__Single__Single(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Client_SetVisualEffectFloatValue__String__String__Single__Single__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_SET_VISUAL_EFFECT_FLOAT_VALUE__STRING__STRING__SINGLE__SINGLE__SINGLE(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_Miss(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_Miss", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_MISS(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_PlayAnimation__String__Boolean__Single__Boolean__Boolean(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_PlayAnimation__String__Boolean__Single__Boolean__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_PLAY_ANIMATION__STRING__BOOLEAN__SINGLE__BOOLEAN__BOOLEAN(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_PlayBingPointSkillEffect__String__String__Single(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_PlayBingPointSkillEffect__String__String__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_PLAY_BING_POINT_SKILL_EFFECT__STRING__STRING__SINGLE(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_PlayBuffEffect__String__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_PlayBuffEffect__String__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_PLAY_BUFF_EFFECT__STRING__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_PlayCameraShake__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_PlayCameraShake__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_PLAY_CAMERA_SHAKE__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_PlayDamageEffect__String__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_PlayDamageEffect__String__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_PLAY_DAMAGE_EFFECT__STRING__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_PlayRoomSkillEffect__String__Vector3__Vector3__Single(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_PlayRoomSkillEffect__String__Vector3__Vector3__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_PLAY_ROOM_SKILL_EFFECT__STRING__VECTOR3__VECTOR3__SINGLE(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_PlaySkillEffect__String__Vector3(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_PlaySkillEffect__String__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_PLAY_SKILL_EFFECT__STRING__VECTOR3(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_RemoveBuffEffect__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_RemoveBuffEffect__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_REMOVE_BUFF_EFFECT__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_RemoveSkillEffect__String(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_RemoveSkillEffect__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_REMOVE_SKILL_EFFECT__STRING(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_RestAnimationSpeedRate(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_RestAnimationSpeedRate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_REST_ANIMATION_SPEED_RATE(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_SpawnSkillWarning__String__String__Vector3__Single__Int32__Single__GameObject__Int32__Single__Single__E_PlaySpecialEffectsLocation__Vector3(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_SpawnSkillWarning__String__String__Vector3__Single__Int32__Single__GameObject__Int32__Single__Single__E_PlaySpecialEffectsLocation__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_SPAWN_SKILL_WARNING__STRING__STRING__VECTOR3__SINGLE__INT32__SINGLE__GAME_OBJECT__INT32__SINGLE__SINGLE__E_PLAY_SPECIAL_EFFECTS_LOCATION__VECTOR3(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_TakeDamaged__Single__E_SkillDamageType__Boolean(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_TakeDamaged__Single__E_SkillDamageType__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_TAKE_DAMAGED__SINGLE__E_SKILL_DAMAGE_TYPE__BOOLEAN(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_UpdateAttribute__CharacterAttribute__E_AttributeType__Single__Single(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_UpdateAttribute__CharacterAttribute__E_AttributeType__Single__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_UPDATE_ATTRIBUTE__CHARACTER_ATTRIBUTE__E_ATTRIBUTE_TYPE__SINGLE__SINGLE(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_ClientRpc_UpdateBaseAnimation(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_ClientRpc_UpdateBaseAnimation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_CLIENT_RPC_UPDATE_BASE_ANIMATION(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Target_PlayAudio__String__Vector3(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Target_PlayAudio__String__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_TARGET_PLAY_AUDIO__STRING__VECTOR3(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_Target_PlayEffect__String__Vector3(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_Target_PlayEffect__String__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_TARGET_PLAY_EFFECT__STRING__VECTOR3(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            /// static  System.Void InvokeUserCode_TargetRpc_PlayEffect__String__Vector3__Vector3(Mirror.NetworkBehaviour obj, Mirror.NetworkReader reader, Mirror.NetworkConnectionToClient senderConnection)
            /// </summary>
            /// <param name = "obj">abstract class Mirror.NetworkBehaviour</param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "senderConnection">class Mirror.NetworkConnectionToClient</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeUserCode_TargetRpc_PlayEffect__String__Vector3__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnectionToClient", 2)]
            public static partial void INVOKE_USER_CODE_TARGET_RPC_PLAY_EFFECT__STRING__VECTOR3__VECTOR3(nint obj, nint reader, nint senderConnection); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void <Start>b__153_1()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("<Start>b__153_1", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void STARTB__153_1(); 
*/
            /// <summary>
            ///   System.Void ActivateSkill(Skill.Skill skill)
            /// </summary>
            /// <param name = "skill">class Skill.Skill</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ActivateSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Skill.Skill", 0)]
            public partial void ACTIVATE_SKILL(nint skill); 
*/
            /// <summary>
            ///   System.Void AddItem(System.String id, System.Int32 count)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD_ITEM(nint id, System.Int32 count); 
*/
            /// <summary>
            ///   System.Void AddSkillData(System.String skillId)
            /// </summary>
            /// <param name = "skillId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddSkillData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void ADD_SKILL_DATA(nint skillId); 
*/
            /// <summary>
            ///   System.Void AddTempTotemData(System.Int32 pos, System.String totemId)
            /// </summary>
            /// <param name = "pos">struct System.Int32</param>
            /// <param name = "totemId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddTempTotemData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void ADD_TEMP_TOTEM_DATA(System.Int32 pos, nint totemId); 
*/
            /// <summary>
            ///   System.Void Awake()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Awake", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void AWAKE(); 
*/
            /// <summary>
            ///   System.Void ChangeWeapon(System.String slotName, System.String weaponId)
            /// </summary>
            /// <param name = "slotName">class System.String</param>
            /// <param name = "weaponId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ChangeWeapon", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void CHANGE_WEAPON(nint slotName, nint weaponId); 
*/
            /// <summary>
            ///   System.Void ClearBuffEffect()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearBuffEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR_BUFF_EFFECT(); 
*/
            /// <summary>
            ///   System.Void ClearWeaponEffect()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearWeaponEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR_WEAPON_EFFECT(); 
*/
            /// <summary>
            ///   System.Void Client_PlayGhostEffect(System.Single time)
            /// </summary>
            /// <param name = "time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Client_PlayGhostEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void CLIENT_PLAY_GHOST_EFFECT(System.Single time); 
*/
            /// <summary>
            ///   System.Void Client_PlaySound(System.String soundPath)
            /// </summary>
            /// <param name = "soundPath">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Client_PlaySound", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CLIENT_PLAY_SOUND(nint soundPath); 
*/
            /// <summary>
            ///   System.Void Client_RemoteChangeWeapon(System.String slotName, System.String weaponId)
            /// </summary>
            /// <param name = "slotName">class System.String</param>
            /// <param name = "weaponId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Client_RemoteChangeWeapon", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void CLIENT_REMOTE_CHANGE_WEAPON(nint slotName, nint weaponId); 
*/
            /// <summary>
            ///   System.Void Client_SetVisible(System.Boolean visible)
            /// </summary>
            /// <param name = "visible">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Client_SetVisible", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void CLIENT_SET_VISIBLE(System.Boolean visible); 
*/
            /// <summary>
            ///   System.Void Client_SetVisualEffectFloatValue(System.String nodeName, System.String paramName, System.Single defaultValue, System.Single targetValue, System.Single time)
            /// </summary>
            /// <param name = "nodeName">class System.String</param>
            /// <param name = "paramName">class System.String</param>
            /// <param name = "defaultValue">struct System.Single</param>
            /// <param name = "targetValue">struct System.Single</param>
            /// <param name = "time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Client_SetVisualEffectFloatValue", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 4)]
            public partial void CLIENT_SET_VISUAL_EFFECT_FLOAT_VALUE(nint nodeName, nint paramName, System.Single defaultValue, System.Single targetValue, System.Single time); 
*/
            /// <summary>
            ///   System.Void ClientRpc_Miss()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_Miss", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLIENT_RPC_MISS(); 
*/
            /// <summary>
            ///   System.Void ClientRpc_PlayAnimation(System.String aniName, System.Boolean toBase, System.Single speedRate, System.Boolean loop, System.Boolean bFight)
            /// </summary>
            /// <param name = "aniName">class System.String</param>
            /// <param name = "toBase">struct System.Boolean</param>
            /// <param name = "speedRate">struct System.Single</param>
            /// <param name = "loop">struct System.Boolean</param>
            /// <param name = "bFight">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_PlayAnimation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            public partial void CLIENT_RPC_PLAY_ANIMATION(nint aniName, System.Boolean toBase, System.Single speedRate, System.Boolean loop, System.Boolean bFight); 
*/
            /// <summary>
            ///   System.Void ClientRpc_PlayBingPointSkillEffect(System.String skillEffectPath, System.String boneName, System.Single playTime)
            /// </summary>
            /// <param name = "skillEffectPath">class System.String</param>
            /// <param name = "boneName">class System.String</param>
            /// <param name = "playTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_PlayBingPointSkillEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void CLIENT_RPC_PLAY_BING_POINT_SKILL_EFFECT(nint skillEffectPath, nint boneName, System.Single playTime); 
*/
            /// <summary>
            ///   System.Void ClientRpc_PlayBuffEffect(System.String buffId, System.String boneName)
            /// </summary>
            /// <param name = "buffId">class System.String</param>
            /// <param name = "boneName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_PlayBuffEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void CLIENT_RPC_PLAY_BUFF_EFFECT(nint buffId, nint boneName); 
*/
            /// <summary>
            ///   System.Void ClientRpc_PlayCameraShake(System.String cameraShakeProfilePath)
            /// </summary>
            /// <param name = "cameraShakeProfilePath">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_PlayCameraShake", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CLIENT_RPC_PLAY_CAMERA_SHAKE(nint cameraShakeProfilePath); 
*/
            /// <summary>
            ///   System.Void ClientRpc_PlayDamageEffect(System.String skillId, System.String hitEffect)
            /// </summary>
            /// <param name = "skillId">class System.String</param>
            /// <param name = "hitEffect">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_PlayDamageEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void CLIENT_RPC_PLAY_DAMAGE_EFFECT(nint skillId, nint hitEffect); 
*/
            /// <summary>
            ///   System.Void ClientRpc_PlayRoomSkillEffect(System.String skillEffectPath, UnityEngine.Vector3 beginPos, UnityEngine.Vector3 endPos, System.Single standingTime)
            /// </summary>
            /// <param name = "skillEffectPath">class System.String</param>
            /// <param name = "beginPos">struct UnityEngine.Vector3</param>
            /// <param name = "endPos">struct UnityEngine.Vector3</param>
            /// <param name = "standingTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_PlayRoomSkillEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public partial void CLIENT_RPC_PLAY_ROOM_SKILL_EFFECT(nint skillEffectPath, UnityEngine.Vector3 beginPos, UnityEngine.Vector3 endPos, System.Single standingTime); 
*/
            /// <summary>
            ///   System.Void ClientRpc_PlaySkillEffect(System.String skillEffectPath, UnityEngine.Vector3 effectPos)
            /// </summary>
            /// <param name = "skillEffectPath">class System.String</param>
            /// <param name = "effectPos">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_PlaySkillEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public partial void CLIENT_RPC_PLAY_SKILL_EFFECT(nint skillEffectPath, UnityEngine.Vector3 effectPos); 
*/
            /// <summary>
            ///   System.Void ClientRpc_RemoveBuffEffect(System.String buffId)
            /// </summary>
            /// <param name = "buffId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_RemoveBuffEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CLIENT_RPC_REMOVE_BUFF_EFFECT(nint buffId); 
*/
            /// <summary>
            ///   System.Void ClientRpc_RemoveSkillEffect(System.String skillEffectPath)
            /// </summary>
            /// <param name = "skillEffectPath">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_RemoveSkillEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CLIENT_RPC_REMOVE_SKILL_EFFECT(nint skillEffectPath); 
*/
            /// <summary>
            ///   System.Void ClientRpc_RestAnimationSpeedRate()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_RestAnimationSpeedRate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLIENT_RPC_REST_ANIMATION_SPEED_RATE(); 
*/
            /// <summary>
            ///   System.Void ClientRpc_SpawnSkillWarning(System.String objAssetPath, System.String bindName, UnityEngine.Vector3 objPosition, System.Single liftTime, System.Int32 pointToTarget, System.Single updateDirTime, UnityEngine.GameObject targetObj, System.Int32 trackingMove, System.Single trackingSpeed, System.Single angle, Game.Script.Character.Skill.Action.E_PlaySpecialEffectsLocation ePlayLocation, UnityEngine.Vector3 lockHorizontalDir)
            /// </summary>
            /// <param name = "objAssetPath">class System.String</param>
            /// <param name = "bindName">class System.String</param>
            /// <param name = "objPosition">struct UnityEngine.Vector3</param>
            /// <param name = "liftTime">struct System.Single</param>
            /// <param name = "pointToTarget">struct System.Int32</param>
            /// <param name = "updateDirTime">struct System.Single</param>
            /// <param name = "targetObj">class UnityEngine.GameObject</param>
            /// <param name = "trackingMove">struct System.Int32</param>
            /// <param name = "trackingSpeed">struct System.Single</param>
            /// <param name = "angle">struct System.Single</param>
            /// <param name = "ePlayLocation">enum Game.Script.Character.Skill.Action.E_PlaySpecialEffectsLocation</param>
            /// <param name = "lockHorizontalDir">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_SpawnSkillWarning", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 8)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 9)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.Skill.Action.E_PlaySpecialEffectsLocation", 10)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 11)]
            public partial void CLIENT_RPC_SPAWN_SKILL_WARNING(nint objAssetPath, nint bindName, UnityEngine.Vector3 objPosition, System.Single liftTime, System.Int32 pointToTarget, System.Single updateDirTime, nint targetObj, System.Int32 trackingMove, System.Single trackingSpeed, System.Single angle, Game.Script.Character.Skill.Action.E_PlaySpecialEffectsLocation ePlayLocation, UnityEngine.Vector3 lockHorizontalDir); 
*/
            /// <summary>
            ///   System.Void ClientRpc_TakeDamaged(System.Single damage, Skill.E_SkillDamageType damageType, System.Boolean isCritical)
            /// </summary>
            /// <param name = "damage">struct System.Single</param>
            /// <param name = "damageType">enum Skill.E_SkillDamageType</param>
            /// <param name = "isCritical">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_TakeDamaged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Skill.E_SkillDamageType", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void CLIENT_RPC_TAKE_DAMAGED(System.Single damage, Skill.E_SkillDamageType damageType, System.Boolean isCritical); 
*/
            /// <summary>
            ///   System.Void ClientRpc_UpdateAttribute(Game.Script.Character.CharacterAttribute characterAttribute, Game.Script.Character.E_AttributeType eAttributeType, System.Single oldHp, System.Single curHp)
            /// </summary>
            /// <param name = "characterAttribute">class Game.Script.Character.CharacterAttribute</param>
            /// <param name = "eAttributeType">enum Game.Script.Character.E_AttributeType</param>
            /// <param name = "oldHp">struct System.Single</param>
            /// <param name = "curHp">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_UpdateAttribute", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.CharacterAttribute", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.E_AttributeType", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public partial void CLIENT_RPC_UPDATE_ATTRIBUTE(nint characterAttribute, Game.Script.Character.E_AttributeType eAttributeType, System.Single oldHp, System.Single curHp); 
*/
            /// <summary>
            ///   System.Void ClientRpc_UpdateBaseAnimation()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClientRpc_UpdateBaseAnimation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLIENT_RPC_UPDATE_BASE_ANIMATION(); 
*/
            /// <summary>
            ///   System.Void Cmd_SetState(Game.Script.Character.CharacterState state)
            /// </summary>
            /// <param name = "state">enum Game.Script.Character.CharacterState</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Cmd_SetState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.CharacterState", 0)]
            public partial void CMD_SET_STATE(Game.Script.Character.CharacterState state); 
*/
            /// <summary>
            ///   System.Void CostLayer()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CostLayer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void COST_LAYER(); 
*/
            /// <summary>
            ///   System.Void CreateHeadInfo()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateHeadInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CREATE_HEAD_INFO(); 
*/
            /// <summary>
            ///   System.Void DeserializeSyncVars(Mirror.NetworkReader reader, System.Boolean initialState)
            /// </summary>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "initialState">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeserializeSyncVars", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void DESERIALIZE_SYNC_VARS(nint reader, System.Boolean initialState); 
*/
            /// <summary>
            ///   Game.Script.Character.CharacterAnimation get_AnimationComponent()
            /// </summary>
            /// <returns>abstract class Game.Script.Character.CharacterAnimation</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AnimationComponent", "Game.Script.Character.CharacterAnimation", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ANIMATION_COMPONENT(); 
*/
            /// <summary>
            ///   UnityEngine.Vector3 get_AniPosition()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AniPosition", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector3 GET_ANI_POSITION(); 
*/
            /// <summary>
            ///   UnityEngine.Quaternion get_AniRotation()
            /// </summary>
            /// <returns>struct UnityEngine.Quaternion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AniRotation", "UnityEngine.Quaternion", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Quaternion GET_ANI_ROTATION(); 
*/
            /// <summary>
            ///   UnityEngine.Vector3 get_AniScale()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AniScale", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector3 GET_ANI_SCALE(); 
*/
            /// <summary>
            ///   Game.Script.Character.CharacterAttribute get_AttributeComponent()
            /// </summary>
            /// <returns>class Game.Script.Character.CharacterAttribute</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_AttributeComponent", "Game.Script.Character.CharacterAttribute", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ATTRIBUTE_COMPONENT(); 
*/
            /// <summary>
            ///   System.String get_BaseAtkSkill()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BaseAtkSkill", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BASE_ATK_SKILL(); 
*/
            /// <summary>
            ///   System.Single get_BornTime()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BornTime", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_BORN_TIME(); 
*/
            /// <summary>
            ///   Mirror.SyncList<Game.Script.Character.Buff.BuffBase> get_Buffs()
            /// </summary>
            /// <returns>class Mirror.SyncList<Game.Script.Character.Buff.BuffBase></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Buffs", "Mirror.SyncList<Game.Script.Character.Buff.BuffBase>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BUFFS(); 
*/
            /// <summary>
            ///   UnityEngine.Vector3 get_BuffScale()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BuffScale", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector3 GET_BUFF_SCALE(); 
*/
            /// <summary>
            ///   Game.Script.Map.Actor.Home.HomeActor get_BuildOwner()
            /// </summary>
            /// <returns>class Game.Script.Map.Actor.Home.HomeActor</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_BuildOwner", "Game.Script.Map.Actor.Home.HomeActor", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_BUILD_OWNER(); 
*/
            /// <summary>
            ///   System.Int32 get_Camp()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Camp", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_CAMP(); 
*/
            /// <summary>
            ///   UnityEngine.Vector3 get_Center()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Center", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector3 GET_CENTER(); 
*/
            /// <summary>
            ///   Game.Script.Character.CharacterMovement get_CharacterMovement()
            /// </summary>
            /// <returns>class Game.Script.Character.CharacterMovement</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CharacterMovement", "Game.Script.Character.CharacterMovement", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CHARACTER_MOVEMENT(); 
*/
            /// <summary>
            ///   Game.Script.Character.ECharacterSkillState get_CharacterSkillState()
            /// </summary>
            /// <returns>enum Game.Script.Character.ECharacterSkillState</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CharacterSkillState", "Game.Script.Character.ECharacterSkillState", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Game.Script.Character.ECharacterSkillState GET_CHARACTER_SKILL_STATE(); 
*/
            /// <summary>
            ///   Game.Script.Character.CharacterState get_CharacterState()
            /// </summary>
            /// <returns>enum Game.Script.Character.CharacterState</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CharacterState", "Game.Script.Character.CharacterState", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Game.Script.Character.CharacterState GET_CHARACTER_STATE(); 
*/
            /// <summary>
            ///   Game.Script.Character.Character get_CreateOwner()
            /// </summary>
            /// <returns>class Game.Script.Character.Character</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CreateOwner", "Game.Script.Character.Character", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CREATE_OWNER(); 
*/
            /// <summary>
            ///   Skill.Skill get_CurUseSkill()
            /// </summary>
            /// <returns>class Skill.Skill</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CurUseSkill", "Skill.Skill", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CUR_USE_SKILL(); 
*/
            /// <summary>
            ///   System.Boolean get_Death()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Death", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_DEATH(); 
*/
            /// <summary>
            ///   Game.Script.Common.UIHeadInfo get_HeadInfo()
            /// </summary>
            /// <returns>class Game.Script.Common.UIHeadInfo</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_HeadInfo", "Game.Script.Common.UIHeadInfo", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_HEAD_INFO(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<System.String , Skill.Skill> get_InstanceSkills()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , Skill.Skill></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_InstanceSkills", "System.Collections.Generic.Dictionary<System.String,Skill.Skill>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_INSTANCE_SKILLS(); 
*/
            /// <summary>
            ///   System.Boolean get_IsAddToSearch()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsAddToSearch", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_ADD_TO_SEARCH(); 
*/
            /// <summary>
            ///   System.Int32 get_IsDiscovery()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsDiscovery", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_IS_DISCOVERY(); 
*/
            /// <summary>
            ///   System.Boolean get_IsHurting()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsHurting", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_HURTING(); 
*/
            /// <summary>
            ///   System.Boolean get_IsLockSkillRelease()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsLockSkillRelease", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_LOCK_SKILL_RELEASE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsNeedBuildSearchTree()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsNeedBuildSearchTree", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_NEED_BUILD_SEARCH_TREE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsSkillLockAction()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsSkillLockAction", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_SKILL_LOCK_ACTION(); 
*/
            /// <summary>
            ///   System.Boolean get_IsSkillLockFace()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsSkillLockFace", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_SKILL_LOCK_FACE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsSkillLockMoveState()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsSkillLockMoveState", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_SKILL_LOCK_MOVE_STATE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsUpdateHideEnvironment()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsUpdateHideEnvironment", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_UPDATE_HIDE_ENVIRONMENT(); 
*/
            /// <summary>
            ///   Mirror.SyncList<Game.Script.User.Item> get_Items()
            /// </summary>
            /// <returns>class Mirror.SyncList<Game.Script.User.Item></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Items", "Mirror.SyncList<Game.Script.User.Item>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ITEMS(); 
*/
            /// <summary>
            ///   System.Boolean get_Network_death()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network_death", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_NETWORK_DEATH(); 
*/
            /// <summary>
            ///   System.Boolean get_Network_isHurting()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network_isHurting", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_NETWORK_IS_HURTING(); 
*/
            /// <summary>
            ///   System.Boolean get_Network_isLockSkillRelease()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network_isLockSkillRelease", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_NETWORK_IS_LOCK_SKILL_RELEASE(); 
*/
            /// <summary>
            ///   System.Boolean get_Network_isSkillLockAction()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network_isSkillLockAction", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_NETWORK_IS_SKILL_LOCK_ACTION(); 
*/
            /// <summary>
            ///   System.Boolean get_Network_isSkillLockFace()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network_isSkillLockFace", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_NETWORK_IS_SKILL_LOCK_FACE(); 
*/
            /// <summary>
            ///   System.Boolean get_Network_isSkillLockMoveState()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network_isSkillLockMoveState", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_NETWORK_IS_SKILL_LOCK_MOVE_STATE(); 
*/
            /// <summary>
            ///   System.String get_Network<BaseAtkSkill>k__BackingField()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network<BaseAtkSkill>k__BackingField", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NETWORK_BASE_ATK_SKILLK__BACKING_FIELD(); 
*/
            /// <summary>
            ///   Game.Script.Character.ECharacterSkillState get_Network<CharacterSkillState>k__BackingField()
            /// </summary>
            /// <returns>enum Game.Script.Character.ECharacterSkillState</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network<CharacterSkillState>k__BackingField", "Game.Script.Character.ECharacterSkillState", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Game.Script.Character.ECharacterSkillState GET_NETWORK_CHARACTER_SKILL_STATEK__BACKING_FIELD(); 
*/
            /// <summary>
            ///   Game.Script.Character.CharacterState get_Network<CharacterState>k__BackingField()
            /// </summary>
            /// <returns>enum Game.Script.Character.CharacterState</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network<CharacterState>k__BackingField", "Game.Script.Character.CharacterState", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Game.Script.Character.CharacterState GET_NETWORK_CHARACTER_STATEK__BACKING_FIELD(); 
*/
            /// <summary>
            ///   Game.Script.Character.Character get_Network<CreateOwner>k__BackingField()
            /// </summary>
            /// <returns>class Game.Script.Character.Character</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network<CreateOwner>k__BackingField", "Game.Script.Character.Character", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NETWORK_CREATE_OWNERK__BACKING_FIELD(); 
*/
            /// <summary>
            ///   Game.Script.Character.FightCharacter get_Network<Owner>k__BackingField()
            /// </summary>
            /// <returns>class Game.Script.Character.FightCharacter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network<Owner>k__BackingField", "Game.Script.Character.FightCharacter", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NETWORK_OWNERK__BACKING_FIELD(); 
*/
            /// <summary>
            ///   Game.Script.Character.FightCharacter get_Owner()
            /// </summary>
            /// <returns>class Game.Script.Character.FightCharacter</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Owner", "Game.Script.Character.FightCharacter", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_OWNER(); 
*/
            /// <summary>
            ///   System.Boolean get_ShowDamage()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ShowDamage", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_SHOW_DAMAGE(); 
*/
            /// <summary>
            ///   Mirror.SyncDictionary<System.String , System.Single> get_SkillCds()
            /// </summary>
            /// <returns>class Mirror.SyncDictionary<System.String , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SkillCds", "Mirror.SyncDictionary<System.String,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKILL_CDS(); 
*/
            /// <summary>
            ///   Mirror.SyncDictionary<System.String , System.Int32> get_SkillLayers()
            /// </summary>
            /// <returns>class Mirror.SyncDictionary<System.String , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SkillLayers", "Mirror.SyncDictionary<System.String,System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKILL_LAYERS(); 
*/
            /// <summary>
            ///   Mirror.SyncList<System.String> get_Skills()
            /// </summary>
            /// <returns>class Mirror.SyncList<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Skills", "Mirror.SyncList<System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKILLS(); 
*/
            /// <summary>
            ///   Mirror.SyncDictionary<System.Int32 , System.String> get_TotemItems()
            /// </summary>
            /// <returns>class Mirror.SyncDictionary<System.Int32 , System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_TotemItems", "Mirror.SyncDictionary<System.Int32,System.String>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TOTEM_ITEMS(); 
*/
            /// <summary>
            ///   System.Single GetAttributeValue(Game.Script.Character.E_AttributeType attributeType)
            /// </summary>
            /// <param name = "attributeType">enum Game.Script.Character.E_AttributeType</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetAttributeValue", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.E_AttributeType", 0)]
            public partial System.Single GET_ATTRIBUTE_VALUE(Game.Script.Character.E_AttributeType attributeType); 
*/
            /// <summary>
            ///   UnityEngine.Vector3 GetChainAnchor()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetChainAnchor", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector3 GET_CHAIN_ANCHOR(); 
*/
            /// <summary>
            ///   System.Int32 GetItemNum(System.String id)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetItemNum", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Int32 GET_ITEM_NUM(nint id); 
*/
            /// <summary>
            ///   Skill.Skill GetSkillBySkillID(System.String skillId)
            /// </summary>
            /// <param name = "skillId">class System.String</param>
            /// <returns>class Skill.Skill</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkillBySkillID", "Skill.Skill", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint GET_SKILL_BY_SKILL_ID(nint skillId); 
*/
            /// <summary>
            ///   System.Void HandleBeatBackEffect(Game.Script.Common.DamageInfo damageInfo)
            /// </summary>
            /// <param name = "damageInfo">class Game.Script.Common.DamageInfo</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HandleBeatBackEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.DamageInfo", 0)]
            public partial void HANDLE_BEAT_BACK_EFFECT(nint damageInfo); 
*/
            /// <summary>
            ///   System.Void HandleBuffExtraDamage(Game.Script.Common.DamageInfo damageInfo)
            /// </summary>
            /// <param name = "damageInfo">class Game.Script.Common.DamageInfo</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HandleBuffExtraDamage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.DamageInfo", 0)]
            public partial void HANDLE_BUFF_EXTRA_DAMAGE(nint damageInfo); 
*/
            /// <summary>
            ///   System.Void HandleShieldDamage(Game.Script.Common.DamageInfo info)
            /// </summary>
            /// <param name = "info">class Game.Script.Common.DamageInfo</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HandleShieldDamage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.DamageInfo", 0)]
            public partial void HANDLE_SHIELD_DAMAGE(nint info); 
*/
            /// <summary>
            ///   System.Void InitTotemBag()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitTotemBag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_TOTEM_BAG(); 
*/
            /// <summary>
            ///   System.Void Internal_SetVisible(System.Boolean visible)
            /// </summary>
            /// <param name = "visible">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_SetVisible", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void INTERNAL_SET_VISIBLE(System.Boolean visible); 
*/
            /// <summary>
            ///   System.Boolean IsChainAlive()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsChainAlive", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_CHAIN_ALIVE(); 
*/
            /// <summary>
            ///   System.Boolean IsMaxLayers(System.String skillId)
            /// </summary>
            /// <param name = "skillId">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsMaxLayers", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean IS_MAX_LAYERS(nint skillId); 
*/
            /// <summary>
            ///   System.Void ModifyDmgCollider(System.Boolean active)
            /// </summary>
            /// <param name = "active">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ModifyDmgCollider", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void MODIFY_DMG_COLLIDER(System.Boolean active); 
*/
            /// <summary>
            ///   System.Void OnCharacterHpChanged(System.Single oldHp, System.Single newHp)
            /// </summary>
            /// <param name = "oldHp">struct System.Single</param>
            /// <param name = "newHp">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnCharacterHpChanged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void ON_CHARACTER_HP_CHANGED(System.Single oldHp, System.Single newHp); 
*/
            /// <summary>
            ///   System.Void OnCharacterShieldChanged(System.Single old, System.Single new)
            /// </summary>
            /// <param name = "old">struct System.Single</param>
            /// <param name = "new">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnCharacterShieldChanged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void ON_CHARACTER_SHIELD_CHANGED(System.Single old, System.Single new); 
*/
            /// <summary>
            ///   System.Void OnDead(System.Boolean oldValue, System.Boolean newValue)
            /// </summary>
            /// <param name = "oldValue">struct System.Boolean</param>
            /// <param name = "newValue">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDead", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ON_DEAD(System.Boolean oldValue, System.Boolean newValue); 
*/
            /// <summary>
            ///   System.Void OnDestroy()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDestroy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_DESTROY(); 
*/
            /// <summary>
            ///   System.Void OnSkillStateChange(Game.Script.Character.ECharacterSkillState oldValue, Game.Script.Character.ECharacterSkillState newValue)
            /// </summary>
            /// <param name = "oldValue">enum Game.Script.Character.ECharacterSkillState</param>
            /// <param name = "newValue">enum Game.Script.Character.ECharacterSkillState</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnSkillStateChange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.ECharacterSkillState", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.ECharacterSkillState", 1)]
            public partial void ON_SKILL_STATE_CHANGE(Game.Script.Character.ECharacterSkillState oldValue, Game.Script.Character.ECharacterSkillState newValue); 
*/
            /// <summary>
            ///   System.Void OnSkillStatusCleaning()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnSkillStatusCleaning", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_SKILL_STATUS_CLEANING(); 
*/
            /// <summary>
            ///   System.Void OnStartClient()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStartClient", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_START_CLIENT(); 
*/
            /// <summary>
            ///   System.Void OnStateChange(Game.Script.Character.CharacterState _, Game.Script.Character.CharacterState newValue)
            /// </summary>
            /// <param name = "_">enum Game.Script.Character.CharacterState</param>
            /// <param name = "newValue">enum Game.Script.Character.CharacterState</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStateChange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.CharacterState", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.CharacterState", 1)]
            public partial void ON_STATE_CHANGE(Game.Script.Character.CharacterState _, Game.Script.Character.CharacterState newValue); 
*/
            /// <summary>
            ///   System.Void PlayDamageEffect(System.String hitEffect)
            /// </summary>
            /// <param name = "hitEffect">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PlayDamageEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void PLAY_DAMAGE_EFFECT(nint hitEffect); 
*/
            /// <summary>
            ///   System.Void PlayFlashWhite(System.Single delayTime)
            /// </summary>
            /// <param name = "delayTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PlayFlashWhite", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void PLAY_FLASH_WHITE(System.Single delayTime); 
*/
            /// <summary>
            ///   System.String PopItem()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("PopItem", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint POP_ITEM(); 
*/
            /// <summary>
            ///   System.Void ReduceAllSkillCoolTime(System.Single reduceTime)
            /// </summary>
            /// <param name = "reduceTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReduceAllSkillCoolTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void REDUCE_ALL_SKILL_COOL_TIME(System.Single reduceTime); 
*/
            /// <summary>
            ///   System.Void ReduceSkillCoolTime(System.String skillId, System.Single reduceTime)
            /// </summary>
            /// <param name = "skillId">class System.String</param>
            /// <param name = "reduceTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ReduceSkillCoolTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void REDUCE_SKILL_COOL_TIME(nint skillId, System.Single reduceTime); 
*/
            /// <summary>
            ///   System.Void RemoveItem(System.String id, System.Int32 count)
            /// </summary>
            /// <param name = "id">class System.String</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveItem", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void REMOVE_ITEM(nint id, System.Int32 count); 
*/
            /// <summary>
            ///   System.Void RemoveRelicById(System.String relicsId)
            /// </summary>
            /// <param name = "relicsId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveRelicById", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void REMOVE_RELIC_BY_ID(nint relicsId); 
*/
            /// <summary>
            ///   System.Void RemoveSkillData(System.String skillId)
            /// </summary>
            /// <param name = "skillId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveSkillData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void REMOVE_SKILL_DATA(nint skillId); 
*/
            /// <summary>
            ///   System.Void ResetBossSkillData(MonsterConfig monsterConfig)
            /// </summary>
            /// <param name = "monsterConfig">class MonsterConfig</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetBossSkillData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("MonsterConfig", 0)]
            public partial void RESET_BOSS_SKILL_DATA(nint monsterConfig); 
*/
            /// <summary>
            ///   System.Void ResetSkillData()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetSkillData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET_SKILL_DATA(); 
*/
            /// <summary>
            ///   System.Void SerializeSyncVars(Mirror.NetworkWriter writer, System.Boolean forceAll)
            /// </summary>
            /// <param name = "writer">class Mirror.NetworkWriter</param>
            /// <param name = "forceAll">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeSyncVars", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkWriter", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SERIALIZE_SYNC_VARS(nint writer, System.Boolean forceAll); 
*/
            /// <summary>
            ///   System.Void set_AnimationComponent(Game.Script.Character.CharacterAnimation value)
            /// </summary>
            /// <param name = "value">abstract class Game.Script.Character.CharacterAnimation</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AnimationComponent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.CharacterAnimation", 0)]
            public partial void SET_ANIMATION_COMPONENT(nint value); 
*/
            /// <summary>
            ///   System.Void set_AniPosition(UnityEngine.Vector3 value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AniPosition", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public partial void SET_ANI_POSITION(UnityEngine.Vector3 value); 
*/
            /// <summary>
            ///   System.Void set_AniRotation(UnityEngine.Quaternion value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Quaternion</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AniRotation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 0)]
            public partial void SET_ANI_ROTATION(UnityEngine.Quaternion value); 
*/
            /// <summary>
            ///   System.Void set_AniScale(UnityEngine.Vector3 value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AniScale", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public partial void SET_ANI_SCALE(UnityEngine.Vector3 value); 
*/
            /// <summary>
            ///   System.Void set_AttributeComponent(Game.Script.Character.CharacterAttribute value)
            /// </summary>
            /// <param name = "value">class Game.Script.Character.CharacterAttribute</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_AttributeComponent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.CharacterAttribute", 0)]
            public partial void SET_ATTRIBUTE_COMPONENT(nint value); 
*/
            /// <summary>
            ///   System.Void set_BaseAtkSkill(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BaseAtkSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_BASE_ATK_SKILL(nint value); 
*/
            /// <summary>
            ///   System.Void set_BornTime(System.Single value)
            /// </summary>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BornTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void SET_BORN_TIME(System.Single value); 
*/
            /// <summary>
            ///   System.Void set_BuildOwner(Game.Script.Map.Actor.Home.HomeActor value)
            /// </summary>
            /// <param name = "value">class Game.Script.Map.Actor.Home.HomeActor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_BuildOwner", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.Actor.Home.HomeActor", 0)]
            public partial void SET_BUILD_OWNER(nint value); 
*/
            /// <summary>
            ///   System.Void set_Camp(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Camp", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_CAMP(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_CharacterMovement(Game.Script.Character.CharacterMovement value)
            /// </summary>
            /// <param name = "value">class Game.Script.Character.CharacterMovement</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CharacterMovement", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.CharacterMovement", 0)]
            public partial void SET_CHARACTER_MOVEMENT(nint value); 
*/
            /// <summary>
            ///   System.Void set_CharacterSkillState(Game.Script.Character.ECharacterSkillState value)
            /// </summary>
            /// <param name = "value">enum Game.Script.Character.ECharacterSkillState</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CharacterSkillState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.ECharacterSkillState", 0)]
            public partial void SET_CHARACTER_SKILL_STATE(Game.Script.Character.ECharacterSkillState value); 
*/
            /// <summary>
            ///   System.Void set_CharacterState(Game.Script.Character.CharacterState value)
            /// </summary>
            /// <param name = "value">enum Game.Script.Character.CharacterState</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CharacterState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.CharacterState", 0)]
            public partial void SET_CHARACTER_STATE(Game.Script.Character.CharacterState value); 
*/
            /// <summary>
            ///   System.Void set_CreateOwner(Game.Script.Character.Character value)
            /// </summary>
            /// <param name = "value">class Game.Script.Character.Character</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CreateOwner", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.Character", 0)]
            public partial void SET_CREATE_OWNER(nint value); 
*/
            /// <summary>
            ///   System.Void set_CurUseSkill(Skill.Skill value)
            /// </summary>
            /// <param name = "value">class Skill.Skill</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CurUseSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Skill.Skill", 0)]
            public partial void SET_CUR_USE_SKILL(nint value); 
*/
            /// <summary>
            ///   System.Void set_Death(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Death", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_DEATH(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_HeadInfo(Game.Script.Common.UIHeadInfo value)
            /// </summary>
            /// <param name = "value">class Game.Script.Common.UIHeadInfo</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_HeadInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.UIHeadInfo", 0)]
            public partial void SET_HEAD_INFO(nint value); 
*/
            /// <summary>
            ///   System.Void set_IsDiscovery(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsDiscovery", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_IS_DISCOVERY(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_IsHurting(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsHurting", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_HURTING(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_IsLockSkillRelease(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsLockSkillRelease", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_LOCK_SKILL_RELEASE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_IsSkillLockAction(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsSkillLockAction", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_SKILL_LOCK_ACTION(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_IsSkillLockFace(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsSkillLockFace", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_SKILL_LOCK_FACE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_IsSkillLockMoveState(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsSkillLockMoveState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_SKILL_LOCK_MOVE_STATE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Network_death(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network_death", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_NETWORK_DEATH(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Network_isHurting(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network_isHurting", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_NETWORK_IS_HURTING(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Network_isLockSkillRelease(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network_isLockSkillRelease", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_NETWORK_IS_LOCK_SKILL_RELEASE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Network_isSkillLockAction(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network_isSkillLockAction", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_NETWORK_IS_SKILL_LOCK_ACTION(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Network_isSkillLockFace(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network_isSkillLockFace", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_NETWORK_IS_SKILL_LOCK_FACE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Network_isSkillLockMoveState(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network_isSkillLockMoveState", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_NETWORK_IS_SKILL_LOCK_MOVE_STATE(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_Network<BaseAtkSkill>k__BackingField(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network<BaseAtkSkill>k__BackingField", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_NETWORK_BASE_ATK_SKILLK__BACKING_FIELD(nint value); 
*/
            /// <summary>
            ///   System.Void set_Network<CharacterSkillState>k__BackingField(Game.Script.Character.ECharacterSkillState value)
            /// </summary>
            /// <param name = "value">enum Game.Script.Character.ECharacterSkillState</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network<CharacterSkillState>k__BackingField", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.ECharacterSkillState", 0)]
            public partial void SET_NETWORK_CHARACTER_SKILL_STATEK__BACKING_FIELD(Game.Script.Character.ECharacterSkillState value); 
*/
            /// <summary>
            ///   System.Void set_Network<CharacterState>k__BackingField(Game.Script.Character.CharacterState value)
            /// </summary>
            /// <param name = "value">enum Game.Script.Character.CharacterState</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network<CharacterState>k__BackingField", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.CharacterState", 0)]
            public partial void SET_NETWORK_CHARACTER_STATEK__BACKING_FIELD(Game.Script.Character.CharacterState value); 
*/
            /// <summary>
            ///   System.Void set_Network<CreateOwner>k__BackingField(Game.Script.Character.Character value)
            /// </summary>
            /// <param name = "value">class Game.Script.Character.Character</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network<CreateOwner>k__BackingField", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.Character", 0)]
            public partial void SET_NETWORK_CREATE_OWNERK__BACKING_FIELD(nint value); 
*/
            /// <summary>
            ///   System.Void set_Network<Owner>k__BackingField(Game.Script.Character.FightCharacter value)
            /// </summary>
            /// <param name = "value">class Game.Script.Character.FightCharacter</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network<Owner>k__BackingField", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.FightCharacter", 0)]
            public partial void SET_NETWORK_OWNERK__BACKING_FIELD(nint value); 
*/
            /// <summary>
            ///   System.Void set_Owner(Game.Script.Character.FightCharacter value)
            /// </summary>
            /// <param name = "value">class Game.Script.Character.FightCharacter</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Owner", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.FightCharacter", 0)]
            public partial void SET_OWNER(nint value); 
*/
            /// <summary>
            ///   Cysharp.Threading.Tasks.UniTaskVoid SetVisualEffectFloatValue(System.String nodeName, System.String paramName, System.Single defaultValue, System.Single targetValue, System.Single time)
            /// </summary>
            /// <param name = "nodeName">class System.String</param>
            /// <param name = "paramName">class System.String</param>
            /// <param name = "defaultValue">struct System.Single</param>
            /// <param name = "targetValue">struct System.Single</param>
            /// <param name = "time">struct System.Single</param>
            /// <returns>struct Cysharp.Threading.Tasks.UniTaskVoid</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetVisualEffectFloatValue", "Cysharp.Threading.Tasks.UniTaskVoid", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 4)]
            public partial Cysharp.Threading.Tasks.UniTaskVoid SET_VISUAL_EFFECT_FLOAT_VALUE(nint nodeName, nint paramName, System.Single defaultValue, System.Single targetValue, System.Single time); 
*/
            /// <summary>
            ///   System.Void SkillCdsChanges(Mirror.SyncIDictionary.Operation<System.String , System.Single> op, System.String key, System.Single item)
            /// </summary>
            /// <param name = "op">enum Mirror.SyncIDictionary.Operation<System.String , System.Single></param>
            /// <param name = "key">class System.String</param>
            /// <param name = "item">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SkillCdsChanges", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.SyncIDictionary.Operation<System.String,System.Single>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void SKILL_CDS_CHANGES(Mirror.SyncIDictionary.Operation<System.String, System.Single> op, nint key, System.Single item); 
*/
            /// <summary>
            ///   System.Void Start()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Start", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void START(); 
*/
            /// <summary>
            ///   System.Void StopSkill()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void STOP_SKILL(); 
*/
            /// <summary>
            ///   System.Void TakeDamage(Game.Script.Common.Actor srcActor, Game.Script.Common.DamageInfo info)
            /// </summary>
            /// <param name = "srcActor">class Game.Script.Common.Actor</param>
            /// <param name = "info">class Game.Script.Common.DamageInfo</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TakeDamage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.Actor", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.DamageInfo", 1)]
            public partial void TAKE_DAMAGE(nint srcActor, nint info); 
*/
            /// <summary>
            ///   System.Void Target_PlayAudio(System.String path, UnityEngine.Vector3 pos)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Target_PlayAudio", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public partial void TARGET_PLAY_AUDIO(nint path, UnityEngine.Vector3 pos); 
*/
            /// <summary>
            ///   System.Void Target_PlayEffect(System.String path, UnityEngine.Vector3 pos)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Target_PlayEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public partial void TARGET_PLAY_EFFECT(nint path, UnityEngine.Vector3 pos); 
*/
            /// <summary>
            ///   System.Void TargetRpc_PlayEffect(System.String skillEffectPath, UnityEngine.Vector3 pos, UnityEngine.Vector3 scale)
            /// </summary>
            /// <param name = "skillEffectPath">class System.String</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <param name = "scale">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TargetRpc_PlayEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            public partial void TARGET_RPC_PLAY_EFFECT(nint skillEffectPath, UnityEngine.Vector3 pos, UnityEngine.Vector3 scale); 
*/
            /// <summary>
            ///   System.Void UpdateAniTransformInfo(UnityEngine.Jobs.TransformAccess access)
            /// </summary>
            /// <param name = "access">struct UnityEngine.Jobs.TransformAccess</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateAniTransformInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Jobs.TransformAccess", 0)]
            public partial void UPDATE_ANI_TRANSFORM_INFO(UnityEngine.Jobs.TransformAccess access); 
*/
            /// <summary>
            ///   System.Void UpdateAttributeValue(Game.Script.Character.E_AttributeType attributeType, Game.Script.Character.E_OperateType type, System.Single value)
            /// </summary>
            /// <param name = "attributeType">enum Game.Script.Character.E_AttributeType</param>
            /// <param name = "type">enum Game.Script.Character.E_OperateType</param>
            /// <param name = "value">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateAttributeValue", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.E_AttributeType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.E_OperateType", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void UPDATE_ATTRIBUTE_VALUE(Game.Script.Character.E_AttributeType attributeType, Game.Script.Character.E_OperateType type, System.Single value); 
*/
            /// <summary>
            ///   System.Void UpdateHideEffect()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateHideEffect", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_HIDE_EFFECT(); 
*/
            /// <summary>
            ///   System.Void UpdateIsUseSkill()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateIsUseSkill", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_IS_USE_SKILL(); 
*/
            /// <summary>
            ///   System.Void UserCode_Client_PlayGhostEffect__Single(System.Single time)
            /// </summary>
            /// <param name = "time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Client_PlayGhostEffect__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            public partial void USER_CODE_CLIENT_PLAY_GHOST_EFFECT__SINGLE(System.Single time); 
*/
            /// <summary>
            ///   System.Void UserCode_Client_PlaySound__String(System.String soundPath)
            /// </summary>
            /// <param name = "soundPath">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Client_PlaySound__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void USER_CODE_CLIENT_PLAY_SOUND__STRING(nint soundPath); 
*/
            /// <summary>
            ///   System.Void UserCode_Client_RemoteChangeWeapon__String__String(System.String slotName, System.String weaponId)
            /// </summary>
            /// <param name = "slotName">class System.String</param>
            /// <param name = "weaponId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Client_RemoteChangeWeapon__String__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void USER_CODE_CLIENT_REMOTE_CHANGE_WEAPON__STRING__STRING(nint slotName, nint weaponId); 
*/
            /// <summary>
            ///   System.Void UserCode_Client_SetVisible__Boolean(System.Boolean visible)
            /// </summary>
            /// <param name = "visible">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Client_SetVisible__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void USER_CODE_CLIENT_SET_VISIBLE__BOOLEAN(System.Boolean visible); 
*/
            /// <summary>
            ///   System.Void UserCode_Client_SetVisualEffectFloatValue__String__String__Single__Single__Single(System.String nodeName, System.String paramName, System.Single defaultValue, System.Single targetValue, System.Single time)
            /// </summary>
            /// <param name = "nodeName">class System.String</param>
            /// <param name = "paramName">class System.String</param>
            /// <param name = "defaultValue">struct System.Single</param>
            /// <param name = "targetValue">struct System.Single</param>
            /// <param name = "time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Client_SetVisualEffectFloatValue__String__String__Single__Single__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 4)]
            public partial void USER_CODE_CLIENT_SET_VISUAL_EFFECT_FLOAT_VALUE__STRING__STRING__SINGLE__SINGLE__SINGLE(nint nodeName, nint paramName, System.Single defaultValue, System.Single targetValue, System.Single time); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_Miss()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_Miss", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void USER_CODE_CLIENT_RPC_MISS(); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_PlayAnimation__String__Boolean__Single__Boolean__Boolean(System.String aniName, System.Boolean toBase, System.Single speedRate, System.Boolean loop, System.Boolean bFight)
            /// </summary>
            /// <param name = "aniName">class System.String</param>
            /// <param name = "toBase">struct System.Boolean</param>
            /// <param name = "speedRate">struct System.Single</param>
            /// <param name = "loop">struct System.Boolean</param>
            /// <param name = "bFight">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_PlayAnimation__String__Boolean__Single__Boolean__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            public partial void USER_CODE_CLIENT_RPC_PLAY_ANIMATION__STRING__BOOLEAN__SINGLE__BOOLEAN__BOOLEAN(nint aniName, System.Boolean toBase, System.Single speedRate, System.Boolean loop, System.Boolean bFight); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_PlayBingPointSkillEffect__String__String__Single(System.String skillEffectPath, System.String boneName, System.Single playTime)
            /// </summary>
            /// <param name = "skillEffectPath">class System.String</param>
            /// <param name = "boneName">class System.String</param>
            /// <param name = "playTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_PlayBingPointSkillEffect__String__String__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void USER_CODE_CLIENT_RPC_PLAY_BING_POINT_SKILL_EFFECT__STRING__STRING__SINGLE(nint skillEffectPath, nint boneName, System.Single playTime); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_PlayBuffEffect__String__String(System.String buffId, System.String boneName)
            /// </summary>
            /// <param name = "buffId">class System.String</param>
            /// <param name = "boneName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_PlayBuffEffect__String__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void USER_CODE_CLIENT_RPC_PLAY_BUFF_EFFECT__STRING__STRING(nint buffId, nint boneName); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_PlayCameraShake__String(System.String cameraShakeProfilePath)
            /// </summary>
            /// <param name = "cameraShakeProfilePath">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_PlayCameraShake__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void USER_CODE_CLIENT_RPC_PLAY_CAMERA_SHAKE__STRING(nint cameraShakeProfilePath); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_PlayDamageEffect__String__String(System.String skillId, System.String hitEffect)
            /// </summary>
            /// <param name = "skillId">class System.String</param>
            /// <param name = "hitEffect">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_PlayDamageEffect__String__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void USER_CODE_CLIENT_RPC_PLAY_DAMAGE_EFFECT__STRING__STRING(nint skillId, nint hitEffect); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_PlayRoomSkillEffect__String__Vector3__Vector3__Single(System.String skillEffectPath, UnityEngine.Vector3 beginPos, UnityEngine.Vector3 endPos, System.Single standingTime)
            /// </summary>
            /// <param name = "skillEffectPath">class System.String</param>
            /// <param name = "beginPos">struct UnityEngine.Vector3</param>
            /// <param name = "endPos">struct UnityEngine.Vector3</param>
            /// <param name = "standingTime">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_PlayRoomSkillEffect__String__Vector3__Vector3__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public partial void USER_CODE_CLIENT_RPC_PLAY_ROOM_SKILL_EFFECT__STRING__VECTOR3__VECTOR3__SINGLE(nint skillEffectPath, UnityEngine.Vector3 beginPos, UnityEngine.Vector3 endPos, System.Single standingTime); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_PlaySkillEffect__String__Vector3(System.String skillEffectPath, UnityEngine.Vector3 effectPos)
            /// </summary>
            /// <param name = "skillEffectPath">class System.String</param>
            /// <param name = "effectPos">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_PlaySkillEffect__String__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public partial void USER_CODE_CLIENT_RPC_PLAY_SKILL_EFFECT__STRING__VECTOR3(nint skillEffectPath, UnityEngine.Vector3 effectPos); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_RemoveBuffEffect__String(System.String buffId)
            /// </summary>
            /// <param name = "buffId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_RemoveBuffEffect__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void USER_CODE_CLIENT_RPC_REMOVE_BUFF_EFFECT__STRING(nint buffId); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_RemoveSkillEffect__String(System.String skillEffectPath)
            /// </summary>
            /// <param name = "skillEffectPath">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_RemoveSkillEffect__String", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void USER_CODE_CLIENT_RPC_REMOVE_SKILL_EFFECT__STRING(nint skillEffectPath); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_RestAnimationSpeedRate()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_RestAnimationSpeedRate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void USER_CODE_CLIENT_RPC_REST_ANIMATION_SPEED_RATE(); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_SpawnSkillWarning__String__String__Vector3__Single__Int32__Single__GameObject__Int32__Single__Single__E_PlaySpecialEffectsLocation__Vector3(System.String objAssetPath, System.String bindName, UnityEngine.Vector3 objPosition, System.Single liftTime, System.Int32 pointToTarget, System.Single updateDirTime, UnityEngine.GameObject targetObj, System.Int32 trackingMove, System.Single trackingSpeed, System.Single angle, Game.Script.Character.Skill.Action.E_PlaySpecialEffectsLocation ePlayLocation, UnityEngine.Vector3 lockHorizontalDir)
            /// </summary>
            /// <param name = "objAssetPath">class System.String</param>
            /// <param name = "bindName">class System.String</param>
            /// <param name = "objPosition">struct UnityEngine.Vector3</param>
            /// <param name = "liftTime">struct System.Single</param>
            /// <param name = "pointToTarget">struct System.Int32</param>
            /// <param name = "updateDirTime">struct System.Single</param>
            /// <param name = "targetObj">class UnityEngine.GameObject</param>
            /// <param name = "trackingMove">struct System.Int32</param>
            /// <param name = "trackingSpeed">struct System.Single</param>
            /// <param name = "angle">struct System.Single</param>
            /// <param name = "ePlayLocation">enum Game.Script.Character.Skill.Action.E_PlaySpecialEffectsLocation</param>
            /// <param name = "lockHorizontalDir">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_SpawnSkillWarning__String__String__Vector3__Single__Int32__Single__GameObject__Int32__Single__Single__E_PlaySpecialEffectsLocation__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 7)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 8)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 9)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.Skill.Action.E_PlaySpecialEffectsLocation", 10)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 11)]
            public partial void USER_CODE_CLIENT_RPC_SPAWN_SKILL_WARNING__STRING__STRING__VECTOR3__SINGLE__INT32__SINGLE__GAME_OBJECT__INT32__SINGLE__SINGLE__E_PLAY_SPECIAL_EFFECTS_LOCATION__VECTOR3(nint objAssetPath, nint bindName, UnityEngine.Vector3 objPosition, System.Single liftTime, System.Int32 pointToTarget, System.Single updateDirTime, nint targetObj, System.Int32 trackingMove, System.Single trackingSpeed, System.Single angle, Game.Script.Character.Skill.Action.E_PlaySpecialEffectsLocation ePlayLocation, UnityEngine.Vector3 lockHorizontalDir); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_TakeDamaged__Single__E_SkillDamageType__Boolean(System.Single damage, Skill.E_SkillDamageType damageType, System.Boolean isCritical)
            /// </summary>
            /// <param name = "damage">struct System.Single</param>
            /// <param name = "damageType">enum Skill.E_SkillDamageType</param>
            /// <param name = "isCritical">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_TakeDamaged__Single__E_SkillDamageType__Boolean", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Skill.E_SkillDamageType", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public partial void USER_CODE_CLIENT_RPC_TAKE_DAMAGED__SINGLE__E_SKILL_DAMAGE_TYPE__BOOLEAN(System.Single damage, Skill.E_SkillDamageType damageType, System.Boolean isCritical); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_UpdateAttribute__CharacterAttribute__E_AttributeType__Single__Single(Game.Script.Character.CharacterAttribute characterAttribute, Game.Script.Character.E_AttributeType eAttributeType, System.Single oldHp, System.Single curHp)
            /// </summary>
            /// <param name = "characterAttribute">class Game.Script.Character.CharacterAttribute</param>
            /// <param name = "eAttributeType">enum Game.Script.Character.E_AttributeType</param>
            /// <param name = "oldHp">struct System.Single</param>
            /// <param name = "curHp">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_UpdateAttribute__CharacterAttribute__E_AttributeType__Single__Single", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.CharacterAttribute", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.E_AttributeType", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public partial void USER_CODE_CLIENT_RPC_UPDATE_ATTRIBUTE__CHARACTER_ATTRIBUTE__E_ATTRIBUTE_TYPE__SINGLE__SINGLE(nint characterAttribute, Game.Script.Character.E_AttributeType eAttributeType, System.Single oldHp, System.Single curHp); 
*/
            /// <summary>
            ///   System.Void UserCode_ClientRpc_UpdateBaseAnimation()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_ClientRpc_UpdateBaseAnimation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void USER_CODE_CLIENT_RPC_UPDATE_BASE_ANIMATION(); 
*/
            /// <summary>
            ///   System.Void UserCode_Target_PlayAudio__String__Vector3(System.String path, UnityEngine.Vector3 pos)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Target_PlayAudio__String__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public partial void USER_CODE_TARGET_PLAY_AUDIO__STRING__VECTOR3(nint path, UnityEngine.Vector3 pos); 
*/
            /// <summary>
            ///   System.Void UserCode_Target_PlayEffect__String__Vector3(System.String path, UnityEngine.Vector3 pos)
            /// </summary>
            /// <param name = "path">class System.String</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_Target_PlayEffect__String__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            public partial void USER_CODE_TARGET_PLAY_EFFECT__STRING__VECTOR3(nint path, UnityEngine.Vector3 pos); 
*/
            /// <summary>
            ///   System.Void UserCode_TargetRpc_PlayEffect__String__Vector3__Vector3(System.String skillEffectPath, UnityEngine.Vector3 pos, UnityEngine.Vector3 scale)
            /// </summary>
            /// <param name = "skillEffectPath">class System.String</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <param name = "scale">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UserCode_TargetRpc_PlayEffect__String__Vector3__Vector3", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            public partial void USER_CODE_TARGET_RPC_PLAY_EFFECT__STRING__VECTOR3__VECTOR3(nint skillEffectPath, UnityEngine.Vector3 pos, UnityEngine.Vector3 scale); 
*/
            /// <summary>
            ///   System.Boolean Weaved()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Weaved", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean WEAVED(); 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Common"."Actor"]
        /// </summary>
        partial struct Ptr_FightCharacter
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void Awake()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Awake", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void AWAKE(); 
*/
            /// <summary>
            ///   System.Void DeserializeSyncVars(Mirror.NetworkReader reader, System.Boolean initialState)
            /// </summary>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "initialState">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeserializeSyncVars", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void DESERIALIZE_SYNC_VARS(nint reader, System.Boolean initialState); 
*/
            /// <summary>
            ///   System.Void Enter()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Enter", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ENTER(); 
*/
            /// <summary>
            ///   System.Boolean get_bIsDestroyed()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_bIsDestroyed", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_B_IS_DESTROYED(); 
*/
            /// <summary>
            ///   UnityEngine.Transform get_CacheTransform()
            /// </summary>
            /// <returns>class UnityEngine.Transform</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CacheTransform", "UnityEngine.Transform", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CACHE_TRANSFORM(); 
*/
            /// <summary>
            ///   System.Boolean get_CanEnter()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_CanEnter", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_CAN_ENTER(); 
*/
            /// <summary>
            ///   UnityEngine.Vector3 get_Center()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Center", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector3 GET_CENTER(); 
*/
            /// <summary>
            ///   System.Boolean get_DrawLand()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_DrawLand", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_DRAW_LAND(); 
*/
            /// <summary>
            ///   SearchFilterType get_FilterType()
            /// </summary>
            /// <returns>enum SearchFilterType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_FilterType", "SearchFilterType", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial SearchFilterType GET_FILTER_TYPE(); 
*/
            /// <summary>
            ///   System.String get_Id()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Id", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_ID(); 
*/
            /// <summary>
            ///   System.Boolean get_IsActorVisible()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsActorVisible", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_ACTOR_VISIBLE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsAddToSearch()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsAddToSearch", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_ADD_TO_SEARCH(); 
*/
            /// <summary>
            ///   System.Boolean get_IsBlock()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsBlock", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_BLOCK(); 
*/
            /// <summary>
            ///   System.Boolean get_IsNeedBuildSearchTree()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsNeedBuildSearchTree", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_NEED_BUILD_SEARCH_TREE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsSetData()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsSetData", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_SET_DATA(); 
*/
            /// <summary>
            ///   System.Boolean get_IsUpdateGrid()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsUpdateGrid", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_UPDATE_GRID(); 
*/
            /// <summary>
            ///   System.Boolean get_IsUpdateHideEnvironment()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsUpdateHideEnvironment", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_UPDATE_HIDE_ENVIRONMENT(); 
*/
            /// <summary>
            ///   UnityEngine.Matrix4x4 get_LocalToWorldMat()
            /// </summary>
            /// <returns>struct UnityEngine.Matrix4x4</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_LocalToWorldMat", "UnityEngine.Matrix4x4", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Matrix4x4 GET_LOCAL_TO_WORLD_MAT(); 
*/
            /// <summary>
            ///   SearchFilterType get_Network<FilterType>k__BackingField()
            /// </summary>
            /// <returns>enum SearchFilterType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network<FilterType>k__BackingField", "SearchFilterType", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial SearchFilterType GET_NETWORK_FILTER_TYPEK__BACKING_FIELD(); 
*/
            /// <summary>
            ///   System.String get_Network<Id>k__BackingField()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Network<Id>k__BackingField", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NETWORK_IDK__BACKING_FIELD(); 
*/
            /// <summary>
            ///   Game.Script.Common.ActorType get_NetworkActorType()
            /// </summary>
            /// <returns>enum Game.Script.Common.ActorType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_NetworkActorType", "Game.Script.Common.ActorType", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial Game.Script.Common.ActorType GET_NETWORK_ACTOR_TYPE(); 
*/
            /// <summary>
            ///   UnityEngine.Vector3 get_Position()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Position", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector3 GET_POSITION(); 
*/
            /// <summary>
            ///   System.Int32 get_RealLandRadius()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_RealLandRadius", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_REAL_LAND_RADIUS(); 
*/
            /// <summary>
            ///   UnityEngine.Quaternion get_Rotation()
            /// </summary>
            /// <returns>struct UnityEngine.Quaternion</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Rotation", "UnityEngine.Quaternion", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Quaternion GET_ROTATION(); 
*/
            /// <summary>
            ///   UnityEngine.Vector3 get_Scale()
            /// </summary>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Scale", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.Vector3 GET_SCALE(); 
*/
            /// <summary>
            ///   System.Single get_Size()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Size", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single GET_SIZE(); 
*/
            /// <summary>
            ///   Game.Script.Common.World get_World()
            /// </summary>
            /// <returns>class Game.Script.Common.World</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_World", "Game.Script.Common.World", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_WORLD(); 
*/
            /// <summary>
            ///   UnityEngine.Vector3 GetEmptyPosition(Game.Script.Character.AICharacter cur)
            /// </summary>
            /// <param name = "cur">class Game.Script.Character.AICharacter</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEmptyPosition", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.AICharacter", 0)]
            public partial UnityEngine.Vector3 GET_EMPTY_POSITION(nint cur); 
*/
            /// <summary>
            ///   UnityEngine.Vector3 GetNearGridPosition(Game.Script.Character.AICharacter cur)
            /// </summary>
            /// <param name = "cur">class Game.Script.Character.AICharacter</param>
            /// <returns>struct UnityEngine.Vector3</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetNearGridPosition", "UnityEngine.Vector3", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Character.AICharacter", 0)]
            public partial UnityEngine.Vector3 GET_NEAR_GRID_POSITION(nint cur); 
*/
            /// <summary>
            ///   System.Boolean IsValidPosition(UnityEngine.Vector3 pos)
            /// </summary>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsValidPosition", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public partial System.Boolean IS_VALID_POSITION(UnityEngine.Vector3 pos); 
*/
            /// <summary>
            ///   System.Void Leave()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Leave", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LEAVE(); 
*/
            /// <summary>
            ///   System.Void LeaveAllCollisionGrid()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LeaveAllCollisionGrid", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LEAVE_ALL_COLLISION_GRID(); 
*/
            /// <summary>
            ///   System.Void LeaveAllLandGrid()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LeaveAllLandGrid", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void LEAVE_ALL_LAND_GRID(); 
*/
            /// <summary>
            ///   System.Void LoadArchive(System.Byte[] data)
            /// </summary>
            /// <param name = "data">class System.Byte[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LoadArchive", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Byte[]", 0)]
            public partial void LOAD_ARCHIVE(nint data); 
*/
            /// <summary>
            ///   System.Void ManualEnter()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ManualEnter", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void MANUAL_ENTER(); 
*/
            /// <summary>
            ///   System.Void OnDestroy()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDestroy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_DESTROY(); 
*/
            /// <summary>
            ///   System.Void OnDisable()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDisable", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_DISABLE(); 
*/
            /// <summary>
            ///   System.Void OnEnable()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnEnable", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_ENABLE(); 
*/
            /// <summary>
            ///   System.Void OnEnterFocus()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnEnterFocus", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_ENTER_FOCUS(); 
*/
            /// <summary>
            ///   System.Void OnIdChange(System.String oldId, System.String newId)
            /// </summary>
            /// <param name = "oldId">class System.String</param>
            /// <param name = "newId">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnIdChange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial void ON_ID_CHANGE(nint oldId, nint newId); 
*/
            /// <summary>
            ///   System.Void OnLeaveFocus()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnLeaveFocus", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_LEAVE_FOCUS(); 
*/
            /// <summary>
            ///   System.Void OnStartClient()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStartClient", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_START_CLIENT(); 
*/
            /// <summary>
            ///   System.Void OnStartServer()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStartServer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_START_SERVER(); 
*/
            /// <summary>
            ///   System.Void OnStopClient()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStopClient", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_STOP_CLIENT(); 
*/
            /// <summary>
            ///   System.Byte[] SerializeArchive()
            /// </summary>
            /// <returns>class System.Byte[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeArchive", "System.Byte[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SERIALIZE_ARCHIVE(); 
*/
            /// <summary>
            ///   System.Void SerializeSyncVars(Mirror.NetworkWriter writer, System.Boolean forceAll)
            /// </summary>
            /// <param name = "writer">class Mirror.NetworkWriter</param>
            /// <param name = "forceAll">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeSyncVars", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkWriter", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SERIALIZE_SYNC_VARS(nint writer, System.Boolean forceAll); 
*/
            /// <summary>
            ///   System.Void set_bIsDestroyed(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_bIsDestroyed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_B_IS_DESTROYED(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_CacheTransform(UnityEngine.Transform value)
            /// </summary>
            /// <param name = "value">class UnityEngine.Transform</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_CacheTransform", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 0)]
            public partial void SET_CACHE_TRANSFORM(nint value); 
*/
            /// <summary>
            ///   System.Void set_FilterType(SearchFilterType value)
            /// </summary>
            /// <param name = "value">enum SearchFilterType</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_FilterType", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SearchFilterType", 0)]
            public partial void SET_FILTER_TYPE(SearchFilterType value); 
*/
            /// <summary>
            ///   System.Void set_Id(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Id", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_ID(nint value); 
*/
            /// <summary>
            ///   System.Void set_IsSetData(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_IsSetData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_IS_SET_DATA(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_LocalToWorldMat(UnityEngine.Matrix4x4 value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Matrix4x4</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_LocalToWorldMat", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Matrix4x4", 0)]
            public partial void SET_LOCAL_TO_WORLD_MAT(UnityEngine.Matrix4x4 value); 
*/
            /// <summary>
            ///   System.Void set_Network<FilterType>k__BackingField(SearchFilterType value)
            /// </summary>
            /// <param name = "value">enum SearchFilterType</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network<FilterType>k__BackingField", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SearchFilterType", 0)]
            public partial void SET_NETWORK_FILTER_TYPEK__BACKING_FIELD(SearchFilterType value); 
*/
            /// <summary>
            ///   System.Void set_Network<Id>k__BackingField(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Network<Id>k__BackingField", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_NETWORK_IDK__BACKING_FIELD(nint value); 
*/
            /// <summary>
            ///   System.Void set_NetworkActorType(Game.Script.Common.ActorType value)
            /// </summary>
            /// <param name = "value">enum Game.Script.Common.ActorType</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_NetworkActorType", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.ActorType", 0)]
            public partial void SET_NETWORK_ACTOR_TYPE(Game.Script.Common.ActorType value); 
*/
            /// <summary>
            ///   System.Void set_Position(UnityEngine.Vector3 value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Position", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public partial void SET_POSITION(UnityEngine.Vector3 value); 
*/
            /// <summary>
            ///   System.Void set_Rotation(UnityEngine.Quaternion value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Quaternion</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Rotation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 0)]
            public partial void SET_ROTATION(UnityEngine.Quaternion value); 
*/
            /// <summary>
            ///   System.Void set_Scale(UnityEngine.Vector3 value)
            /// </summary>
            /// <param name = "value">struct UnityEngine.Vector3</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Scale", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 0)]
            public partial void SET_SCALE(UnityEngine.Vector3 value); 
*/
            /// <summary>
            ///   System.Void set_World(Game.Script.Common.World value)
            /// </summary>
            /// <param name = "value">class Game.Script.Common.World</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_World", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.World", 0)]
            public partial void SET_WORLD(nint value); 
*/
            /// <summary>
            ///   System.Void Start()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Start", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void START(); 
*/
            /// <summary>
            ///   System.Void TakeDamage(Game.Script.Common.Actor srcActor, Game.Script.Common.DamageInfo damageInfo)
            /// </summary>
            /// <param name = "srcActor">class Game.Script.Common.Actor</param>
            /// <param name = "damageInfo">class Game.Script.Common.DamageInfo</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TakeDamage", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.Actor", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.DamageInfo", 1)]
            public partial void TAKE_DAMAGE(nint srcActor, nint damageInfo); 
*/
            /// <summary>
            ///   System.Void TransformChanged()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TransformChanged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void TRANSFORM_CHANGED(); 
*/
            /// <summary>
            ///   System.Void UpdateCollisionGridNormal(System.Int32 x, System.Int32 z)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "z">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateCollisionGridNormal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_COLLISION_GRID_NORMAL(System.Int32 x, System.Int32 z); 
*/
            /// <summary>
            ///   System.Void UpdateGrid()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateGrid", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_GRID(); 
*/
            /// <summary>
            ///   System.Void UpdateLandGridHorizontal(System.Int32 x, System.Int32 z)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "z">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateLandGridHorizontal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_LAND_GRID_HORIZONTAL(System.Int32 x, System.Int32 z); 
*/
            /// <summary>
            ///   System.Void UpdateLandGridNormal(System.Int32 x, System.Int32 z)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "z">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateLandGridNormal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_LAND_GRID_NORMAL(System.Int32 x, System.Int32 z); 
*/
            /// <summary>
            ///   System.Void UpdateLandGridVertical(System.Int32 x, System.Int32 z)
            /// </summary>
            /// <param name = "x">struct System.Int32</param>
            /// <param name = "z">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateLandGridVertical", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void UPDATE_LAND_GRID_VERTICAL(System.Int32 x, System.Int32 z); 
*/
            /// <summary>
            ///   System.Void UpdateTransform(UnityEngine.Jobs.TransformAccess transformAccess)
            /// </summary>
            /// <param name = "transformAccess">struct UnityEngine.Jobs.TransformAccess</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateTransform", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Jobs.TransformAccess", 0)]
            public partial void UPDATE_TRANSFORM(UnityEngine.Jobs.TransformAccess transformAccess); 
*/
            /// <summary>
            ///   System.Void UpdateTransformInfo()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateTransformInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void UPDATE_TRANSFORM_INFO(); 
*/
            /// <summary>
            ///   System.Boolean Weaved()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Weaved", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean WEAVED(); 
*/
        }

        /// <summary>
        /// abstract class ["Mirror.dll"."Mirror"."NetworkBehaviour"]
        /// </summary>
        partial struct Ptr_FightCharacter
        {
            /// <summary>
            /// static  System.Int32 ErrorCorrection(System.Int32 size, System.Byte safety)
            /// </summary>
            /// <param name = "size">struct System.Int32</param>
            /// <param name = "safety">struct System.Byte</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ErrorCorrection", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Byte", 1)]
            public static partial System.Int32 ERROR_CORRECTION(System.Int32 size, System.Byte safety); 
*/
            /// <summary>
            /// static  System.Boolean SyncVarEqual(T value, T& fieldValue)
            /// </summary>
            /// <param name = "value">class T</param>
            /// <param name = "fieldValue">class T&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SyncVarEqual", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 1)]
            public static partial System.Boolean SYNC_VAR_EQUAL(nint value, nint fieldValue); 
*/
            /// <summary>
            /// static  System.Boolean SyncVarGameObjectEqual(UnityEngine.GameObject newGameObject, System.UInt32 netIdField)
            /// </summary>
            /// <param name = "newGameObject">class UnityEngine.GameObject</param>
            /// <param name = "netIdField">struct System.UInt32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SyncVarGameObjectEqual", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 1)]
            public static partial System.Boolean SYNC_VAR_GAME_OBJECT_EQUAL(nint newGameObject, System.UInt32 netIdField); 
*/
            /// <summary>
            /// static  System.Boolean SyncVarNetworkBehaviourEqual(T newBehaviour, Mirror.NetworkBehaviourSyncVar syncField)
            /// </summary>
            /// <param name = "newBehaviour">class T</param>
            /// <param name = "syncField">struct Mirror.NetworkBehaviourSyncVar</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SyncVarNetworkBehaviourEqual", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviourSyncVar", 1)]
            public static partial System.Boolean SYNC_VAR_NETWORK_BEHAVIOUR_EQUAL(nint newBehaviour, Mirror.NetworkBehaviourSyncVar syncField); 
*/
            /// <summary>
            /// static  System.Boolean SyncVarNetworkIdentityEqual(Mirror.NetworkIdentity newIdentity, System.UInt32 netIdField)
            /// </summary>
            /// <param name = "newIdentity">class Mirror.NetworkIdentity</param>
            /// <param name = "netIdField">struct System.UInt32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SyncVarNetworkIdentityEqual", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkIdentity", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 1)]
            public static partial System.Boolean SYNC_VAR_NETWORK_IDENTITY_EQUAL(nint newIdentity, System.UInt32 netIdField); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void Awake()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Awake", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void AWAKE(); 
*/
            /// <summary>
            ///   System.Void ClearAllDirtyBits()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearAllDirtyBits", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR_ALL_DIRTY_BITS(); 
*/
            /// <summary>
            ///   System.Boolean Deserialize(Mirror.NetworkReader reader, System.Boolean initialState)
            /// </summary>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "initialState">struct System.Boolean</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Deserialize", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial System.Boolean DESERIALIZE(nint reader, System.Boolean initialState); 
*/
            /// <summary>
            ///   System.Void DeserializeObjectsAll(Mirror.NetworkReader reader)
            /// </summary>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeserializeObjectsAll", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 0)]
            public partial void DESERIALIZE_OBJECTS_ALL(nint reader); 
*/
            /// <summary>
            ///   System.Void DeserializeObjectsDelta(Mirror.NetworkReader reader)
            /// </summary>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeserializeObjectsDelta", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 0)]
            public partial void DESERIALIZE_OBJECTS_DELTA(nint reader); 
*/
            /// <summary>
            ///   System.Void DeserializeSyncObjects(Mirror.NetworkReader reader, System.Boolean initialState)
            /// </summary>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "initialState">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeserializeSyncObjects", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void DESERIALIZE_SYNC_OBJECTS(nint reader, System.Boolean initialState); 
*/
            /// <summary>
            ///   System.Void DeserializeSyncVars(Mirror.NetworkReader reader, System.Boolean initialState)
            /// </summary>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "initialState">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DeserializeSyncVars", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void DESERIALIZE_SYNC_VARS(nint reader, System.Boolean initialState); 
*/
            /// <summary>
            ///   System.Void GeneratedSyncVarDeserialize(T& field, System.Action<T , T> OnChanged, T value)
            /// </summary>
            /// <param name = "field">class T&</param>
            /// <param name = "OnChanged">class System.Action<T , T></param>
            /// <param name = "value">class T</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GeneratedSyncVarDeserialize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<T,T>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 2)]
            public partial void GENERATED_SYNC_VAR_DESERIALIZE(nint field, nint OnChanged, nint value); 
*/
            /// <summary>
            ///   System.Void GeneratedSyncVarDeserialize_GameObject(UnityEngine.GameObject& field, System.Action<UnityEngine.GameObject , UnityEngine.GameObject> OnChanged, Mirror.NetworkReader reader, System.UInt32& netIdField)
            /// </summary>
            /// <param name = "field">class UnityEngine.GameObject&</param>
            /// <param name = "OnChanged">class System.Action<UnityEngine.GameObject , UnityEngine.GameObject></param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "netIdField">struct System.UInt32&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GeneratedSyncVarDeserialize_GameObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject&", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<UnityEngine.GameObject,UnityEngine.GameObject>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32&", 3)]
            public partial void GENERATED_SYNC_VAR_DESERIALIZE_GAME_OBJECT(nint field, nint OnChanged, nint reader, System.UInt32 &netIdField); 
*/
            /// <summary>
            ///   System.Void GeneratedSyncVarDeserialize_NetworkBehaviour(T& field, System.Action<T , T> OnChanged, Mirror.NetworkReader reader, Mirror.NetworkBehaviourSyncVar& netIdField)
            /// </summary>
            /// <param name = "field">class T&</param>
            /// <param name = "OnChanged">class System.Action<T , T></param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "netIdField">struct Mirror.NetworkBehaviourSyncVar&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GeneratedSyncVarDeserialize_NetworkBehaviour", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<T,T>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviourSyncVar&", 3)]
            public partial void GENERATED_SYNC_VAR_DESERIALIZE_NETWORK_BEHAVIOUR(nint field, nint OnChanged, nint reader, Mirror.NetworkBehaviourSyncVar &netIdField); 
*/
            /// <summary>
            ///   System.Void GeneratedSyncVarDeserialize_NetworkIdentity(Mirror.NetworkIdentity& field, System.Action<Mirror.NetworkIdentity , Mirror.NetworkIdentity> OnChanged, Mirror.NetworkReader reader, System.UInt32& netIdField)
            /// </summary>
            /// <param name = "field">class Mirror.NetworkIdentity&</param>
            /// <param name = "OnChanged">class System.Action<Mirror.NetworkIdentity , Mirror.NetworkIdentity></param>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "netIdField">struct System.UInt32&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GeneratedSyncVarDeserialize_NetworkIdentity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkIdentity&", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<Mirror.NetworkIdentity,Mirror.NetworkIdentity>", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32&", 3)]
            public partial void GENERATED_SYNC_VAR_DESERIALIZE_NETWORK_IDENTITY(nint field, nint OnChanged, nint reader, System.UInt32 &netIdField); 
*/
            /// <summary>
            ///   System.Void GeneratedSyncVarSetter(T value, T& field, System.UInt64 dirtyBit, System.Action<T , T> OnChanged)
            /// </summary>
            /// <param name = "value">class T</param>
            /// <param name = "field">class T&</param>
            /// <param name = "dirtyBit">struct System.UInt64</param>
            /// <param name = "OnChanged">class System.Action<T , T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GeneratedSyncVarSetter", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt64", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<T,T>", 3)]
            public partial void GENERATED_SYNC_VAR_SETTER(nint value, nint field, System.UInt64 dirtyBit, nint OnChanged); 
*/
            /// <summary>
            ///   System.Void GeneratedSyncVarSetter_GameObject(UnityEngine.GameObject value, UnityEngine.GameObject& field, System.UInt64 dirtyBit, System.Action<UnityEngine.GameObject , UnityEngine.GameObject> OnChanged, System.UInt32& netIdField)
            /// </summary>
            /// <param name = "value">class UnityEngine.GameObject</param>
            /// <param name = "field">class UnityEngine.GameObject&</param>
            /// <param name = "dirtyBit">struct System.UInt64</param>
            /// <param name = "OnChanged">class System.Action<UnityEngine.GameObject , UnityEngine.GameObject></param>
            /// <param name = "netIdField">struct System.UInt32&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GeneratedSyncVarSetter_GameObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt64", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<UnityEngine.GameObject,UnityEngine.GameObject>", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32&", 4)]
            public partial void GENERATED_SYNC_VAR_SETTER_GAME_OBJECT(nint value, nint field, System.UInt64 dirtyBit, nint OnChanged, System.UInt32 &netIdField); 
*/
            /// <summary>
            ///   System.Void GeneratedSyncVarSetter_NetworkBehaviour(T value, T& field, System.UInt64 dirtyBit, System.Action<T , T> OnChanged, Mirror.NetworkBehaviourSyncVar& netIdField)
            /// </summary>
            /// <param name = "value">class T</param>
            /// <param name = "field">class T&</param>
            /// <param name = "dirtyBit">struct System.UInt64</param>
            /// <param name = "OnChanged">class System.Action<T , T></param>
            /// <param name = "netIdField">struct Mirror.NetworkBehaviourSyncVar&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GeneratedSyncVarSetter_NetworkBehaviour", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt64", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<T,T>", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviourSyncVar&", 4)]
            public partial void GENERATED_SYNC_VAR_SETTER_NETWORK_BEHAVIOUR(nint value, nint field, System.UInt64 dirtyBit, nint OnChanged, Mirror.NetworkBehaviourSyncVar &netIdField); 
*/
            /// <summary>
            ///   System.Void GeneratedSyncVarSetter_NetworkIdentity(Mirror.NetworkIdentity value, Mirror.NetworkIdentity& field, System.UInt64 dirtyBit, System.Action<Mirror.NetworkIdentity , Mirror.NetworkIdentity> OnChanged, System.UInt32& netIdField)
            /// </summary>
            /// <param name = "value">class Mirror.NetworkIdentity</param>
            /// <param name = "field">class Mirror.NetworkIdentity&</param>
            /// <param name = "dirtyBit">struct System.UInt64</param>
            /// <param name = "OnChanged">class System.Action<Mirror.NetworkIdentity , Mirror.NetworkIdentity></param>
            /// <param name = "netIdField">struct System.UInt32&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GeneratedSyncVarSetter_NetworkIdentity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkIdentity", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkIdentity&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt64", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<Mirror.NetworkIdentity,Mirror.NetworkIdentity>", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32&", 4)]
            public partial void GENERATED_SYNC_VAR_SETTER_NETWORK_IDENTITY(nint value, nint field, System.UInt64 dirtyBit, nint OnChanged, System.UInt32 &netIdField); 
*/
            /// <summary>
            ///   System.Boolean get_authority()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_authority", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_AUTHORITY(); 
*/
            /// <summary>
            ///   System.Byte get_ComponentIndex()
            /// </summary>
            /// <returns>struct System.Byte</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_ComponentIndex", "System.Byte", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Byte GET_COMPONENT_INDEX(); 
*/
            /// <summary>
            ///   Mirror.NetworkConnectionToClient get_connectionToClient()
            /// </summary>
            /// <returns>class Mirror.NetworkConnectionToClient</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_connectionToClient", "Mirror.NetworkConnectionToClient", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CONNECTION_TO_CLIENT(); 
*/
            /// <summary>
            ///   Mirror.NetworkConnection get_connectionToServer()
            /// </summary>
            /// <returns>abstract class Mirror.NetworkConnection</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_connectionToServer", "Mirror.NetworkConnection", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_CONNECTION_TO_SERVER(); 
*/
            /// <summary>
            ///   System.Boolean get_isClient()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isClient", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_CLIENT(); 
*/
            /// <summary>
            ///   System.Boolean get_isClientOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isClientOnly", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_CLIENT_ONLY(); 
*/
            /// <summary>
            ///   System.Boolean get_isLocalPlayer()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isLocalPlayer", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_LOCAL_PLAYER(); 
*/
            /// <summary>
            ///   System.Boolean get_isOwned()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isOwned", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_OWNED(); 
*/
            /// <summary>
            ///   System.Boolean get_isServer()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isServer", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_SERVER(); 
*/
            /// <summary>
            ///   System.Boolean get_isServerOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isServerOnly", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_SERVER_ONLY(); 
*/
            /// <summary>
            ///   System.UInt32 get_netId()
            /// </summary>
            /// <returns>struct System.UInt32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_netId", "System.UInt32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.UInt32 GET_NET_ID(); 
*/
            /// <summary>
            ///   Mirror.NetworkIdentity get_netIdentity()
            /// </summary>
            /// <returns>class Mirror.NetworkIdentity</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_netIdentity", "Mirror.NetworkIdentity", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NET_IDENTITY(); 
*/
            /// <summary>
            ///   System.Guid get_UnNetGuid()
            /// </summary>
            /// <returns>struct System.Guid</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_UnNetGuid", "System.Guid", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Guid GET_UN_NET_GUID(); 
*/
            /// <summary>
            ///   UnityEngine.GameObject GetSyncVarGameObject(System.UInt32 netId, UnityEngine.GameObject& gameObjectField)
            /// </summary>
            /// <param name = "netId">struct System.UInt32</param>
            /// <param name = "gameObjectField">class UnityEngine.GameObject&</param>
            /// <returns>class UnityEngine.GameObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSyncVarGameObject", "UnityEngine.GameObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject&", 1)]
            public partial nint GET_SYNC_VAR_GAME_OBJECT(System.UInt32 netId, nint gameObjectField); 
*/
            /// <summary>
            ///   System.Boolean GetSyncVarHookGuard(System.UInt64 dirtyBit)
            /// </summary>
            /// <param name = "dirtyBit">struct System.UInt64</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSyncVarHookGuard", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt64", 0)]
            public partial System.Boolean GET_SYNC_VAR_HOOK_GUARD(System.UInt64 dirtyBit); 
*/
            /// <summary>
            ///   T GetSyncVarNetworkBehaviour(Mirror.NetworkBehaviourSyncVar syncNetBehaviour, T& behaviourField)
            /// </summary>
            /// <param name = "syncNetBehaviour">struct Mirror.NetworkBehaviourSyncVar</param>
            /// <param name = "behaviourField">class T&</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSyncVarNetworkBehaviour", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviourSyncVar", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 1)]
            public partial nint GET_SYNC_VAR_NETWORK_BEHAVIOUR(Mirror.NetworkBehaviourSyncVar syncNetBehaviour, nint behaviourField); 
*/
            /// <summary>
            ///   Mirror.NetworkIdentity GetSyncVarNetworkIdentity(System.UInt32 netId, Mirror.NetworkIdentity& identityField)
            /// </summary>
            /// <param name = "netId">struct System.UInt32</param>
            /// <param name = "identityField">class Mirror.NetworkIdentity&</param>
            /// <returns>class Mirror.NetworkIdentity</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSyncVarNetworkIdentity", "Mirror.NetworkIdentity", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkIdentity&", 1)]
            public partial nint GET_SYNC_VAR_NETWORK_IDENTITY(System.UInt32 netId, nint identityField); 
*/
            /// <summary>
            ///   System.Boolean HasSyncObjects()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("HasSyncObjects", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean HAS_SYNC_OBJECTS(); 
*/
            /// <summary>
            ///   System.Void InitSyncObject(Mirror.SyncObject syncObject)
            /// </summary>
            /// <param name = "syncObject">abstract class Mirror.SyncObject</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitSyncObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.SyncObject", 0)]
            public partial void INIT_SYNC_OBJECT(nint syncObject); 
*/
            /// <summary>
            ///   System.Boolean IsDirty()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsDirty", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_DIRTY(); 
*/
            /// <summary>
            ///   System.Void OnDeserialize(Mirror.NetworkReader reader, System.Boolean initialState)
            /// </summary>
            /// <param name = "reader">class Mirror.NetworkReader</param>
            /// <param name = "initialState">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDeserialize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkReader", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ON_DESERIALIZE(nint reader, System.Boolean initialState); 
*/
            /// <summary>
            ///   System.Void OnDestroy()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDestroy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_DESTROY(); 
*/
            /// <summary>
            ///   System.Void OnSerialize(Mirror.NetworkWriter writer, System.Boolean initialState)
            /// </summary>
            /// <param name = "writer">class Mirror.NetworkWriter</param>
            /// <param name = "initialState">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnSerialize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkWriter", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void ON_SERIALIZE(nint writer, System.Boolean initialState); 
*/
            /// <summary>
            ///   System.Void OnStartAuthority()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStartAuthority", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_START_AUTHORITY(); 
*/
            /// <summary>
            ///   System.Void OnStartClient()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStartClient", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_START_CLIENT(); 
*/
            /// <summary>
            ///   System.Void OnStartLocalPlayer()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStartLocalPlayer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_START_LOCAL_PLAYER(); 
*/
            /// <summary>
            ///   System.Void OnStartServer()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStartServer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_START_SERVER(); 
*/
            /// <summary>
            ///   System.Void OnStopAuthority()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStopAuthority", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_STOP_AUTHORITY(); 
*/
            /// <summary>
            ///   System.Void OnStopClient()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStopClient", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_STOP_CLIENT(); 
*/
            /// <summary>
            ///   System.Void OnStopLocalPlayer()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStopLocalPlayer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_STOP_LOCAL_PLAYER(); 
*/
            /// <summary>
            ///   System.Void OnStopServer()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnStopServer", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_STOP_SERVER(); 
*/
            /// <summary>
            ///   System.Void OnValidate()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnValidate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_VALIDATE(); 
*/
            /// <summary>
            ///   System.Void ResetSyncObjects()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ResetSyncObjects", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RESET_SYNC_OBJECTS(); 
*/
            /// <summary>
            ///   System.Void SendCommandInternal(System.String functionFullName, System.Int32 functionHashCode, Mirror.NetworkWriter writer, System.Int32 channelId, System.Boolean requiresAuthority)
            /// </summary>
            /// <param name = "functionFullName">class System.String</param>
            /// <param name = "functionHashCode">struct System.Int32</param>
            /// <param name = "writer">class Mirror.NetworkWriter</param>
            /// <param name = "channelId">struct System.Int32</param>
            /// <param name = "requiresAuthority">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SendCommandInternal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkWriter", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            public partial void SEND_COMMAND_INTERNAL(nint functionFullName, System.Int32 functionHashCode, nint writer, System.Int32 channelId, System.Boolean requiresAuthority); 
*/
            /// <summary>
            ///   System.Void SendRPCInternal(System.String functionFullName, System.Int32 functionHashCode, Mirror.NetworkWriter writer, System.Int32 channelId, System.Boolean includeOwner)
            /// </summary>
            /// <param name = "functionFullName">class System.String</param>
            /// <param name = "functionHashCode">struct System.Int32</param>
            /// <param name = "writer">class Mirror.NetworkWriter</param>
            /// <param name = "channelId">struct System.Int32</param>
            /// <param name = "includeOwner">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SendRPCInternal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkWriter", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 4)]
            public partial void SEND_RPC_INTERNAL(nint functionFullName, System.Int32 functionHashCode, nint writer, System.Int32 channelId, System.Boolean includeOwner); 
*/
            /// <summary>
            ///   System.Void SendTargetRPCInternal(Mirror.NetworkConnection conn, System.String functionFullName, System.Int32 functionHashCode, Mirror.NetworkWriter writer, System.Int32 channelId)
            /// </summary>
            /// <param name = "conn">abstract class Mirror.NetworkConnection</param>
            /// <param name = "functionFullName">class System.String</param>
            /// <param name = "functionHashCode">struct System.Int32</param>
            /// <param name = "writer">class Mirror.NetworkWriter</param>
            /// <param name = "channelId">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SendTargetRPCInternal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkConnection", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkWriter", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            public partial void SEND_TARGET_RPC_INTERNAL(nint conn, nint functionFullName, System.Int32 functionHashCode, nint writer, System.Int32 channelId); 
*/
            /// <summary>
            ///   System.Void Serialize(Mirror.NetworkWriter writer, System.Boolean initialState)
            /// </summary>
            /// <param name = "writer">class Mirror.NetworkWriter</param>
            /// <param name = "initialState">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Serialize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkWriter", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SERIALIZE(nint writer, System.Boolean initialState); 
*/
            /// <summary>
            ///   System.Void SerializeObjectsAll(Mirror.NetworkWriter writer)
            /// </summary>
            /// <param name = "writer">class Mirror.NetworkWriter</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeObjectsAll", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkWriter", 0)]
            public partial void SERIALIZE_OBJECTS_ALL(nint writer); 
*/
            /// <summary>
            ///   System.Void SerializeObjectsDelta(Mirror.NetworkWriter writer)
            /// </summary>
            /// <param name = "writer">class Mirror.NetworkWriter</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeObjectsDelta", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkWriter", 0)]
            public partial void SERIALIZE_OBJECTS_DELTA(nint writer); 
*/
            /// <summary>
            ///   System.Void SerializeSyncObjects(Mirror.NetworkWriter writer, System.Boolean initialState)
            /// </summary>
            /// <param name = "writer">class Mirror.NetworkWriter</param>
            /// <param name = "initialState">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeSyncObjects", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkWriter", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SERIALIZE_SYNC_OBJECTS(nint writer, System.Boolean initialState); 
*/
            /// <summary>
            ///   System.Void SerializeSyncVars(Mirror.NetworkWriter writer, System.Boolean initialState)
            /// </summary>
            /// <param name = "writer">class Mirror.NetworkWriter</param>
            /// <param name = "initialState">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SerializeSyncVars", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkWriter", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SERIALIZE_SYNC_VARS(nint writer, System.Boolean initialState); 
*/
            /// <summary>
            ///   System.Void set_ComponentIndex(System.Byte value)
            /// </summary>
            /// <param name = "value">struct System.Byte</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ComponentIndex", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Byte", 0)]
            public partial void SET_COMPONENT_INDEX(System.Byte value); 
*/
            /// <summary>
            ///   System.Void set_netIdentity(Mirror.NetworkIdentity value)
            /// </summary>
            /// <param name = "value">class Mirror.NetworkIdentity</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_netIdentity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkIdentity", 0)]
            public partial void SET_NET_IDENTITY(nint value); 
*/
            /// <summary>
            ///   System.Void set_UnNetGuid(System.Guid value)
            /// </summary>
            /// <param name = "value">struct System.Guid</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_UnNetGuid", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Guid", 0)]
            public partial void SET_UN_NET_GUID(System.Guid value); 
*/
            /// <summary>
            ///   System.Void SetDirty()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetDirty", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SET_DIRTY(); 
*/
            /// <summary>
            ///   System.Void SetSyncObjectDirtyBit(System.UInt64 dirtyBit)
            /// </summary>
            /// <param name = "dirtyBit">struct System.UInt64</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSyncObjectDirtyBit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt64", 0)]
            public partial void SET_SYNC_OBJECT_DIRTY_BIT(System.UInt64 dirtyBit); 
*/
            /// <summary>
            ///   System.Void SetSyncVar(T value, T& fieldValue, System.UInt64 dirtyBit)
            /// </summary>
            /// <param name = "value">class T</param>
            /// <param name = "fieldValue">class T&</param>
            /// <param name = "dirtyBit">struct System.UInt64</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSyncVar", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt64", 2)]
            public partial void SET_SYNC_VAR(nint value, nint fieldValue, System.UInt64 dirtyBit); 
*/
            /// <summary>
            ///   System.Void SetSyncVarDirtyBit(System.UInt64 dirtyBit)
            /// </summary>
            /// <param name = "dirtyBit">struct System.UInt64</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSyncVarDirtyBit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt64", 0)]
            public partial void SET_SYNC_VAR_DIRTY_BIT(System.UInt64 dirtyBit); 
*/
            /// <summary>
            ///   System.Void SetSyncVarGameObject(UnityEngine.GameObject newGameObject, UnityEngine.GameObject& gameObjectField, System.UInt64 dirtyBit, System.UInt32& netIdField)
            /// </summary>
            /// <param name = "newGameObject">class UnityEngine.GameObject</param>
            /// <param name = "gameObjectField">class UnityEngine.GameObject&</param>
            /// <param name = "dirtyBit">struct System.UInt64</param>
            /// <param name = "netIdField">struct System.UInt32&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSyncVarGameObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.GameObject&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt64", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32&", 3)]
            public partial void SET_SYNC_VAR_GAME_OBJECT(nint newGameObject, nint gameObjectField, System.UInt64 dirtyBit, System.UInt32 &netIdField); 
*/
            /// <summary>
            ///   System.Void SetSyncVarHookGuard(System.UInt64 dirtyBit, System.Boolean value)
            /// </summary>
            /// <param name = "dirtyBit">struct System.UInt64</param>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSyncVarHookGuard", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt64", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial void SET_SYNC_VAR_HOOK_GUARD(System.UInt64 dirtyBit, System.Boolean value); 
*/
            /// <summary>
            ///   System.Void SetSyncVarNetworkBehaviour(T newBehaviour, T& behaviourField, System.UInt64 dirtyBit, Mirror.NetworkBehaviourSyncVar& syncField)
            /// </summary>
            /// <param name = "newBehaviour">class T</param>
            /// <param name = "behaviourField">class T&</param>
            /// <param name = "dirtyBit">struct System.UInt64</param>
            /// <param name = "syncField">struct Mirror.NetworkBehaviourSyncVar&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSyncVarNetworkBehaviour", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt64", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkBehaviourSyncVar&", 3)]
            public partial void SET_SYNC_VAR_NETWORK_BEHAVIOUR(nint newBehaviour, nint behaviourField, System.UInt64 dirtyBit, Mirror.NetworkBehaviourSyncVar &syncField); 
*/
            /// <summary>
            ///   System.Void SetSyncVarNetworkIdentity(Mirror.NetworkIdentity newIdentity, Mirror.NetworkIdentity& identityField, System.UInt64 dirtyBit, System.UInt32& netIdField)
            /// </summary>
            /// <param name = "newIdentity">class Mirror.NetworkIdentity</param>
            /// <param name = "identityField">class Mirror.NetworkIdentity&</param>
            /// <param name = "dirtyBit">struct System.UInt64</param>
            /// <param name = "netIdField">struct System.UInt32&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetSyncVarNetworkIdentity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkIdentity", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Mirror.NetworkIdentity&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt64", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.UInt32&", 3)]
            public partial void SET_SYNC_VAR_NETWORK_IDENTITY(nint newIdentity, nint identityField, System.UInt64 dirtyBit, System.UInt32 &netIdField); 
*/
            /// <summary>
            ///   System.Boolean Weaved()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Weaved", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean WEAVED(); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Component"]
        /// </summary>
        partial struct Ptr_FightCharacter
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Boolean CompareTag(System.String tag)
            /// </summary>
            /// <param name = "tag">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CompareTag", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean COMPARE_TAG(nint tag); 
*/
            /// <summary>
            ///   UnityEngine.GameObject get_gameObject()
            /// </summary>
            /// <returns>class UnityEngine.GameObject</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_gameObject", "UnityEngine.GameObject", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_GAME_OBJECT(); 
*/
            /// <summary>
            ///   UnityEngine.Transform get_transform()
            /// </summary>
            /// <returns>class UnityEngine.Transform</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_transform", "UnityEngine.Transform", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_TRANSFORM(); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponent(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Component</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponent", "UnityEngine.Component", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public partial nint GET_COMPONENT(nint type); 
*/
            /// <summary>
            ///   T GetComponent()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponent", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENT(); 
*/
            /// <summary>
            ///   System.Void GetComponentFastPath(System.Type type, System.IntPtr oneFurtherThanResultValue)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "oneFurtherThanResultValue">struct System.IntPtr</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentFastPath", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 1)]
            public partial void GET_COMPONENT_FAST_PATH(nint type, System.IntPtr oneFurtherThanResultValue); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponentInChildren(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInChildren", "UnityEngine.Component", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_COMPONENT_IN_CHILDREN(nint t, System.Boolean includeInactive); 
*/
            /// <summary>
            ///   T GetComponentInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInChildren", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_COMPONENT_IN_CHILDREN(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   T GetComponentInChildren()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInChildren", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENT_IN_CHILDREN(); 
*/
            /// <summary>
            ///   UnityEngine.Component GetComponentInParent(System.Type t, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "t">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Component</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInParent", "UnityEngine.Component", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public partial nint GET_COMPONENT_IN_PARENT(nint t, System.Boolean includeInactive); 
*/
            /// <summary>
            ///   T GetComponentInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInParent", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_COMPONENT_IN_PARENT(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   T GetComponentInParent()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentInParent", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENT_IN_PARENT(); 
*/
            /// <summary>
            ///   System.Void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "results">class System.Collections.Generic.List<UnityEngine.Component></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Component>", 1)]
            public partial void GET_COMPONENTS(nint type, nint results); 
*/
            /// <summary>
            ///   System.Void GetComponents(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name = "results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponents", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 0)]
            public partial void GET_COMPONENTS(nint results); 
*/
            /// <summary>
            ///   T[] GetComponents()
            /// </summary>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponents", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENTS(); 
*/
            /// <summary>
            ///   System.Void GetComponentsForListInternal(System.Type searchType, System.Object resultList)
            /// </summary>
            /// <param name = "searchType">abstract class System.Type</param>
            /// <param name = "resultList">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsForListInternal", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial void GET_COMPONENTS_FOR_LIST_INTERNAL(nint searchType, nint resultList); 
*/
            /// <summary>
            ///   T[] GetComponentsInChildren(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInChildren", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_COMPONENTS_IN_CHILDREN(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Boolean includeInactive, System.Collections.Generic.List<T> result)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <param name = "result">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInChildren", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 1)]
            public partial void GET_COMPONENTS_IN_CHILDREN(System.Boolean includeInactive, nint result); 
*/
            /// <summary>
            ///   T[] GetComponentsInChildren()
            /// </summary>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInChildren", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENTS_IN_CHILDREN(); 
*/
            /// <summary>
            ///   System.Void GetComponentsInChildren(System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name = "results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInChildren", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 0)]
            public partial void GET_COMPONENTS_IN_CHILDREN(nint results); 
*/
            /// <summary>
            ///   T[] GetComponentsInParent(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInParent", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial nint GET_COMPONENTS_IN_PARENT(System.Boolean includeInactive); 
*/
            /// <summary>
            ///   System.Void GetComponentsInParent(System.Boolean includeInactive, System.Collections.Generic.List<T> results)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <param name = "results">class System.Collections.Generic.List<T></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInParent", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<T>", 1)]
            public partial void GET_COMPONENTS_IN_PARENT(System.Boolean includeInactive, nint results); 
*/
            /// <summary>
            ///   T[] GetComponentsInParent()
            /// </summary>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetComponentsInParent", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_COMPONENTS_IN_PARENT(); 
*/
            /// <summary>
            ///   System.Void set_tag(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_tag", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_TAG(nint value); 
*/
            /// <summary>
            ///   System.Boolean TryGetComponent(System.Type type, UnityEngine.Component& component)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "component">class UnityEngine.Component&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryGetComponent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Component&", 1)]
            public partial System.Boolean TRY_GET_COMPONENT(nint type, nint component); 
*/
            /// <summary>
            ///   System.Boolean TryGetComponent(T& component)
            /// </summary>
            /// <param name = "component">class T&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryGetComponent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T&", 0)]
            public partial System.Boolean TRY_GET_COMPONENT(nint component); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Behaviour"]
        /// </summary>
        partial struct Ptr_FightCharacter
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Boolean get_enabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_enabled", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_ENABLED(); 
*/
            /// <summary>
            ///   System.Boolean get_isActiveAndEnabled()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_isActiveAndEnabled", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_ACTIVE_AND_ENABLED(); 
*/
            /// <summary>
            ///   System.Void set_enabled(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_enabled", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_ENABLED(System.Boolean value); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."MonoBehaviour"]
        /// </summary>
        partial struct Ptr_FightCharacter
        {
            /// <summary>
            /// static  System.Void CancelInvoke(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancelInvoke", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial void CANCEL_INVOKE(nint self, nint methodName); 
*/
            /// <summary>
            /// static  System.Void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CancelInvokeAll", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            public static partial void INTERNAL_CANCEL_INVOKE_ALL(nint self); 
*/
            /// <summary>
            /// static  System.Boolean Internal_IsInvokingAll(UnityEngine.MonoBehaviour self)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_IsInvokingAll", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            public static partial System.Boolean INTERNAL_IS_INVOKING_ALL(nint self); 
*/
            /// <summary>
            /// static  System.Void InvokeDelayed(UnityEngine.MonoBehaviour self, System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "time">struct System.Single</param>
            /// <param name = "repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeDelayed", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 3)]
            public static partial void INVOKE_DELAYED(nint self, nint methodName, System.Single time, System.Single repeatRate); 
*/
            /// <summary>
            /// static  System.Boolean IsInvoking(UnityEngine.MonoBehaviour self, System.String methodName)
            /// </summary>
            /// <param name = "self">class UnityEngine.MonoBehaviour</param>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsInvoking", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.MonoBehaviour", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial System.Boolean IS_INVOKING(nint self, nint methodName); 
*/
            /// <summary>
            /// static  System.Boolean IsObjectMonoBehaviour(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsObjectMonoBehaviour", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean IS_OBJECT_MONO_BEHAVIOUR(nint obj); 
*/
            /// <summary>
            /// static  System.Void print(System.Object message)
            /// </summary>
            /// <param name = "message">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("print", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public static partial void PRINT(nint message); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void CancelInvoke()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancelInvoke", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CANCEL_INVOKE(); 
*/
            /// <summary>
            ///   System.Void CancelInvoke(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CancelInvoke", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void CANCEL_INVOKE(nint methodName); 
*/
            /// <summary>
            ///   System.Threading.CancellationToken get_destroyCancellationToken()
            /// </summary>
            /// <returns>struct System.Threading.CancellationToken</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_destroyCancellationToken", "System.Threading.CancellationToken", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Threading.CancellationToken GET_DESTROY_CANCELLATION_TOKEN(); 
*/
            /// <summary>
            ///   System.Boolean get_useGUILayout()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_useGUILayout", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_USE_GUI_LAYOUT(); 
*/
            /// <summary>
            ///   System.String GetScriptClassName()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetScriptClassName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SCRIPT_CLASS_NAME(); 
*/
            /// <summary>
            ///   System.Void Invoke(System.String methodName, System.Single time)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "time">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Invoke", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public partial void INVOKE(nint methodName, System.Single time); 
*/
            /// <summary>
            ///   System.Void InvokeRepeating(System.String methodName, System.Single time, System.Single repeatRate)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "time">struct System.Single</param>
            /// <param name = "repeatRate">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InvokeRepeating", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 2)]
            public partial void INVOKE_REPEATING(nint methodName, System.Single time, System.Single repeatRate); 
*/
            /// <summary>
            ///   System.Boolean IsInvoking()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsInvoking", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean IS_INVOKING(); 
*/
            /// <summary>
            ///   System.Boolean IsInvoking(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsInvoking", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial System.Boolean IS_INVOKING(nint methodName); 
*/
            /// <summary>
            ///   System.Void OnCancellationTokenCreated()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnCancellationTokenCreated", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_CANCELLATION_TOKEN_CREATED(); 
*/
            /// <summary>
            ///   System.Void RaiseCancellation()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RaiseCancellation", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void RAISE_CANCELLATION(); 
*/
            /// <summary>
            ///   System.Void set_useGUILayout(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_useGUILayout", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_USE_GUI_LAYOUT(System.Boolean value); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutine", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial nint START_COROUTINE(nint methodName); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.String methodName, System.Object value)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutine", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial nint START_COROUTINE(nint methodName, nint value); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutine", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial nint START_COROUTINE(nint routine); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutine_Auto", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial nint START_COROUTINE_AUTO(nint routine); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged(System.String methodName, System.Object value)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutineManaged", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial nint START_COROUTINE_MANAGED(nint methodName, nint value); 
*/
            /// <summary>
            ///   UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator)
            /// </summary>
            /// <param name = "enumerator">interface System.Collections.IEnumerator</param>
            /// <returns>class UnityEngine.Coroutine</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartCoroutineManaged2", "UnityEngine.Coroutine", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial nint START_COROUTINE_MANAGED2(nint enumerator); 
*/
            /// <summary>
            ///   System.Void StopAllCoroutines()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopAllCoroutines", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void STOP_ALL_COROUTINES(); 
*/
            /// <summary>
            ///   System.Void StopCoroutine(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutine", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial void STOP_COROUTINE(nint routine); 
*/
            /// <summary>
            ///   System.Void StopCoroutine(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name = "routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutine", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Coroutine", 0)]
            public partial void STOP_COROUTINE(nint routine); 
*/
            /// <summary>
            ///   System.Void StopCoroutine(System.String methodName)
            /// </summary>
            /// <param name = "methodName">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutine", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void STOP_COROUTINE(nint methodName); 
*/
            /// <summary>
            ///   System.Void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine)
            /// </summary>
            /// <param name = "routine">interface System.Collections.IEnumerator</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutineFromEnumeratorManaged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.IEnumerator", 0)]
            public partial void STOP_COROUTINE_FROM_ENUMERATOR_MANAGED(nint routine); 
*/
            /// <summary>
            ///   System.Void StopCoroutineManaged(UnityEngine.Coroutine routine)
            /// </summary>
            /// <param name = "routine">class UnityEngine.Coroutine</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StopCoroutineManaged", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Coroutine", 0)]
            public partial void STOP_COROUTINE_MANAGED(nint routine); 
*/
        }

        /// <summary>
        /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Object"]
        /// </summary>
        partial struct Ptr_FightCharacter
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  System.Void CheckNullArgument(System.Object arg, System.String message)
            /// </summary>
            /// <param name = "arg">class System.Object</param>
            /// <param name = "message">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckNullArgument", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial void CHECK_NULL_ARGUMENT(nint arg, nint message); 
*/
            /// <summary>
            /// static  System.Boolean CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs)
            /// </summary>
            /// <param name = "lhs">class UnityEngine.Object</param>
            /// <param name = "rhs">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CompareBaseObjects", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 1)]
            public static partial System.Boolean COMPARE_BASE_OBJECTS(nint lhs, nint rhs); 
*/
            /// <summary>
            /// static  System.Boolean CurrentThreadIsMainThread()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CurrentThreadIsMainThread", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Boolean CURRENT_THREAD_IS_MAIN_THREAD(); 
*/
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Destroy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial void DESTROY(nint obj, System.Single t); 
*/
            /// <summary>
            /// static  System.Void Destroy(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Destroy", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DESTROY(nint obj); 
*/
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj, System.Boolean allowDestroyingAssets)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "allowDestroyingAssets">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyImmediate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial void DESTROY_IMMEDIATE(nint obj, System.Boolean allowDestroyingAssets); 
*/
            /// <summary>
            /// static  System.Void DestroyImmediate(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyImmediate", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DESTROY_IMMEDIATE(nint obj); 
*/
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj, System.Single t)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "t">struct System.Single</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Single", 1)]
            public static partial void DESTROY_OBJECT(nint obj, System.Single t); 
*/
            /// <summary>
            /// static  System.Void DestroyObject(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DestroyObject", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DESTROY_OBJECT(nint obj); 
*/
            /// <summary>
            /// static  System.Boolean DoesObjectWithInstanceIDExist(System.Int32 instanceID)
            /// </summary>
            /// <param name = "instanceID">struct System.Int32</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DoesObjectWithInstanceIDExist", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial System.Boolean DOES_OBJECT_WITH_INSTANCE_ID_EXIST(System.Int32 instanceID); 
*/
            /// <summary>
            /// static  System.Void DontDestroyOnLoad(UnityEngine.Object target)
            /// </summary>
            /// <param name = "target">class UnityEngine.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DontDestroyOnLoad", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial void DONT_DESTROY_ON_LOAD(nint target); 
*/
            /// <summary>
            /// static  T FindAnyObjectByType()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindAnyObjectByType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint FIND_ANY_OBJECT_BY_TYPE(); 
*/
            /// <summary>
            /// static  T FindAnyObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindAnyObjectByType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsInactive", 0)]
            public static partial nint FIND_ANY_OBJECT_BY_TYPE(UnityEngine.FindObjectsInactive findObjectsInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindAnyObjectByType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindAnyObjectByType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_ANY_OBJECT_BY_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindAnyObjectByType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsInactive", 1)]
            public static partial nint FIND_ANY_OBJECT_BY_TYPE(nint type, UnityEngine.FindObjectsInactive findObjectsInactive); 
*/
            /// <summary>
            /// static  T FindFirstObjectByType()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindFirstObjectByType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint FIND_FIRST_OBJECT_BY_TYPE(); 
*/
            /// <summary>
            /// static  T FindFirstObjectByType(UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindFirstObjectByType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsInactive", 0)]
            public static partial nint FIND_FIRST_OBJECT_BY_TYPE(UnityEngine.FindObjectsInactive findObjectsInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindFirstObjectByType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindFirstObjectByType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_FIRST_OBJECT_BY_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindFirstObjectByType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsInactive", 1)]
            public static partial nint FIND_FIRST_OBJECT_BY_TYPE(nint type, UnityEngine.FindObjectsInactive findObjectsInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name = "instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectFromInstanceID", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint FIND_OBJECT_FROM_INSTANCE_ID(System.Int32 instanceID); 
*/
            /// <summary>
            /// static  T FindObjectOfType()
            /// </summary>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectOfType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint FIND_OBJECT_OF_TYPE(); 
*/
            /// <summary>
            /// static  T FindObjectOfType(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectOfType", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public static partial nint FIND_OBJECT_OF_TYPE(System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectOfType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECT_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object FindObjectOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectOfType", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial nint FIND_OBJECT_OF_TYPE(nint type, System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsByType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsSortMode", 1)]
            public static partial nint FIND_OBJECTS_BY_TYPE(nint type, UnityEngine.FindObjectsSortMode sortMode); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <param name = "sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsByType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsInactive", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsSortMode", 2)]
            public static partial nint FIND_OBJECTS_BY_TYPE(nint type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode); 
*/
            /// <summary>
            /// static  T[] FindObjectsByType(UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name = "sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsByType", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsSortMode", 0)]
            public static partial nint FIND_OBJECTS_BY_TYPE(UnityEngine.FindObjectsSortMode sortMode); 
*/
            /// <summary>
            /// static  T[] FindObjectsByType(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode)
            /// </summary>
            /// <param name = "findObjectsInactive">enum UnityEngine.FindObjectsInactive</param>
            /// <param name = "sortMode">enum UnityEngine.FindObjectsSortMode</param>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsByType", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsInactive", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.FindObjectsSortMode", 1)]
            public static partial nint FIND_OBJECTS_BY_TYPE(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECTS_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfType(System.Type type, System.Boolean includeInactive)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 1)]
            public static partial nint FIND_OBJECTS_OF_TYPE(nint type, System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  T[] FindObjectsOfType()
            /// </summary>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial nint FIND_OBJECTS_OF_TYPE(); 
*/
            /// <summary>
            /// static  T[] FindObjectsOfType(System.Boolean includeInactive)
            /// </summary>
            /// <param name = "includeInactive">struct System.Boolean</param>
            /// <returns>class T[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfType", "T[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public static partial nint FIND_OBJECTS_OF_TYPE(System.Boolean includeInactive); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfTypeAll", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECTS_OF_TYPE_ALL(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindObjectsOfTypeIncludingAssets", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_OBJECTS_OF_TYPE_INCLUDING_ASSETS(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object[] FindSceneObjectsOfType(System.Type type)
            /// </summary>
            /// <param name = "type">abstract class System.Type</param>
            /// <returns>class UnityEngine.Object[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindSceneObjectsOfType", "UnityEngine.Object[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Type", 0)]
            public static partial nint FIND_SCENE_OBJECTS_OF_TYPE(nint type); 
*/
            /// <summary>
            /// static  UnityEngine.Object ForceLoadFromInstanceID(System.Int32 instanceID)
            /// </summary>
            /// <param name = "instanceID">struct System.Int32</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ForceLoadFromInstanceID", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public static partial nint FORCE_LOAD_FROM_INSTANCE_ID(System.Int32 instanceID); 
*/
            /// <summary>
            /// static  System.String GetName(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetName", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint GET_NAME(nint obj); 
*/
            /// <summary>
            /// static  System.Int32 GetOffsetOfInstanceIDInCPlusPlusObject()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetOffsetOfInstanceIDInCPlusPlusObject", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial System.Int32 GET_OFFSET_OF_INSTANCE_ID_IN_C_PLUS_PLUS_OBJECT(); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 3)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint INSTANTIATE(nint original); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.SceneManagement.Scene scene)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "scene">struct UnityEngine.SceneManagement.Scene</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SceneManagement.Scene", 1)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.SceneManagement.Scene scene); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            public static partial nint INSTANTIATE(nint original, nint parent); 
*/
            /// <summary>
            /// static  UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, System.Boolean instantiateInWorldSpace)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "instantiateInWorldSpace">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint INSTANTIATE(nint original, nint parent, System.Boolean instantiateInWorldSpace); 
*/
            /// <summary>
            /// static  T Instantiate(T original)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public static partial nint INSTANTIATE(nint original); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 3)]
            public static partial nint INSTANTIATE(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, nint parent); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            public static partial nint INSTANTIATE(nint original, nint parent); 
*/
            /// <summary>
            /// static  T Instantiate(T original, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "worldPositionStays">struct System.Boolean</param>
            /// <returns>class T</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Instantiate", "T", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint INSTANTIATE(nint original, nint parent, System.Boolean worldPositionStays); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            public static partial nint INSTANTIATE_ASYNC(nint original); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            public static partial nint INSTANTIATE_ASYNC(nint original, nint parent); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INSTANTIATE_ASYNC(nint original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 3)]
            public static partial nint INSTANTIATE_ASYNC(nint original, nint parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.Transform parent)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 2)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count, nint parent); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 3)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "positions">struct System.ReadOnlySpan<UnityEngine.Vector3></param>
            /// <param name = "rotations">struct System.ReadOnlySpan<UnityEngine.Quaternion></param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ReadOnlySpan<UnityEngine.Vector3>", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ReadOnlySpan<UnityEngine.Quaternion>", 3)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "position">struct UnityEngine.Vector3</param>
            /// <param name = "rotation">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 4)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count, nint parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync(T original, System.Int32 count, UnityEngine.Transform parent, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations)
            /// </summary>
            /// <param name = "original">class T</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "positions">struct System.ReadOnlySpan<UnityEngine.Vector3></param>
            /// <param name = "rotations">struct System.ReadOnlySpan<UnityEngine.Quaternion></param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation<T></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InstantiateAsync", "UnityEngine.AsyncInstantiateOperation<T>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("T", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ReadOnlySpan<UnityEngine.Vector3>", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.ReadOnlySpan<UnityEngine.Quaternion>", 4)]
            public static partial nint INSTANTIATE_ASYNC(nint original, System.Int32 count, nint parent, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingle", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint INTERNAL_CLONE_SINGLE(nint data); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, System.Boolean worldPositionStays)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "worldPositionStays">struct System.Boolean</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingleWithParent", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 2)]
            public static partial nint INTERNAL_CLONE_SINGLE_WITH_PARENT(nint data, nint parent, System.Boolean worldPositionStays); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithScene(UnityEngine.Object data, UnityEngine.SceneManagement.Scene scene)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "scene">struct UnityEngine.SceneManagement.Scene</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingleWithScene", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SceneManagement.Scene", 1)]
            public static partial nint INTERNAL_CLONE_SINGLE_WITH_SCENE(nint data, UnityEngine.SceneManagement.Scene scene); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_CloneSingleWithScene_Injected(UnityEngine.Object data, UnityEngine.SceneManagement.Scene& scene)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "scene">struct UnityEngine.SceneManagement.Scene&</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_CloneSingleWithScene_Injected", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.SceneManagement.Scene&", 1)]
            public static partial nint INTERNAL_CLONE_SINGLE_WITH_SCENE_INJECTED(nint data, UnityEngine.SceneManagement.Scene &scene); 
*/
            /// <summary>
            /// static  UnityEngine.AsyncInstantiateOperation Internal_InstantiateAsyncWithParent(UnityEngine.Object original, System.Int32 count, UnityEngine.Transform parent, System.IntPtr positions, System.Int32 positionsCount, System.IntPtr rotations, System.Int32 rotationsCount)
            /// </summary>
            /// <param name = "original">class UnityEngine.Object</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "positions">struct System.IntPtr</param>
            /// <param name = "positionsCount">struct System.Int32</param>
            /// <param name = "rotations">struct System.IntPtr</param>
            /// <param name = "rotationsCount">struct System.Int32</param>
            /// <returns>class UnityEngine.AsyncInstantiateOperation</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateAsyncWithParent", "UnityEngine.AsyncInstantiateOperation", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.IntPtr", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 6)]
            public static partial nint INTERNAL_INSTANTIATE_ASYNC_WITH_PARENT(nint original, System.Int32 count, nint parent, System.IntPtr positions, System.Int32 positionsCount, System.IntPtr rotations, System.Int32 rotationsCount); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <param name = "rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingle", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 2)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE(nint data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "pos">struct UnityEngine.Vector3&</param>
            /// <param name = "rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingle_Injected", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion&", 2)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE_INJECTED(nint data, UnityEngine.Vector3 &pos, UnityEngine.Quaternion &rot); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "pos">struct UnityEngine.Vector3</param>
            /// <param name = "rot">struct UnityEngine.Quaternion</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingleWithParent", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion", 3)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT(nint data, nint parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot); 
*/
            /// <summary>
            /// static  UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3& pos, UnityEngine.Quaternion& rot)
            /// </summary>
            /// <param name = "data">class UnityEngine.Object</param>
            /// <param name = "parent">class UnityEngine.Transform</param>
            /// <param name = "pos">struct UnityEngine.Vector3&</param>
            /// <param name = "rot">struct UnityEngine.Quaternion&</param>
            /// <returns>class UnityEngine.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Internal_InstantiateSingleWithParent_Injected", "UnityEngine.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Transform", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3&", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Quaternion&", 3)]
            public static partial nint INTERNAL_INSTANTIATE_SINGLE_WITH_PARENT_INJECTED(nint data, nint parent, UnityEngine.Vector3 &pos, UnityEngine.Quaternion &rot); 
*/
            /// <summary>
            /// static  System.Boolean IsNativeObjectAlive(UnityEngine.Object o)
            /// </summary>
            /// <param name = "o">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsNativeObjectAlive", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean IS_NATIVE_OBJECT_ALIVE(nint o); 
*/
            /// <summary>
            /// static  System.Boolean IsPersistent(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsPersistent", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean IS_PERSISTENT(nint obj); 
*/
            /// <summary>
            /// static  System.Boolean op_Equality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name = "x">class UnityEngine.Object</param>
            /// <param name = "y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Equality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 1)]
            public static partial System.Boolean OP_EQUALITY(nint x, nint y); 
*/
            /// <summary>
            /// static  System.Boolean op_Implicit(UnityEngine.Object exists)
            /// </summary>
            /// <param name = "exists">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Implicit", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial System.Boolean OP_IMPLICIT(nint exists); 
*/
            /// <summary>
            /// static  System.Boolean op_Inequality(UnityEngine.Object x, UnityEngine.Object y)
            /// </summary>
            /// <param name = "x">class UnityEngine.Object</param>
            /// <param name = "y">class UnityEngine.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("op_Inequality", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 1)]
            public static partial System.Boolean OP_INEQUALITY(nint x, nint y); 
*/
            /// <summary>
            /// static  System.Void SetName(UnityEngine.Object obj, System.String name)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <param name = "name">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetName", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public static partial void SET_NAME(nint obj, nint name); 
*/
            /// <summary>
            /// static  System.String ToString(UnityEngine.Object obj)
            /// </summary>
            /// <param name = "obj">class UnityEngine.Object</param>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Object", 0)]
            public static partial nint TO_STRING(nint obj); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void EnsureRunningOnMainThread()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EnsureRunningOnMainThread", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ENSURE_RUNNING_ON_MAIN_THREAD(); 
*/
            /// <summary>
            ///   System.Boolean Equals(System.Object other)
            /// </summary>
            /// <param name = "other">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Equals", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial System.Boolean EQUALS(nint other); 
*/
            /// <summary>
            ///   UnityEngine.HideFlags get_hideFlags()
            /// </summary>
            /// <returns>enum UnityEngine.HideFlags</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_hideFlags", "UnityEngine.HideFlags", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial UnityEngine.HideFlags GET_HIDE_FLAGS(); 
*/
            /// <summary>
            ///   System.String get_name()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_name", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_NAME(); 
*/
            /// <summary>
            ///   System.IntPtr GetCachedPtr()
            /// </summary>
            /// <returns>struct System.IntPtr</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetCachedPtr", "System.IntPtr", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.IntPtr GET_CACHED_PTR(); 
*/
            /// <summary>
            ///   System.Int32 GetHashCode()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetHashCode", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_HASH_CODE(); 
*/
            /// <summary>
            ///   System.Int32 GetInstanceID()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetInstanceID", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_INSTANCE_ID(); 
*/
            /// <summary>
            ///   System.Void MarkDirty()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("MarkDirty", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void MARK_DIRTY(); 
*/
            /// <summary>
            ///   System.Void set_hideFlags(UnityEngine.HideFlags value)
            /// </summary>
            /// <param name = "value">enum UnityEngine.HideFlags</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_hideFlags", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.HideFlags", 0)]
            public partial void SET_HIDE_FLAGS(UnityEngine.HideFlags value); 
*/
            /// <summary>
            ///   System.Void set_name(System.String value)
            /// </summary>
            /// <param name = "value">class System.String</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_name", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 0)]
            public partial void SET_NAME(nint value); 
*/
            /// <summary>
            ///   System.String ToString()
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToString", "System.String", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint TO_STRING(); 
*/
        }
    }
}