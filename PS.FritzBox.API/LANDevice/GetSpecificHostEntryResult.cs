using System;
using System.Linq;
using System.Xml.Linq;

namespace PS.FritzBox.API.LANDevice
{
    /// <summary>
    /// result object for GetSpecificHostEntry
    /// </summary>
    public class GetSpecificHostEntryResult
    {
        #region construction / destruction

        /// <summary>
        /// constructor for parsing soap result
        /// </summary>	    
        internal GetSpecificHostEntryResult(XDocument soapresult)
        {
            this.IPAddress = soapresult.Descendants("NewIPAddress").First().Value;
            this.AddressSource = soapresult.Descendants("NewAddressSource").First().Value;
            this.LeaseTimeRemaining = Convert.ToInt32(soapresult.Descendants("NewLeaseTimeRemaining").First().Value);
            this.InterfaceType = soapresult.Descendants("NewInterfaceType").First().Value;
            this.Active = soapresult.Descendants("NewActive").First().Value == "1";
            this.HostName = soapresult.Descendants("NewHostName").First().Value;
        }

        #endregion

        #region properties

        /// <summary>
        /// gets or sets the IPAddress
        /// </summary>
        public string IPAddress { get; internal set;}

        /// <summary>
        /// gets or sets the AddressSource
        /// </summary>
        public string AddressSource { get; internal set;}

        /// <summary>
        /// gets or sets the LeaseTimeRemaining
        /// </summary>
        public Int32 LeaseTimeRemaining { get; internal set;}

        /// <summary>
        /// gets or sets the InterfaceType
        /// </summary>
        public string InterfaceType { get; internal set;}

        /// <summary>
        /// gets or sets the Active
        /// </summary>
        public bool Active { get; internal set;}

        /// <summary>
        /// gets or sets the HostName
        /// </summary>
        public string HostName { get; internal set;}

        #endregion
    }
}