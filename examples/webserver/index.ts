// Copyright 2016-2017, Pulumi Corporation.  All rights reserved.

import * as packet from "@pulumi/packet";

let project = new packet.Project("project", {
    name: "pulumi",
});

let vm = new packet.Device("vm", {
    facilities: [packet.EWR1Facility],
    billingCycle: "hourly",
    hostname: "lukehoban",
    operatingSystem: "coreos_stable",
    plan: "baremetal_0",
    projectId:  project.id,
});

export let ip = vm.accessPublicIpv4;
