﻿using System;
using System.Collections.Generic;

namespace movies.client.dbentities
{
    public partial class UmbracoCacheInstruction
    {
        public int Id { get; set; }
        public DateTime UtcStamp { get; set; }
        public string JsonInstruction { get; set; }
        public string Originated { get; set; }
        public int InstructionCount { get; set; }
    }
}
