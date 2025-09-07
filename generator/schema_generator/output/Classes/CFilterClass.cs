using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterClass : CBaseFilter, IFilterClass {

  public CFilterClass(nint handle) : base(handle) {
  }

  public CFilterClass(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge FilterClass {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x31025D487FECB06));
  }


}