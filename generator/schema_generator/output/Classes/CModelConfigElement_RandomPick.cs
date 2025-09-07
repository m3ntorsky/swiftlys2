using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CModelConfigElement_RandomPick : CModelConfigElement, IModelConfigElement_RandomPick {

  public CModelConfigElement_RandomPick(nint handle) : base(handle) {
  }

  public CModelConfigElement_RandomPick(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CUtlString > Choices {
    get => ref _Handle.AsRef<CUtlVector< CUtlString >>(Schema.GetOffset(0x31F9AEEA9E9959BF));
  }
  public ref CUtlVector< float32 > ChoiceWeights {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x31F9AEEA379579F7));
  }


}