namespace SwiftlyS2.Shared.Services;

public enum MessageType: byte
{
    Notify = 1,
    Console,
    Chat,
    Center,
    ChatEOT,
    Alert,
    CenterHTML
};