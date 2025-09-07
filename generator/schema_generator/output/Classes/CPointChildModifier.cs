using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointChildModifier : CPointEntity, IPointChildModifier {

  public CPointChildModifier(nint handle) : base(handle) {
  }

  public CPointChildModifier(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool OrphanInsteadOfDeletingChildrenOnRemove {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDA7544AF85891348));
  }


}