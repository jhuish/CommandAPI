using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;
        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do Something Awesome",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }
        public void Dispose() {
            testCommand = null;
        }

        [Fact]

        public void CanChangeHowTo() 
        {
            //arrange
        
            //act
            testCommand.HowTo = "Execute Unit Tests";

            //assert 
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
        }
        
        [Fact]
        public void CanChangePlatform()
        {
            //arrange
           
    
            //act
            testCommand.Platform = "Docker";

            //assert 
            Assert.Equal("Docker", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            //arrange
        
            //act
            testCommand.CommandLine = "dotnet build";

            //assert 
            Assert.Equal("dotnet build", testCommand.CommandLine);
        }
    }
}