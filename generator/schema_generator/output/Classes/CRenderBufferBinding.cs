using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRenderBufferBinding : SchemaClass, IRenderBufferBinding {

  public CRenderBufferBinding(nint handle) : base(handle) {
  }

  public ref ulong Buffer {
    get => ref _Handle.AsRef<ulong>(Schema.GetOffset(0xFC8416C144D3898D));
  }
  public ref uint BindOffsetBytes {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xFC8416C1AD9A201C));
  }


}