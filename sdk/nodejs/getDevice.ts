// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Provides a Packet device datasource.
 * 
 * > **Note:** All arguments including the `rootPassword` and `userData` will be stored in
 *  the raw state as plain-text.
 * [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
 * 
 * 
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-packet/blob/master/website/docs/d/device.html.markdown.
 */
export function getDevice(args?: GetDeviceArgs, opts?: pulumi.InvokeOptions): Promise<GetDeviceResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("packet:index/getDevice:getDevice", {
        "deviceId": args.deviceId,
        "hostname": args.hostname,
        "projectId": args.projectId,
    }, opts);
}

/**
 * A collection of arguments for invoking getDevice.
 */
export interface GetDeviceArgs {
    /**
     * Device ID
     */
    readonly deviceId?: string;
    /**
     * The device name
     */
    readonly hostname?: string;
    /**
     * The id of the project in which the devices exists
     */
    readonly projectId?: string;
}

/**
 * A collection of values returned by getDevice.
 */
export interface GetDeviceResult {
    /**
     * The ipv4 private IP assigned to the device
     */
    readonly accessPrivateIpv4: string;
    /**
     * The ipv4 management IP assigned to the device
     */
    readonly accessPublicIpv4: string;
    /**
     * The ipv6 management IP assigned to the device
     */
    readonly accessPublicIpv6: string;
    readonly alwaysPxe: boolean;
    /**
     * The billing cycle of the device (monthly or hourly)
     */
    readonly billingCycle: string;
    /**
     * Description string for the device
     */
    readonly description: string;
    readonly deviceId: string;
    /**
     * The facility where the device is deployed.
     */
    readonly facility: string;
    /**
     * The id of hardware reservation which this device occupies
     */
    readonly hardwareReservationId: string;
    readonly hostname: string;
    readonly ipxeScriptUrl: string;
    /**
     * The device's private and public IP (v4 and v6) network details. When a device is run without any special network configuration, it will have 3 networks: 
     * * Public IPv4 at `packet_device.name.network.0`
     * * IPv6 at `packet_device.name.network.1`
     * * Private IPv4 at `packet_device.name.network.2`
     * Elastic addresses then stack by type - an assigned public IPv4 will go after the management public IPv4 (to index 1), and will then shift the indices of the IPv6 and private IPv4. Assigned private IPv4 will go after the management private IPv4 (to the end of the network list).
     * The fields of the network attributes are:
     */
    readonly networks: outputs.GetDeviceNetwork[];
    /**
     * L2 network type of the device, one of "layer3", "layer2-bonded", "layer2-individual", "hybrid"
     */
    readonly networkType: string;
    /**
     * The operating system running on the device
     */
    readonly operatingSystem: string;
    /**
     * The hardware config of the device
     */
    readonly plan: string;
    /**
     * Ports assigned to the device
     */
    readonly ports: outputs.GetDevicePort[];
    readonly projectId: string;
    readonly publicIpv4SubnetSize: number;
    /**
     * Root password to the server (if still available)
     */
    readonly rootPassword: string;
    /**
     * List of IDs of SSH keys deployed in the device, can be both user or project SSH keys
     */
    readonly sshKeyIds: string[];
    /**
     * The state of the device
     */
    readonly state: string;
    readonly storage: string;
    /**
     * Tags attached to the device
     */
    readonly tags: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
