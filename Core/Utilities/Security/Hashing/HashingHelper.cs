using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePassword(
            string password, out byte[] passwordHas, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHas = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHas, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i]!=passwordHas[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
