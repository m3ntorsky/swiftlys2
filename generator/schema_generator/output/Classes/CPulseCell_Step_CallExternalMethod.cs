using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Step_CallExternalMethod : CPulseCell_BaseYieldingInflow, IPulseCell_Step_CallExternalMethod {

  public CPulseCell_Step_CallExternalMethod(nint handle) : base(handle) {
  }

  public ISchemaUntypedField MethodName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6A5B3EF57D863B13));
  }
  public ISchemaUntypedField GameBlackboard {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6A5B3EF536FB1236));
  }
  public ISchemaUntypedField ExpectedArgs {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6A5B3EF594EB10E8));
  }
  public ref PulseMethodCallMode_t AsyncCallMode {
    get => ref _Handle.AsRef<PulseMethodCallMode_t>(Schema.GetOffset(0x6A5B3EF535F27204));
  }
  public IPulse_ResumePoint OnFinished {
    get => new CPulse_ResumePoint(_Handle + Schema.GetOffset(0x6A5B3EF58D903E5E));
  }


}