using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapSpeedtoCP : CParticleFunctionPreEmission, IC_OP_RemapSpeedtoCP {

  public C_OP_RemapSpeedtoCP(nint handle) : base(handle) {
  }

  public C_OP_RemapSpeedtoCP(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int InControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x15A0E8C3E7CB99DE));
  }
  public ref int OutControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x15A0E8C3D021D73F));
  }
  public ref int Field {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x15A0E8C3C257B93B));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x15A0E8C3E88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x15A0E8C3D6766901));
  }
  public ref float OutputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x15A0E8C35F8D7716));
  }
  public ref float OutputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x15A0E8C351A0E8C4));
  }
  public ref bool UseDeltaV {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x15A0E8C389609F7C));
  }


}