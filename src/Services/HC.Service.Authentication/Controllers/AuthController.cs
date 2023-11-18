﻿using Microsoft.AspNetCore.Mvc;

namespace HC.Service.Authentication.Controllers
{
    [MyAuthorize("claim")]
    public class AuthController : ControllerBase
    {
        [HttpGet("s")]
        public async Task<IActionResult> Index()
        {
            return Ok();
        }
    }
}