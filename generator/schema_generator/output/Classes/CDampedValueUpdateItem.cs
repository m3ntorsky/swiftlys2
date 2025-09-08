using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDampedValueUpdateItem : SchemaClass, IDampedValueUpdateItem {

  public CDampedValueUpdateItem(nint handle) : base(handle) {
  }

  public IAnimInputDamping Damping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0x4B11725415440FB5));
  }
  public IAnimParamHandle ParamIn {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x4B117254ED40E37B));
  }
  public IAnimParamHandle ParamOut {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x4B117254AA5799A8));
  }


}