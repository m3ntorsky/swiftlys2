using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MotionBlendItem : SchemaClass, IMotionBlendItem {

  public MotionBlendItem(nint handle) : base(handle) {
  }

  public MotionBlendItem(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField Child {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6AF18B8D4A0B773F));
  }
  public ref float KeyValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6AF18B8D039CE1D7));
  }


}