using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CUnaryUpdateNode : CAnimUpdateNodeBase, IUnaryUpdateNode {

  public CUnaryUpdateNode(nint handle) : base(handle) {
  }

  public IAnimUpdateNodeRef ChildNode {
    get => new CAnimUpdateNodeRef(_Handle + Schema.GetOffset(0x7A35EAF8C0359CFF));
  }


}