using SwiftlyS2.Core.Schemas;

namespace SwiftlyS2.Shared.Schemas;

public interface ISchemaFixedString : ISchemaFixedArray<byte> {

  public string Value { get; set; }

}