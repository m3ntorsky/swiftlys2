using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRagdollAnimTag : CAnimTagBase, IRagdollAnimTag {

  public CRagdollAnimTag(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol ProfileName {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xC5917190285D878D));
  }


}