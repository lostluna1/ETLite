using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using ETLiteAPI.Repositories.Service;
namespace ETLiteAPI.Services;

public class AesEncryptionService : IAesEncryptionService
{
    private readonly byte[] _key;
    private readonly byte[] _iv;

    public AesEncryptionService(string key, string iv)
    {
        _key = Convert.FromBase64String(key);
        _iv = Convert.FromBase64String(iv);
    }

    public string Encrypt(string plainText)
    {
        using var aesAlg = Aes.Create();
        aesAlg.Key = _key;
        aesAlg.IV = _iv;

        var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

        using var msEncrypt = new MemoryStream();
        using var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
        using (var swEncrypt = new StreamWriter(csEncrypt))
        {
            swEncrypt.Write(plainText);
        }
        return Convert.ToBase64String(msEncrypt.ToArray());
    }

    public string Decrypt(string cipherText)
    {
        using var aesAlg = Aes.Create();
        aesAlg.Key = _key;
        aesAlg.IV = _iv;

        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

        using var msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText));
        using var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
        using var srDecrypt = new StreamReader(csDecrypt);
        return srDecrypt.ReadToEnd();
    }
}
