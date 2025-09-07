using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RenderHairStrandInfo_t : SchemaClass, IRenderHairStrandInfo_t {

  public RenderHairStrandInfo_t(nint handle) : base(handle) {
  }

  public RenderHairStrandInfo_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint32> GuideHairIndices_nSurfaceTriIndex {
    get => new SchemaFixedArray<uint32>(_Handle + Schema.GetOffset(0x9037AEC699AC7193));
  }
  public ISchemaFixedArray<uint16> GuideBary_vBaseBary {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x9037AEC6B3848BF7));
  }
  public ISchemaFixedArray<uint16> RootOffset_flLengthScale {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x9037AEC67324D845));
  }
  public ISchemaFixedArray<uint16> PackedBaseUv {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x9037AEC6D5457D8B));
  }
  public ref uint PackedSurfaceNormalOs {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x9037AEC605444631));
  }
  public ref uint PackedSurfaceTangentOs {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x9037AEC6FD9896F7));
  }
  public ref uint DataOffset_Segments {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x9037AEC6BB31BC1D));
  }


}