using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ControlPointReference_t : SchemaClass, IControlPointReference_t {

  public ControlPointReference_t(nint handle) : base(handle) {
  }

  public ref int ControlPointNameString {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x83CD020625F4E2B6));
  }
  public ref Vector OffsetFromControlPoint {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x83CD0206C9E39FFF));
  }
  public ref bool OffsetInLocalSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x83CD02064ADEF5FE));
  }


}