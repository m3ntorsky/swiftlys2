using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeAnimStrayRadius_t : SchemaClass, IFeAnimStrayRadius_t {

  public FeAnimStrayRadius_t(nint handle) : base(handle) {
  }

  public ISchemaFixedArray<ushort> Node {
    get => new SchemaFixedArray<ushort>(_Handle, 0xF06BE9BCD6694B9, 2, 2, 2);
  }
  public ref float MaxDist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF06BE9BC9FFDD57));
  }
  public ref float RelaxationFactor {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF06BE9B357F3BFF));
  }


}