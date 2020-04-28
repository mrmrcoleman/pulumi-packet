// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Packet.Inputs
{

    public sealed class ProjectBgpConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Autonomous System Numer for local BGP deployment
        /// </summary>
        [Input("asn", required: true)]
        public Input<int> Asn { get; set; } = null!;

        /// <summary>
        /// `private` or `public`, the `private` is likely to be usable immediately, the `public` will need to be review by Packet engineers
        /// </summary>
        [Input("deploymentType", required: true)]
        public Input<string> DeploymentType { get; set; } = null!;

        /// <summary>
        /// The maximum number of route filters allowed per server
        /// </summary>
        [Input("maxPrefix")]
        public Input<int>? MaxPrefix { get; set; }

        /// <summary>
        /// Password for BGP session in plaintext (not a checksum)
        /// </summary>
        [Input("md5")]
        public Input<string>? Md5 { get; set; }

        /// <summary>
        /// status of BGP configuration in the project
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public ProjectBgpConfigArgs()
        {
        }
    }
}