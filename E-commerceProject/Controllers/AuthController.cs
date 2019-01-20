using Microsoft.Extensions.Configuration;
using E_commerceProject.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace E_commerceProject.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IConfiguration _config;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserAuth _authUser;


        public AuthController(IConfiguration config, IHttpContextAccessor httpContextAccessor)
        {
            _config = config;
            _httpContextAccessor = httpContextAccessor;
            _authUser = new UserAuth(_config);
        }
        [AllowAnonymous, HttpPost]
        public IActionResult CreateToken([FromBody] Login login)
        {
            IActionResult response = Unauthorized();
            var user = _authUser.Authenticate(login);

            if (user == null) return response;
            var tokenString = _authUser.BuildToken(user);
            response = Ok(new { token = tokenString });

            return response;
        }
        [HttpGet("myself")]
        public IActionResult MySelf()
        {
            var currentUser = _httpContextAccessor.HttpContext.User;
            var email = currentUser.FindFirst(ClaimTypes.NameIdentifier);

            if (currentUser == null || email == null)
            {
                return BadRequest("No ways !");
            }
            return Ok(email.Value);
        }

    }
}
