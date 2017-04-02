﻿namespace OmniXaml.ReworkPhases
{
    using System.Collections.Generic;

    public class InflatedMemberAssignment : IMemberAssignment<InflatedNode>
    {
        public Member Member { get; set; }
        public IEnumerable<InflatedNode> Children { get; set; } = new List<InflatedNode>();
    }
}