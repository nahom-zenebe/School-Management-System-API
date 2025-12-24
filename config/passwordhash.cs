using Microsoft.AspNetCore.Identity;




public static class PasswordHasherHelper{
    private static readonly PasswordHasher<string>hash=new();

    public static string Hash(string password)=> hasher.HashPassword(null,password);

    public static bool Verify(string hashPassword,string providedPassword)
    =>hasher.VerifyHashedPassword(null, hashedPassword, providedPassword)
     == PasswordVerificationResult.Success;
}