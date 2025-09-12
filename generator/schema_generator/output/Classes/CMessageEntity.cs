using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMessageEntity : CPointEntity, IMessageEntity {

  public CMessageEntity(nint handle) : base(handle) {
  }

  public ref int Radius {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x893EADCEA921CA53));
  }
  public ISchemaUntypedField MessageText {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x893EADCEBA6E5D73));
  }
  public ref bool DrawText {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x893EADCE598871D4));
  }
  public ref bool DeveloperOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x893EADCE981A6E5F));
  }
  public ref bool Enabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x893EADCE6154EB7E));
  }


}