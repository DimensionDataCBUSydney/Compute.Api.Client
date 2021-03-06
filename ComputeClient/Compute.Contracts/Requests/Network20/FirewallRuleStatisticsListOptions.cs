﻿namespace DD.CBU.Compute.Api.Contracts.Requests.Network20
{
    using System;

    /// <summary>A firewall rule list options model. </summary>
    public class FirewallRuleStatisticsListOptions : FilterableRequest
    {
		/// <summary>
		/// The "firewallRuleId" field name.
		/// </summary>
		public const string FirewallRuleIdField = "firewallRuleId";

        /// <summary>
        /// The "networkDomainId" field name.
        /// </summary>
        public const string NetworkDomainIdField = "networkDomainId";

        /// <summary>
        /// The "name" field name.
        /// </summary>
        public const string NameField = "name";

        /// <summary>
        /// The "state" field name.
        /// </summary>
        public const string StateField = "state";

		/// <summary>
		/// The "enabled" field name.
		/// </summary>
		public const string EnabledField = "enabled";


		/// <summary>	
		/// Filter by identifier.
		/// </summary>
		public Guid? FirewallRuleId
		{
            get { return GetFilter<Guid?>(FirewallRuleIdField); }
            set { SetFilter(FirewallRuleIdField, value); }
        }

        /// <summary>	
        /// Filter by Network Domain.
        /// </summary>
        public Guid NetworkDomainId
        {
            get { return GetFilter<Guid>(NetworkDomainIdField); }
            set { SetFilter(NetworkDomainIdField, value); }
        }

        /// <summary>	
        /// Filter by their name.
        /// </summary>
        public string Name
        {
            get { return GetFilter<string>(NameField); }
            set { SetFilter(NameField, value); }
        }

        /// <summary>	
        /// Filter by their state.
        /// Case insensitive. The initial possible set of values for state are:
        /// "NORMAL",
        /// "PENDING_ADD",
        /// "PENDING_CHANGE",
        /// "PENDING_DELETE",
        /// "FAILED_ADD",
        /// "FAILED_CHANGE",
        /// "FAILED_DELETE" and
        /// "REQUIRES_SUPPORT".
        /// </summary>
        public string State
        {
            get { return GetFilter<string>(StateField); }
            set { SetFilter(StateField, value); }
        }

        /// <summary>	
        /// Filter by their enabled.
        /// </summary>
        public bool Enabled
        {
	        get { return GetFilter<bool>(EnabledField); }
	        set { SetFilter(EnabledField, value); }
        }
	}
}
