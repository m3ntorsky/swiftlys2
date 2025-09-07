using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MoodAnimation_t : SchemaClass, IMoodAnimation_t {

  public MoodAnimation_t(nint handle) : base(handle) {
  }

  public MoodAnimation_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField Name {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8982458763D22D49));
  }
  public ref float Weight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x898245877B81E7AB));
  }


}