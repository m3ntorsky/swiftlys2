using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDecalGroupVData : SchemaClass, IDecalGroupVData {

  public CDecalGroupVData(nint handle) : base(handle) {
  }

  public ref CUtlVector Options {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x56FC0D98C5C14E85));
  }
  public ref float TotalProbability {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x56FC0D98154D3742));
  }


}