using System.Runtime.CompilerServices;
using DD.CBU.Compute.Api.Contracts.Image;

namespace DD.CBU.Compute.Api.Client.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;

    using DD.CBU.Compute.Api.Contracts.Billing;
    using DD.CBU.Compute.Api.Contracts.Datacenter;
    using DD.CBU.Compute.Api.Contracts.Directory;
    using DD.CBU.Compute.Api.Contracts.General;
    using DD.CBU.Compute.Api.Contracts.Provisioning;
    using DD.CBU.Compute.Api.Contracts.Software;
    using DD.CBU.Compute.Api.Contracts.Server;

    /// <summary>
    /// The interface of the CaaS API Client
    /// </summary>
    public interface IComputeApiClient : IDisposable
    {
        /// <summary>
        /// The account of the organisation.
        /// </summary>
        IAccount Account { get; }

        /// <summary>
        /// The web API that requests directly from the REST API.
        /// </summary>
        IWebApi WebApi { get; }
        
        /// <summary>
        /// Login into the organisation account using credentials.
        /// </summary>
        /// <param name="accountCredentials">The account credentials.</param>
        /// <returns>The account associated with the organisation.</returns>
        Task<IAccount> LoginAsync(ICredentials accountCredentials);
        
        /// <summary>
        /// Gets a list of software labels.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<SoftwareLabel>> GetListOfSoftwareLabels();

        /// <summary>
        /// Gets a list of multi geography regions
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Region>> GetListOfMultiGeographyRegions();

        /// <summary>
        /// Deletes a sub administrator account
        /// </summary>
        /// <param name="username">The username</param>
        /// <returns></returns>
        Task<ApiStatus> DeleteSubAdministratorAccountAsync(string username);

        /// <summary>
        /// Designate a primary administrator account
        /// </summary>
        /// <param name="username">The username</param>
        /// <returns></returns>
        Task<ApiStatus> DesignatePrimaryAdministratorAccountAsync(string username);

        /// <summary>
        /// Gets all the data centres for the organisation.
        /// </summary>
        /// <returns>The data centres.</returns>
        Task<IEnumerable<DatacenterWithMaintenanceStatusType>> GetDataCentersWithMaintenanceStatuses();

        /// <summary>
        /// Gets the account of the organisation.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Account>> GetAccounts();

        /// <summary>
        /// Adds a sub administrator account
        /// </summary>
        /// <param name="account">The account</param>
        /// <returns></returns>
        Task<Status> AddSubAdministratorAccount(Account account);
        
        /// <summary>
        /// Updates an administrator account
        /// </summary>
        /// <param name="account">The account</param>
        /// <returns></returns>
        Task<Status> UpdateAdministratorAccount(Account account);

        /// <summary>
        /// Gets available data centres
        /// </summary>
        /// <returns></returns>
        [Obsolete("Use GetDataCentersWithMaintenanceStatuses instead!")]
        Task<IReadOnlyList<DatacenterWithDiskSpeedDetails>> GetAvailableDataCenters();

        /// <summary>
        /// Gets the OS images at a particular location.
        /// </summary>
        /// <param name="locationName">The location.</param>
        /// <returns></returns>
        [Obsolete]
        Task<IReadOnlyList<DeployedImageWithSoftwareLabelsType>> GetImages(string locationName);


        /// <summary>
        /// Get OS server images
        /// </summary>
        /// <param name="imageId">the imageId filter</param>
        /// <param name="name">the name filter</param>
        /// <param name="location">the location filter</param>
        /// <param name="operatingSystemId">the OS id</param>
        /// <param name="operatingSystemFamily">The OS family</param>
        /// <returns></returns>
        Task<IReadOnlyList<ImagesWithDiskSpeedImage>> GetImages(string imageId, string name, string location, string operatingSystemId, string operatingSystemFamily);

        /// <summary>
        /// Gets the deployed customer server images.
        /// </summary>
        /// <param name="networkLocation">The location.</param>
        /// <returns></returns>
        [Obsolete]
        Task<IEnumerable<DeployedImageWithSoftwareLabelsType>> GetCustomerServerImages(string networkLocation);


        /// <summary>
        /// Get customer server images
        /// </summary>
        /// <param name="imageId">the imageId filter</param>
        /// <param name="name">the name filter</param>
        /// <param name="location">the location filter</param>
        /// <param name="operatingSystemId">the OS id</param>
        /// <param name="operatingSystemFamily">The OS family</param>
        /// <returns></returns>
        Task<IReadOnlyList<ImagesWithDiskSpeedImage>> GetCustomerServerImages(string imageId, string name, string location, string operatingSystemId, string operatingSystemFamily);

        /// <summary>
        /// Remove customer images
        /// </summary>
        /// <param name="imageid">the image id</param>
        /// <returns></returns>
        Task<Status> RemoveCustomerServerImage(string imageid);


        /// <summary>
        /// Deploy a server using an image in a specified network.
        /// </summary>
        /// <param name="name">The name of the new server.</param>
        /// <param name="description">The description of the new server.</param>
        /// <param name="networkId">The network id to deploy the server.</param>
        /// <param name="imageId">The image id to deploy the server.</param>
        /// <param name="adminPassword">The administrator password.</param>
        /// <param name="isStarted">Will the server powers on after deployment?</param>
        /// <returns>The status of the deployment.</returns>
        Task<Status> DeployServerImageTask(
            string name,
            string description,
            string networkId,
            string imageId,
            string adminPassword,
            bool isStarted);

        /// <summary>
        /// Deploy a server using an image in a specified network.
        /// </summary>
        /// <param name="name">The name of the new server.</param>
        /// <param name="description">The description of the new server.</param>
        /// <param name="privateIp">The privateIp address to deploy the server.</param>
        /// <param name="networkId">The network id to deploy the server.</param>
        /// <param name="imageId">The image id to deploy the server.</param>
        /// <param name="adminPassword">The administrator password.</param>
        /// <param name="start">Will the server powers on after deployment?</param>
        /// <param name="disk">Array od disk configurations</param>
        /// <returns>The status of the deployment.</returns>
        Task<Status> DeployServerWithDiskSpeedImageTask(
            string name,
            string description,
            string networkId,
            string privateIp,
            string imageId,
            string adminPassword,
            bool start,
            Disk[] disk
            );


        /// <summary>
        /// Deploy a server using an image in a specified network.
        /// </summary>
        /// <param name="name">The name of the new server.</param>
        /// <param name="description">The description of the new server.</param>
        /// <param name="privateIp">The network id or privateIp address to deploy the server.</param>
        /// <param name="networkId">The network id to deploy the server.</param>
        /// <param name="imageId">The image id to deploy the server.</param>
        /// <param name="adminPassword">The administrator password.</param>
        /// <param name="start">Will the server powers on after deployment?</param>
        /// <returns>The status of the deployment.</returns>
        Task<Status> DeployServerWithDiskSpeedImageTask(
            string name,
            string description,
            string networkId,
            string privateIp,
            string imageId,
            string adminPassword,
            bool start
       
            );


        /// <summary>
        /// Modify server server settings.
        /// </summary>
        /// <param name="serverId">The server id.</param>
        /// <param name="name">The server new name on CaaS. This paramenter does not change the machine/host name.</param>
        /// <param name="description">The new description for the server.</param>
        /// <param name="memory">Memory (in MB). Value must be represent a GB integer (e.g. 1024,. 2048, 3072, 4096, etc.)<param>
        /// <param name="cpuCount">Number of virtual CPU�s (e.g. 1, 2, 4 etc.)<param>        
        /// <param name="privateIp">The new privateIp of the server.</param>
        /// <returns>The status of the deployment.</returns>
        Task<Status> ModifyServer(string serverId, string name, string description, int memory, int cpucount,string privateIp);

               
        /// <summary>
        /// Powers on the server.
        /// </summary>
        /// <param name="serverId">The server id.</param>
        /// <returns></returns>
        Task<Status> ServerPowerOn(string serverId);

        /// <summary>
        /// Powers off the server.
        /// </summary>
        /// <param name="serverId"></param>
        /// <returns></returns>
        Task<Status> ServerPowerOff(string serverId);

        /// <summary>
        /// Restart the server.
        /// </summary>
        /// <param name="serverId">The server id.</param>
        /// <returns></returns>
        Task<Status> ServerRestart(string serverId);

        /// <summary>
        /// Shutdown the server.
        /// </summary>
        /// <param name="serverId">The server id.</param>
        /// <returns></returns>
        Task<Status> ServerShutdown(string serverId);



        /// <summary>
        /// Modify server disk size.
        /// </summary>
        /// <param name="serverId">The server id.</param>
        /// <param name="diskId">The scsi disk Id.</param>
        /// <param name="sizeInGb">sizeInGb.</param>
        /// <returns>The status of the deployment.</returns>
        Task<Status> ChangeServerDiskSize(string serverId, string diskId, string sizeInGb);


        /// <summary>
        /// Modify server disk speed.
        /// </summary>
        /// <param name="serverId">The server id.</param>
        /// <param name="diskId">The scsi disk Id.</param>
        /// <param name="speedId">sizeInGb.</param>
        /// <returns>The status of the deployment.</returns>
        Task<Status> ChangeServerDiskSpeed(string serverId, string diskId, string speedId);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverId">The server id</param>
        /// <param name="size">the size of the new disk</param>
        /// <param name="speed">the speed of the new disk</param>
        /// <returns></returns>
        Task<Status> AddServerDisk(string serverId, string size, string speedId);



        /// <summary>
        /// Modify server server settings.
        /// </summary>
        /// <param name="serverId">The server id.</param>
        /// <param name="diskId">The scsi disk Id.</param>
        /// <returns>The status of the deployment.</returns>
        Task<Status> RemoveServerDisk(string serverId, string diskId);


        /// <summary>
        /// Triggers an update of the VMware Tools software running on the guest OS of a virtual server
        /// </summary>
        /// <param name="serverId">The server id.</param>
        /// <returns></returns>
        Task<Status> ServerUpdateVMwareTools(string serverId);


        /// <summary>
        /// Delete the server.
        /// </summary>
        /// <param name="serverId">The server id.</param>
        /// <returns></returns>
        Task<Status> ServerDelete(string serverId);


        /// <summary>
        /// Initiates a clone of a server to create a Customer Image
        /// </summary>
        /// <param name="serverId">The server id.</param>
        /// <param name="imageName">the customer image name.</param>
        /// <param name="imageDesc">the customer image description.</param>
        /// <returns></returns>
        Task<Status> ServerCloneToCustomerImage(string serverId,string imageName, string imageDesc);

        /// <summary>
        /// Gets the deployed servers.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ServerWithBackupType>> GetDeployedServers();


        /// <summary>
        /// Gets a filtered list of deployed servers.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ServerWithBackupType>> GetDeployedServers(string serverid, string name,string networkId, string location);

       /// <summary>
       /// Creates a new Server Anti-Affinity Rule between two servers on the same Cloud network. 
       /// </summary>
       /// <param name="serverId1">the serverId for the 1st server</param>
        /// <param name="serverId2">the serverId for the 2nd server</param>
       /// <returns></returns>
        Task<Status> CreateServerAntiAffinityRule(string serverId1, string serverId2);

        /// <summary>
        /// List all Server Anti-Affinity Rules 
        /// </summary>
        /// <param name="ruleId">filter by ruleId</param>
        /// <param name="location">filter by location</param>
        /// <param name="networkId">filter by networkid</param>
        /// <returns></returns>
        Task<IEnumerable<AntiAffinityRuleType>> GetServerAntiAffinityRules(string ruleId, string location,
            string networkId);



        /// <summary>
        /// Remove a server Anti-Affinity Rule between two servers on the same Cloud network. 
        /// </summary>
        /// <param name="ruleId">the ruleId</param>
        /// <returns></returns>
        Task<Status> RemoveServerAntiAffinityRule(string ruleId);

        /// <summary>
        /// Provision customer in home geo
        /// </summary>
        /// <param name="organizationId">Organization Id</param>
        /// <param name="customerProvision">Customer Provision</param>
        /// <returns>Status</returns>
        Task<Status> Provision(Guid organizationId, CustomerProvision customerProvision);

        /// <summary>
        /// Provision customers on Geo
        /// </summary>
        /// <param name="organizationId">Organization Id</param>
        /// <param name="geographyId">Geography Id</param>
        /// <param name="customerPricingPlanKey">Pricing Plan Key</param>
        /// <returns>Status</returns>
        Task<Status> ProvisionOnGeo(Guid organizationId, Guid geographyId, string customerPricingPlanKey);

        /// <summary>
        /// List Multi-Geography Data Centers With Key
        /// </summary>
        /// <param name="organizationId">Organization Id</param>
        Task<Geos> ListMultiGeoDataCentersWithKey(Guid organizationId);
    }
}