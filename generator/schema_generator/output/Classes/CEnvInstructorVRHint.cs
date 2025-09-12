using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvInstructorVRHint : CPointEntity, IEnvInstructorVRHint {

  public CEnvInstructorVRHint(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Name {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x75F3B61F74FF65FE));
  }
  public ISchemaUntypedField HintTargetEntity {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x75F3B61F0024C1BE));
  }
  public ref int Timeout {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x75F3B61F2EC6CDDF));
  }
  public ISchemaUntypedField Caption {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x75F3B61FBE8E34DD));
  }
  public ISchemaUntypedField StartSound {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x75F3B61FF9B2297E));
  }
  public ref int LayoutFileType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x75F3B61FAB45B364));
  }
  public ISchemaUntypedField CustomLayoutFile {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x75F3B61F60A92CB6));
  }
  public ref int AttachType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x75F3B61F432E8381));
  }
  public ref float HeightOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x75F3B61F2D0C5BF3));
  }


}