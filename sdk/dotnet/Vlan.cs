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
    /// Provides a resource to allow users to manage Virtual Networks in their projects.
    /// 
    /// To learn more about Layer 2 networking in Packet, refer to
    /// * https://www.packet.com/resources/guides/layer-2-configurations/
    /// * https://www.packet.com/developers/docs/network/advanced/layer-2/
    /// 
    /// 
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-packet/blob/master/website/docs/r/vlan.html.markdown.
    /// </summary>
    public partial class Vlan : Pulumi.CustomResource
    {
        /// <summary>
        /// Description string
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Facility where to create the VLAN
        /// </summary>
        [Output("facility")]
        public Output<string> Facility { get; private set; } = null!;

        /// <summary>
        /// ID of parent project
        /// </summary>
        [Output("projectId")]
        public Output<string> ProjectId { get; private set; } = null!;

        /// <summary>
        /// VXLAN segment ID
        /// </summary>
        [Output("vxlan")]
        public Output<int> Vxlan { get; private set; } = null!;


        /// <summary>
        /// Create a Vlan resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Vlan(string name, VlanArgs args, CustomResourceOptions? options = null)
            : base("packet:index/vlan:Vlan", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Vlan(string name, Input<string> id, VlanState? state = null, CustomResourceOptions? options = null)
            : base("packet:index/vlan:Vlan", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Vlan resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Vlan Get(string name, Input<string> id, VlanState? state = null, CustomResourceOptions? options = null)
        {
            return new Vlan(name, id, state, options);
        }
    }

    public sealed class VlanArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description string
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Facility where to create the VLAN
        /// </summary>
        [Input("facility", required: true)]
        public Input<string> Facility { get; set; } = null!;

        /// <summary>
        /// ID of parent project
        /// </summary>
        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        public VlanArgs()
        {
        }
    }

    public sealed class VlanState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description string
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Facility where to create the VLAN
        /// </summary>
        [Input("facility")]
        public Input<string>? Facility { get; set; }

        /// <summary>
        /// ID of parent project
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        /// <summary>
        /// VXLAN segment ID
        /// </summary>
        [Input("vxlan")]
        public Input<int>? Vxlan { get; set; }

        public VlanState()
        {
        }
    }
}
