using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeNodeBase_t : SchemaClass, IFeNodeBase_t {

  public FeNodeBase_t(nint handle) : base(handle) {
  }

  public FeNodeBase_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort Node {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x74CA29BECD6694B9));
  }
  public ISchemaFixedArray<uint16> Dummy {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x74CA29BECD8BAE5F));
  }
  public ref ushort NodeX0 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x74CA29BE81C7FEB9));
  }
  public ref ushort NodeX1 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x74CA29BE80C7FD26));
  }
  public ref ushort NodeY0 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x74CA29BE7BC5B6B0));
  }
  public ref ushort NodeY1 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x74CA29BE7CC5B843));
  }
  public ref QuaternionStorage Adjust {
    get => ref _Handle.AsRef<QuaternionStorage>(Schema.GetOffset(0x74CA29BE0F6C0983));
  }


}