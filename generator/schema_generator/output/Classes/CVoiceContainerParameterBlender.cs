using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerParameterBlender : CVoiceContainerBase, IVoiceContainerParameterBlender {

  public CVoiceContainerParameterBlender(nint handle) : base(handle) {
  }

  public ISoundContainerReference FirstSound {
    get => new CSoundContainerReference(_Handle + Schema.GetOffset(0xEC5F1A42666B0138));
  }
  public ISoundContainerReference SecondSound {
    get => new CSoundContainerReference(_Handle + Schema.GetOffset(0xEC5F1A42A2BC3E5C));
  }
  public ref bool EnableOcclusionBlend {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEC5F1A42041C67C2));
  }
  public ISchemaUntypedField Curve1 {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xEC5F1A423B9F58DF));
  }
  public ISchemaUntypedField Curve2 {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xEC5F1A423C9F5A72));
  }
  public ref bool EnableDistanceBlend {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xEC5F1A428EDC5388));
  }
  public ISchemaUntypedField Curve3 {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xEC5F1A423D9F5C05));
  }
  public ISchemaUntypedField Curve4 {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xEC5F1A42369F5100));
  }


}