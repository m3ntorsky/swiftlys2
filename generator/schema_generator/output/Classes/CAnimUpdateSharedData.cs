using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimUpdateSharedData : SchemaClass, IAnimUpdateSharedData {

  public CAnimUpdateSharedData(nint handle) : base(handle) {
  }

  public ref CUtlVector Nodes {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA294DB47780F027A));
  }
  public ISchemaUntypedField NodeIndexMap {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xA294DB47D3B3E7A3));
  }
  public ref CUtlVector Components {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA294DB47F87FC409));
  }
  public ISchemaUntypedField ParamListUpdater {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xA294DB4784AA7F15));
  }
  public ISchemaUntypedField TagManagerUpdater {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xA294DB47432E460D));
  }
  public ISchemaUntypedField ScriptManager {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xA294DB47F4257D31));
  }
  public IAnimGraphSettingsManager Settings {
    get => new CAnimGraphSettingsManager(_Handle + Schema.GetOffset(0xA294DB47B3DE33A8));
  }
  public ISchemaUntypedField StaticPoseCache {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xA294DB475BFC0C1E));
  }
  public ISchemaUntypedField Skeleton {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xA294DB4744BBF688));
  }
  public IAnimNodePath RootNodePath {
    get => new CAnimNodePath(_Handle + Schema.GetOffset(0xA294DB476893B9EE));
  }


}