namespace Quine {
    using System;
    using Xunit;
    using Xunit.Abstractions;

    public class Tests {
        private ITestOutputHelper output;

        public Tests(ITestOutputHelper output) {
            this.output = output;
        }

        [Fact]
        public void QuineWorks() {
            // assemble
            var expected = System.IO.File.ReadAllText(@"../../../../Quine/Program.cs");
            var p = new System.Diagnostics.Process();
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = System.IO.Directory.GetCurrentDirectory() + @"\..\..\..\..\Quine\bin\Debug\netcoreapp3.1\Quine.exe";

            // act
            p.Start();
            var actual = p.StandardOutput.ReadToEnd();

            // assert
            Assert.Equal(expected, actual);
        }
    }
}