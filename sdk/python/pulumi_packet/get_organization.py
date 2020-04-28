# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from . import utilities, tables

class GetOrganizationResult:
    """
    A collection of values returned by getOrganization.
    """
    def __init__(__self__, description=None, id=None, logo=None, name=None, organization_id=None, project_ids=None, twitter=None, website=None):
        if description and not isinstance(description, str):
            raise TypeError("Expected argument 'description' to be a str")
        __self__.description = description
        """
        Description string
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if logo and not isinstance(logo, str):
            raise TypeError("Expected argument 'logo' to be a str")
        __self__.logo = logo
        """
        Logo URL
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if organization_id and not isinstance(organization_id, str):
            raise TypeError("Expected argument 'organization_id' to be a str")
        __self__.organization_id = organization_id
        if project_ids and not isinstance(project_ids, list):
            raise TypeError("Expected argument 'project_ids' to be a list")
        __self__.project_ids = project_ids
        """
        UUIDs of project resources which belong to this organization
        """
        if twitter and not isinstance(twitter, str):
            raise TypeError("Expected argument 'twitter' to be a str")
        __self__.twitter = twitter
        """
        Twitter handle
        """
        if website and not isinstance(website, str):
            raise TypeError("Expected argument 'website' to be a str")
        __self__.website = website
        """
        Website link
        """
class AwaitableGetOrganizationResult(GetOrganizationResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetOrganizationResult(
            description=self.description,
            id=self.id,
            logo=self.logo,
            name=self.name,
            organization_id=self.organization_id,
            project_ids=self.project_ids,
            twitter=self.twitter,
            website=self.website)

def get_organization(name=None,organization_id=None,opts=None):
    """
    Provides a Packet organization datasource.




    :param str name: The organization name
    :param str organization_id: The UUID of the organization resource
    """
    __args__ = dict()


    __args__['name'] = name
    __args__['organizationId'] = organization_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('packet:index/getOrganization:getOrganization', __args__, opts=opts).value

    return AwaitableGetOrganizationResult(
        description=__ret__.get('description'),
        id=__ret__.get('id'),
        logo=__ret__.get('logo'),
        name=__ret__.get('name'),
        organization_id=__ret__.get('organizationId'),
        project_ids=__ret__.get('projectIds'),
        twitter=__ret__.get('twitter'),
        website=__ret__.get('website'))
