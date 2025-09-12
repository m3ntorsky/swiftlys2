using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncTrackChange : IFuncPlatRot {

  
  public IPathTrack TrackTop { get; }
  
  public IPathTrack TrackBottom { get; }
  
  public IFuncTrackTrain Train { get; }
  
  public ISchemaUntypedField TrackTopName { get; }
  
  public ISchemaUntypedField TrackBottomName { get; }
  
  public ISchemaUntypedField TrainName { get; }
  
  public ref TRAIN_CODE Code { get; }
  
  public ref int TargetState { get; }
  
  public ref int Use { get; }
}