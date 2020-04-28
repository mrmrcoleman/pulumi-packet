// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Packet
{
    public static class GetSpotMarketPrice
    {
        /// <summary>
        /// Use this data source to get Packet Spot Market Price.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetSpotMarketPriceResult> InvokeAsync(GetSpotMarketPriceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSpotMarketPriceResult>("packet:index/getSpotMarketPrice:getSpotMarketPrice", args ?? new GetSpotMarketPriceArgs(), options.WithVersion());
    }


    public sealed class GetSpotMarketPriceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the facility.
        /// </summary>
        [Input("facility", required: true)]
        public string Facility { get; set; } = null!;

        /// <summary>
        /// Name of the plan.
        /// </summary>
        [Input("plan", required: true)]
        public string Plan { get; set; } = null!;

        public GetSpotMarketPriceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSpotMarketPriceResult
    {
        public readonly string Facility;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Plan;
        /// <summary>
        /// Current spot market price for given plan in given facility.
        /// </summary>
        public readonly double Price;

        [OutputConstructor]
        private GetSpotMarketPriceResult(
            string facility,

            string id,

            string plan,

            double price)
        {
            Facility = facility;
            Id = id;
            Plan = plan;
            Price = price;
        }
    }
}
