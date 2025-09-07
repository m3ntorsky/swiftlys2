using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncTankTrain : CFuncTrackTrain, IFuncTankTrain {

  public CFuncTankTrain(nint handle) : base(handle) {
  }

  public CFuncTankTrain(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntityIOOutput OnDeath {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xF7897E7E6F756BD2));
  }


}