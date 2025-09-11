using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBakedLightingInfo_t__BakedShadowAssignment_t : ISchemaClass {

  
  public ref uint LightHash { get; }
  
  public ref uint MapHash { get; }
  
  public ref byte ShadowChannel { get; }
}