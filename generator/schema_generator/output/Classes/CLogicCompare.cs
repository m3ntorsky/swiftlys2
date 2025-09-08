using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicCompare : CLogicalEntity, ILogicCompare {

  public CLogicCompare(nint handle) : base(handle) {
  }

  public ref float InValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCEFDBF2F414AD5ED));
  }
  public ref float CompareValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCEFDBF2F42C0882F));
  }
  public ISchemaUntypedField OnLessThan {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xCEFDBF2FB6AC02FE));
  }
  public ISchemaUntypedField OnEqualTo {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xCEFDBF2F87EEC581));
  }
  public ISchemaUntypedField OnNotEqualTo {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xCEFDBF2FDA1680D6));
  }
  public ISchemaUntypedField OnGreaterThan {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xCEFDBF2F50BD472D));
  }


}