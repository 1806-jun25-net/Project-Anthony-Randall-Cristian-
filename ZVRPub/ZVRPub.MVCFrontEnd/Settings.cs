﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ZVRPub.MVCFrontEnd
{
    public class Settings
    {
        public Uri ServiceUri { get; private set; }
        public Settings(IConfiguration configuration)
        {
            ServiceUri = new Uri(configuration["ServiceUris:angular"]);
        }
    }
}