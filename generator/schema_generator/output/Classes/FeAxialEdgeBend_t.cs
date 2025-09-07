using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeAxialEdgeBend_t : SchemaClass, IFeAxialEdgeBend_t {

  public FeAxialEdgeBend_t(nint handle) : base(handle) {
  }

  public FeAxialEdgeBend_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Te {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6CF84D703C453EB2));
  }
  public ref float Tv {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6CF84D704B45564F));
  }
  public ref float Dist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6CF84D701234268F));
  }
  public ISchemaFixedArray<float32> Weight {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0x6CF84D70CFFC66CB));
  }
  public ISchemaFixedArray<uint16> Node {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x6CF84D70CD6694B9));
  }


}