using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNavLinkMovementVData : SchemaClass, INavLinkMovementVData {

  public CNavLinkMovementVData(nint handle) : base(handle) {
  }

  public CNavLinkMovementVData(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField ToolsOnlyOwnerModelName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xACA2D2486DD9DD04));
  }
  public ref bool IsInterpolated {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xACA2D248EC811A8C));
  }
  public ref uint RecommendedDistance {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xACA2D248BA1A388E));
  }
  public ref CUtlVector< CNavLinkAnimgraphVar > AnimgraphVars {
    get => ref _Handle.AsRef<CUtlVector< CNavLinkAnimgraphVar >>(Schema.GetOffset(0xACA2D2480FD1BA32));
  }


}