using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNavHullVData : SchemaClass, INavHullVData {

  public CNavHullVData(nint handle) : base(handle) {
  }

  public ref bool AgentEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x74449E2E9D43CFF3));
  }
  public ref float AgentRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x74449E2ED9F4ED84));
  }
  public ref float AgentHeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x74449E2E5A46CC6D));
  }
  public ref bool AgentShortHeightEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x74449E2EB869D4B0));
  }
  public ref float AgentShortHeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x74449E2E82909A4B));
  }
  public ref bool AgentCrawlEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x74449E2E042611D2));
  }
  public ref float AgentCrawlHeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x74449E2E8068594E));
  }
  public ref float AgentMaxClimb {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x74449E2EDF3EC175));
  }
  public ref int AgentMaxSlope {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x74449E2EFAC02727));
  }
  public ref float AgentMaxJumpDownDist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x74449E2E1B440540));
  }
  public ref float AgentMaxJumpHorizDistBase {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x74449E2ED8C1AC5F));
  }
  public ref float AgentMaxJumpUpDist {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x74449E2E0CA237AD));
  }
  public ref int AgentBorderErosion {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x74449E2EC445012D));
  }
  public ref bool FlowMapGenerationEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x74449E2E8E7494D0));
  }
  public ref float FlowMapNodeMaxRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x74449E2E19B2323B));
  }


}