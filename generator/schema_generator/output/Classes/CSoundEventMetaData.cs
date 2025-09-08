using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundEventMetaData : SchemaClass, ISoundEventMetaData {

  public CSoundEventMetaData(nint handle) : base(handle) {
  }

  public CStrongHandle<IInfoForResourceTypeCVMixListResource> SoundEventVMix {
    get => new CStrongHandle<InfoForResourceTypeCVMixListResource>(_Handle + Schema.GetOffset(0xE03E2D8ED7B83398));
  }


}