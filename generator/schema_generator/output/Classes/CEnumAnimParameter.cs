using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnumAnimParameter : CConcreteAnimParameter, IEnumAnimParameter {

  public CEnumAnimParameter(nint handle) : base(handle) {
  }

  public ref byte DefaultValue {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xCCD4BF1DBBE0341F));
  }
  public ref CUtlVector<CUtlString> EnumOptions {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0xCCD4BF1D5A08D71E));
  }
  public ref CUtlVector<ulong> EnumReferenced {
    get => ref _Handle.AsRef<CUtlVector<ulong>>(Schema.GetOffset(0xCCD4BF1D5C66779B));
  }


}