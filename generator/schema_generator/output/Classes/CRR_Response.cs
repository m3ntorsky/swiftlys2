using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRR_Response : SchemaClass, IRR_Response {

  public CRR_Response(nint handle) : base(handle) {
  }

  public ref byte Type {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x7B8008788ED6D5CD));
  }
  public ISchemaFixedString ResponseName {
    get => new SchemaFixedString(_Handle, 0x7B800878C2716964, 192, 1, 1);
  }
  public ISchemaFixedString MatchingRule {
    get => new SchemaFixedString(_Handle, 0x7B80087820850239, 128, 1, 1);
  }
  public IResponseParams Params {
    get => new ResponseParams(_Handle + Schema.GetOffset(0x7B800878900020D3));
  }
  public ref float MatchScore {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7B80087861BE6F08));
  }
  public ref bool AnyMatchingRulesInCooldown {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7B800878579F1BE7));
  }
  public ref CString SpeakerContext {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0x7B80087877C70A38));
  }
  public ref CString WorldContext {
    get => ref _Handle.AsRef<CString>(Schema.GetOffset(0x7B8008781DC998DF));
  }
  public IResponseFollowup Followup {
    get => new ResponseFollowup(_Handle + Schema.GetOffset(0x7B800878B1F72BFD));
  }
  public ISchemaUntypedField RecipientFilter {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x7B800878CC301E4A));
  }


}