using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class audioparams_t : SchemaClass, Iaudioparams_t {

  public audioparams_t(nint handle) : base(handle) {
  }



  public void LocalSoundUpdated() {
    Schema.Update(_Handle, 0x6D349E3CCE184A47);
  }
  public void SoundscapeIndexUpdated() {
    Schema.Update(_Handle, 0x6D349E3C046FCFEE);
  }
  public void LocalBitsUpdated() {
    Schema.Update(_Handle, 0x6D349E3C1DE85B60);
  }
  public void SoundscapeEntityListIndexUpdated() {
    Schema.Update(_Handle, 0x6D349E3CA4E4FB9B);
  }
  public void SoundEventHashUpdated() {
    Schema.Update(_Handle, 0x6D349E3C335E17CC);
  }
}