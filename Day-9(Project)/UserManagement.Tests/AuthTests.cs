using NUnit.Framework;
using System.Security.Cryptography;
using UserManagement;

namespace UserManagement.Tests;

[TestFixture]
public class AuthTests
{
    private AuthService _auth = null!;
    private UserRepository _repo = null!;

    [SetUp]
    public void Setup()
    {
        _repo = new UserRepository();
        _auth = new AuthService(_repo);
    }

    // ---------- User Authentication ----------
    [Test]
    public void Register_Then_Login_Succeeds()
    {
        _auth.Register("alice", "Pa$$w0rd!");
        Assert.IsTrue(_auth.Login("alice", "Pa$$w0rd!"));
    }

    [Test]
    public void Login_WrongPassword_Fails()
    {
        _auth.Register("bob", "secret");
        Assert.IsFalse(_auth.Login("bob", "badpassword"));
    }

    // ---------- Data Encryption ----------
    [Test]
    public void Encrypt_Then_Decrypt_ReturnsOriginal()
    {
        byte[] key = RandomNumberGenerator.GetBytes(32);
        byte[] iv = RandomNumberGenerator.GetBytes(16);

        string secret = "Sensitive data";
        byte[] cipher = CryptoService.Encrypt(secret, key, iv);
        string plain = CryptoService.Decrypt(cipher, key, iv);

        Assert.AreEqual(secret, plain);
    }

    // ---------- Error Handling & Logging ----------
    [Test]
    public void Register_DuplicateUser_Throws()
    {
        _auth.Register("chris", "pwd");
        Assert.Throws<InvalidOperationException>(() => _auth.Register("chris", "pwd2"));
    }
}
