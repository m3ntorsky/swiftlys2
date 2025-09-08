using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotionSearchDB : SchemaClass, IMotionSearchDB {

  public CMotionSearchDB(nint handle) : base(handle) {
  }

  public IMotionSearchNode RootNode {
    get => new CMotionSearchNode(_Handle + Schema.GetOffset(0x5F49286C3D5FF0D));
  }
  public IProductQuantizer ResidualQuantizer {
    get => new CProductQuantizer(_Handle + Schema.GetOffset(0x5F49286A3EDA009));
  }
  public ref CUtlVector CodeIndices {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x5F49286767A76B1));
  }


}