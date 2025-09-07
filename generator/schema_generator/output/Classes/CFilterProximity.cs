using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterProximity : CBaseFilter, IFilterProximity {

  public CFilterProximity(nint handle) : base(handle) {
  }

  public CFilterProximity(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE1C36A555ACFC08D));
  }


}