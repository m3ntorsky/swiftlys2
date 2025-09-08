using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCredits : CPointEntity, ICredits {

  public CCredits(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnCreditsDone {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xF1224C0488A2DA7A));
  }
  public ref bool RolledOutroCredits {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF1224C048E1511D4));
  }
  public ref float LogoLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF1224C04D283492C));
  }


}