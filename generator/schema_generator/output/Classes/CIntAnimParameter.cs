using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CIntAnimParameter : CConcreteAnimParameter, IIntAnimParameter {

  public CIntAnimParameter(nint handle) : base(handle) {
  }

  public ref int DefaultValue {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD1AA42D5BBE0341F));
  }
  public ref int MinValue {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD1AA42D503F1334C));
  }
  public ref int MaxValue {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD1AA42D5857E5426));
  }


}