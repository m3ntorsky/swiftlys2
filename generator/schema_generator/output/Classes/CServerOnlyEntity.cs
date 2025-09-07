using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CServerOnlyEntity : CBaseEntity, IServerOnlyEntity {

  public CServerOnlyEntity(nint handle) : base(handle) {
  }

  public CServerOnlyEntity(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}