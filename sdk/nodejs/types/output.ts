// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";

export interface DeviceIpAddress {
    /**
     * CIDR suffix for IP address block to be assigned, i.e. amount of addresses.
     */
    cidr?: number;
    reservationIds?: string[];
    /**
     * One of [`privateIpv4`, `publicIpv4`, `publicIpv6`]
     */
    type: string;
}

export interface DeviceNetwork {
    /**
     * IPv4 or IPv6 address string
     */
    address: string;
    /**
     * CIDR suffix for IP address block to be assigned, i.e. amount of addresses.
     */
    cidr: number;
    /**
     * IP version - "4" or "6"
     * * `networkType` Network type of a device, used in [Layer 2 networking](https://www.packet.com/developers/docs/network/advanced/layer-2/). Will be one of `layer3`, `hybrid`, `layer2-individual` and `layer2-bonded`.
     */
    family: number;
    /**
     * address of router
     */
    gateway: string;
    /**
     * whether the address is routable from the Internet
     */
    public: boolean;
}

export interface DevicePort {
    /**
     * Whether this port is part of a bond in bonded network setup
     * * `projectId`- The ID of the project the device belongs to
     */
    bonded: boolean;
    /**
     * ID of the port
     */
    id: string;
    /**
     * MAC address assigned to the port
     */
    mac: string;
    /**
     * Name of the port (e.g. `eth0`, or `bond0`)
     */
    name: string;
    /**
     * One of [`privateIpv4`, `publicIpv4`, `publicIpv6`]
     */
    type: string;
}

export interface GetDeviceBgpNeighborsBgpNeighbor {
    /**
     * IP address version, 4 or 6
     */
    addressFamily: number;
    /**
     * Local autonomous system number
     */
    customerAs: number;
    /**
     * Local used peer IP address
     */
    customerIp: string;
    /**
     * Whether BGP session is password enabled
     */
    md5Enabled: boolean;
    /**
     * BGP session password in plaintext (not a checksum)
     */
    md5Password: string;
    /**
     * Whether the neighbor is in EBGP multihop session
     */
    multihop: boolean;
    /**
     * Peer AS number (different than customerAs for EBGP)
     */
    peerAs: number;
    /**
     * Array of IP addresses of this neighbor's peers
     */
    peerIps?: string[];
    /**
     * Array of incoming routes. Each route has attributes:
     */
    routesIns: outputs.GetDeviceBgpNeighborsBgpNeighborRoutesIn[];
    /**
     * Array of outgoing routes in the same format
     */
    routesOuts: outputs.GetDeviceBgpNeighborsBgpNeighborRoutesOut[];
}

export interface GetDeviceBgpNeighborsBgpNeighborRoutesIn {
    /**
     * (bool) Whether the route is exact
     */
    exact: boolean;
    /**
     * CIDR expression of route (ip/mask)
     */
    route: string;
}

export interface GetDeviceBgpNeighborsBgpNeighborRoutesOut {
    /**
     * (bool) Whether the route is exact
     */
    exact: boolean;
    /**
     * CIDR expression of route (ip/mask)
     */
    route: string;
}

export interface GetDeviceNetwork {
    /**
     * IPv4 or IPv6 address string
     */
    address: string;
    /**
     * Bit length of the network mask of the address
     */
    cidr: number;
    /**
     * IP version - "4" or "6"
     */
    family: number;
    /**
     * Address of router
     */
    gateway: string;
    /**
     * Whether the address is routable from the Internet
     */
    public: boolean;
}

export interface GetDevicePort {
    /**
     * Whether this port is part of a bond in bonded network setup
     */
    bonded: boolean;
    /**
     * ID of the port
     */
    id: string;
    /**
     * MAC address assigned to the port
     */
    mac: string;
    /**
     * Name of the port (e.g. `eth0`, or `bond0`)
     */
    name: string;
    /**
     * Type of the port (e.g. `NetworkPort` or `NetworkBondPort`)
     */
    type: string;
}

export interface GetProjectBgpConfig {
    /**
     * Autonomous System Numer for local BGP deployment
     */
    asn: number;
    /**
     * `private` or `public`, the `private` is likely to be usable immediately, the `public` will need to be review by Packet engineers
     */
    deploymentType: string;
    /**
     * The maximum number of route filters allowed per server
     */
    maxPrefix: number;
    /**
     * Password for BGP session in plaintext (not a checksum)
     */
    md5?: string;
    /**
     * status of BGP configuration in the project
     */
    status: string;
}

export interface GetVolumeSnapshotPolicy {
    snapshotCount: number;
    snapshotFrequency: string;
}

export interface ProjectBgpConfig {
    /**
     * Autonomous System Number for local BGP deployment
     */
    asn: number;
    /**
     * `private` or `public`, the `private` is likely to be usable immediately, the `public` will need to be review by Packet engineers
     */
    deploymentType: string;
    /**
     * The maximum number of route filters allowed per server
     */
    maxPrefix: number;
    /**
     * Password for BGP session in plaintext (not a checksum)
     */
    md5?: string;
    /**
     * status of BGP configuration in the project
     */
    status: string;
}

export interface SpotMarketRequestInstanceParameters {
    alwaysPxe?: string;
    billingCycle: string;
    description?: string;
    features?: string[];
    hostname: string;
    locked?: string;
    operatingSystem: string;
    plan: string;
    projectSshKeys?: string[];
    termintationTime: string;
    userSshKeys?: string[];
    userdata?: string;
}

export interface VolumeAttachment {
    href: string;
}

export interface VolumeSnapshotPolicy {
    snapshotCount: number;
    snapshotFrequency: string;
}
