using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCollisionProperty : SchemaClass, ICollisionProperty {

  public CCollisionProperty(nint handle) : base(handle) {
  }

  public CCollisionProperty(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IVPhysicsCollisionAttribute_t CollisionAttribute {
    get => new VPhysicsCollisionAttribute_t(_Handle + Schema.GetOffset(0x794D87F77E1AEF05));
  }
  public ref Vector Mins {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x794D87F70E57F80C));
  }
  public ref Vector Maxs {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x794D87F77D388D3E));
  }
  public ref byte SolidFlags {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x794D87F7B21D0CFB));
  }
  public ref SolidType_t SolidType {
    get => ref _Handle.AsRef<SolidType_t>(Schema.GetOffset(0x794D87F7BE0FC0E8));
  }
  public ref byte TriggerBloat {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x794D87F789A6F5C3));
  }
  public ref SurroundingBoundsType_t SurroundType {
    get => ref _Handle.AsRef<SurroundingBoundsType_t>(Schema.GetOffset(0x794D87F725FA3137));
  }
  public ref byte CollisionGroup {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x794D87F791BF7016));
  }
  public ref byte EnablePhysics {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x794D87F7BCD6B6BB));
  }
  public ref float BoundingRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x794D87F74C638611));
  }
  public ref Vector SpecifiedSurroundingMins {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x794D87F71406E000));
  }
  public ref Vector SpecifiedSurroundingMaxs {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x794D87F792FCA91A));
  }
  public ref Vector SurroundingMaxs {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x794D87F7F5AED3D6));
  }
  public ref Vector SurroundingMins {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x794D87F7749A0F94));
  }
  public ref Vector CapsuleCenter1 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x794D87F7A5E81978));
  }
  public ref Vector CapsuleCenter2 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x794D87F7A8E81E31));
  }
  public ref float CapsuleRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x794D87F7A1A593D0));
  }

  public void CollisionAttributeUpdated() {
    Schema.Update(_Handle, 0x794D87F77E1AEF05);
  }
  public void MinsUpdated() {
    Schema.Update(_Handle, 0x794D87F70E57F80C);
  }
  public void MaxsUpdated() {
    Schema.Update(_Handle, 0x794D87F77D388D3E);
  }
  public void SolidFlagsUpdated() {
    Schema.Update(_Handle, 0x794D87F7B21D0CFB);
  }
  public void SolidTypeUpdated() {
    Schema.Update(_Handle, 0x794D87F7BE0FC0E8);
  }
  public void TriggerBloatUpdated() {
    Schema.Update(_Handle, 0x794D87F789A6F5C3);
  }
  public void SurroundTypeUpdated() {
    Schema.Update(_Handle, 0x794D87F725FA3137);
  }
  public void CollisionGroupUpdated() {
    Schema.Update(_Handle, 0x794D87F791BF7016);
  }
  public void EnablePhysicsUpdated() {
    Schema.Update(_Handle, 0x794D87F7BCD6B6BB);
  }
  public void SpecifiedSurroundingMinsUpdated() {
    Schema.Update(_Handle, 0x794D87F71406E000);
  }
  public void SpecifiedSurroundingMaxsUpdated() {
    Schema.Update(_Handle, 0x794D87F792FCA91A);
  }
  public void CapsuleCenter1Updated() {
    Schema.Update(_Handle, 0x794D87F7A5E81978);
  }
  public void CapsuleCenter2Updated() {
    Schema.Update(_Handle, 0x794D87F7A8E81E31);
  }
  public void CapsuleRadiusUpdated() {
    Schema.Update(_Handle, 0x794D87F7A1A593D0);
  }
}