// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides attachment of Packet Block Storage Volume to Devices.
 * 
 * Device and volume must be in the same location (facility).
 * 
 * Once attached by Terraform, they must then be mounted using the `packet_block_attach` and `packet_block_detach` scripts.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as packet from "@pulumi/packet";
 * 
 * const testProject = new packet.Project("test_project", {});
 * const testDeviceVa = new packet.Device("test_device_va", {
 *     billingCycle: "hourly",
 *     facility: "ewr1",
 *     hostname: "terraform-test-device-va",
 *     operatingSystem: "ubuntu_16_04",
 *     plan: "t1.small.x86",
 *     projectId: testProject.id,
 * });
 * const testVolumeVa = new packet.Volume("test_volume_va", {
 *     billingCycle: "hourly",
 *     facility: "ewr1",
 *     plan: "storage_1",
 *     projectId: testProject.id,
 *     size: 100,
 *     snapshotPolicies: [{
 *         snapshotCount: 7,
 *         snapshotFrequency: "1day",
 *     }],
 * });
 * const testVolumeAttachment = new packet.VolumeAttachment("test_volume_attachment", {
 *     deviceId: testDeviceVa.id,
 *     volumeId: testVolumeVa.id,
 * });
 * ```
 */
export class VolumeAttachment extends pulumi.CustomResource {
    /**
     * Get an existing VolumeAttachment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VolumeAttachmentState, opts?: pulumi.CustomResourceOptions): VolumeAttachment {
        return new VolumeAttachment(name, <any>state, { ...opts, id: id });
    }

    /**
     * The ID of the device to which the volume should be attached
     */
    public readonly deviceId: pulumi.Output<string>;
    /**
     * The ID of the volume to attach
     */
    public readonly volumeId: pulumi.Output<string>;

    /**
     * Create a VolumeAttachment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VolumeAttachmentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VolumeAttachmentArgs | VolumeAttachmentState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: VolumeAttachmentState = argsOrState as VolumeAttachmentState | undefined;
            inputs["deviceId"] = state ? state.deviceId : undefined;
            inputs["volumeId"] = state ? state.volumeId : undefined;
        } else {
            const args = argsOrState as VolumeAttachmentArgs | undefined;
            if (!args || args.deviceId === undefined) {
                throw new Error("Missing required property 'deviceId'");
            }
            if (!args || args.volumeId === undefined) {
                throw new Error("Missing required property 'volumeId'");
            }
            inputs["deviceId"] = args ? args.deviceId : undefined;
            inputs["volumeId"] = args ? args.volumeId : undefined;
        }
        super("packet:index/volumeAttachment:VolumeAttachment", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VolumeAttachment resources.
 */
export interface VolumeAttachmentState {
    /**
     * The ID of the device to which the volume should be attached
     */
    readonly deviceId?: pulumi.Input<string>;
    /**
     * The ID of the volume to attach
     */
    readonly volumeId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a VolumeAttachment resource.
 */
export interface VolumeAttachmentArgs {
    /**
     * The ID of the device to which the volume should be attached
     */
    readonly deviceId: pulumi.Input<string>;
    /**
     * The ID of the volume to attach
     */
    readonly volumeId: pulumi.Input<string>;
}
