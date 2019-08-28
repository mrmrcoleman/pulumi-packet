# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class GetOperatingSystemResult:
    """
    A collection of values returned by getOperatingSystem.
    """
    def __init__(__self__, distro=None, name=None, provisionable_on=None, slug=None, version=None, id=None):
        if distro and not isinstance(distro, str):
            raise TypeError("Expected argument 'distro' to be a str")
        __self__.distro = distro
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if provisionable_on and not isinstance(provisionable_on, str):
            raise TypeError("Expected argument 'provisionable_on' to be a str")
        __self__.provisionable_on = provisionable_on
        if slug and not isinstance(slug, str):
            raise TypeError("Expected argument 'slug' to be a str")
        __self__.slug = slug
        """
        Operating system slug (same as `id`)
        """
        if version and not isinstance(version, str):
            raise TypeError("Expected argument 'version' to be a str")
        __self__.version = version
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """
class AwaitableGetOperatingSystemResult(GetOperatingSystemResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetOperatingSystemResult(
            distro=self.distro,
            name=self.name,
            provisionable_on=self.provisionable_on,
            slug=self.slug,
            version=self.version,
            id=self.id)

def get_operating_system(distro=None,name=None,provisionable_on=None,version=None,opts=None):
    """
    Use this data source to get Packet Operating System image.
    
    :param str distro: Name of the OS distribution.
    :param str name: Name or part of the name of the distribution. Case insensitive.
    :param str provisionable_on: Plan name.
    :param str version: Version of the distribution

    > This content is derived from https://github.com/terraform-providers/terraform-provider-packet/blob/master/website/docs/d/operating_system.html.markdown.
    """
    __args__ = dict()

    __args__['distro'] = distro
    __args__['name'] = name
    __args__['provisionableOn'] = provisionable_on
    __args__['version'] = version
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('packet:index/getOperatingSystem:getOperatingSystem', __args__, opts=opts).value

    return AwaitableGetOperatingSystemResult(
        distro=__ret__.get('distro'),
        name=__ret__.get('name'),
        provisionable_on=__ret__.get('provisionableOn'),
        slug=__ret__.get('slug'),
        version=__ret__.get('version'),
        id=__ret__.get('id'))
