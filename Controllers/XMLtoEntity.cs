using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Vremenko.Models;
using System.Xml;

namespace Vremenko.Controllers;

public class XMLtoEntity : Controller
{
    public static void Read(string url)
    {
        XmlTextReader reader = new XmlTextReader (url);

        while (reader.Read())
        {
            // Do some work here on the data.
            //Console.WriteLine(reader.Name);
        }
        Console.ReadLine();
    }



}