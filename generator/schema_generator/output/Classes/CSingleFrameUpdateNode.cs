using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSingleFrameUpdateNode : CLeafUpdateNode, ISingleFrameUpdateNode {

  public CSingleFrameUpdateNode(nint handle) : base(handle) {
  }

  public CSingleFrameUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CSmartPtr< CAnimActionUpdater > > Actions {
    get => ref _Handle.AsRef<CUtlVector< CSmartPtr< CAnimActionUpdater > >>(Schema.GetOffset(0x5A65D6168D622684));
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