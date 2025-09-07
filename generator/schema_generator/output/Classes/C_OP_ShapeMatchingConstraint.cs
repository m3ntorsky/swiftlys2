using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ShapeMatchingConstraint : CParticleFunctionConstraint, IC_OP_ShapeMatchingConstraint {

  public C_OP_ShapeMatchingConstraint(nint handle) : base(handle) {
  }

  public C_OP_ShapeMatchingConstraint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float ShapeRestorationTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4FF42FB6A86E05A9));
  }


}