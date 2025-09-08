using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ParticleNamedValueConfiguration_t : SchemaClass, IParticleNamedValueConfiguration_t {

  public ParticleNamedValueConfiguration_t(nint handle) : base(handle) {
  }

  public ref CUtlString ConfigName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x4C42AD0EA7B74064));
  }
  public ISchemaUntypedField ConfigValue {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x4C42AD0ECF981D3C));
  }
  public ref ParticleAttachment_t AttachType {
    get => ref _Handle.AsRef<ParticleAttachment_t>(Schema.GetOffset(0x4C42AD0E432E8381));
  }
  public ref CUtlString BoundEntityPath {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x4C42AD0E45A442E3));
  }
  public ref CUtlString StrEntityScope {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x4C42AD0ECCAF0621));
  }
  public ref CUtlString StrAttachmentName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x4C42AD0EEB143B4E));
  }


}