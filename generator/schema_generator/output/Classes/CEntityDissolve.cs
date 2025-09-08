using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEntityDissolve : CBaseModelEntity, IEntityDissolve {

  public CEntityDissolve(nint handle) : base(handle) {
  }



  public void FadeInStartUpdated() {
    Schema.Update(_Handle, 0x443F205EF5AD2D6A);
  }
  public void FadeInLengthUpdated() {
    Schema.Update(_Handle, 0x443F205E74538EE6);
  }
  public void FadeOutModelStartUpdated() {
    Schema.Update(_Handle, 0x443F205E9C8AC6F4);
  }
  public void FadeOutModelLengthUpdated() {
    Schema.Update(_Handle, 0x443F205E6FC0EC34);
  }
  public void FadeOutStartUpdated() {
    Schema.Update(_Handle, 0x443F205E3F5B2209);
  }
  public void FadeOutLengthUpdated() {
    Schema.Update(_Handle, 0x443F205E9D0749A3);
  }
  public void StartTimeUpdated() {
    Schema.Update(_Handle, 0x443F205E67FE9DC4);
  }
  public void DissolveTypeUpdated() {
    Schema.Update(_Handle, 0x443F205E79AB525E);
  }
  public void DissolverOriginUpdated() {
    Schema.Update(_Handle, 0x443F205E34A16EE6);
  }
  public void MagnitudeUpdated() {
    Schema.Update(_Handle, 0x443F205E0C71BDF1);
  }
}