using System.Text;
using XSystem.Security.Cryptography;

internal class Encrypt
{
    public string EncryptPassword(string passwordValue)
    {
        using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            byte[] data = md5.ComputeHash(utf8.GetBytes(passwordValue));
            return Convert.ToBase64String(data);
        }
    }
}

