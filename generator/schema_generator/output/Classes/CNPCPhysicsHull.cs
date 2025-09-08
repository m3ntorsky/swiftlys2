using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNPCPhysicsHull : SchemaClass, INPCPhysicsHull {

  public CNPCPhysicsHull(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol Name {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x6C27881963D22D49));
  }
  public ref NPCPhysicsHullType_t Type {
    get => ref _Handle.AsRef<NPCPhysicsHullType_t>(Schema.GetOffset(0x6C27881921B39888));
  }
  public ref float CapsuleHeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6C278819043CF691));
  }
  public ref float CapsuleRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6C278819A1A593D0));
  }
  public ref Vector CapsuleCenter1 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6C278819A5E81978));
  }
  public ref Vector CapsuleCenter2 {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6C278819A8E81E31));
  }
  public ref float GroundBoxHeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6C2788195B2D099E));
  }
  public ref float GroundBoxWidth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6C2788194A30F5E3));
  }


}