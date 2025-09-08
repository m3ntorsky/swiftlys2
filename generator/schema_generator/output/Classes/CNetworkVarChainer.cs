using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNetworkVarChainer : SchemaClass, INetworkVarChainer {

  public CNetworkVarChainer(nint handle) : base(handle) {
  }

  public IChangeAccessorFieldPathIndex_t PathIndex {
    get => new ChangeAccessorFieldPathIndex_t(_Handle + Schema.GetOffset(0x6609CE852DA3F47A));
  }


}