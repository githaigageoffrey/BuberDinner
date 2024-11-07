namespace BuberDinner.Application.Common.interfaces.Authentication;


public interface IJwtTokeGenerator
{
    string GenerateToken(Guid userId, string firstNmae,string lastName);
}


// public class JwtTokenProvider
// {
//     private readonly string _secretKey = "your_secret_key";

//     private readonly string _secretKey = "your_secret_key"; // Make sure to replace "your_secret_key" with your actual secret key
//     public string GenerateToken()
//     {
//         var tokenHandler = new JwtSecurityTokenHandler();
        
//         var tokenDescriptor = new SecurityTokenDescriptor
//         {
//             Subject = new ClaimsIdentity(new[]
//             Subject = new ClaimsIdentity(new[] 
//                 {
//                     new Claim("sub", "your_subject"),
//                     new Claim("sub", "your_subject"), // Replace "your_subject" with the subject of the token
//                     new Claim("exp", DateTime.UtcNow.AddDays(7).ToString("yyyy-MM-dd HH:mm:ss"))
//                 }),
//             Expires = DateTime.UtcNow.AddDays(7),
//             SigningCredentials = new SigningCredentials(
//                 new SymmetricSecurityKey(_secretKey), SecurityAlgorithms.HmacSha256Signature)
//                 new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_secretKey)), 
//                 SecurityAlgorithms.HmacSha256Signature)
//         };
        
//         var token = tokenHandler.CreateToken(tokenDescriptor);
//         return tokenHandler.WriteToken(token);
//     }
// }
