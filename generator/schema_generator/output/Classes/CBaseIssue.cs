using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseIssue : SchemaClass, IBaseIssue {

  public CBaseIssue(nint handle) : base(handle) {
  }

  public CBaseIssue(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaFixedString TypeString {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xE0727D1E2E3EE7A9));
  }
  public ISchemaFixedString DetailsString {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0xE0727D1ECCE4C9BF));
  }
  public ref int NumYesVotes {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE0727D1E7ED4202C));
  }
  public ref int NumNoVotes {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE0727D1E54F18188));
  }
  public ref int NumPotentialVotes {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE0727D1E61EC9307));
  }
  public IVoteController VoteController {
    get => new CVoteController(_Handle + Schema.GetOffset(0xE0727D1ECB818C7B));
  }


}