using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundEventOBBEntity : CSoundEventEntity, ISoundEventOBBEntity {

  public CSoundEventOBBEntity(nint handle) : base(handle) {
  }



  public void MinsUpdated() {
    Schema.Update(_Handle, 0x470330BB421BB730);
  }
  public void MaxsUpdated() {
    Schema.Update(_Handle, 0x470330BBC0C1CE6A);
  }
}