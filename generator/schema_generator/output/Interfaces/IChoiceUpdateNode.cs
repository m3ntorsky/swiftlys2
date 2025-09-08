using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IChoiceUpdateNode : IAnimUpdateNodeBase {

  public ref CUtlVector Children { get; }
  
  public ref CUtlVector<float> Weights { get; }
  
  public ref CUtlVector<float> BlendTimes { get; }
  
  public ref ChoiceMethod ChoiceMethod { get; }
  
  public ref ChoiceChangeMethod ChoiceChangeMethod { get; }
  
  public ref ChoiceBlendMethod BlendMethod { get; }
  
  public ref float BlendTime { get; }
  
  public ref bool CrossFade { get; }
  
  public ref bool ResetChosen { get; }
  
  public ref bool DontResetSameSelection { get; }
  
}