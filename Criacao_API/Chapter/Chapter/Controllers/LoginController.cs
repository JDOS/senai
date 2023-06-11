using Chapter.Interfaces;
using Chapter.Models;
using Chapter.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using JwtRegisteredCaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Chapter.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioRepository _iUsuarioRepository;

        public LoginController(IUsuarioRepository iUsuarioRepository)
        {
            _iUsuarioRepository = iUsuarioRepository;
        }
        [HttpGet]
        public IActionResult Login(LoginViewModel dadosLogin)
        {
            try
            {

                Usuario usuarioBuscado = _iUsuarioRepository.Login(dadosLogin.email, dadosLogin.senha);
                if (usuarioBuscado == null)
                {
                    return Unauthorized(new {msg = "E-mail e/ou senha incorreto"});
                }
                //jwt
                var minhaClaims = new[]
                {
                    new Claim(JwtRegisteredCaimNames.Email, usuarioBuscado.Email),
                    new Claim(JwtRegisteredCaimNames.Jti, usuarioBuscado.Id.ToString()),
                    new Claim(ClaimTypes.Role, usuarioBuscado.Tipo)

                };

                var chave = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("chapter-chave-autencicacao"));
                var credenciais = new SigningCredentials(chave,SecurityAlgorithms.HmacSha256);
                var meuToken = new JwtSecurityToken(
                    issuer: "chapter.webapi",
                    audience: "chapter.webapi",
                    claims: minhaClaims,
                    expires: DateTime.Now.AddMinutes(60),
                    signingCredentials: credenciais
                    );

                return Ok( new { token = new JwtSecurityTokenHandler().WriteToken(meuToken)});

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
