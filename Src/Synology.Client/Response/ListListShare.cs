﻿using System.Collections.Generic;

namespace SynologyClient.Response
{
    public class ListListShare
    {
        public int total { get; set; }
        public int offset { get; set; }
        public List<SharedFolder> shares { get; set; }
    }
}