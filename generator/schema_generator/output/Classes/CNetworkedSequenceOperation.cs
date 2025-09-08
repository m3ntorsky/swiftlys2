using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNetworkedSequenceOperation : SchemaClass, INetworkedSequenceOperation {

  public CNetworkedSequenceOperation(nint handle) : base(handle) {
  }

  public ref bool SequenceChangeNetworked {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3EA8ECC510DEC927));
  }
  public ref bool Discontinuity {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3EA8ECC5C37DF9B1));
  }
  public ref float PrevCycleFromDiscontinuity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3EA8ECC581FD154E));
  }
  public ref float PrevCycleForAnimEventDetection {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3EA8ECC5B36E4559));
  }

  public void SequenceUpdated() {
    Schema.Update(_Handle, 0x3EA8ECC5E0A0598E);
  }
  public void PrevCycleUpdated() {
    Schema.Update(_Handle, 0x3EA8ECC5AA0F5CF4);
  }
  public void CycleUpdated() {
    Schema.Update(_Handle, 0x3EA8ECC50C77829F);
  }
  public void WeightUpdated() {
    Schema.Update(_Handle, 0x3EA8ECC57B81E7AB);
  }
}