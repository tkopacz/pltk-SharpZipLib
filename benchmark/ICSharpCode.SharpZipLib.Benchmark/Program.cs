using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;

namespace ICSharpCode.SharpZipLib.Benchmark
{
	public class MultipleRuntimes : ManualConfig
	{
		public MultipleRuntimes()
		{
			AddJob(Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp60)); // .NET 6.0
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
		}
	}
}
