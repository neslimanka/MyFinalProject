using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    //Anlamsız değerlerden oluşan anahtar
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }//Tokenın bıtış suresı -son kullanma tarıhı gıbı
    }
}
