using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CServerOnlyModelEntity : CBaseModelEntity, IServerOnlyModelEntity {

  public CServerOnlyModelEntity(nint handle) : base(handle) {
  }




}