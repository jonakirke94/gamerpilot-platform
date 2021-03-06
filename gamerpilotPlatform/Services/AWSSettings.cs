﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon;

namespace gamerpilotPlatform.Services
{
    public class AWSSettings
    {
        public string AWSAccessKey { get; set; }
        public string AWSSecretKey { get; set; }
        public string AWSBucketName { get; set; }
        public RegionEndpoint AWSRegion { get; set; }
    }
}

