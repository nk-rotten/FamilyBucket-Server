﻿using Ocelot.Configuration.File;

namespace Bucket.Admin.Dto.Microservice
{
    public class SetApiGatewayConfigurationInput : FileGlobalConfiguration
    {
        public int GatewayId { set; get; }
        public string GatewayKey { set; get; }
    }
}
