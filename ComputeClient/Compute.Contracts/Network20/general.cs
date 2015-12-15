﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.81.0.
// 
namespace DD.CBU.Compute.Api.Contracts.Network20
{
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    [System.Xml.Serialization.XmlRootAttribute("response", Namespace = "urn:didata.com:api:cloud:types",
        IsNullable = false)]
    public partial class ResponseType
    {

        private string operationField;

        private string responseCodeField;

        private string messageField;

        private NameValuePairType[] infoField;

        private NameValuePairType[] warningField;

        private NameValuePairType[] errorField;

        private string requestIdField;

        /// <remarks/>
        public string operation
        {
            get { return this.operationField; }
            set { this.operationField = value; }
        }

        /// <remarks/>
        public string responseCode
        {
            get { return this.responseCodeField; }
            set { this.responseCodeField = value; }
        }

        /// <remarks/>
        public string message
        {
            get { return this.messageField; }
            set { this.messageField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("info")]
        public NameValuePairType[] info
        {
            get { return this.infoField; }
            set { this.infoField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("warning")]
        public NameValuePairType[] warning
        {
            get { return this.warningField; }
            set { this.warningField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("error")]
        public NameValuePairType[] error
        {
            get { return this.errorField; }
            set { this.errorField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestId
        {
            get { return this.requestIdField; }
            set { this.requestIdField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class NameValuePairType
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ProgressStepType
    {

        private string nameField;

        private int numberField;

        private int percentCompleteField;

        private bool percentCompleteFieldSpecified;

        /// <remarks/>
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        /// <remarks/>
        public int number
        {
            get { return this.numberField; }
            set { this.numberField = value; }
        }

        /// <remarks/>
        public int percentComplete
        {
            get { return this.percentCompleteField; }
            set { this.percentCompleteField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentCompleteSpecified
        {
            get { return this.percentCompleteFieldSpecified; }
            set { this.percentCompleteFieldSpecified = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class ProgressType
    {

        private string actionField;

        private System.DateTime requestTimeField;

        private string userNameField;

        private int numberOfStepsField;

        private bool numberOfStepsFieldSpecified;

        private System.DateTime updateTimeField;

        private bool updateTimeFieldSpecified;

        private ProgressStepType stepField;

        private string failureReasonField;

        /// <remarks/>
        public string action
        {
            get { return this.actionField; }
            set { this.actionField = value; }
        }

        /// <remarks/>
        public System.DateTime requestTime
        {
            get { return this.requestTimeField; }
            set { this.requestTimeField = value; }
        }

        /// <remarks/>
        public string userName
        {
            get { return this.userNameField; }
            set { this.userNameField = value; }
        }

        /// <remarks/>
        public int numberOfSteps
        {
            get { return this.numberOfStepsField; }
            set { this.numberOfStepsField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool numberOfStepsSpecified
        {
            get { return this.numberOfStepsFieldSpecified; }
            set { this.numberOfStepsFieldSpecified = value; }
        }

        /// <remarks/>
        public System.DateTime updateTime
        {
            get { return this.updateTimeField; }
            set { this.updateTimeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool updateTimeSpecified
        {
            get { return this.updateTimeFieldSpecified; }
            set { this.updateTimeFieldSpecified = value; }
        }

        /// <remarks/>
        public ProgressStepType step
        {
            get { return this.stepField; }
            set { this.stepField = value; }
        }

        /// <remarks/>
        public string failureReason
        {
            get { return this.failureReasonField; }
            set { this.failureReasonField = value; }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class VirtualHardwareType
    {

        private string versionField;

        private bool upToDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool upToDate
        {
            get
            {
                return this.upToDateField;
            }
            set
            {
                this.upToDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class VmwareToolsType
    {

        private string versionStatusField;

        private string runningStatusField;

        private int apiVersionField;

        private bool apiVersionFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string versionStatus
        {
            get
            {
                return this.versionStatusField;
            }
            set
            {
                this.versionStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string runningStatus
        {
            get
            {
                return this.runningStatusField;
            }
            set
            {
                this.runningStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int apiVersion
        {
            get
            {
                return this.apiVersionField;
            }
            set
            {
                this.apiVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool apiVersionSpecified
        {
            get
            {
                return this.apiVersionFieldSpecified;
            }
            set
            {
                this.apiVersionFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class CpuType
    {

        private uint countField;

        private string speedField;

        private uint coresPerSocketField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint coresPerSocket
        {
            get
            {
                return this.coresPerSocketField;
            }
            set
            {
                this.coresPerSocketField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class OperatingSystemType
    {

        private string idField;

        private string displayNameField;

        private string familyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displayName
        {
            get { return this.displayNameField; }
            set { this.displayNameField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string family
        {
            get { return this.familyField; }
            set { this.familyField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:didata.com:api:cloud:types")]
    public partial class IdAndNameType
    {

        private string idField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }
    }
}
