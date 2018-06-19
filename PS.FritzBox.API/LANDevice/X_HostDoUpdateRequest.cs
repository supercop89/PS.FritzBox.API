using System;

namespace PS.FritzBox.API.TR64.LANDevice.Hosts
{
    /// <summary>
    /// request object for X_HostDoUpdate
    /// </summary>
    public class X_HostDoUpdateRequest
    {
        /// <summary>
        /// gets or sets the MACAddress
        /// </summary>
        public string MACAddress { get; set;}
    }
}