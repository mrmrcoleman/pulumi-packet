// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides a resource to manage User SSH keys on your Packet user account. If you create a new device in a project, all the keys of the project's collaborators will be injected to the device.
 * 
 * The link between User SSH key and device is implicit. If you want to make sure that a key will be copied to a device, you must ensure that the device resource `depends_on` the key resource.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as fs from "fs";
 * import * as packet from "@pulumi/packet";
 * 
 * // Create a new SSH key
 * const key1 = new packet.SshKey("key1", {
 *     name: "terraform-1",
 *     publicKey: fs.readFileSync("/home/terraform/.ssh/id_rsa.pub", "utf-8"),
 * });
 * // Create new device with "key1" included. The device resource "depends_on" the
 * // key, in order to make sure the key is created before the device.
 * const test = new packet.Device("test", {
 *     billingCycle: "hourly",
 *     facility: "sjc1",
 *     hostname: "test-device",
 *     operatingSystem: "ubuntu_16_04",
 *     plan: "t1.small.x86",
 *     projectId: local_project_id,
 * }, {dependsOn: [key1]});
 * ```
 */
export class SshKey extends pulumi.CustomResource {
    /**
     * Get an existing SshKey resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SshKeyState, opts?: pulumi.CustomResourceOptions): SshKey {
        return new SshKey(name, <any>state, { ...opts, id: id });
    }

    /**
     * The timestamp for when the SSH key was created
     */
    public /*out*/ readonly created: pulumi.Output<string>;
    /**
     * The fingerprint of the SSH key
     */
    public /*out*/ readonly fingerprint: pulumi.Output<string>;
    /**
     * The name of the SSH key for identification
     */
    public readonly name: pulumi.Output<string>;
    /**
     * The public key. If this is a file, it
     * can be read using the file interpolation function
     */
    public readonly publicKey: pulumi.Output<string>;
    /**
     * The timestamp for the last time the SSH key was updated
     */
    public /*out*/ readonly updated: pulumi.Output<string>;

    /**
     * Create a SshKey resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SshKeyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SshKeyArgs | SshKeyState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: SshKeyState = argsOrState as SshKeyState | undefined;
            inputs["created"] = state ? state.created : undefined;
            inputs["fingerprint"] = state ? state.fingerprint : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["publicKey"] = state ? state.publicKey : undefined;
            inputs["updated"] = state ? state.updated : undefined;
        } else {
            const args = argsOrState as SshKeyArgs | undefined;
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.publicKey === undefined) {
                throw new Error("Missing required property 'publicKey'");
            }
            inputs["name"] = args ? args.name : undefined;
            inputs["publicKey"] = args ? args.publicKey : undefined;
            inputs["created"] = undefined /*out*/;
            inputs["fingerprint"] = undefined /*out*/;
            inputs["updated"] = undefined /*out*/;
        }
        super("packet:index/sshKey:SshKey", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SshKey resources.
 */
export interface SshKeyState {
    /**
     * The timestamp for when the SSH key was created
     */
    readonly created?: pulumi.Input<string>;
    /**
     * The fingerprint of the SSH key
     */
    readonly fingerprint?: pulumi.Input<string>;
    /**
     * The name of the SSH key for identification
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The public key. If this is a file, it
     * can be read using the file interpolation function
     */
    readonly publicKey?: pulumi.Input<string>;
    /**
     * The timestamp for the last time the SSH key was updated
     */
    readonly updated?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a SshKey resource.
 */
export interface SshKeyArgs {
    /**
     * The name of the SSH key for identification
     */
    readonly name: pulumi.Input<string>;
    /**
     * The public key. If this is a file, it
     * can be read using the file interpolation function
     */
    readonly publicKey: pulumi.Input<string>;
}
