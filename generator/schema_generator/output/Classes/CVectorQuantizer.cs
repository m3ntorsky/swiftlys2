using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVectorQuantizer : SchemaClass, IVectorQuantizer {

  public CVectorQuantizer(nint handle) : base(handle) {
  }

  public CVectorQuantizer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< float32 > CentroidVectors {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x9E79F13089538103));
  }
  public ref int Centroids {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9E79F13064667B2E));
  }
  public ref int Dimensions {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9E79F1302D8795AC));
  }


}