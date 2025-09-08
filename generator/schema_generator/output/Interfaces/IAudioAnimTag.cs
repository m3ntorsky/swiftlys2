using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAudioAnimTag : IAnimTagBase {

  public ref CUtlString ClipName { get; }
  
  public ref CUtlString AttachmentName { get; }
  
  public ref float Volume { get; }
  
  public ref bool StopWhenTagEnds { get; }
  
  public ref bool StopWhenGraphEnds { get; }
  
  public ref bool PlayOnServer { get; }
  
  public ref bool PlayOnClient { get; }
  
}