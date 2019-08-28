# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class Project(pulumi.CustomResource):
    backend_transfer: pulumi.Output[bool]
    """
    Enable or disable [Backend Transfer](https://support.packet.com/kb/articles/backend-transfer), default is false
    """
    bgp_config: pulumi.Output[dict]
    """
    Optional BGP settings. Refer to [Packet guide for BGP](https://support.packet.com/kb/articles/bgp).
    
      * `asn` (`float`)
      * `deploymentType` (`str`)
      * `maxPrefix` (`float`) - The maximum number of route filters allowed per server
      * `md5` (`str`)
      * `status` (`str`) - status of BGP configuration in the project
    """
    created: pulumi.Output[str]
    """
    The timestamp for when the project was created
    """
    name: pulumi.Output[str]
    """
    The name of the project
    """
    organization_id: pulumi.Output[str]
    """
    The UUID of organization under which you want to create the project. If you leave it out, the project will be create under your the default organization of your account.
    """
    payment_method_id: pulumi.Output[str]
    """
    The UUID of payment method for this project. The payment method and the project need to belong to the same organization (passed with `organization_id`, or default).
    """
    updated: pulumi.Output[str]
    """
    The timestamp for the last time the project was updated
    """
    def __init__(__self__, resource_name, opts=None, backend_transfer=None, bgp_config=None, name=None, organization_id=None, payment_method_id=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a Packet project resource to allow you manage devices
        in your projects.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] backend_transfer: Enable or disable [Backend Transfer](https://support.packet.com/kb/articles/backend-transfer), default is false
        :param pulumi.Input[dict] bgp_config: Optional BGP settings. Refer to [Packet guide for BGP](https://support.packet.com/kb/articles/bgp).
        :param pulumi.Input[str] name: The name of the project
        :param pulumi.Input[str] organization_id: The UUID of organization under which you want to create the project. If you leave it out, the project will be create under your the default organization of your account.
        :param pulumi.Input[str] payment_method_id: The UUID of payment method for this project. The payment method and the project need to belong to the same organization (passed with `organization_id`, or default).
        
        The **bgp_config** object supports the following:
        
          * `asn` (`pulumi.Input[float]`)
          * `deploymentType` (`pulumi.Input[str]`)
          * `maxPrefix` (`pulumi.Input[float]`) - The maximum number of route filters allowed per server
          * `md5` (`pulumi.Input[str]`)
          * `status` (`pulumi.Input[str]`) - status of BGP configuration in the project

        > This content is derived from https://github.com/terraform-providers/terraform-provider-packet/blob/master/website/docs/r/project.html.markdown.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['backend_transfer'] = backend_transfer
            __props__['bgp_config'] = bgp_config
            if name is None:
                raise TypeError("Missing required property 'name'")
            __props__['name'] = name
            __props__['organization_id'] = organization_id
            __props__['payment_method_id'] = payment_method_id
            __props__['created'] = None
            __props__['updated'] = None
        super(Project, __self__).__init__(
            'packet:index/project:Project',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, backend_transfer=None, bgp_config=None, created=None, name=None, organization_id=None, payment_method_id=None, updated=None):
        """
        Get an existing Project resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] backend_transfer: Enable or disable [Backend Transfer](https://support.packet.com/kb/articles/backend-transfer), default is false
        :param pulumi.Input[dict] bgp_config: Optional BGP settings. Refer to [Packet guide for BGP](https://support.packet.com/kb/articles/bgp).
        :param pulumi.Input[str] created: The timestamp for when the project was created
        :param pulumi.Input[str] name: The name of the project
        :param pulumi.Input[str] organization_id: The UUID of organization under which you want to create the project. If you leave it out, the project will be create under your the default organization of your account.
        :param pulumi.Input[str] payment_method_id: The UUID of payment method for this project. The payment method and the project need to belong to the same organization (passed with `organization_id`, or default).
        :param pulumi.Input[str] updated: The timestamp for the last time the project was updated
        
        The **bgp_config** object supports the following:
        
          * `asn` (`pulumi.Input[float]`)
          * `deploymentType` (`pulumi.Input[str]`)
          * `maxPrefix` (`pulumi.Input[float]`) - The maximum number of route filters allowed per server
          * `md5` (`pulumi.Input[str]`)
          * `status` (`pulumi.Input[str]`) - status of BGP configuration in the project

        > This content is derived from https://github.com/terraform-providers/terraform-provider-packet/blob/master/website/docs/r/project.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["backend_transfer"] = backend_transfer
        __props__["bgp_config"] = bgp_config
        __props__["created"] = created
        __props__["name"] = name
        __props__["organization_id"] = organization_id
        __props__["payment_method_id"] = payment_method_id
        __props__["updated"] = updated
        return Project(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

