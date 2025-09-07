using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqScaleSet : SchemaClass, ISeqScaleSet {

  public CSeqScaleSet(nint handle) : base(handle) {
  }

  public CSeqScaleSet(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
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
  public ref CUtlVector< int16 > LocalBoneArray {
    get => ref _Handle.AsRef<CUtlVector< int16 >>(Schema.GetOffset(0x34C951AB0B8EFD6B));
  }
  public ref CUtlVector< float32 > BoneScaleArray {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x34C951ABC4BD868A));
  }


}