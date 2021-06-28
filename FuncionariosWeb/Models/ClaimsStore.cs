using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace FuncionariosWeb.Models
{
    public static class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
        {
           new Claim("Cria Role", "Cria Role"),
           new Claim("Edita Role","Edita Role"),
           new Claim("Deleta Role","Deleta Role")
         };
    }
}
