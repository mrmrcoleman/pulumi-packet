// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package packet

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type VolumeAttachment struct {
	pulumi.CustomResourceState

	// The ID of the device to which the volume should be attached
	DeviceId pulumi.StringOutput `pulumi:"deviceId"`
	// The ID of the volume to attach
	VolumeId pulumi.StringOutput `pulumi:"volumeId"`
}

// NewVolumeAttachment registers a new resource with the given unique name, arguments, and options.
func NewVolumeAttachment(ctx *pulumi.Context,
	name string, args *VolumeAttachmentArgs, opts ...pulumi.ResourceOption) (*VolumeAttachment, error) {
	if args == nil || args.DeviceId == nil {
		return nil, errors.New("missing required argument 'DeviceId'")
	}
	if args == nil || args.VolumeId == nil {
		return nil, errors.New("missing required argument 'VolumeId'")
	}
	if args == nil {
		args = &VolumeAttachmentArgs{}
	}
	var resource VolumeAttachment
	err := ctx.RegisterResource("packet:index/volumeAttachment:VolumeAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVolumeAttachment gets an existing VolumeAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVolumeAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VolumeAttachmentState, opts ...pulumi.ResourceOption) (*VolumeAttachment, error) {
	var resource VolumeAttachment
	err := ctx.ReadResource("packet:index/volumeAttachment:VolumeAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VolumeAttachment resources.
type volumeAttachmentState struct {
	// The ID of the device to which the volume should be attached
	DeviceId *string `pulumi:"deviceId"`
	// The ID of the volume to attach
	VolumeId *string `pulumi:"volumeId"`
}

type VolumeAttachmentState struct {
	// The ID of the device to which the volume should be attached
	DeviceId pulumi.StringPtrInput
	// The ID of the volume to attach
	VolumeId pulumi.StringPtrInput
}

func (VolumeAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*volumeAttachmentState)(nil)).Elem()
}

type volumeAttachmentArgs struct {
	// The ID of the device to which the volume should be attached
	DeviceId string `pulumi:"deviceId"`
	// The ID of the volume to attach
	VolumeId string `pulumi:"volumeId"`
}

// The set of arguments for constructing a VolumeAttachment resource.
type VolumeAttachmentArgs struct {
	// The ID of the device to which the volume should be attached
	DeviceId pulumi.StringInput
	// The ID of the volume to attach
	VolumeId pulumi.StringInput
}

func (VolumeAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*volumeAttachmentArgs)(nil)).Elem()
}
