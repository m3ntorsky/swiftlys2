using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysicsWire : CBaseEntity, IPhysicsWire {

  public CPhysicsWire(nint handle) : base(handle) {
  }

  public CPhysicsWire(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Density {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x455AFD76A65E630F));
  }


}