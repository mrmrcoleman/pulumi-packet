// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../types/output";

export interface DeviceIpAddress {
    /**
     * bit length of the network mask of the address
     */
    cidr?: number;
    reservationIds?: string[];
    /**
     * Type of the port (e.g. `NetworkPort` or `NetworkBondPort`)
     */
    type: string;
}

export interface DeviceNetwork {
    /**
     * IPv4 or IPv6 address string
     */
    address: string;
    /**
     * bit length of the network mask of the address
     */
    cidr: number;
    /**
     * IP version - "4" or "6"
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
     * Type of the port (e.g. `NetworkPort` or `NetworkBondPort`)
     */
    type: string;
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
    asn: number;
    deploymentType: string;
    /**
     * The maximum number of route filters allowed per server
     */
    maxPrefix: number;
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
