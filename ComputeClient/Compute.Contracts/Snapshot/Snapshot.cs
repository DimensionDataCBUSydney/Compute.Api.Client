﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DD.CBU.Compute.Api.Contracts.Network20;
using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 

    /// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:didata.com:api:cloud:types", IsNullable=false)]
public partial class snapshots {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("snapshot")]
    public SnapshotType[] snapshot;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int pageNumber;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool pageNumberSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int pageCount;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool pageCountSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int totalCount;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool totalCountSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int pageSize;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool pageSizeSpecified;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigType {
    
    /// <remarks/>
    public SnapshotServerConfigTypeCluster cluster;
    
    /// <remarks/>
    public SnapshotServerConfigTypeCpu cpu;
    
    /// <remarks/>
    public uint memoryGb;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("scsiController")]
    public SnapshotServerConfigTypeScsiController[] scsiController;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("sataController")]
    public SnapshotServerConfigTypeSataController[] sataController;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ideController")]
    public SnapshotServerConfigTypeIdeController[] ideController;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("floppy")]
    public SnapshotServerConfigTypeFloppy[] floppy;
    
    /// <remarks/>
    public SnapshotServerConfigTypeNetworkInfo networkInfo;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("softwareLabel")]
    public string[] softwareLabel;
    
    /// <remarks/>
    public SnapshotServerConfigTypeGuest guest;
    
    /// <remarks/>
    public string virtualHardwareVersion;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeCluster {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeCpu {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint count;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool countSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string speed;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint coresPerSocket;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool coresPerSocketSpecified;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeScsiController {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("disk")]
    public SnapshotServerConfigTypeScsiControllerDisk[] disk;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string adapterType;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string state;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int busNumber;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool busNumberSpecified;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeScsiControllerDisk {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int sizeGb;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sizeGbSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string speed;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string driveType;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string state;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int scsiId;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool scsiIdSpecified;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeSataController {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("device", typeof(SnapshotServerConfigTypeSataControllerDevice))]
    [System.Xml.Serialization.XmlElementAttribute("disk", typeof(SnapshotServerConfigTypeSataControllerDisk))]
    public object[] Items;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string adapterType;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string state;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int busNumber;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeSataControllerDevice {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int sizeGb;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sizeGbSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fileName;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string driveType;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string state;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int sataId;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeSataControllerDisk {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int sizeGb;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sizeGbSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string speed;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string driveType;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string state;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int sataId;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeIdeController {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("device", typeof(SnapshotServerConfigTypeIdeControllerDevice))]
    [System.Xml.Serialization.XmlElementAttribute("disk", typeof(SnapshotServerConfigTypeIdeControllerDisk))]
    public object[] Items;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string adapterType;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string state;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int channel;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool channelSpecified;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeIdeControllerDevice {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int sizeGb;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sizeGbSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fileName;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string driveType;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string state;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int slot;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotSpecified;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeIdeControllerDisk {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int sizeGb;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sizeGbSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string speed;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string driveType;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string state;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int slot;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotSpecified;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeFloppy {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int driveNumber;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int sizeGb;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sizeGbSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fileName;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string state;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeNetworkInfo {
    
    /// <remarks/>
    public SnapshotServerConfigTypeNetworkInfoPrimaryNic primaryNic;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("additionalNic")]
    public SnapshotServerConfigTypeNetworkInfoAdditionalNic[] additionalNic;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string networkDomainId;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string networkDomainName;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeNetworkInfoPrimaryNic {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string privateIpv4;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ipv6;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string vlanId;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string vlanName;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string networkAdapter;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool connected;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int key;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string state;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeNetworkInfoAdditionalNic {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string privateIpv4;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ipv6;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string vlanId;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string vlanName;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string networkAdapter;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool connected;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int key;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string state;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeGuest {
    
    /// <remarks/>
    public SnapshotServerConfigTypeGuestOperatingSystem operatingSystem;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool osCustomization;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool osCustomizationSpecified;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:didata.com:api:cloud:types")]
public partial class SnapshotServerConfigTypeGuestOperatingSystem {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string displayName;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string family;
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:didata.com:api:cloud:types")]
[System.Xml.Serialization.XmlRootAttribute("snapshot", Namespace="urn:didata.com:api:cloud:types", IsNullable=false)]
public partial class SnapshotType {
    
    /// <remarks/>
    public System.DateTime startTime;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool startTimeSpecified;
    
    /// <remarks/>
    public System.DateTime endTime;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool endTimeSpecified;
    
    /// <remarks/>
    public string type;
    
    /// <remarks/>
    public string consistencyLevel;
    
    /// <remarks/>
    public SnapshotServerConfigType serverConfig;
    
    /// <remarks/>
    public string state;
    
    /// <remarks/>
    public ProgressType progress;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id;
}
