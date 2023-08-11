using System;
using System.IO;
using Xunit;
using HelloWorld;

public class ProgramTest
{
    [Fact]
    public void Main_Writes_HelloWorld()
    {
        var writer = new StringWriter();
        Console.SetOut(writer);

        Program.Main(new string[0]);
        
        var output = writer.GetStringBuilder().ToString().Trim();
        Assert.Equal("Hello, World!", output);
    }
}
