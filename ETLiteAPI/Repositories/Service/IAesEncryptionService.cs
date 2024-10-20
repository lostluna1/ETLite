using System.Security.Cryptography;

namespace ETLiteAPI.Repositories.Service;

public interface IAesEncryptionService
{
    string Encrypt(string plainText);
    string Decrypt(string cipherText);
}
