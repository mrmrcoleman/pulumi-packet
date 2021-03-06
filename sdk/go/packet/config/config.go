// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package config

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi/config"
)

// The API auth key for API operations.
func GetAuthToken(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "packet:authToken")
	if err == nil {
		return v
	}
	return getEnvOrDefault("", nil, "PACKET_AUTH_TOKEN").(string)
}
