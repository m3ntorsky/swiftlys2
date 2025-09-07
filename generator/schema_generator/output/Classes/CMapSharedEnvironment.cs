using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMapSharedEnvironment : CLogicalEntity, IMapSharedEnvironment {

  public CMapSharedEnvironment(nint handle) : base(handle) {
  }

  public CMapSharedEnvironment(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge TargetMapName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xDA50C2DE129742FD));
  }


}