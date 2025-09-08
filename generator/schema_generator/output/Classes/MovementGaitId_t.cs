using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MovementGaitId_t : SchemaClass, IMovementGaitId_t {

  public MovementGaitId_t(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol Id {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xD64B37F7C4A0BD8F));
  }


}