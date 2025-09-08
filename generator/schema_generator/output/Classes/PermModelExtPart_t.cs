using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PermModelExtPart_t : SchemaClass, IPermModelExtPart_t {

  public PermModelExtPart_t(nint handle) : base(handle) {
  }

  public ref CTransform Transform {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0xCA30851D6EC5209B));
  }
  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xCA30851DCAE8A266));
  }
  public ref int Parent {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xCA30851D0AABB9D1));
  }
  public ref CStrongHandle<InfoForResourceTypeCModel> RefModel {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeCModel>>(Schema.GetOffset(0xCA30851D63E6E3DF));
  }


}