using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SecuriyKeyHelper
        //Bu işin içerisinde şifreleme olan sisitemlerde bizim herşeyi bir byte array formatında veriyi almaız gerekıyor.
        //onu o şekilde oluşrmamız gerekıyor. Basit bir stringle bir key oluşturduk.Bunları asp.net in
        //json ve token servislerinin anlayacagı hale getırmemız gerekiyor.
    {
        //Bizim elimizde uyduruk bır string securitykeyimiz var.bız bu uydurugu encription a parametre gecemiyruz.Onu byte hale getırmemız 
        //lazım.
        public static SecurityKey CreateSecuritKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));//byteını alıp onu bir simetriksecurty 
            //anahtarına getırıyoe. 
        }
    }
}
