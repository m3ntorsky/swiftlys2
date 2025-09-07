using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysicsBodyGameMarkupData : SchemaClass, IPhysicsBodyGameMarkupData {

  public CPhysicsBodyGameMarkupData(nint handle) : base(handle) {
  }

  public CPhysicsBodyGameMarkupData(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField PhysicsBodyMarkupByBoneName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x29262AE188A1FE22));
  }


}