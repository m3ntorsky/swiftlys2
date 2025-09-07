using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncPlat : CBasePlatTrain, IFuncPlat {

  public CFuncPlat(nint handle) : base(handle) {
  }

  public CFuncPlat(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge Noise {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x57400D651F22B8CC));
  }


}