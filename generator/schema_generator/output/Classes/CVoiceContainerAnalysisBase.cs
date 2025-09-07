using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerAnalysisBase : SchemaClass, IVoiceContainerAnalysisBase {

  public CVoiceContainerAnalysisBase(nint handle) : base(handle) {
  }

  public CVoiceContainerAnalysisBase(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool RegenerateCurveOnCompile {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC0BE2FE061AFA19C));
  }
  public ISchemaUntypedField Curve {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC0BE2FE0BFFA0B34));
  }


}