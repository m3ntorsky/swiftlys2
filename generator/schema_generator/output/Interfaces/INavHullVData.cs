using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INavHullVData : ISchemaClass {

  
  public ref bool AgentEnabled { get; }
  
  public ref float AgentRadius { get; }
  
  public ref float AgentHeight { get; }
  
  public ref bool AgentShortHeightEnabled { get; }
  
  public ref float AgentShortHeight { get; }
  
  public ref bool AgentCrawlEnabled { get; }
  
  public ref float AgentCrawlHeight { get; }
  
  public ref float AgentMaxClimb { get; }
  
  public ref int AgentMaxSlope { get; }
  
  public ref float AgentMaxJumpDownDist { get; }
  
  public ref float AgentMaxJumpHorizDistBase { get; }
  
  public ref float AgentMaxJumpUpDist { get; }
  
  public ref int AgentBorderErosion { get; }
  
  public ref bool FlowMapGenerationEnabled { get; }
  
  public ref float FlowMapNodeMaxRadius { get; }
}