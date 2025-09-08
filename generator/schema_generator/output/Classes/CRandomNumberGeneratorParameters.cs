using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRandomNumberGeneratorParameters : SchemaClass, IRandomNumberGeneratorParameters {

  public CRandomNumberGeneratorParameters(nint handle) : base(handle) {
  }

  public ref bool DistributeEvenly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x60FDB8F9BED90721));
  }
  public ref int Seed {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x60FDB8F99A113550));
  }


}