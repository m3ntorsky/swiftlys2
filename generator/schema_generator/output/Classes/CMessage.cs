using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMessage : CPointEntity, IMessage {

  public CMessage(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Message {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xCCCF499CC5243DC));
  }
  public ref float MessageVolume {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCCCF499C87F24D6));
  }
  public ref int MessageAttenuation {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xCCCF4998F72B2B4));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCCCF4997C5B0533));
  }
  public ISchemaUntypedField Noise {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xCCCF4991F22B8CC));
  }
  public IEntityIOOutput OnShowMessage {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xCCCF499D586D920));
  }


}