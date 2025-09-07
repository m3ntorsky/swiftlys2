using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvBeverage : CBaseEntity, IEnvBeverage {

  public CEnvBeverage(nint handle) : base(handle) {
  }

  public CEnvBeverage(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool CanInDispenser {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x205E38FCDFB6F3B5));
  }
  public ref int BeverageType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x205E38FC694E74C8));
  }


}