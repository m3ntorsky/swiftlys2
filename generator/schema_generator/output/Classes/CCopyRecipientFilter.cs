using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCopyRecipientFilter : SchemaClass, ICopyRecipientFilter {

  public CCopyRecipientFilter(nint handle) : base(handle) {
  }

  public CCopyRecipientFilter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Flags {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB27F546C36B92FAC));
  }
  public ref CUtlVector< CPlayerSlot > Recipients {
    get => ref _Handle.AsRef<CUtlVector< CPlayerSlot >>(Schema.GetOffset(0xB27F546CDF6522D1));
  }


}