﻿using MarkDownConverter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkDownConverter.Nodes
{
    public class ParentNode : Node, INodeWithChildren
    {
        public override NodeState State => NodeState.Root;
        public List<Node> Children { get; } = [];
    }
}