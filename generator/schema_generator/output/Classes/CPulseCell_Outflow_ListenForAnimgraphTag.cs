using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_ListenForAnimgraphTag : CPulseCell_BaseYieldingInflow, IPulseCell_Outflow_ListenForAnimgraphTag {

  public CPulseCell_Outflow_ListenForAnimgraphTag(nint handle) : base(handle) {
  }

  public CPulseCell_Outflow_ListenForAnimgraphTag(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulse_ResumePoint OnStart {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0xAD79BF78C3FE848C));
  }
  public IPulse_ResumePoint OnEnd {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0xAD79BF78B88A4375));
  }
  public IPulse_ResumePoint OnCanceled {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0xAD79BF78F02162DB));
  }
  public ref CGlobalSymbol TagName {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xAD79BF78647DC278));
  }


}