// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package packet

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Provides a resource to create and manage blocks of reserved IP addresses in a project.
//
// When a user provisions first device in a facility, Packet API automatically allocates IPv6/56 and private IPv4/25 blocks.
// The new device then gets IPv6 and private IPv4 addresses from those block. It also gets a public IPv4/31 address.
// Every new device in the project and facility will automatically get IPv6 and private IPv4 addresses from these pre-allocated blocks.
// The IPv6 and private IPv4 blocks can't be created, only imported. With this resource, it's possible to create either public IPv4 blocks or global IPv4 blocks.
//
// Public blocks are allocated in a facility. Addresses from public blocks can only be assigned to devices in the facility. Public blocks can have mask from /24 (256 addresses) to /32 (1 address). If you create public block with this resource, you must fill the facility argmument.
//
// Addresses from global blocks can be assigned in any facility. Global blocks can have mask from /30 (4 addresses), to /32 (1 address). If you create global block with this resource, you must specify type = "globalIpv4" and you must omit the facility argument.
//
// Once IP block is allocated or imported, an address from it can be assigned to device with the `.IpAttachment` resource.
//
//
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-packet/blob/master/website/docs/r/reserved_ip_block.html.markdown.
type ReservedIpBlock struct {
	pulumi.CustomResourceState

	Address pulumi.StringOutput `pulumi:"address"`
	// Address family as integer (4 or 6)
	AddressFamily pulumi.IntOutput `pulumi:"addressFamily"`
	// length of CIDR prefix of the block as integer
	Cidr pulumi.IntOutput `pulumi:"cidr"`
	// Address and mask in CIDR notation, e.g. "147.229.15.30/31"
	CidrNotation pulumi.StringOutput `pulumi:"cidrNotation"`
	// Arbitrary description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Facility where to allocate the public IP address block, makes sense only for type==public_ipv4, must be empty for type==global_ipv4
	Facility pulumi.StringPtrOutput `pulumi:"facility"`
	Gateway  pulumi.StringOutput    `pulumi:"gateway"`
	// boolean flag whether addresses from a block are global (i.e. can be assigned in any facility)
	Global     pulumi.BoolOutput `pulumi:"global"`
	Manageable pulumi.BoolOutput `pulumi:"manageable"`
	Management pulumi.BoolOutput `pulumi:"management"`
	// Mask in decimal notation, e.g. "255.255.255.0"
	Netmask pulumi.StringOutput `pulumi:"netmask"`
	// Network IP address portion of the block specification
	Network pulumi.StringOutput `pulumi:"network"`
	// The packet project ID where to allocate the address block
	ProjectId pulumi.StringOutput `pulumi:"projectId"`
	// boolean flag whether addresses from a block are public
	Public pulumi.BoolOutput `pulumi:"public"`
	// The number of allocated /32 addresses, a power of 2
	Quantity pulumi.IntOutput `pulumi:"quantity"`
	// Either "globalIpv4" or "publicIpv4", defaults to "publicIpv4" for backward compatibility
	Type pulumi.StringPtrOutput `pulumi:"type"`
}

// NewReservedIpBlock registers a new resource with the given unique name, arguments, and options.
func NewReservedIpBlock(ctx *pulumi.Context,
	name string, args *ReservedIpBlockArgs, opts ...pulumi.ResourceOption) (*ReservedIpBlock, error) {
	if args == nil || args.ProjectId == nil {
		return nil, errors.New("missing required argument 'ProjectId'")
	}
	if args == nil || args.Quantity == nil {
		return nil, errors.New("missing required argument 'Quantity'")
	}
	if args == nil {
		args = &ReservedIpBlockArgs{}
	}
	var resource ReservedIpBlock
	err := ctx.RegisterResource("packet:index/reservedIpBlock:ReservedIpBlock", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetReservedIpBlock gets an existing ReservedIpBlock resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetReservedIpBlock(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ReservedIpBlockState, opts ...pulumi.ResourceOption) (*ReservedIpBlock, error) {
	var resource ReservedIpBlock
	err := ctx.ReadResource("packet:index/reservedIpBlock:ReservedIpBlock", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ReservedIpBlock resources.
type reservedIpBlockState struct {
	Address *string `pulumi:"address"`
	// Address family as integer (4 or 6)
	AddressFamily *int `pulumi:"addressFamily"`
	// length of CIDR prefix of the block as integer
	Cidr *int `pulumi:"cidr"`
	// Address and mask in CIDR notation, e.g. "147.229.15.30/31"
	CidrNotation *string `pulumi:"cidrNotation"`
	// Arbitrary description
	Description *string `pulumi:"description"`
	// Facility where to allocate the public IP address block, makes sense only for type==public_ipv4, must be empty for type==global_ipv4
	Facility *string `pulumi:"facility"`
	Gateway  *string `pulumi:"gateway"`
	// boolean flag whether addresses from a block are global (i.e. can be assigned in any facility)
	Global     *bool `pulumi:"global"`
	Manageable *bool `pulumi:"manageable"`
	Management *bool `pulumi:"management"`
	// Mask in decimal notation, e.g. "255.255.255.0"
	Netmask *string `pulumi:"netmask"`
	// Network IP address portion of the block specification
	Network *string `pulumi:"network"`
	// The packet project ID where to allocate the address block
	ProjectId *string `pulumi:"projectId"`
	// boolean flag whether addresses from a block are public
	Public *bool `pulumi:"public"`
	// The number of allocated /32 addresses, a power of 2
	Quantity *int `pulumi:"quantity"`
	// Either "globalIpv4" or "publicIpv4", defaults to "publicIpv4" for backward compatibility
	Type *string `pulumi:"type"`
}

type ReservedIpBlockState struct {
	Address pulumi.StringPtrInput
	// Address family as integer (4 or 6)
	AddressFamily pulumi.IntPtrInput
	// length of CIDR prefix of the block as integer
	Cidr pulumi.IntPtrInput
	// Address and mask in CIDR notation, e.g. "147.229.15.30/31"
	CidrNotation pulumi.StringPtrInput
	// Arbitrary description
	Description pulumi.StringPtrInput
	// Facility where to allocate the public IP address block, makes sense only for type==public_ipv4, must be empty for type==global_ipv4
	Facility pulumi.StringPtrInput
	Gateway  pulumi.StringPtrInput
	// boolean flag whether addresses from a block are global (i.e. can be assigned in any facility)
	Global     pulumi.BoolPtrInput
	Manageable pulumi.BoolPtrInput
	Management pulumi.BoolPtrInput
	// Mask in decimal notation, e.g. "255.255.255.0"
	Netmask pulumi.StringPtrInput
	// Network IP address portion of the block specification
	Network pulumi.StringPtrInput
	// The packet project ID where to allocate the address block
	ProjectId pulumi.StringPtrInput
	// boolean flag whether addresses from a block are public
	Public pulumi.BoolPtrInput
	// The number of allocated /32 addresses, a power of 2
	Quantity pulumi.IntPtrInput
	// Either "globalIpv4" or "publicIpv4", defaults to "publicIpv4" for backward compatibility
	Type pulumi.StringPtrInput
}

func (ReservedIpBlockState) ElementType() reflect.Type {
	return reflect.TypeOf((*reservedIpBlockState)(nil)).Elem()
}

type reservedIpBlockArgs struct {
	// Arbitrary description
	Description *string `pulumi:"description"`
	// Facility where to allocate the public IP address block, makes sense only for type==public_ipv4, must be empty for type==global_ipv4
	Facility *string `pulumi:"facility"`
	// The packet project ID where to allocate the address block
	ProjectId string `pulumi:"projectId"`
	// The number of allocated /32 addresses, a power of 2
	Quantity int `pulumi:"quantity"`
	// Either "globalIpv4" or "publicIpv4", defaults to "publicIpv4" for backward compatibility
	Type *string `pulumi:"type"`
}

// The set of arguments for constructing a ReservedIpBlock resource.
type ReservedIpBlockArgs struct {
	// Arbitrary description
	Description pulumi.StringPtrInput
	// Facility where to allocate the public IP address block, makes sense only for type==public_ipv4, must be empty for type==global_ipv4
	Facility pulumi.StringPtrInput
	// The packet project ID where to allocate the address block
	ProjectId pulumi.StringInput
	// The number of allocated /32 addresses, a power of 2
	Quantity pulumi.IntInput
	// Either "globalIpv4" or "publicIpv4", defaults to "publicIpv4" for backward compatibility
	Type pulumi.StringPtrInput
}

func (ReservedIpBlockArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*reservedIpBlockArgs)(nil)).Elem()
}
