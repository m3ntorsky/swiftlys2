using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotionDataSet : SchemaClass, IMotionDataSet {

  public CMotionDataSet(nint handle) : base(handle) {
  }

  public CMotionDataSet(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CMotionGraphGroup > Groups {
    get => ref _Handle.AsRef<CUtlVector< CMotionGraphGroup >>(Schema.GetOffset(0x8AC1A050641FFE0D));
  }
  public ref int DimensionCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8AC1A05036656C8E));
  }


}