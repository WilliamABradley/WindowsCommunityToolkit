using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Text;

namespace Microsoft.Toolkit.Uwp.UI.Controls.TextToolbarEditors.RichEdit
{
    public class RichEditRange : ITextRange
    {
        public RichEditRange(Windows.UI.Text.ITextRange Range)
        {
            this.Range = Range;
        }

        public string GetText(TextFormatOptions options = TextFormatOptions.Plain)
        {
            var format = options == TextFormatOptions.Plain ? TextGetOptions.None : TextGetOptions.FormatRtf;
            string result = string.Empty;
            Range.GetText(format, out result);
            return result;
        }

        public void SetText(string text, TextFormatOptions options = TextFormatOptions.Plain)
        {
            var format = options == TextFormatOptions.Plain ? TextSetOptions.None : TextSetOptions.FormatRtf;
            Range.SetText(format, text);
        }

        public void SetLink(Uri link)
        {
            throw new NotImplementedException();
        }

        public Uri GetLink()
        {
            throw new NotImplementedException();
        }

        public Windows.UI.Text.ITextRange Range { get; }
    }
}