using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFeIndexedJiggleBone : SchemaClass, IFeIndexedJiggleBone {

  public CFeIndexedJiggleBone(nint handle) : base(handle) {
  }

  public ref uint Node {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x1DD153AEF6FB9B19));
  }
  public ref uint JiggleParent {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x1DD153AE8AABF3B9));
  }
  public IFeJiggleBone JiggleBone {
    get => new CFeJiggleBone(_Handle + Schema.GetOffset(0x1DD153AE6038C557));
  }


}