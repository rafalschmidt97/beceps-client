﻿using System.Collections.Generic;

namespace Beceps.History
{
    public class RoutineHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SetHistory> Sets { get; set; }
    }
}