#include "metamod.h"

SwiftlyMMBridge g_MMPluginBridge;

PLUGIN_EXPOSE(SwiftlyMMBridge, g_MMPluginBridge);
bool SwiftlyMMBridge::Load(PluginId id, ISmmAPI* ismm, char* error, size_t maxlen, bool late)
{
    PLUGIN_SAVEVARS();

    return true;
}

bool SwiftlyMMBridge::Unload(char* error, size_t maxlen)
{
    return true;
}

void SwiftlyMMBridge::AllPluginsLoaded()
{

}

void SwiftlyMMBridge::OnLevelInit(char const* pMapName, char const* pMapEntities, char const* pOldLevel, char const* pLandmarkName, bool loadGame, bool background)
{
}

void SwiftlyMMBridge::OnLevelShutdown()
{
}

const char* SwiftlyMMBridge::GetAuthor()
{
    return "Swiftly Development Team";
}

const char* SwiftlyMMBridge::GetName()
{
    return "SwiftlyS2";
}

const char* SwiftlyMMBridge::GetDescription()
{
    return "Lua/C# Framework for Source2-based games";
}

const char* SwiftlyMMBridge::GetURL()
{
    return "https://github.com/swiftly-solution/swiftly";
}

const char* SwiftlyMMBridge::GetLicense()
{
    return "GNU GPLv3";
}

const char* SwiftlyMMBridge::GetVersion()
{
#ifndef SWIFTLY_VERSION
    return "Local";
#else
    return SWIFTLY_VERSION;
#endif
}

const char* SwiftlyMMBridge::GetDate()
{
    return __DATE__;
}

const char* SwiftlyMMBridge::GetLogTag()
{
    return "SwiftlyS2";
}
