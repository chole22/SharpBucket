﻿using System;

namespace SharpBucket.V1.Pocos
{
    [Obsolete("Bitbucket Cloud v1 APIs are deprecated")]
    public class EmailInfo
    {
        public bool? active { get; set; }
        public string email { get; set; }
        public bool? primary { get; set; }
    }
}