// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Packet
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to get CIDR expression for precreated IPv6 and IPv4 blocks in Packet.
        /// You can then use the cidrsubnet TF builtin function to derive subnets.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-packet/blob/master/website/docs/d/precreated_ip_block.html.markdown.
        /// </summary>
        [Obsolete("Use GetPrecreatedIpBlock.InvokeAsync() instead")]
        public static Task<GetPrecreatedIpBlockResult> GetPrecreatedIpBlock(GetPrecreatedIpBlockArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPrecreatedIpBlockResult>("packet:index/getPrecreatedIpBlock:getPrecreatedIpBlock", args ?? InvokeArgs.Empty, options.WithVersion());
    }
    public static class GetPrecreatedIpBlock
    {
        /// <summary>
        /// Use this data source to get CIDR expression for precreated IPv6 and IPv4 blocks in Packet.
        /// You can then use the cidrsubnet TF builtin function to derive subnets.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-packet/blob/master/website/docs/d/precreated_ip_block.html.markdown.
        /// </summary>
        public static Task<GetPrecreatedIpBlockResult> InvokeAsync(GetPrecreatedIpBlockArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPrecreatedIpBlockResult>("packet:index/getPrecreatedIpBlock:getPrecreatedIpBlock", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetPrecreatedIpBlockArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// 4 or 6, depending on which block you are looking for.
        /// </summary>
        [Input("addressFamily", required: true)]
        public int AddressFamily { get; set; }

        /// <summary>
        /// Facility of the searched block. (Optional) Only allowed for non-global blocks.
        /// </summary>
        [Input("facility")]
        public string? Facility { get; set; }

        /// <summary>
        /// Whether to look for global block. Default is false for backward compatibility.
        /// </summary>
        [Input("global")]
        public bool? Global { get; set; }

        /// <summary>
        /// ID of the project where the searched block should be.
        /// </summary>
        [Input("projectId", required: true)]
        public string ProjectId { get; set; } = null!;

        /// <summary>
        /// Whether to look for public or private block. 
        /// </summary>
        [Input("public", required: true)]
        public bool Public { get; set; }

        public GetPrecreatedIpBlockArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetPrecreatedIpBlockResult
    {
        public readonly string Address;
        public readonly int AddressFamily;
        public readonly int Cidr;
        /// <summary>
        /// CIDR notation of the looked up block.
        /// </summary>
        public readonly string CidrNotation;
        public readonly string? Facility;
        public readonly string Gateway;
        public readonly bool? Global;
        public readonly bool Manageable;
        public readonly bool Management;
        public readonly string Netmask;
        public readonly string Network;
        public readonly string ProjectId;
        public readonly bool Public;
        public readonly int Quantity;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetPrecreatedIpBlockResult(
            string address,
            int addressFamily,
            int cidr,
            string cidrNotation,
            string? facility,
            string gateway,
            bool? global,
            bool manageable,
            bool management,
            string netmask,
            string network,
            string projectId,
            bool @public,
            int quantity,
            string id)
        {
            Address = address;
            AddressFamily = addressFamily;
            Cidr = cidr;
            CidrNotation = cidrNotation;
            Facility = facility;
            Gateway = gateway;
            Global = global;
            Manageable = manageable;
            Management = management;
            Netmask = netmask;
            Network = network;
            ProjectId = projectId;
            Public = @public;
            Quantity = quantity;
            Id = id;
        }
    }
}
