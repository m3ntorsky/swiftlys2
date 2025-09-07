using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseGraphDef : SchemaClass, IPulseGraphDef {

  public CPulseGraphDef(nint handle) : base(handle) {
  }

  public CPulseGraphDef(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField DomainIdentifier {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2A792CD89A57EDFA));
  }
  public ISchemaUntypedField DomainSubType {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2A792CD83A580FB9));
  }
  public ISchemaUntypedField ParentMapName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2A792CD8A9A81AA2));
  }
  public ISchemaUntypedField ParentXmlName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2A792CD80689878D));
  }
  public ref CUtlVector< CPulse_Chunk* > Chunks {
    get => ref _Handle.AsRef<CUtlVector< CPulse_Chunk* >>(Schema.GetOffset(0x2A792CD8CCAED623));
  }
  public ref CUtlVector< CPulseCell_Base* > Cells {
    get => ref _Handle.AsRef<CUtlVector< CPulseCell_Base* >>(Schema.GetOffset(0x2A792CD8739C8132));
  }
  public ref CUtlVector< CPulse_Variable > Vars {
    get => ref _Handle.AsRef<CUtlVector< CPulse_Variable >>(Schema.GetOffset(0x2A792CD8845ACC37));
  }
  public ref CUtlVector< CPulse_PublicOutput > PublicOutputs {
    get => ref _Handle.AsRef<CUtlVector< CPulse_PublicOutput >>(Schema.GetOffset(0x2A792CD8F0A9E7DA));
  }
  public ref CUtlVector< CPulse_InvokeBinding* > InvokeBindings {
    get => ref _Handle.AsRef<CUtlVector< CPulse_InvokeBinding* >>(Schema.GetOffset(0x2A792CD8828E222B));
  }
  public ref CUtlVector< CPulse_CallInfo* > CallInfos {
    get => ref _Handle.AsRef<CUtlVector< CPulse_CallInfo* >>(Schema.GetOffset(0x2A792CD8EBB65CE6));
  }
  public ref CUtlVector< CPulse_Constant > Constants {
    get => ref _Handle.AsRef<CUtlVector< CPulse_Constant >>(Schema.GetOffset(0x2A792CD83ACB72E2));
  }
  public ref CUtlVector< CPulse_DomainValue > DomainValues {
    get => ref _Handle.AsRef<CUtlVector< CPulse_DomainValue >>(Schema.GetOffset(0x2A792CD8AA783E57));
  }
  public ref CUtlVector< CPulse_BlackboardReference > BlackboardReferences {
    get => ref _Handle.AsRef<CUtlVector< CPulse_BlackboardReference >>(Schema.GetOffset(0x2A792CD8AC9DF456));
  }
  public ref CUtlVector< CPulse_OutputConnection* > OutputConnections {
    get => ref _Handle.AsRef<CUtlVector< CPulse_OutputConnection* >>(Schema.GetOffset(0x2A792CD843CD6C85));
  }


}