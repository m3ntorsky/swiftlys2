using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqScaleSet : SchemaClass, ISeqScaleSet {

  public CSeqScaleSet(nint handle) : base(handle) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x34C951AB63D22D49));
  }
  public ref bool RootOffset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x34C951ABEE69828A));
  }
  public ref Vector RootOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x34C951ABA62E010E));
  }
  public ref CUtlVector<short> LocalBoneArray {
    get => ref _Handle.AsRef<CUtlVector<short>>(Schema.GetOffset(0x34C951AB0B8EFD6B));
  }
  public ref CUtlVector<float> BoneScaleArray {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0x34C951ABC4BD868A));
  }


}