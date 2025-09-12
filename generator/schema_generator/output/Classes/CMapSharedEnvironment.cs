using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMapSharedEnvironment : CLogicalEntity, IMapSharedEnvironment {

  public CMapSharedEnvironment(nint handle) : base(handle) {
  }

  public ISchemaUntypedField TargetMapName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xDA50C2DE129742FD));
  }


}