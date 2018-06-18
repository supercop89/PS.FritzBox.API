using System;

namespace PS.FritzBox.API.TR64.WANDevice.WANConnectionDevice.WANIPConnection
{
    /// <summary>
    /// request object for DeletePortMapping
    /// </summary>
    public class DeletePortMappingRequest
    {
        /// <summary>
        /// gets or sets the RemoteHost
        /// </summary>
        public string RemoteHost { get; set;}

        /// <summary>
        /// gets or sets the ExternalPort
        /// </summary>
        public Int32 ExternalPort { get; set;}

        /// <summary>
        /// gets or sets the Protocol
        /// </summary>
        public PortMappingProtocol Protocol { get; set;}
    }
}