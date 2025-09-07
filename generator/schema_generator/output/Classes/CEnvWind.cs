using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvWind : CBaseEntity, IEnvWind {

  public CEnvWind(nint handle) : base(handle) {
  }

  public CEnvWind(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEnvWindShared EnvWindShared {
    get => new CEnvWindShared(_Handle + Schema.GetOffset(0x39465FB775DDCB0F));
  }

  public void EnvWindSharedUpdated() {
    Schema.Update(_Handle, 0x39465FB775DDCB0F);
  }
}