// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package packet

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to get CIDR expression for precreated IPv6 and IPv4 blocks in Packet.
// You can then use the cidrsubnet TF builtin function to derive subnets.
func LookupPrecreatedIpBlock(ctx *pulumi.Context, args *GetPrecreatedIpBlockArgs) (*GetPrecreatedIpBlockResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["addressFamily"] = args.AddressFamily
		inputs["facility"] = args.Facility
		inputs["global"] = args.Global
		inputs["projectId"] = args.ProjectId
		inputs["public"] = args.Public
	}
	outputs, err := ctx.Invoke("packet:index/getPrecreatedIpBlock:getPrecreatedIpBlock", inputs)
	if err != nil {
		return nil, err
	}
	return &GetPrecreatedIpBlockResult{
		Address: outputs["address"],
		AddressFamily: outputs["addressFamily"],
		Cidr: outputs["cidr"],
		CidrNotation: outputs["cidrNotation"],
		Facility: outputs["facility"],
		Gateway: outputs["gateway"],
		Global: outputs["global"],
		Manageable: outputs["manageable"],
		Management: outputs["management"],
		Netmask: outputs["netmask"],
		Network: outputs["network"],
		ProjectId: outputs["projectId"],
		Public: outputs["public"],
		Quantity: outputs["quantity"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getPrecreatedIpBlock.
type GetPrecreatedIpBlockArgs struct {
	// 4 or 6, depending on which block you are looking for.
	AddressFamily interface{}
	// Facility of the searched block. (Optional) Only allowed for non-global blocks.
	Facility interface{}
	// Whether to look for global block. Default is false for backward compatibility.
	Global interface{}
	// ID of the project where the searched block should be.
	ProjectId interface{}
	// Whether to look for public or private block. 
	Public interface{}
}

// A collection of values returned by getPrecreatedIpBlock.
type GetPrecreatedIpBlockResult struct {
	Address interface{}
	AddressFamily interface{}
	Cidr interface{}
	// CIDR notation of the looked up block.
	CidrNotation interface{}
	Facility interface{}
	Gateway interface{}
	Global interface{}
	Manageable interface{}
	Management interface{}
	Netmask interface{}
	Network interface{}
	ProjectId interface{}
	Public interface{}
	Quantity interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
