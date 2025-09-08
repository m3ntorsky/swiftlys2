using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundAreaEntityBase : CBaseEntity, ISoundAreaEntityBase {

  public CSoundAreaEntityBase(nint handle) : base(handle) {
  }



  public void DisabledUpdated() {
    Schema.Update(_Handle, 0x15C90E163A7C5965);
  }
  public void SoundAreaTypeUpdated() {
    Schema.Update(_Handle, 0x15C90E16227612E5);
  }
  public void PosUpdated() {
    Schema.Update(_Handle, 0x15C90E16DE9CFC5D);
  }
}