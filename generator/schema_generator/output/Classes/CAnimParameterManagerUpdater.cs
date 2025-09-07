using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimParameterManagerUpdater : SchemaClass, IAnimParameterManagerUpdater {

  public CAnimParameterManagerUpdater(nint handle) : base(handle) {
  }

  public CAnimParameterManagerUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CSmartPtr< CAnimParameterBase > > Parameters {
    get => ref _Handle.AsRef<CUtlVector< CSmartPtr< CAnimParameterBase > >>(Schema.GetOffset(0x2289044E99935479));
  }
  public ISchemaUntypedField IdToIndexMap {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2289044E7B873A5F));
  }
  public ISchemaUntypedField NameToIndexMap {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2289044EDA1FC14D));
  }
  public ref CUtlVector< CAnimParamHandle > IndexToHandle {
    get => ref _Handle.AsRef<CUtlVector< CAnimParamHandle >>(Schema.GetOffset(0x2289044E3F943600));
  }
  public ref CUtlVector< std::pair< CAnimParamHandle, CAnimVariant > > AutoResetParams {
    get => ref _Handle.AsRef<CUtlVector< std::pair< CAnimParamHandle, CAnimVariant > >>(Schema.GetOffset(0x2289044EA74F889F));
  }
  public ISchemaUntypedField AutoResetMap {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2289044E024CB2F5));
  }


}