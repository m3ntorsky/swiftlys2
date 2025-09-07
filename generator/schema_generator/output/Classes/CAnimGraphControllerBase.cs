using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimGraphControllerBase : SchemaClass, IAnimGraphControllerBase {

  public CAnimGraphControllerBase(nint handle) : base(handle) {
  }

  public CAnimGraphControllerBase(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVectorFixedGrowable< CGlobalSymbol, 8 > ParamsToResetInPostGraphUpdate {
    get => ref _Handle.AsRef<CUtlVectorFixedGrowable< CGlobalSymbol, 8 >>(Schema.GetOffset(0x1AA25B60A3E3A289));
  }


}