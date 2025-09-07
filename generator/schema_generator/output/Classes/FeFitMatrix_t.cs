using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeFitMatrix_t : SchemaClass, IFeFitMatrix_t {

  public FeFitMatrix_t(nint handle) : base(handle) {
  }

  public FeFitMatrix_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CTransform Bone {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0xB8804215DB90E18F));
  }
  public ref Vector Center {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB88042157CA60028));
  }
  public ref ushort End {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xB8804215FE4CFBD6));
  }
  public ref ushort Node {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xB8804215CD6694B9));
  }
  public ref ushort BeginDynamic {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xB88042153F6B5607));
  }


}