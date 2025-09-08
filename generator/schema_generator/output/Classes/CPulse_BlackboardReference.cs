using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulse_BlackboardReference : SchemaClass, IPulse_BlackboardReference {

  public CPulse_BlackboardReference(nint handle) : base(handle) {
  }

  public ref CStrongHandle<InfoForResourceTypeIPulseGraphDef> BlackboardResource {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeIPulseGraphDef>>(Schema.GetOffset(0xEF83970A45E704DE));
  }
  public ISchemaUntypedField BlackboardResource {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xEF83970A83127470));
  }
  public IPulseDocNodeID_t NodeID {
    get => new PulseDocNodeID_t(_Handle + Schema.GetOffset(0xEF83970A0FD6755C));
  }
  public ref CGlobalSymbol NodeName {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xEF83970A3FB4DAAE));
  }


}