﻿namespace DD.CBU.Compute.Api.Contracts.Drs
{
	//------------------------------------------------------------------------------
	// <auto-generated>
	//     This code was generated by a tool.
	//     Runtime Version:4.0.30319.42000
	//
	//     Changes to this file may cause incorrect behavior and will be lost if
	//     the code is regenerated.
	// </auto-generated>
	//------------------------------------------------------------------------------

	using System.Xml.Serialization;

	// 
	// This source code was auto-generated by xsd, Version=4.6.1055.0.
	// 


	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
	[System.Xml.Serialization.XmlRootAttribute("setDrsReIpAddressRules", Namespace = "urn:didata.com:api:cloud:types", IsNullable = false)]
	public partial class SetDrsReIpAddressRulesType
	{

		/// <remarks/>
		public string hostName;

		/// <remarks/>
		public string domain;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("dnsServer")]
		public string[] dnsServer;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("dnsSuffix")]
		public string[] dnsSuffix;

		/// <remarks/>
		public bool netBiosEnabled;

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool netBiosEnabledSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("nicReIpAddressRules")]
		public SetDrsReIpAddressRulesTypeNicReIpAddressRules[] nicReIpAddressRules;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string serverPairId;
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:didata.com:api:cloud:types")]
	public partial class SetDrsReIpAddressRulesTypeNicReIpAddressRules
	{

		/// <remarks/>
		public string privateIpv4Address;

		/// <remarks/>
		public int ipv4PrefixSize;

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool ipv4PrefixSizeSpecified;

		/// <remarks/>
		public string ipv4GatewayAddress;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string targetNicId;
	}

}
