using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FourCovMatrices3 : SchemaClass, IFourCovMatrices3 {

  public FourCovMatrices3(nint handle) : base(handle) {
  }

  public FourCovMatrices3(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref FourVectors Diag {
    get => ref _Handle.AsRef<FourVectors>(Schema.GetOffset(0xCEA91E487CC0D332));
  }
  public ref fltx4 XY {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0xCEA91E48A58DC304));
  }
  public ref fltx4 XZ {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0xCEA91E48A88DC7BD));
  }
  public ref fltx4 YZ {
    get => ref _Handle.AsRef<fltx4>(Schema.GetOffset(0xCEA91E489E8B7968));
  }


}