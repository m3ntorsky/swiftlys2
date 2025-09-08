using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFlexRule : SchemaClass, IFlexRule {

  public CFlexRule(nint handle) : base(handle) {
  }

  public ref int Flex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA92320A3D3DC2E86));
  }
  public ref CUtlVector FlexOps {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA92320A3F3F4D8D2));
  }


}