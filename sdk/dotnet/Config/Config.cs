// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;

namespace Pulumi.Packet
{
    public static class Config
    {
        private static readonly Pulumi.Config __config = new Pulumi.Config("packet");
        /// <summary>
        /// The API auth key for API operations.
        /// </summary>
        public static string? AuthToken { get; set; } = __config.Get("authToken") ?? Utilities.GetEnv("PACKET_AUTH_TOKEN");

    }
}
