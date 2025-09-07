using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PhysShapeMarkup_t : SchemaClass, IPhysShapeMarkup_t {

  public PhysShapeMarkup_t(nint handle) : base(handle) {
  }

  public PhysShapeMarkup_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int BodyInAggregate {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x87CE340954AFE651));
  }
  public ref int ShapeInBody {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x87CE3409C45F6FDD));
  }
  public ref CGlobalSymbol HitGroup {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x87CE3409A13CBDEA));
  }


}