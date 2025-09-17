namespace SwiftlyS2.Shared.NetMessages;

public interface IRepeatedField {
}

public interface IProtobufRepeatedFieldValueType<T> : IRepeatedField, IList<T> where T :  unmanaged {



}

public interface IProtobufRepeatedFieldSubMessageType<T> : IRepeatedField, IList<T> where T : IProtobuf<T>
{

}