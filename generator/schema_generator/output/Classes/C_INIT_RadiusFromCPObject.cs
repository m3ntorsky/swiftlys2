using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RadiusFromCPObject : CParticleFunctionInitializer, IC_INIT_RadiusFromCPObject {

  public C_INIT_RadiusFromCPObject(nint handle) : base(handle) {
  }

  public C_INIT_RadiusFromCPObject(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC79B0CC80D0DDF8C));
  }


}