using SwiftlyS2.Core.Natives;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPlayerControllerImpl
{
    public void Respawn()
    {
        GameFunctions.CCSPlayerController_Respawn(Address);
    }
}