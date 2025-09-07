using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFollowAttachmentUpdateNode : CUnaryUpdateNode, IFollowAttachmentUpdateNode {

  public CFollowAttachmentUpdateNode(nint handle) : base(handle) {
  }

  public CFollowAttachmentUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IFollowAttachmentSettings_t OpFixedData {
    get => new FollowAttachmentSettings_t(_Handle + Schema.GetOffset(0x8E705AE36960AF8C));
  }


}