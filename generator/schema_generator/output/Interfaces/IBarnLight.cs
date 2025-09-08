using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBarnLight : IBaseModelEntity {

  public ref bool Enabled { get; }
  
  public ref int ColorMode { get; }
  
  public ref Color Color { get; }
  
  public ref float ColorTemperature { get; }
  
  public ref float Brightness { get; }
  
  public ref float BrightnessScale { get; }
  
  public ref int DirectLight { get; }
  
  public ref int BakedShadowIndex { get; }
  
  public ref int LightPathUniqueId { get; }
  
  public ref int LightMapUniqueId { get; }
  
  public ref int LuminaireShape { get; }
  
  public ref float LuminaireSize { get; }
  
  public ref float LuminaireAnisotropy { get; }
  
  public ref CUtlString LightStyleString { get; }
  
  public IGameTime_t LightStyleStartTime { get; }
  
  public ref CUtlVector<CUtlString> QueuedLightStyleStrings { get; }
  
  public ref CUtlVector<CUtlString> LightStyleEvents { get; }
  
  public ref CUtlVector LightStyleTargets { get; }
  
  public IEntityIOOutput StyleEvent { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> LightCookie { get; }
  
  public ref float Shape { get; }
  
  public ref float SoftX { get; }
  
  public ref float SoftY { get; }
  
  public ref float Skirt { get; }
  
  public ref float SkirtNear { get; }
  
  public ref Vector SizeParams { get; }
  
  public ref float Range { get; }
  
  public ref Vector Shear { get; }
  
  public ref int BakeSpecularToCubemaps { get; }
  
  public ref Vector BakeSpecularToCubemapsSize { get; }
  
  public ref int CastShadows { get; }
  
  public ref int ShadowMapSize { get; }
  
  public ref int ShadowPriority { get; }
  
  public ref bool ContactShadow { get; }
  
  public ref bool ForceShadowsEnabled { get; }
  
  public ref int BounceLight { get; }
  
  public ref float BounceScale { get; }
  
  public ref float MinRoughness { get; }
  
  public ref Vector AlternateColor { get; }
  
  public ref float AlternateColorBrightness { get; }
  
  public ref int Fog { get; }
  
  public ref float FogStrength { get; }
  
  public ref int FogShadows { get; }
  
  public ref float FogScale { get; }
  
  public ref bool FogMixedShadows { get; }
  
  public ref float FadeSizeStart { get; }
  
  public ref float FadeSizeEnd { get; }
  
  public ref float ShadowFadeSizeStart { get; }
  
  public ref float ShadowFadeSizeEnd { get; }
  
  public ref bool PrecomputedFieldsValid { get; }
  
  public ref Vector PrecomputedBoundsMins { get; }
  
  public ref Vector PrecomputedBoundsMaxs { get; }
  
  public ref Vector PrecomputedOBBOrigin { get; }
  
  public ref QAngle PrecomputedOBBAngles { get; }
  
  public ref Vector PrecomputedOBBExtent { get; }
  
  public ref int PrecomputedSubFrusta { get; }
  
  public ref Vector PrecomputedOBBOrigin0 { get; }
  
  public ref QAngle PrecomputedOBBAngles0 { get; }
  
  public ref Vector PrecomputedOBBExtent0 { get; }
  
  public ref Vector PrecomputedOBBOrigin1 { get; }
  
  public ref QAngle PrecomputedOBBAngles1 { get; }
  
  public ref Vector PrecomputedOBBExtent1 { get; }
  
  public ref Vector PrecomputedOBBOrigin2 { get; }
  
  public ref QAngle PrecomputedOBBAngles2 { get; }
  
  public ref Vector PrecomputedOBBExtent2 { get; }
  
  public ref Vector PrecomputedOBBOrigin3 { get; }
  
  public ref QAngle PrecomputedOBBAngles3 { get; }
  
  public ref Vector PrecomputedOBBExtent3 { get; }
  
  public ref Vector PrecomputedOBBOrigin4 { get; }
  
  public ref QAngle PrecomputedOBBAngles4 { get; }
  
  public ref Vector PrecomputedOBBExtent4 { get; }
  
  public ref Vector PrecomputedOBBOrigin5 { get; }
  
  public ref QAngle PrecomputedOBBAngles5 { get; }
  
  public ref Vector PrecomputedOBBExtent5 { get; }
  
  public ref bool PvsModifyEntity { get; }
  
  public ref CUtlVector<ushort> VisClusters { get; }
  
}