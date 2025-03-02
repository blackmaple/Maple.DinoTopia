namespace Maple.DinoTopia.Metadata
{
    /// <summary>
    /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem.World"."LandDrawSubsystem"]
    /// [Game.Script.Subsystem.WorldSubsystem]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_LandDrawSubsystem>, Ptr_LandDrawSubsystem>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Assembly-CSharp.dll", "Game.Script.Subsystem.World", "LandDrawSubsystem", "Game.Script.Subsystem.World.LandDrawSubsystem")]
    public partial class LandDrawSubsystem
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_LandDrawSubsystem(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_LandDrawSubsystem(System.IntPtr ptr) => new Ptr_LandDrawSubsystem(ptr);
            public static implicit operator System.IntPtr(Ptr_LandDrawSubsystem ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_LandDrawSubsystem ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem.World"."LandDrawSubsystem"]
        /// </summary>
        partial struct Ptr_LandDrawSubsystem
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
            /// 0x18 System.Collections.Generic.List<Game.Script.Common.Actor> _actors
            /// class ["mscorlib.dll"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<Game.Script.Common.Actor></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_actors", "System.Collections.Generic.List<Game.Script.Common.Actor>")]
            public partial nint _ACTORS { get; set; } 
*/

            /// <summary>
            /// 0x20 UnityEngine.Mesh _mesh
            /// class ["UnityEngine.CoreModule.dll"."UnityEngine"."Mesh"]
            /// </summary>
            /// <returns>class UnityEngine.Mesh</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_mesh", "UnityEngine.Mesh")]
            public partial nint _MESH { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Boolean _reCreateMesh
            /// struct ["mscorlib.dll"."System"."Boolean"]
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_reCreateMesh", "System.Boolean")]
            public partial System.Boolean _RE_CREATE_MESH { get; set; } 
*/

            /// <summary>
            /// 0x30 Game.Script.Common.Actor <SelectActor>k__BackingField
            /// class ["Assembly-CSharp.dll"."Game.Script.Common"."Actor"]
            /// </summary>
            /// <returns>class Game.Script.Common.Actor</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("<SelectActor>k__BackingField", "Game.Script.Common.Actor")]
            public partial nint SELECT_ACTOR { get; set; } 
*/
        }

        /// <summary>
        /// class ["Assembly-CSharp.dll"."Game.Script.Subsystem.World"."LandDrawSubsystem"]
        /// </summary>
        partial struct Ptr_LandDrawSubsystem
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
            ///   System.Void CreateMesh(Game.Script.Map.MapBk bk, UnityEngine.Color baseLandColor, UnityEngine.Color selectColor)
            /// </summary>
            /// <param name = "bk">class Game.Script.Map.MapBk</param>
            /// <param name = "baseLandColor">struct UnityEngine.Color</param>
            /// <param name = "selectColor">struct UnityEngine.Color</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CreateMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.MapBk", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 2)]
            public partial void CREATE_MESH(nint bk, UnityEngine.Color baseLandColor, UnityEngine.Color selectColor); 
*/
            /// <summary>
            ///   System.Void Draw(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.RenderingData& renderingData, UnityEngine.Material material, UnityEngine.Color baseLandColor, UnityEngine.Color selectColor)
            /// </summary>
            /// <param name = "context">struct UnityEngine.Rendering.ScriptableRenderContext</param>
            /// <param name = "renderingData">struct UnityEngine.Rendering.Universal.RenderingData&</param>
            /// <param name = "material">class UnityEngine.Material</param>
            /// <param name = "baseLandColor">struct UnityEngine.Color</param>
            /// <param name = "selectColor">struct UnityEngine.Color</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Draw", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.ScriptableRenderContext", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Rendering.Universal.RenderingData&", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Material", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 4)]
            public partial void DRAW(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.RenderingData &renderingData, nint material, UnityEngine.Color baseLandColor, UnityEngine.Color selectColor); 
*/
            /// <summary>
            ///   System.Void DrawLand(UnityEngine.Color color, System.Int32 gridX, System.Int32 gridZ, UnityEngine.Vector3 start, Game.Script.Map.MapBk bk, System.Collections.Generic.List<UnityEngine.Vector3> vertices, System.Collections.Generic.List<UnityEngine.Vector2> uvs, System.Collections.Generic.List<UnityEngine.Color> colors, System.Int32 realLandRadius, System.Collections.Generic.List<System.Int32> indices, System.Int32& index)
            /// </summary>
            /// <param name = "color">struct UnityEngine.Color</param>
            /// <param name = "gridX">struct System.Int32</param>
            /// <param name = "gridZ">struct System.Int32</param>
            /// <param name = "start">struct UnityEngine.Vector3</param>
            /// <param name = "bk">class Game.Script.Map.MapBk</param>
            /// <param name = "vertices">class System.Collections.Generic.List<UnityEngine.Vector3></param>
            /// <param name = "uvs">class System.Collections.Generic.List<UnityEngine.Vector2></param>
            /// <param name = "colors">class System.Collections.Generic.List<UnityEngine.Color></param>
            /// <param name = "realLandRadius">struct System.Int32</param>
            /// <param name = "indices">class System.Collections.Generic.List<System.Int32></param>
            /// <param name = "index">struct System.Int32&</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("DrawLand", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Color", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UnityEngine.Vector3", 3)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Map.MapBk", 4)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Vector3>", 5)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Vector2>", 6)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<UnityEngine.Color>", 7)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 8)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.Int32>", 9)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 10)]
            public partial void DRAW_LAND(UnityEngine.Color color, System.Int32 gridX, System.Int32 gridZ, UnityEngine.Vector3 start, nint bk, nint vertices, nint uvs, nint colors, System.Int32 realLandRadius, nint indices, System.Int32 &index); 
*/
            /// <summary>
            ///   Game.Script.Common.Actor get_SelectActor()
            /// </summary>
            /// <returns>class Game.Script.Common.Actor</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SelectActor", "Game.Script.Common.Actor", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SELECT_ACTOR(); 
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
            ///   System.Void set_ReCreateMesh(System.Boolean value)
            /// </summary>
            /// <param name = "value">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_ReCreateMesh", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void SET_RE_CREATE_MESH(System.Boolean value); 
*/
            /// <summary>
            ///   System.Void set_SelectActor(Game.Script.Common.Actor value)
            /// </summary>
            /// <param name = "value">class Game.Script.Common.Actor</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_SelectActor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("Game.Script.Common.Actor", 0)]
            public partial void SET_SELECT_ACTOR(nint value); 
*/
        }

        /// <summary>
        /// abstract class ["Assembly-CSharp.dll"."Game.Script.Subsystem"."WorldSubsystem"]
        /// </summary>
        partial struct Ptr_LandDrawSubsystem
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