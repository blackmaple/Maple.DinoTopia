namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem.World"."ActorStateSubsystem"]
    /// [Game.Script.Subsystem.WorldSubsystem]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ActorStateSubsystem>, Ptr_ActorStateSubsystem>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "Game.Script.Subsystem.World", "ActorStateSubsystem", "Game.Script.Subsystem.World.ActorStateSubsystem")]
    public partial class ActorStateSubsystem
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ActorStateSubsystem(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ActorStateSubsystem(System.IntPtr ptr) => new Ptr_ActorStateSubsystem(ptr);
            public static implicit operator System.IntPtr(Ptr_ActorStateSubsystem ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_ActorStateSubsystem ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem.World"."ActorStateSubsystem"]
        /// </summary>
        partial struct Ptr_ActorStateSubsystem
        {
            /// <summary>
            /// 0x10 Game.Script.Common.World <World>k__BackingField
            /// class ["Assembly-CSharp.dll"."Game.Script.Common"."World"]
            /// </summary>
            /// <returns>class Game.Script.Common.World</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<World>k__BackingField", "Game.Script.Common.World")]
            public partial nint WORLD { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Collections.Generic.List<Game.Script.Common.Actor> Actors
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Game.Script.Common.Actor></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Actors", "System.Collections.Generic.List<Game.Script.Common.Actor>")]
            public partial nint ACTORS { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<UnityEngine.Transform> _transforms
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<UnityEngine.Transform></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_transforms", "System.Collections.Generic.List<UnityEngine.Transform>")]
            public partial nint _TRANSFORMS { get; set; } 
*/

            /// <summary>
            /// 0x28 Game.Script.Subsystem.World.ActorStateSubsystem.UpdateJob _updateJob
            /// struct ["Assembly-CSharp.dll".""."UpdateJob"]
            /// </summary>
            /// <returns>struct Game.Script.Subsystem.World.ActorStateSubsystem.UpdateJob</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_updateJob", "Game.Script.Subsystem.World.ActorStateSubsystem.UpdateJob")]
            public partial Game.Script.Subsystem.World.ActorStateSubsystem.UpdateJob _UPDATE_JOB { get; set; } 
*/

            /// <summary>
            /// 0x30 UnityEngine.Jobs.TransformAccessArray _transformAccessArray
            /// struct ["UnityEngine.CoreModule.dll"."UnityEngine.Jobs"."TransformAccessArray"]
            /// </summary>
            /// <returns>struct UnityEngine.Jobs.TransformAccessArray</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_transformAccessArray", "UnityEngine.Jobs.TransformAccessArray")]
            public partial UnityEngine.Jobs.TransformAccessArray _TRANSFORM_ACCESS_ARRAY { get; set; } 
*/

            /// <summary>
            /// 0x38 Unity.Jobs.JobHandle _updateJobHandle
            /// struct ["UnityEngine.CoreModule.dll"."Unity.Jobs"."JobHandle"]
            /// </summary>
            /// <returns>struct Unity.Jobs.JobHandle</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_updateJobHandle", "Unity.Jobs.JobHandle")]
            public partial Unity.Jobs.JobHandle _UPDATE_JOB_HANDLE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem.World"."ActorStateSubsystem"]
        /// </summary>
        partial struct Ptr_ActorStateSubsystem
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
            ///   System.Void Add(Game.Script.Common.Actor actor)
            /// </summary>
            /// <param name = "actor">class Game.Script.Common.Actor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Add", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.Actor", 0)]
            public partial void ADD(nint actor); 
*/
            /// <summary>
            ///   System.Void Clear()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clear", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR(); 
*/
            /// <summary>
            ///   System.Void OnApplicationQuit()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnApplicationQuit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_APPLICATION_QUIT(); 
*/
            /// <summary>
            ///   System.Void OnBeginJobs()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnBeginJobs", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_BEGIN_JOBS(); 
*/
            /// <summary>
            ///   System.Void OnEndJobs()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnEndJobs", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_END_JOBS(); 
*/
            /// <summary>
            ///   System.Void OnInitialize()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnInitialize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_INITIALIZE(); 
*/
            /// <summary>
            ///   System.Void Remove(Game.Script.Common.Actor actor)
            /// </summary>
            /// <param name = "actor">class Game.Script.Common.Actor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Remove", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.Actor", 0)]
            public partial void REMOVE(nint actor); 
*/
            /// <summary>
            ///   System.Void UpdateActorTransform(System.Int32 index, UnityEngine.Jobs.TransformAccess transform)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "transform">struct UnityEngine.Jobs.TransformAccess</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateActorTransform", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Jobs.TransformAccess", 1)]
            public partial void UPDATE_ACTOR_TRANSFORM(System.Int32 index, UnityEngine.Jobs.TransformAccess transform); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp.dll"."Game.Script.Subsystem"."WorldSubsystem"]
        /// </summary>
        partial struct Ptr_ActorStateSubsystem
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
            ///   System.Boolean get_IsUseful()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsUseful", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean GET_IS_USEFUL(); 
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
            ///   System.Void OnApplicationQuit()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnApplicationQuit", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_APPLICATION_QUIT(); 
*/
            /// <summary>
            ///   System.Void OnBeginEnterGame()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnBeginEnterGame", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_BEGIN_ENTER_GAME(); 
*/
            /// <summary>
            ///   System.Void OnInitialize()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnInitialize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void ON_INITIALIZE(); 
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
        }
    }
}