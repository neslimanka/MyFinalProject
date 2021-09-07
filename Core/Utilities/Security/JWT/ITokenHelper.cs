using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
        //kullanıcnın girdiği kulanııc bilgilerini apiye gönderdi, eğer doğru ise çalışacak olan kısım burası
    }
}
 