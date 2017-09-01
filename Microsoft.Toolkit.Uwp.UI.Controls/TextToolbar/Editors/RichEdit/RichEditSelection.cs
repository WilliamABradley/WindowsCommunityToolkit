using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Text;

namespace Microsoft.Toolkit.Uwp.UI.Controls.TextToolbarEditors.RichEdit
{
    public class RichEditSelection : RichEditRange, ITextSelection
    {
        public RichEditSelection(Windows.UI.Text.ITextSelection Range) : base(Range)
        {
        }
    }
}