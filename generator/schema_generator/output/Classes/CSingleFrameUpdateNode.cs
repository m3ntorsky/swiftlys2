using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSingleFrameUpdateNode : CLeafUpdateNode, ISingleFrameUpdateNode {

  public CSingleFrameUpdateNode(nint handle) : base(handle) {
  }

  public ref CUtlVector Actions {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x5A65D6168D622684));
  }
  public IPoseHandle PoseCacheHandle {
    get => new CPoseHandle(_Handle + Schema.GetOffset(0x5A65D6164719447A));
  }
  public IHSequence Sequence {
    get => new HSequence(_Handle + Schema.GetOffset(0x5A65D616E0A0598E));
  }
  public ref float Cycle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5A65D6160C77829F));
  }


}