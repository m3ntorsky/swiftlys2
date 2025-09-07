using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFlexRule : SchemaClass, IFlexRule {

  public CFlexRule(nint handle) : base(handle) {
  }

  public CFlexRule(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Flex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA92320A3D3DC2E86));
  }
  public ref CUtlVector< CFlexOp > FlexOps {
    get => ref _Handle.AsRef<CUtlVector< CFlexOp >>(Schema.GetOffset(0xA92320A3F3F4D8D2));
  }


}