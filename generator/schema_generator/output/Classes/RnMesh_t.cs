using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RnMesh_t : SchemaClass, IRnMesh_t {

  public RnMesh_t(nint handle) : base(handle) {
  }

  public RnMesh_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Min {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5F23FA63F4B0AA63));
  }
  public ref Vector Max {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5F23FA63EAC4225D));
  }
  public ref CUtlVector< RnNode_t > Nodes {
    get => ref _Handle.AsRef<CUtlVector< RnNode_t >>(Schema.GetOffset(0x5F23FA63EBA045DA));
  }
  public ref CUtlVectorSIMDPaddedVector Vertices {
    get => ref _Handle.AsRef<CUtlVectorSIMDPaddedVector>(Schema.GetOffset(0x5F23FA63E4F9760E));
  }
  public ref CUtlVector< RnTriangle_t > Triangles {
    get => ref _Handle.AsRef<CUtlVector< RnTriangle_t >>(Schema.GetOffset(0x5F23FA6365BD00C2));
  }
  public ref CUtlVector< RnWing_t > Wings {
    get => ref _Handle.AsRef<CUtlVector< RnWing_t >>(Schema.GetOffset(0x5F23FA63B34C1A4B));
  }
  public ref CUtlVector< uint8 > TriangleEdgeFlags {
    get => ref _Handle.AsRef<CUtlVector< uint8 >>(Schema.GetOffset(0x5F23FA6379FF46EF));
  }
  public ref CUtlVector< uint8 > Materials {
    get => ref _Handle.AsRef<CUtlVector< uint8 >>(Schema.GetOffset(0x5F23FA639E4B1B69));
  }
  public ref Vector OrthographicAreas {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5F23FA63B74855D3));
  }
  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x5F23FA63CE6E9C28));
  }
  public ref uint DebugFlags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x5F23FA6321AEBFEF));
  }


}