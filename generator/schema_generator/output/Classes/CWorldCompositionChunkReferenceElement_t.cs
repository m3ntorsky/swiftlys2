using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CWorldCompositionChunkReferenceElement_t : SchemaClass, IWorldCompositionChunkReferenceElement_t {

  public CWorldCompositionChunkReferenceElement_t(nint handle) : base(handle) {
  }

  public ref CUtlString StrMapToLoad {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x9B80004DE87F0C1B));
  }
  public ref CUtlString StrLandmarkName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x9B80004DE0BB30D3));
  }


}