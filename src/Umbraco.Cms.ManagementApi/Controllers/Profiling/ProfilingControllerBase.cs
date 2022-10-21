﻿using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using Umbraco.New.Cms.Web.Common.Routing;

namespace Umbraco.Cms.ManagementApi.Controllers.Profiling;

[ApiVersion("1.0")]
[ApiController]
[VersionedApiBackOfficeRoute("profiling")]
[OpenApiTag("Profiling")]
public class ProfilingControllerBase : ManagementApiControllerBase
{
}
