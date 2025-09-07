using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeAnimStrayRadius_t : SchemaClass, IFeAnimStrayRadius_t {

  public FeAnimStrayRadius_t(nint handle) : base(handle) {
  }

  public FeAnimStrayRadius_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint16> Node {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0xF06BE9BCD6694B9));
  }
  public ref float MaxDist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF06BE9BC9FFDD57));
  }
  public ref float RelaxationFactor {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF06BE9B357F3BFF));
  }


}