using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSceneObjectData : SchemaClass, ISceneObjectData {

  public CSceneObjectData(nint handle) : base(handle) {
  }

  public ref Vector MinBounds {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x628AC6A9114799FE));
  }
  public ref Vector MaxBounds {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x628AC6A9C0B4CE60));
  }
  public ISchemaUntypedField DrawCalls {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x628AC6A9CA953770));
  }
  public ISchemaUntypedField DrawBounds {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x628AC6A96CBBD6CE));
  }
  public ISchemaUntypedField Meshlets {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x628AC6A928865C36));
  }
  public ref Vector4D TintColor {
    get => ref _Handle.AsRef<Vector4D>(Schema.GetOffset(0x628AC6A950AFF21F));
  }


}