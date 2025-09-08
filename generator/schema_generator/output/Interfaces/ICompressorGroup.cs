using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICompressorGroup : ISchemaClass {

  public ref int TotalElementCount { get; }
  
  public ref CUtlVector<PointerTo<CString>> ChannelClass { get; }
  
  public ref CUtlVector<PointerTo<CString>> VariableName { get; }
  
  public ref CUtlVector<fieldtype_t> Type { get; }
  
  public ref CUtlVector<int> Flags { get; }
  
  public ref CUtlVector<CUtlString> Grouping { get; }
  
  public ref CUtlVector<int> CompressorIndex { get; }
  
  public ref CUtlVector<CUtlVector<PointerTo<CString>>> ElementNames { get; }
  
  public ref CUtlVector<CUtlVector<int>> ElementUniqueID { get; }
  
  public ref CUtlVector<uint> ElementMask { get; }
  
  public ref CUtlVector<PointerTo<SchemaUntypedField>> VectorCompressor { get; }
  
  public ref CUtlVector<PointerTo<SchemaUntypedField>> QuaternionCompressor { get; }
  
  public ref CUtlVector<PointerTo<SchemaUntypedField>> IntCompressor { get; }
  
  public ref CUtlVector<PointerTo<SchemaUntypedField>> BoolCompressor { get; }
  
  public ref CUtlVector<PointerTo<SchemaUntypedField>> ColorCompressor { get; }
  
  public ref CUtlVector<PointerTo<SchemaUntypedField>> Vector2DCompressor { get; }
  
  public ref CUtlVector<PointerTo<SchemaUntypedField>> Vector4DCompressor { get; }
  
}