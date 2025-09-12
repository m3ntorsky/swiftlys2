using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ResponseContext_t : SchemaClass, IResponseContext_t {

  public ResponseContext_t(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Name {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8F5A90A274FF65FE));
  }
  public ISchemaUntypedField Value {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8F5A90A28044B702));
  }
  public IGameTime_t ExpirationTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x8F5A90A20389142D));
  }


}