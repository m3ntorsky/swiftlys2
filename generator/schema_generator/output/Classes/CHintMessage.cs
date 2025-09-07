using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CHintMessage : SchemaClass, IHintMessage {

  public CHintMessage(nint handle) : base(handle) {
  }

  public CHintMessage(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CString HintString {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0x7663729E433E2101));
  }
  public ref CUtlVector< char* > Args {
    get => ref _Handle.AsRef<CUtlVector< char* >>(Schema.GetOffset(0x7663729E5D6040DC));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7663729E3D9FF5AD));
  }


}