using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AttachmentHandle_t : SchemaClass, IAttachmentHandle_t {

  public AttachmentHandle_t(nint handle) : base(handle) {
  }

  public ref byte Value {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x7F31E925DCB0894A));
  }


}