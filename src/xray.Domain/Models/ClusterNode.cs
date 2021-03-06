﻿// ------------------------------------------------------------
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace xray.Models
{
    using System;
    using System.Collections.Generic;

    public struct ClusterNode
    {
        public ClusterNode(
            string name,
            string type,
            string status,
            string healthState,
            TimeSpan upTime,
            string address,
            string fd,
            string ud)
        {
            this.Name = name;
            this.NodeType = type;
            this.Status = status;
            this.HealthState = healthState;
            this.UpTime = upTime;
            this.Address = address;
            this.FaultDomain = fd;
            this.UpgradeDomain = ud;
        }

        public string Name { get; }

        public string NodeType { get; }

        public string Status { get; }

        public string HealthState { get; }

        public TimeSpan UpTime { get; }

        public string Address { get; }

        public string FaultDomain { get; }

        public string UpgradeDomain { get; }
    }
}