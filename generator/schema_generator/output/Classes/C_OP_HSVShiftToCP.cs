using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_HSVShiftToCP : CParticleFunctionPreEmission, IC_OP_HSVShiftToCP {

  public C_OP_HSVShiftToCP(nint handle) : base(handle) {
  }

  public C_OP_HSVShiftToCP(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ColorCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA6FD1F901D3D233F));
  }
  public ref int ColorGemEnableCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA6FD1F907B5C2B7F));
  }
  public ref int OutputCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA6FD1F9050DF5703));
  }
  public ref Color DefaultHSVColor {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0xA6FD1F90A7EFB0DE));
  }


}