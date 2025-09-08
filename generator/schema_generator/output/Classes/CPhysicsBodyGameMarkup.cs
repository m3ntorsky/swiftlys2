using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysicsBodyGameMarkup : SchemaClass, IPhysicsBodyGameMarkup {

  public CPhysicsBodyGameMarkup(nint handle) : base(handle) {
  }

  public ref CUtlString TargetBody {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xA5257571F2C6B554));
  }
  public ref CGlobalSymbol Tag {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xA5257571218D8313));
  }


}