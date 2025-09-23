using SwiftlyS2.Core.Natives;

namespace SwiftlyS2.Core.Services;

internal class ProfileService {


  public void StartRecordingWithIdentifier(string identifier, string name)
  {
        // @todo: Implement resource monitor
        //NativeResmon.StartRecording(identifier, name);
  }
  public void StopRecordingWithIdentifier(string identifier, string name)
  {
        // @todo: Implement resource monitor
        //NativeResmon.StopRecording(identifier, name);
  }
  public void RecordTimeWithIdentifier(string identifier, string name, double duration) {
        // @todo: Implement resource monitor
        //NativeResmon.RecordTime(identifier, name, duration);
  }

  public void StartRecording(string name) {
    StartRecordingWithIdentifier("SwiftlyS2", name);
  }

  public void StopRecording(string name) {
    StopRecordingWithIdentifier("SwiftlyS2", name);
  }

  public void RecordTime(string name, double duration) {
    RecordTimeWithIdentifier("SwiftlyS2", name, duration);
  }

}
