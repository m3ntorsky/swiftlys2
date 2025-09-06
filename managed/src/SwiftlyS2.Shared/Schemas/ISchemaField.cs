using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Shared.Schemas;

public interface ISchemaField : INativeHandle {

  public bool IsField { get; set; }

  public bool FieldIsNetworked { get; set; }

  public int FieldOffset { get; set; }

  public int FieldSize { get; set; }

  public void FieldNetworkStateChanged();

}