using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqMultiFetch : SchemaClass, ISeqMultiFetch {

  public CSeqMultiFetch(nint handle) : base(handle) {
  }

  public CSeqMultiFetch(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISeqMultiFetchFlag Flags {
    get => new CSeqMultiFetchFlag(_Handle + Schema.GetOffset(0x3846FD62DC74A14C));
  }
  public ref CUtlVector< int16 > LocalReferenceArray {
    get => ref _Handle.AsRef<CUtlVector< int16 >>(Schema.GetOffset(0x3846FD6290C98686));
  }
  public ISchemaFixedArray<int32> GroupSize {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0x3846FD6258533CF9));
  }
  public ISchemaFixedArray<int32> LocalPose {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0x3846FD6270BF8111));
  }
  public ref CUtlVector< float32 > PoseKeyArray0 {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x3846FD62E139B398));
  }
  public ref CUtlVector< float32 > PoseKeyArray1 {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x3846FD62E239B52B));
  }
  public ref int LocalCyclePoseParameter {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3846FD62722CCD8E));
  }
  public ref bool CalculatePoseParameters {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3846FD6259BED3FE));
  }
  public ref bool FixedBlendWeight {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3846FD626C68A6B4));
  }
  public ISchemaFixedArray<float32> FixedBlendWeightVals {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0x3846FD6221B3BB76));
  }


}