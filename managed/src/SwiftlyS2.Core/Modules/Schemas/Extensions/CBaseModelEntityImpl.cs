using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseModelEntityImpl : CBaseModelEntity
{
    public void SetModel(string model)
    {
        GameFunctions.SetModel(Address, model);
    }
}