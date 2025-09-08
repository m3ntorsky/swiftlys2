using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICredits : IPointEntity {

  public IEntityIOOutput OnCreditsDone { get; }
  
  public ref bool RolledOutroCredits { get; }
  
  public ref float LogoLength { get; }
  
}