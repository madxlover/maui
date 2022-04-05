﻿namespace Microsoft.Maui.Controls
{
	public partial class Entry
	{
		public static IPropertyMapper<IEntry, EntryHandler> ControlsEntryMapper = 
			new PropertyMapper<Entry, EntryHandler>(EntryHandler.Mapper)
		{
#if ANDROID
			[nameof(PlatformConfiguration.AndroidSpecific.ImeFlags)] = MapImeOptions,
#endif
			[nameof(Text)] = MapText,
			[nameof(TextTransform)] = MapText,
		};

		internal static new void RemapForControls()
		{
			// Adjust the mappings to preserve Controls.Entry legacy behaviors
			EntryHandler.Mapper = ControlsEntryMapper;
		}
	}
}
