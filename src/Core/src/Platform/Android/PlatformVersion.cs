using System;
using Android.OS;

namespace Microsoft.Maui.Platform
{
	internal static partial class PlatformVersion
	{
		public static bool IsAtLeast(BuildVersionCodes buildVersionCode) => OperatingSystem.IsAndroidVersionAtLeast((int)buildVersionCode);

		public static bool IsAtLeast(int apiLevel) => OperatingSystem.IsAndroidVersionAtLeast(apiLevel);

		public static bool Supports(int platformApi) => OperatingSystem.IsAndroidVersionAtLeast(platformApi);
	}

	internal static class PlatformApis
	{
		public const int BlendModeColorFilter = 29;
		public const int SeekBarSetMin = 26;
		public const int LaunchAdjacent = 24;
	}
}