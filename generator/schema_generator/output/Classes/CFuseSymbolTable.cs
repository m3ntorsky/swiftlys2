using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuseSymbolTable : SchemaClass, IFuseSymbolTable {

  public CFuseSymbolTable(nint handle) : base(handle) {
  }

  public ref CUtlVector Constants {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xD8A03B41460C1382));
  }
  public ref CUtlVector Variables {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xD8A03B4106AE7DE2));
  }
  public ref CUtlVector Functions {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xD8A03B41F6EF246E));
  }
  public ISchemaUntypedField ConstantMap {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD8A03B4198BF6E51));
  }
  public ISchemaUntypedField VariableMap {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD8A03B410FDE3671));
  }
  public ISchemaUntypedField FunctionMap {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD8A03B4147A33EC5));
  }


}