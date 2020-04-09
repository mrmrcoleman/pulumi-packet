// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Packet
{
    /// <summary>
    /// Provides a Packet device resource. This can be used to create,
    /// modify, and delete devices.
    /// 
    /// &gt; **Note:** All arguments including the `root_password` and `user_data` will be stored in
    ///  the raw state as plain-text.
    /// [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
    /// 
    /// 
    /// 
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-packet/blob/master/website/docs/r/device.html.markdown.
    /// </summary>
    public partial class Device : Pulumi.CustomResource
    {
        /// <summary>
        /// The ipv4 private IP assigned to the device
        /// </summary>
        [Output("accessPrivateIpv4")]
        public Output<string> AccessPrivateIpv4 { get; private set; } = null!;

        /// <summary>
        /// The ipv4 maintenance IP assigned to the device
        /// </summary>
        [Output("accessPublicIpv4")]
        public Output<string> AccessPublicIpv4 { get; private set; } = null!;

        /// <summary>
        /// The ipv6 maintenance IP assigned to the device
        /// </summary>
        [Output("accessPublicIpv6")]
        public Output<string> AccessPublicIpv6 { get; private set; } = null!;

        /// <summary>
        /// If true, a device with OS `custom_ipxe` will
        /// continue to boot via iPXE on reboots.
        /// </summary>
        [Output("alwaysPxe")]
        public Output<bool?> AlwaysPxe { get; private set; } = null!;

        /// <summary>
        /// monthly or hourly
        /// </summary>
        [Output("billingCycle")]
        public Output<string> BillingCycle { get; private set; } = null!;

        /// <summary>
        /// The timestamp for when the device was created
        /// </summary>
        [Output("created")]
        public Output<string> Created { get; private set; } = null!;

        /// <summary>
        /// The facility where the device is deployed.
        /// </summary>
        [Output("deployedFacility")]
        public Output<string> DeployedFacility { get; private set; } = null!;

        /// <summary>
        /// Description string for the device
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// List of facility codes with deployment preferences. Packet API will go through the list and will deploy your device to first facility with free capacity. List items must be facility codes or `any` (a wildcard). To find the facility code, visit [Facilities API docs](https://www.packet.com/developers/api/facilities), set your API auth token in the top of the page and see JSON from the API response.
        /// </summary>
        [Output("facilities")]
        public Output<ImmutableArray<string>> Facilities { get; private set; } = null!;

        /// <summary>
        /// Delete device even if it has volumes attached. Only applies for destroy action.
        /// </summary>
        [Output("forceDetachVolumes")]
        public Output<bool?> ForceDetachVolumes { get; private set; } = null!;

        /// <summary>
        /// The ID of hardware reservation which this device occupies
        /// * `hostname`- The hostname of the device
        /// </summary>
        [Output("hardwareReservationId")]
        public Output<string> HardwareReservationId { get; private set; } = null!;

        /// <summary>
        /// The device name
        /// </summary>
        [Output("hostname")]
        public Output<string> Hostname { get; private set; } = null!;

        /// <summary>
        /// A list of IP address types for the device (structure is documented below). 
        /// </summary>
        [Output("ipAddresses")]
        public Output<ImmutableArray<Outputs.DeviceIpAddresses>> IpAddresses { get; private set; } = null!;

        /// <summary>
        /// URL pointing to a hosted iPXE script. More
        /// information is in the
        /// [Custom iPXE](https://www.packet.com/developers/docs/servers/operating-systems/custom-ipxe/)
        /// doc.
        /// </summary>
        [Output("ipxeScriptUrl")]
        public Output<string?> IpxeScriptUrl { get; private set; } = null!;

        /// <summary>
        /// Whether the device is locked
        /// </summary>
        [Output("locked")]
        public Output<bool> Locked { get; private set; } = null!;

        /// <summary>
        /// The device's private and public IP (v4 and v6) network details. When a device is run without any special network configuration, it will have 3 networks: 
        /// * Public IPv4 at `packet_device.name.network.0`
        /// * IPv6 at `packet_device.name.network.1`
        /// * Private IPv4 at `packet_device.name.network.2`
        /// Elastic addresses then stack by type - an assigned public IPv4 will go after the management public IPv4 (to index 1), and will then shift the indices of the IPv6 and private IPv4. Assigned private IPv4 will go after the management private IPv4 (to the end of the network list).
        /// The fields of the network attributes are:
        /// </summary>
        [Output("networks")]
        public Output<ImmutableArray<Outputs.DeviceNetworks>> Networks { get; private set; } = null!;

        [Output("networkType")]
        public Output<string?> NetworkType { get; private set; } = null!;

        /// <summary>
        /// The operating system slug. To find the slug, or visit [Operating Systems API docs](https://www.packet.com/developers/api/operatingsystems), set your API auth token in the top of the page and see JSON from the API response.
        /// </summary>
        [Output("operatingSystem")]
        public Output<string> OperatingSystem { get; private set; } = null!;

        /// <summary>
        /// The device plan slug. To find the plan slug, visit [Device plans API docs](https://www.packet.com/developers/api/plans), set your auth token in the top of the page and see JSON from the API response.
        /// </summary>
        [Output("plan")]
        public Output<string> Plan { get; private set; } = null!;

        /// <summary>
        /// Ports assigned to the device
        /// </summary>
        [Output("ports")]
        public Output<ImmutableArray<Outputs.DevicePorts>> Ports { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which to create the device
        /// </summary>
        [Output("projectId")]
        public Output<string> ProjectId { get; private set; } = null!;

        [Output("projectSshKeyIds")]
        public Output<ImmutableArray<string>> ProjectSshKeyIds { get; private set; } = null!;

        /// <summary>
        /// Size of allocated subnet, more
        /// information is in the
        /// [Custom Subnet Size](https://www.packet.com/developers/docs/servers/key-features/custom-subnet-size/) doc.
        /// </summary>
        [Output("publicIpv4SubnetSize")]
        public Output<int> PublicIpv4SubnetSize { get; private set; } = null!;

        /// <summary>
        /// Root password to the server (disabled after 24 hours)
        /// </summary>
        [Output("rootPassword")]
        public Output<string> RootPassword { get; private set; } = null!;

        /// <summary>
        /// List of IDs of SSH keys deployed in the device, can be both user and project SSH keys
        /// </summary>
        [Output("sshKeyIds")]
        public Output<ImmutableArray<string>> SshKeyIds { get; private set; } = null!;

        /// <summary>
        /// The status of the device
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// JSON for custom partitioning. Only usable on reserved hardware. More information in in the [Custom Partitioning and RAID](https://www.packet.com/developers/docs/servers/key-features/cpr/) doc.
        /// </summary>
        [Output("storage")]
        public Output<string?> Storage { get; private set; } = null!;

        /// <summary>
        /// Tags attached to the device
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// The timestamp for the last time the device was updated
        /// </summary>
        [Output("updated")]
        public Output<string> Updated { get; private set; } = null!;

        /// <summary>
        /// A string of the desired User Data for the device.
        /// </summary>
        [Output("userData")]
        public Output<string?> UserData { get; private set; } = null!;

        /// <summary>
        /// Only used for devices in reserved hardware. If set, the deletion of this device will block until the hardware reservation is marked provisionable (about 4 minutes in August 2019).
        /// </summary>
        [Output("waitForReservationDeprovision")]
        public Output<bool?> WaitForReservationDeprovision { get; private set; } = null!;


        /// <summary>
        /// Create a Device resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Device(string name, DeviceArgs args, CustomResourceOptions? options = null)
            : base("packet:index/device:Device", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Device(string name, Input<string> id, DeviceState? state = null, CustomResourceOptions? options = null)
            : base("packet:index/device:Device", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Device resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Device Get(string name, Input<string> id, DeviceState? state = null, CustomResourceOptions? options = null)
        {
            return new Device(name, id, state, options);
        }
    }

    public sealed class DeviceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If true, a device with OS `custom_ipxe` will
        /// continue to boot via iPXE on reboots.
        /// </summary>
        [Input("alwaysPxe")]
        public Input<bool>? AlwaysPxe { get; set; }

        /// <summary>
        /// monthly or hourly
        /// </summary>
        [Input("billingCycle", required: true)]
        public Input<string> BillingCycle { get; set; } = null!;

        /// <summary>
        /// Description string for the device
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("facilities", required: true)]
        private InputList<string>? _facilities;

        /// <summary>
        /// List of facility codes with deployment preferences. Packet API will go through the list and will deploy your device to first facility with free capacity. List items must be facility codes or `any` (a wildcard). To find the facility code, visit [Facilities API docs](https://www.packet.com/developers/api/facilities), set your API auth token in the top of the page and see JSON from the API response.
        /// </summary>
        public InputList<string> Facilities
        {
            get => _facilities ?? (_facilities = new InputList<string>());
            set => _facilities = value;
        }

        /// <summary>
        /// Delete device even if it has volumes attached. Only applies for destroy action.
        /// </summary>
        [Input("forceDetachVolumes")]
        public Input<bool>? ForceDetachVolumes { get; set; }

        /// <summary>
        /// The ID of hardware reservation which this device occupies
        /// * `hostname`- The hostname of the device
        /// </summary>
        [Input("hardwareReservationId")]
        public Input<string>? HardwareReservationId { get; set; }

        /// <summary>
        /// The device name
        /// </summary>
        [Input("hostname", required: true)]
        public Input<string> Hostname { get; set; } = null!;

        [Input("ipAddresses")]
        private InputList<Inputs.DeviceIpAddressesArgs>? _ipAddresses;

        /// <summary>
        /// A list of IP address types for the device (structure is documented below). 
        /// </summary>
        public InputList<Inputs.DeviceIpAddressesArgs> IpAddresses
        {
            get => _ipAddresses ?? (_ipAddresses = new InputList<Inputs.DeviceIpAddressesArgs>());
            set => _ipAddresses = value;
        }

        /// <summary>
        /// URL pointing to a hosted iPXE script. More
        /// information is in the
        /// [Custom iPXE](https://www.packet.com/developers/docs/servers/operating-systems/custom-ipxe/)
        /// doc.
        /// </summary>
        [Input("ipxeScriptUrl")]
        public Input<string>? IpxeScriptUrl { get; set; }

        [Input("networkType")]
        public Input<string>? NetworkType { get; set; }

        /// <summary>
        /// The operating system slug. To find the slug, or visit [Operating Systems API docs](https://www.packet.com/developers/api/operatingsystems), set your API auth token in the top of the page and see JSON from the API response.
        /// </summary>
        [Input("operatingSystem", required: true)]
        public Input<string> OperatingSystem { get; set; } = null!;

        /// <summary>
        /// The device plan slug. To find the plan slug, visit [Device plans API docs](https://www.packet.com/developers/api/plans), set your auth token in the top of the page and see JSON from the API response.
        /// </summary>
        [Input("plan", required: true)]
        public Input<string> Plan { get; set; } = null!;

        /// <summary>
        /// The ID of the project in which to create the device
        /// </summary>
        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        [Input("projectSshKeyIds")]
        private InputList<string>? _projectSshKeyIds;
        public InputList<string> ProjectSshKeyIds
        {
            get => _projectSshKeyIds ?? (_projectSshKeyIds = new InputList<string>());
            set => _projectSshKeyIds = value;
        }

        /// <summary>
        /// Size of allocated subnet, more
        /// information is in the
        /// [Custom Subnet Size](https://www.packet.com/developers/docs/servers/key-features/custom-subnet-size/) doc.
        /// </summary>
        [Input("publicIpv4SubnetSize")]
        public Input<int>? PublicIpv4SubnetSize { get; set; }

        /// <summary>
        /// JSON for custom partitioning. Only usable on reserved hardware. More information in in the [Custom Partitioning and RAID](https://www.packet.com/developers/docs/servers/key-features/cpr/) doc.
        /// </summary>
        [Input("storage")]
        public Input<string>? Storage { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// Tags attached to the device
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// A string of the desired User Data for the device.
        /// </summary>
        [Input("userData")]
        public Input<string>? UserData { get; set; }

        /// <summary>
        /// Only used for devices in reserved hardware. If set, the deletion of this device will block until the hardware reservation is marked provisionable (about 4 minutes in August 2019).
        /// </summary>
        [Input("waitForReservationDeprovision")]
        public Input<bool>? WaitForReservationDeprovision { get; set; }

        public DeviceArgs()
        {
        }
    }

    public sealed class DeviceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ipv4 private IP assigned to the device
        /// </summary>
        [Input("accessPrivateIpv4")]
        public Input<string>? AccessPrivateIpv4 { get; set; }

        /// <summary>
        /// The ipv4 maintenance IP assigned to the device
        /// </summary>
        [Input("accessPublicIpv4")]
        public Input<string>? AccessPublicIpv4 { get; set; }

        /// <summary>
        /// The ipv6 maintenance IP assigned to the device
        /// </summary>
        [Input("accessPublicIpv6")]
        public Input<string>? AccessPublicIpv6 { get; set; }

        /// <summary>
        /// If true, a device with OS `custom_ipxe` will
        /// continue to boot via iPXE on reboots.
        /// </summary>
        [Input("alwaysPxe")]
        public Input<bool>? AlwaysPxe { get; set; }

        /// <summary>
        /// monthly or hourly
        /// </summary>
        [Input("billingCycle")]
        public Input<string>? BillingCycle { get; set; }

        /// <summary>
        /// The timestamp for when the device was created
        /// </summary>
        [Input("created")]
        public Input<string>? Created { get; set; }

        /// <summary>
        /// The facility where the device is deployed.
        /// </summary>
        [Input("deployedFacility")]
        public Input<string>? DeployedFacility { get; set; }

        /// <summary>
        /// Description string for the device
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("facilities")]
        private InputList<string>? _facilities;

        /// <summary>
        /// List of facility codes with deployment preferences. Packet API will go through the list and will deploy your device to first facility with free capacity. List items must be facility codes or `any` (a wildcard). To find the facility code, visit [Facilities API docs](https://www.packet.com/developers/api/facilities), set your API auth token in the top of the page and see JSON from the API response.
        /// </summary>
        public InputList<string> Facilities
        {
            get => _facilities ?? (_facilities = new InputList<string>());
            set => _facilities = value;
        }

        /// <summary>
        /// Delete device even if it has volumes attached. Only applies for destroy action.
        /// </summary>
        [Input("forceDetachVolumes")]
        public Input<bool>? ForceDetachVolumes { get; set; }

        /// <summary>
        /// The ID of hardware reservation which this device occupies
        /// * `hostname`- The hostname of the device
        /// </summary>
        [Input("hardwareReservationId")]
        public Input<string>? HardwareReservationId { get; set; }

        /// <summary>
        /// The device name
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        [Input("ipAddresses")]
        private InputList<Inputs.DeviceIpAddressesGetArgs>? _ipAddresses;

        /// <summary>
        /// A list of IP address types for the device (structure is documented below). 
        /// </summary>
        public InputList<Inputs.DeviceIpAddressesGetArgs> IpAddresses
        {
            get => _ipAddresses ?? (_ipAddresses = new InputList<Inputs.DeviceIpAddressesGetArgs>());
            set => _ipAddresses = value;
        }

        /// <summary>
        /// URL pointing to a hosted iPXE script. More
        /// information is in the
        /// [Custom iPXE](https://www.packet.com/developers/docs/servers/operating-systems/custom-ipxe/)
        /// doc.
        /// </summary>
        [Input("ipxeScriptUrl")]
        public Input<string>? IpxeScriptUrl { get; set; }

        /// <summary>
        /// Whether the device is locked
        /// </summary>
        [Input("locked")]
        public Input<bool>? Locked { get; set; }

        [Input("networks")]
        private InputList<Inputs.DeviceNetworksGetArgs>? _networks;

        /// <summary>
        /// The device's private and public IP (v4 and v6) network details. When a device is run without any special network configuration, it will have 3 networks: 
        /// * Public IPv4 at `packet_device.name.network.0`
        /// * IPv6 at `packet_device.name.network.1`
        /// * Private IPv4 at `packet_device.name.network.2`
        /// Elastic addresses then stack by type - an assigned public IPv4 will go after the management public IPv4 (to index 1), and will then shift the indices of the IPv6 and private IPv4. Assigned private IPv4 will go after the management private IPv4 (to the end of the network list).
        /// The fields of the network attributes are:
        /// </summary>
        public InputList<Inputs.DeviceNetworksGetArgs> Networks
        {
            get => _networks ?? (_networks = new InputList<Inputs.DeviceNetworksGetArgs>());
            set => _networks = value;
        }

        [Input("networkType")]
        public Input<string>? NetworkType { get; set; }

        /// <summary>
        /// The operating system slug. To find the slug, or visit [Operating Systems API docs](https://www.packet.com/developers/api/operatingsystems), set your API auth token in the top of the page and see JSON from the API response.
        /// </summary>
        [Input("operatingSystem")]
        public Input<string>? OperatingSystem { get; set; }

        /// <summary>
        /// The device plan slug. To find the plan slug, visit [Device plans API docs](https://www.packet.com/developers/api/plans), set your auth token in the top of the page and see JSON from the API response.
        /// </summary>
        [Input("plan")]
        public Input<string>? Plan { get; set; }

        [Input("ports")]
        private InputList<Inputs.DevicePortsGetArgs>? _ports;

        /// <summary>
        /// Ports assigned to the device
        /// </summary>
        public InputList<Inputs.DevicePortsGetArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Inputs.DevicePortsGetArgs>());
            set => _ports = value;
        }

        /// <summary>
        /// The ID of the project in which to create the device
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        [Input("projectSshKeyIds")]
        private InputList<string>? _projectSshKeyIds;
        public InputList<string> ProjectSshKeyIds
        {
            get => _projectSshKeyIds ?? (_projectSshKeyIds = new InputList<string>());
            set => _projectSshKeyIds = value;
        }

        /// <summary>
        /// Size of allocated subnet, more
        /// information is in the
        /// [Custom Subnet Size](https://www.packet.com/developers/docs/servers/key-features/custom-subnet-size/) doc.
        /// </summary>
        [Input("publicIpv4SubnetSize")]
        public Input<int>? PublicIpv4SubnetSize { get; set; }

        /// <summary>
        /// Root password to the server (disabled after 24 hours)
        /// </summary>
        [Input("rootPassword")]
        public Input<string>? RootPassword { get; set; }

        [Input("sshKeyIds")]
        private InputList<string>? _sshKeyIds;

        /// <summary>
        /// List of IDs of SSH keys deployed in the device, can be both user and project SSH keys
        /// </summary>
        public InputList<string> SshKeyIds
        {
            get => _sshKeyIds ?? (_sshKeyIds = new InputList<string>());
            set => _sshKeyIds = value;
        }

        /// <summary>
        /// The status of the device
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// JSON for custom partitioning. Only usable on reserved hardware. More information in in the [Custom Partitioning and RAID](https://www.packet.com/developers/docs/servers/key-features/cpr/) doc.
        /// </summary>
        [Input("storage")]
        public Input<string>? Storage { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// Tags attached to the device
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The timestamp for the last time the device was updated
        /// </summary>
        [Input("updated")]
        public Input<string>? Updated { get; set; }

        /// <summary>
        /// A string of the desired User Data for the device.
        /// </summary>
        [Input("userData")]
        public Input<string>? UserData { get; set; }

        /// <summary>
        /// Only used for devices in reserved hardware. If set, the deletion of this device will block until the hardware reservation is marked provisionable (about 4 minutes in August 2019).
        /// </summary>
        [Input("waitForReservationDeprovision")]
        public Input<bool>? WaitForReservationDeprovision { get; set; }

        public DeviceState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class DeviceIpAddressesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CIDR suffix for IP address block to be assigned, i.e. amount of addresses.
        /// </summary>
        [Input("cidr")]
        public Input<int>? Cidr { get; set; }

        [Input("reservationIds")]
        private InputList<string>? _reservationIds;
        public InputList<string> ReservationIds
        {
            get => _reservationIds ?? (_reservationIds = new InputList<string>());
            set => _reservationIds = value;
        }

        /// <summary>
        /// One of [`private_ipv4`, `public_ipv4`, `public_ipv6`]
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public DeviceIpAddressesArgs()
        {
        }
    }

    public sealed class DeviceIpAddressesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CIDR suffix for IP address block to be assigned, i.e. amount of addresses.
        /// </summary>
        [Input("cidr")]
        public Input<int>? Cidr { get; set; }

        [Input("reservationIds")]
        private InputList<string>? _reservationIds;
        public InputList<string> ReservationIds
        {
            get => _reservationIds ?? (_reservationIds = new InputList<string>());
            set => _reservationIds = value;
        }

        /// <summary>
        /// One of [`private_ipv4`, `public_ipv4`, `public_ipv6`]
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public DeviceIpAddressesGetArgs()
        {
        }
    }

    public sealed class DeviceNetworksGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// IPv4 or IPv6 address string
        /// </summary>
        [Input("address")]
        public Input<string>? Address { get; set; }

        /// <summary>
        /// CIDR suffix for IP address block to be assigned, i.e. amount of addresses.
        /// </summary>
        [Input("cidr")]
        public Input<int>? Cidr { get; set; }

        /// <summary>
        /// IP version - "4" or "6"
        /// </summary>
        [Input("family")]
        public Input<int>? Family { get; set; }

        /// <summary>
        /// address of router
        /// </summary>
        [Input("gateway")]
        public Input<string>? Gateway { get; set; }

        /// <summary>
        /// whether the address is routable from the Internet
        /// </summary>
        [Input("public")]
        public Input<bool>? Public { get; set; }

        public DeviceNetworksGetArgs()
        {
        }
    }

    public sealed class DevicePortsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether this port is part of a bond in bonded network setup
        /// * `project_id`- The ID of the project the device belongs to
        /// </summary>
        [Input("bonded")]
        public Input<bool>? Bonded { get; set; }

        /// <summary>
        /// ID of the port
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// MAC address assigned to the port
        /// </summary>
        [Input("mac")]
        public Input<string>? Mac { get; set; }

        /// <summary>
        /// Name of the port (e.g. `eth0`, or `bond0`)
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// One of [`private_ipv4`, `public_ipv4`, `public_ipv6`]
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public DevicePortsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class DeviceIpAddresses
    {
        /// <summary>
        /// CIDR suffix for IP address block to be assigned, i.e. amount of addresses.
        /// </summary>
        public readonly int? Cidr;
        public readonly ImmutableArray<string> ReservationIds;
        /// <summary>
        /// One of [`private_ipv4`, `public_ipv4`, `public_ipv6`]
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private DeviceIpAddresses(
            int? cidr,
            ImmutableArray<string> reservationIds,
            string type)
        {
            Cidr = cidr;
            ReservationIds = reservationIds;
            Type = type;
        }
    }

    [OutputType]
    public sealed class DeviceNetworks
    {
        /// <summary>
        /// IPv4 or IPv6 address string
        /// </summary>
        public readonly string Address;
        /// <summary>
        /// CIDR suffix for IP address block to be assigned, i.e. amount of addresses.
        /// </summary>
        public readonly int Cidr;
        /// <summary>
        /// IP version - "4" or "6"
        /// </summary>
        public readonly int Family;
        /// <summary>
        /// address of router
        /// </summary>
        public readonly string Gateway;
        /// <summary>
        /// whether the address is routable from the Internet
        /// </summary>
        public readonly bool Public;

        [OutputConstructor]
        private DeviceNetworks(
            string address,
            int cidr,
            int family,
            string gateway,
            bool @public)
        {
            Address = address;
            Cidr = cidr;
            Family = family;
            Gateway = gateway;
            Public = @public;
        }
    }

    [OutputType]
    public sealed class DevicePorts
    {
        /// <summary>
        /// Whether this port is part of a bond in bonded network setup
        /// * `project_id`- The ID of the project the device belongs to
        /// </summary>
        public readonly bool Bonded;
        /// <summary>
        /// ID of the port
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// MAC address assigned to the port
        /// </summary>
        public readonly string Mac;
        /// <summary>
        /// Name of the port (e.g. `eth0`, or `bond0`)
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// One of [`private_ipv4`, `public_ipv4`, `public_ipv6`]
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private DevicePorts(
            bool bonded,
            string id,
            string mac,
            string name,
            string type)
        {
            Bonded = bonded;
            Id = id;
            Mac = mac;
            Name = name;
            Type = type;
        }
    }
    }
}
