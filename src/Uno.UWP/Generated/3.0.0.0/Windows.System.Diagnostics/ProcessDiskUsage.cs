#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Diagnostics
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ProcessDiskUsage 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __MACOS__
		[global::Uno.NotImplemented]
		public  global::Windows.System.Diagnostics.ProcessDiskUsageReport GetReport()
		{
			throw new global::System.NotImplementedException("The member ProcessDiskUsageReport ProcessDiskUsage.GetReport() is not implemented in Uno.");
		}
		#endif
	}
}
