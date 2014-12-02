using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Granite.Core
{
    public enum DisplayStyle
	{
		Naked,
		Fixed,
		FixedWithTitle,
		Resizeable,
		ResizeableWithTitle
	}

    public sealed class ApplicationSettings
    {
        public ApplicationSettings()
        {
            // Defaults
            DisplayStyle = DisplayStyle.FixedWithTitle;
            DisplayColorBits = 24;
            DisplayDepthBits = 16;
            VerticalSynchronization = false;
        }

        public DisplayStyle DisplayStyle { get; set; }
        public int DisplayColorBits { get; set; }
        public int DisplayDepthBits { get; set; }
        public bool VerticalSynchronization { get; set; }
    }
}
