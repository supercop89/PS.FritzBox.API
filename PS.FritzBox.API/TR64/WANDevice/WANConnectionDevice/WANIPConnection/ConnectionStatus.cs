using System;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANIPConnection
{
    /// <summary>
    /// enumeration of ConnectionStatus
    /// </summary>
    public enum ConnectionStatus
    {
        UNCONFIGURED,
        CONNECTING,
        AUTHENTICATING,
        PENDINGDISCONNECT,
        DISCONNECTING,
        DISCONNECTED,
        CONNECTED
    }
}