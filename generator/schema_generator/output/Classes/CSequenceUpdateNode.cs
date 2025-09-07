using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSequenceUpdateNode : CSequenceUpdateNodeBase, ISequenceUpdateNode {

  public CSequenceUpdateNode(nint handle) : base(handle) {
  }

  public CSequenceUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IHSequence Sequence {
    get => new HSequence(_Handle + Schema.GetOffset(0xB5F91396E0A0598E));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB5F913963D9FF5AD));
  }
  public IParamSpanUpdater ParamSpans {
    get => new CParamSpanUpdater(_Handle + Schema.GetOffset(0xB5F91396DAC91553));
  }
  public ref CUtlVector< TagSpan_t > Tags {
    get => ref _Handle.AsRef<CUtlVector< TagSpan_t >>(Schema.GetOffset(0xB5F91396B46C8540));
  }


}