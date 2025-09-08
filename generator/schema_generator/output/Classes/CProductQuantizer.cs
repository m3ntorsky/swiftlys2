using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CProductQuantizer : SchemaClass, IProductQuantizer {

  public CProductQuantizer(nint handle) : base(handle) {
  }

  public ref CUtlVector SubQuantizers {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x5B1A8128593CF0B5));
  }
  public ref int Dimensions {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5B1A81282D8795AC));
  }


}