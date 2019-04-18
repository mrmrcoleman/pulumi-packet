// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Provides a Packet project SSH key resource to manage project-specific SSH keys. On contrary to user SSH keys, project SSH keys are used to exclusively populate `authorized_keys` in new devices.
 * 
 * If you supply a list of project SSH keys when creating a new device, only the listed keys are used; user SSH keys are ignored.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as packet from "@pulumi/packet";
 * 
 * const projectId = "<UUID_of_your_project>";
 * const testProjectSshKey = new packet.ProjectSshKey("test", {
 *     name: "test",
 *     projectId: projectId,
 *     publicKey: "ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAACAQDM/unxJeFqxsTJcu6mhqsMHSaVlpu+Jj/P+44zrm6X/MAoHSX3X9oLgujEjjZ74yLfdfe0bJrbL2YgJzNaEkIQQ1VPMHB5EhTKUBGnzlPP0hHTnxsjAm9qDHgUPgvgFDQSAMzdJRJ0Cexo16Ph9VxCoLh3dxiE7s2gaM2FdVg7P8aSxKypsxAhYV3D0AwqzoOyT6WWhBoQ0xZ85XevOTnJCpImSemEGs6nVGEsWcEc1d1YvdxFjAK4SdsKUMkj4Dsy/leKsdi/DEAf356vbMT1UHsXXvy5TlHu/Pa6qF53v32Enz+nhKy7/8W2Yt2yWx8HnQcT2rug9lvCXagJO6oauqRTO77C4QZn13ZLMZgLT66S/tNh2EX0gi6vmIs5dth8uF+K6nxIyKJXbcA4ASg7F1OJrHKFZdTc5v1cPeq6PcbqGgc+8SrPYQmzvQqLoMBuxyos2hUkYOmw3aeWJj9nFa8Wu5WaN89mUeOqSkU4S5cgUzWUOmKey56B/j/s1sVys9rMhZapVs0wL4L9GBBM48N5jAQZnnpo85A8KsZq5ME22bTLqnxsDXqDYZvS7PSI6Dxi7eleOFE/NYYDkrgDLHTQri8ucDMVeVWHgoMY2bPXdn7KKy5jW5jKsf8EPARXg77A4gRYmgKrcwIKqJEUPqyxJBe0CPoGTqgXPRsUiQ== tomk@hp2",
 * });
 * const testDevice = new packet.Device("test", {
 *     billingCycle: "hourly",
 *     facility: "ewr1",
 *     hostname: "test",
 *     operatingSystem: "ubuntu_16_04",
 *     plan: "baremetal_0",
 *     projectId: projectId,
 *     projectSshKeyIds: [testProjectSshKey.id],
 * });
 * ```
 */
export class ProjectSshKey extends pulumi.CustomResource {
    /**
     * Get an existing ProjectSshKey resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ProjectSshKeyState, opts?: pulumi.CustomResourceOptions): ProjectSshKey {
        return new ProjectSshKey(name, <any>state, { ...opts, id: id });
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
     * The ID of parent project
     */
    public readonly projectId: pulumi.Output<string>;
    /**
     * The public key. If this is a file, it can be read using the file interpolation function
     */
    public readonly publicKey: pulumi.Output<string>;
    /**
     * The timestamp for the last time the SSH key was updated
     */
    public /*out*/ readonly updated: pulumi.Output<string>;

    /**
     * Create a ProjectSshKey resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ProjectSshKeyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ProjectSshKeyArgs | ProjectSshKeyState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: ProjectSshKeyState = argsOrState as ProjectSshKeyState | undefined;
            inputs["created"] = state ? state.created : undefined;
            inputs["fingerprint"] = state ? state.fingerprint : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["projectId"] = state ? state.projectId : undefined;
            inputs["publicKey"] = state ? state.publicKey : undefined;
            inputs["updated"] = state ? state.updated : undefined;
        } else {
            const args = argsOrState as ProjectSshKeyArgs | undefined;
            if (!args || args.name === undefined) {
                throw new Error("Missing required property 'name'");
            }
            if (!args || args.projectId === undefined) {
                throw new Error("Missing required property 'projectId'");
            }
            if (!args || args.publicKey === undefined) {
                throw new Error("Missing required property 'publicKey'");
            }
            inputs["name"] = args ? args.name : undefined;
            inputs["projectId"] = args ? args.projectId : undefined;
            inputs["publicKey"] = args ? args.publicKey : undefined;
            inputs["created"] = undefined /*out*/;
            inputs["fingerprint"] = undefined /*out*/;
            inputs["updated"] = undefined /*out*/;
        }
        super("packet:index/projectSshKey:ProjectSshKey", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ProjectSshKey resources.
 */
export interface ProjectSshKeyState {
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
     * The ID of parent project
     */
    readonly projectId?: pulumi.Input<string>;
    /**
     * The public key. If this is a file, it can be read using the file interpolation function
     */
    readonly publicKey?: pulumi.Input<string>;
    /**
     * The timestamp for the last time the SSH key was updated
     */
    readonly updated?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ProjectSshKey resource.
 */
export interface ProjectSshKeyArgs {
    /**
     * The name of the SSH key for identification
     */
    readonly name: pulumi.Input<string>;
    /**
     * The ID of parent project
     */
    readonly projectId: pulumi.Input<string>;
    /**
     * The public key. If this is a file, it can be read using the file interpolation function
     */
    readonly publicKey: pulumi.Input<string>;
}
