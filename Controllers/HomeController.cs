using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    
    public string Welcome(string name, int ID = 1)
{
    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
}

    

    // GET: /HelloWorld/Welcome/ 
    // public string Welcome(int numTimes = 0, string name = "Anonymous")
    // {
    //     string outMessage = "";
    //     for (int i = 0; i < numTimes; i++)
    //     {
    //         outMessage += $"Hello {name}, {i + 1} times!\n" ; 
    //     }
    //     return (outMessage == "") ? HtmlEncoder.Default.Encode("No parameters were passed") : HtmlEncoder.Default.Encode(outMessage);
    // }
}