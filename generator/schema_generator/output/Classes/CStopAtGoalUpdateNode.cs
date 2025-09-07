using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CStopAtGoalUpdateNode : CUnaryUpdateNode, IStopAtGoalUpdateNode {

  public CStopAtGoalUpdateNode(nint handle) : base(handle) {
  }

  public CStopAtGoalUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float OuterRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4889F8297B66A818));
  }
  public ref float InnerRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4889F82932121407));
  }
  public ref float MaxScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4889F829FF4EC8E7));
  }
  public ref float MinScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4889F829D125D67D));
  }
  public IAnimInputDamping Damping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0x4889F82915440FB5));
  }


}