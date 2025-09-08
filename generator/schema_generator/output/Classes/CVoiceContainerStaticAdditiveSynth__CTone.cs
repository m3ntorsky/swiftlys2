using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerStaticAdditiveSynth__CTone : SchemaClass, IVoiceContainerStaticAdditiveSynth__CTone {

  public CVoiceContainerStaticAdditiveSynth__CTone(nint handle) : base(handle) {
  }

  public ref CUtlVector Harmonics {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1501082A3A08CDBF));
  }
  public ISchemaUntypedField Curve {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1501082ABFFA0B34));
  }
  public ref bool SyncInstances {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1501082A21EE9902));
  }


}