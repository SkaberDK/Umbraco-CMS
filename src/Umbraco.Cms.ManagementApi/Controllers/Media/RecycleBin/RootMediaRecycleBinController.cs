﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.ManagementApi.ViewModels.Pagination;
using Umbraco.Cms.ManagementApi.ViewModels.RecycleBin;

namespace Umbraco.Cms.ManagementApi.Controllers.Media.RecycleBin;

public class RootMediaRecycleBinController : MediaRecycleBinControllerBase
{
    public RootMediaRecycleBinController(IEntityService entityService)
        : base(entityService)
    {
    }

    [HttpGet("root")]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(typeof(PagedViewModel<RecycleBinItemViewModel>), StatusCodes.Status200OK)]
    public async Task<ActionResult<PagedViewModel<RecycleBinItemViewModel>>> Root(int skip = 0, int take = 100)
        => await GetRoot(skip, take);
}
