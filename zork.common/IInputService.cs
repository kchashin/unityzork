using System;


namespace zork.common
{
    public interface IInputService
    {
        event EventHandler<string> InputReceived;
    }
}
