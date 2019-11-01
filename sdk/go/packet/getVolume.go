// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package packet

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Packet Block Storage Volume datasource to allow you to read existing volumes.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-packet/blob/master/website/docs/d/volume.html.markdown.
func LookupVolume(ctx *pulumi.Context, args *GetVolumeArgs) (*GetVolumeResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["name"] = args.Name
		inputs["projectId"] = args.ProjectId
		inputs["volumeId"] = args.VolumeId
	}
	outputs, err := ctx.Invoke("packet:index/getVolume:getVolume", inputs)
	if err != nil {
		return nil, err
	}
	return &GetVolumeResult{
		BillingCycle: outputs["billingCycle"],
		Created: outputs["created"],
		Description: outputs["description"],
		DeviceIds: outputs["deviceIds"],
		Facility: outputs["facility"],
		Locked: outputs["locked"],
		Name: outputs["name"],
		Plan: outputs["plan"],
		ProjectId: outputs["projectId"],
		Size: outputs["size"],
		SnapshotPolicies: outputs["snapshotPolicies"],
		State: outputs["state"],
		Updated: outputs["updated"],
		VolumeId: outputs["volumeId"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getVolume.
type GetVolumeArgs struct {
	// Name of volume for lookup
	Name interface{}
	// The ID the parent Packet project (for lookup by name)
	ProjectId interface{}
	VolumeId interface{}
}

// A collection of values returned by getVolume.
type GetVolumeResult struct {
	// The billing cycle, defaults to hourly
	BillingCycle interface{}
	Created interface{}
	Description interface{}
	// UUIDs of devices to which this volume is attached
	DeviceIds interface{}
	// The facility slug the volume resides in
	Facility interface{}
	// Whether the volume is locked or not
	Locked interface{}
	// The name of the volume
	// * `projectId ` - The project id the volume is in
	Name interface{}
	// Performance plan the volume is on
	Plan interface{}
	ProjectId interface{}
	// The size in GB of the volume
	Size interface{}
	SnapshotPolicies interface{}
	// The state of the volume
	State interface{}
	Updated interface{}
	VolumeId interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}