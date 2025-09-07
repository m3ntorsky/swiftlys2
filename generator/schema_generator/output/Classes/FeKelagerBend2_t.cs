using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeKelagerBend2_t : SchemaClass, IFeKelagerBend2_t {

  public FeKelagerBend2_t(nint handle) : base(handle) {
  }

  public FeKelagerBend2_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<float32> Weight {
    get => new SchemaFixedArray<float32>(_Handle + Schema.GetOffset(0x702E10E1CFFC66CB));
  }
  public ref float Height0 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x702E10E1AA7896A0));
  }
  public ISchemaFixedArray<uint16> Node {
    get => new SchemaFixedArray<uint16>(_Handle + Schema.GetOffset(0x702E10E1CD6694B9));
  }
  public ref ushort Reserved {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x702E10E1156749A1));
  }


}