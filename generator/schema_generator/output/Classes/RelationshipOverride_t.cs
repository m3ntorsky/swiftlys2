using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RelationshipOverride_t : Relationship_t, IRelationshipOverride_t {

  public RelationshipOverride_t(nint handle) : base(handle) {
  }

  public CHandle<IBaseEntity> Entity {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x2EECEBE0D33FF5DA));
  }
  public ref Class_T ClassType {
    get => ref _Handle.AsRef<Class_T>(Schema.GetOffset(0x2EECEBE040A47427));
  }


}