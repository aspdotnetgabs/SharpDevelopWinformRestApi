
// Use https://json2csharp.com to convert json data to C# classes

using System.Collections.Generic;

public class ApiUser
{
    public int UserId { get; set; } 
    public string UserName { get; set; } 
    public List<string> UserRoles { get; set; } 
    public string Token { get; set; } 
}