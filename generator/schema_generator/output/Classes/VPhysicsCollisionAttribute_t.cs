using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VPhysicsCollisionAttribute_t : SchemaClass, IVPhysicsCollisionAttribute_t {

  public VPhysicsCollisionAttribute_t(nint handle) : base(handle) {
  }



  public void InteractsAsUpdated() {
    Schema.Update(_Handle, 0x7E9FC931062B2708);
  }
  public void InteractsWithUpdated() {
    Schema.Update(_Handle, 0x7E9FC93139179720);
  }
  public void InteractsExcludeUpdated() {
    Schema.Update(_Handle, 0x7E9FC9314D765732);
  }
  public void EntityIdUpdated() {
    Schema.Update(_Handle, 0x7E9FC9312E71588B);
  }
  public void OwnerIdUpdated() {
    Schema.Update(_Handle, 0x7E9FC931DD9F9E45);
  }
  public void HierarchyIdUpdated() {
    Schema.Update(_Handle, 0x7E9FC931E2479899);
  }
  public void CollisionGroupUpdated() {
    Schema.Update(_Handle, 0x7E9FC9310AC0C752);
  }
  public void CollisionFunctionMaskUpdated() {
    Schema.Update(_Handle, 0x7E9FC931FC7E6DAF);
  }
}