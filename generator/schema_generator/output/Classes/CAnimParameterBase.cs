using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimParameterBase : SchemaClass, IAnimParameterBase {

  public CAnimParameterBase(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol Name {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x9E097C8F4D8F5786));
  }
  public ref CUtlString Comment {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x9E097C8F88A0B4DF));
  }
  public ref CUtlString Group {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x9E097C8F9FC645AC));
  }
  public IAnimParamID Id {
    get => new AnimParamID(_Handle + Schema.GetOffset(0x9E097C8FB4B6E980));
  }
  public ref CUtlString ComponentName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x9E097C8F7CAC3EA3));
  }
  public ref bool NetworkingRequested {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9E097C8FE57548D5));
  }
  public ref bool IsReferenced {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9E097C8FCEABFB2A));
  }


}