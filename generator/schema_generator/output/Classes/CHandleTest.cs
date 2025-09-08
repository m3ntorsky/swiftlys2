using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CHandleTest : CBaseEntity, IHandleTest {

  public CHandleTest(nint handle) : base(handle) {
  }



  public void HandleUpdated() {
    Schema.Update(_Handle, 0xCC5023E89D208453);
  }
  public void SendHandleUpdated() {
    Schema.Update(_Handle, 0xCC5023E8EACC8501);
  }
}