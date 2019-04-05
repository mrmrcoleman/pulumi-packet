// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package packet

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a resource for [Packet Connect](https://www.packet.com/cloud/all-features/packet-connect/), a link between Packet VLANs and VLANs in other cloud providers.
type Connect struct {
	s *pulumi.ResourceState
}

// NewConnect registers a new resource with the given unique name, arguments, and options.
func NewConnect(ctx *pulumi.Context,
	name string, args *ConnectArgs, opts ...pulumi.ResourceOpt) (*Connect, error) {
	if args == nil || args.Facility == nil {
		return nil, errors.New("missing required argument 'Facility'")
	}
	if args == nil || args.Name == nil {
		return nil, errors.New("missing required argument 'Name'")
	}
	if args == nil || args.PortSpeed == nil {
		return nil, errors.New("missing required argument 'PortSpeed'")
	}
	if args == nil || args.ProjectId == nil {
		return nil, errors.New("missing required argument 'ProjectId'")
	}
	if args == nil || args.ProviderId == nil {
		return nil, errors.New("missing required argument 'ProviderId'")
	}
	if args == nil || args.ProviderPayload == nil {
		return nil, errors.New("missing required argument 'ProviderPayload'")
	}
	if args == nil || args.Vxlan == nil {
		return nil, errors.New("missing required argument 'Vxlan'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["facility"] = nil
		inputs["name"] = nil
		inputs["portSpeed"] = nil
		inputs["projectId"] = nil
		inputs["providerId"] = nil
		inputs["providerPayload"] = nil
		inputs["vxlan"] = nil
	} else {
		inputs["facility"] = args.Facility
		inputs["name"] = args.Name
		inputs["portSpeed"] = args.PortSpeed
		inputs["projectId"] = args.ProjectId
		inputs["providerId"] = args.ProviderId
		inputs["providerPayload"] = args.ProviderPayload
		inputs["vxlan"] = args.Vxlan
	}
	inputs["status"] = nil
	s, err := ctx.RegisterResource("packet:index/connect:Connect", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Connect{s: s}, nil
}

// GetConnect gets an existing Connect resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConnect(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ConnectState, opts ...pulumi.ResourceOpt) (*Connect, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["facility"] = state.Facility
		inputs["name"] = state.Name
		inputs["portSpeed"] = state.PortSpeed
		inputs["projectId"] = state.ProjectId
		inputs["providerId"] = state.ProviderId
		inputs["providerPayload"] = state.ProviderPayload
		inputs["status"] = state.Status
		inputs["vxlan"] = state.Vxlan
	}
	s, err := ctx.ReadResource("packet:index/connect:Connect", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Connect{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Connect) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Connect) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// Facility where to create the VLAN
func (r *Connect) Facility() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["facility"])
}

// Name for the Connect resource
func (r *Connect) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// Port speed in Mbps
func (r *Connect) PortSpeed() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["portSpeed"])
}

// ID of parent project
func (r *Connect) ProjectId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["projectId"])
}

// ID of Connect Provider. Provider IDs are
// * Azure ExpressRoute - "ed5de8e0-77a9-4d3b-9de0-65281d3aa831"
func (r *Connect) ProviderId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["providerId"])
}

// Authorization key for the Connect provider
func (r *Connect) ProviderPayload() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["providerPayload"])
}

// Status of the Connect resource, one of PROVISIONING, PROVISIONED, DEPROVISIONING, DEPROVISIONED
func (r *Connect) Status() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["status"])
}

// VXLAN Network identifier of the linked Packet VLAN
func (r *Connect) Vxlan() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["vxlan"])
}

// Input properties used for looking up and filtering Connect resources.
type ConnectState struct {
	// Facility where to create the VLAN
	Facility interface{}
	// Name for the Connect resource
	Name interface{}
	// Port speed in Mbps
	PortSpeed interface{}
	// ID of parent project
	ProjectId interface{}
	// ID of Connect Provider. Provider IDs are
	// * Azure ExpressRoute - "ed5de8e0-77a9-4d3b-9de0-65281d3aa831"
	ProviderId interface{}
	// Authorization key for the Connect provider
	ProviderPayload interface{}
	// Status of the Connect resource, one of PROVISIONING, PROVISIONED, DEPROVISIONING, DEPROVISIONED
	Status interface{}
	// VXLAN Network identifier of the linked Packet VLAN
	Vxlan interface{}
}

// The set of arguments for constructing a Connect resource.
type ConnectArgs struct {
	// Facility where to create the VLAN
	Facility interface{}
	// Name for the Connect resource
	Name interface{}
	// Port speed in Mbps
	PortSpeed interface{}
	// ID of parent project
	ProjectId interface{}
	// ID of Connect Provider. Provider IDs are
	// * Azure ExpressRoute - "ed5de8e0-77a9-4d3b-9de0-65281d3aa831"
	ProviderId interface{}
	// Authorization key for the Connect provider
	ProviderPayload interface{}
	// VXLAN Network identifier of the linked Packet VLAN
	Vxlan interface{}
}
