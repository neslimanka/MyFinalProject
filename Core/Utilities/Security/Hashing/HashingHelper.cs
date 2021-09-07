using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
        //HAsh oluşturmaya ve onu doğrulamaya yarıyor.
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            //Verdiğimiz passworun Hashini oluşturmaya yarıyor 
            using (var hmac = new System.Security.Cryptography.HMACSHA512())//Hash oluşturuken hangı akgoritmayı kullanacagımızı söylüyoruz.
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            //Sonradan sısteme gırmeye çalışan kişinin verdiği passwordun bizim veri kaynağımızdaki 
            //Hash ile ilgili Salt ile eşleşip eşleşmediğini verdiğimiz yer 
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))//password:Daha önce oluşturuken kullandgımız tuzu kullanarak onu doğruluyoruz. 
            {
                var computedHash = passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
