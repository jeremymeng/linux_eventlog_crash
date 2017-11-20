using System.Diagnostics.Tracing;

public class Tasks
{
    public const EventTask ProcessAPI = (EventTask)1;
}

[EventSource(Name = "AndReader")]
public class AndReaderEventSource : EventSource
{
    public static int NextId;

    [Event(1, Opcode = EventOpcode.Start, Task = Tasks.ProcessAPI, Level = EventLevel.LogAlways)]
    public void StartRequest(int requestID) { WriteEvent(1, requestID); }

    [Event(2, Opcode = EventOpcode.Stop, Task = Tasks.ProcessAPI, Level = EventLevel.LogAlways)]
    public void StopRequest(int requestID) { WriteEvent(2, requestID); }

    public static AndReaderEventSource Logger = new AndReaderEventSource();
}
