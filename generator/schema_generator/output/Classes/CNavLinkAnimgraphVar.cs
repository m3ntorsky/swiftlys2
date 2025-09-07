using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNavLinkAnimgraphVar : SchemaClass, INavLinkAnimgraphVar {

  public CNavLinkAnimgraphVar(nint handle) : base(handle) {
  }

  public CNavLinkAnimgraphVar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CGlobalSymbol AnimGraphNavlinkType {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xD079ABDB24A7FCF6));
  }
  public ref uint AlignmentDegrees {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xD079ABDB371747C0));
  }


}