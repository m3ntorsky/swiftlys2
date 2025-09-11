using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMarkupVolumeWithRef : IMarkupVolumeTagged {

  
  public ref bool UseRef { get; }
  
  public ref Vector RefPosEntitySpace { get; }
  
  public ref Vector RefPosWorldSpace { get; }
  
  public ref float RefDot { get; }
}