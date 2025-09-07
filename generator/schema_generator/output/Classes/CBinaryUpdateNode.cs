using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBinaryUpdateNode : CAnimUpdateNodeBase, IBinaryUpdateNode {

  public CBinaryUpdateNode(nint handle) : base(handle) {
  }

  public CBinaryUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IAnimUpdateNodeRef Child1 {
    get => new CAnimUpdateNodeRef(_Handle + Schema.GetOffset(0xA1CFA91E9E0C6B0A));
  }
  public IAnimUpdateNodeRef Child2 {
    get => new CAnimUpdateNodeRef(_Handle + Schema.GetOffset(0xA1CFA91E9D0C6977));
  }
  public ref BinaryNodeTiming TimingBehavior {
    get => ref _Handle.AsRef<BinaryNodeTiming>(Schema.GetOffset(0xA1CFA91EF9A9BA01));
  }
  public ref float TimingBlend {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA1CFA91E884E1874));
  }
  public ref bool ResetChild1 {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA1CFA91EC7FAEC85));
  }
  public ref bool ResetChild2 {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA1CFA91EC4FAE7CC));
  }


}