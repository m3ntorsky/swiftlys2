using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ForceControlPointStub : CParticleFunctionPreEmission, IC_OP_ForceControlPointStub {

  public C_OP_ForceControlPointStub(nint handle) : base(handle) {
  }

  public ref int ControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE0FD255D5EDF730));
  }


}