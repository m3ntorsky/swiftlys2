using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SampleCode : SchemaClass, ISampleCode {

  public SampleCode(nint handle) : base(handle) {
  }

  public SampleCode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedArray<uint8> SubCode {
    get => new SchemaFixedArray<uint8>(_Handle + Schema.GetOffset(0x6387E3865AD6C244));
  }


}