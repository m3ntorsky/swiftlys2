using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimParamHandleMap : SchemaClass, IAnimParamHandleMap {

  public CAnimParamHandleMap(nint handle) : base(handle) {
  }

  public CAnimParamHandleMap(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField List {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x82522A78CAD81C21));
  }


}