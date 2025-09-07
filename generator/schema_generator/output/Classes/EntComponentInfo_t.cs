using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EntComponentInfo_t : SchemaClass, IEntComponentInfo_t {

  public EntComponentInfo_t(nint handle) : base(handle) {
  }

  public EntComponentInfo_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CString Name {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0xDEAD526A5B47C92C));
  }
  public ref CString CPPClassname {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0xDEAD526A65BE3EC7));
  }
  public ref CString NetworkDataReferencedDescription {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0xDEAD526AB84E3342));
  }
  public ref CString NetworkDataReferencedPtrPropDescription {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0xDEAD526AFDC5489F));
  }
  public ref int RuntimeIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDEAD526AB53184BD));
  }
  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xDEAD526ACE6E9C28));
  }
  public IEntityComponentHelper BaseClassComponentHelper {
    get => new CEntityComponentHelper(_Handle + Schema.GetOffset(0xDEAD526A9799DD51));
  }


}