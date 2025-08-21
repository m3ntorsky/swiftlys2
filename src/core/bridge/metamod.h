#ifndef _core_bridge_metamod_s2_h
#define _core_bridge_metamod_s2_h

#include <ISmmPlugin.h>
#include <igameevents.h>
#include <sh_vector.h>

class SwiftlyMMBridge : public ISmmPlugin, public IMetamodListener
{
public:
    bool Load(PluginId id, ISmmAPI* ismm, char* error, size_t maxlen, bool late);
    bool Unload(char* error, size_t maxlen);
    void AllPluginsLoaded();

    void OnLevelInit(char const* pMapName, char const* pMapEntities, char const* pOldLevel, char const* pLandmarkName, bool loadGame, bool background);
    void OnLevelShutdown();

public:
    const char* GetAuthor();
    const char* GetName();
    const char* GetDescription();
    const char* GetURL();
    const char* GetLicense();
    const char* GetVersion();
    const char* GetDate();
    const char* GetLogTag();
};

extern SwiftlyMMBridge g_MMPluginBridge;

PLUGIN_GLOBALVARS();

#endif