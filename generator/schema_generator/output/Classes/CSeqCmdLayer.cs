using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqCmdLayer : SchemaClass, ISeqCmdLayer {

  public CSeqCmdLayer(nint handle) : base(handle) {
  }

  public CSeqCmdLayer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short Cmd {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xFD1F978E4B3490B));
  }
  public ref short LocalReference {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xFD1F978C8D571D9));
  }
  public ref short LocalBonemask {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xFD1F9782B0E5CB2));
  }
  public ref short DstResult {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xFD1F978EC2D9DB9));
  }
  public ref short SrcResult {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xFD1F9782B5F4F1C));
  }
  public ref bool Spline {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFD1F9782F9204DC));
  }
  public ref float Var1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFD1F978B9FADB9F));
  }
  public ref float Var2 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xFD1F978BAFADD32));
  }
  public ref short LineNumber {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xFD1F978AD012A6A));
  }


}