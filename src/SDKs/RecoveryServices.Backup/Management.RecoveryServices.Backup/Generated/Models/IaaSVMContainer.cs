// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IaaS VM workload-specific container.
    /// </summary>
    public partial class IaaSVMContainer : ProtectionContainer
    {
        /// <summary>
        /// Initializes a new instance of the IaaSVMContainer class.
        /// </summary>
        public IaaSVMContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IaaSVMContainer class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the container.</param>
        /// <param name="backupManagementType">Type of backup management for
        /// the container. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql', 'AzureStorage',
        /// 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="registrationStatus">Status of registration of the
        /// container with the Recovery Services Vault.</param>
        /// <param name="healthStatus">Status of health of the
        /// container.</param>
        /// <param name="virtualMachineId">Fully qualified ARM url of the
        /// virtual machine represented by this Azure IaaS VM
        /// container.</param>
        /// <param name="virtualMachineVersion">Specifies whether the container
        /// represents a Classic or an Azure Resource Manager VM.</param>
        /// <param name="resourceGroup">Resource group name of Recovery
        /// Services Vault.</param>
        public IaaSVMContainer(string friendlyName = default(string), string backupManagementType = default(string), string registrationStatus = default(string), string healthStatus = default(string), string virtualMachineId = default(string), string virtualMachineVersion = default(string), string resourceGroup = default(string))
            : base(friendlyName, backupManagementType, registrationStatus, healthStatus)
        {
            VirtualMachineId = virtualMachineId;
            VirtualMachineVersion = virtualMachineVersion;
            ResourceGroup = resourceGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets fully qualified ARM url of the virtual machine
        /// represented by this Azure IaaS VM container.
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachineId")]
        public string VirtualMachineId { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the container represents a Classic
        /// or an Azure Resource Manager VM.
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachineVersion")]
        public string VirtualMachineVersion { get; set; }

        /// <summary>
        /// Gets or sets resource group name of Recovery Services Vault.
        /// </summary>
        [JsonProperty(PropertyName = "resourceGroup")]
        public string ResourceGroup { get; set; }

    }
}
