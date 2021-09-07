using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}

//sen bir jwt sistemi yöneteceksın. senin anahtarın securtyKey,şifreleme anahtarında SecurityAlgorithms.HmacSha512Signature budur.
//mesela bir ssiteme kullanıcı adı ve şifrre ile giriyoruz ya onlar credentials demek onlar.