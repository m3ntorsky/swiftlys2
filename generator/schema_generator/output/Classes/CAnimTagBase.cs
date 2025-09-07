using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimTagBase : SchemaClass, IAnimTagBase {

  public CAnimTagBase(nint handle) : base(handle) {
  }

  public CAnimTagBase(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CGlobalSymbol Name {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x8F7709C44D8F5786));
  }
  public ref CUtlString Comment {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x8F7709C488A0B4DF));
  }
  public ref CGlobalSymbol Group {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x8F7709C49FC645AC));
  }
  public IAnimTagID TagID {
    get => new AnimTagID(_Handle + Schema.GetOffset(0x8F7709C41F65DDFE));
  }
  public ref bool IsReferenced {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8F7709C4CEABFB2A));
  }


}