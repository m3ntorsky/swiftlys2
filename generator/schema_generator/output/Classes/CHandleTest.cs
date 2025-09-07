using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CHandleTest : CBaseEntity, IHandleTest {

  public CHandleTest(nint handle) : base(handle) {
  }

  public CHandleTest(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CBaseEntity > Handle {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0xCC5023E89D208453));
  }
  public ref bool SendHandle {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xCC5023E8EACC8501));
  }

  public void HandleUpdated() {
    Schema.Update(_Handle, 0xCC5023E89D208453);
  }
  public void SendHandleUpdated() {
    Schema.Update(_Handle, 0xCC5023E8EACC8501);
  }
}