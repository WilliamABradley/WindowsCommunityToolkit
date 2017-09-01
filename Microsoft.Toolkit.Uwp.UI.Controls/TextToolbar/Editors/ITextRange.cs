using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Toolkit.Uwp.UI.Controls.TextToolbarEditors
{
    public interface ITextRange
    {
        void SetText(string text, TextFormatOptions options = TextFormatOptions.Plain);

        string GetText(TextFormatOptions options = TextFormatOptions.Plain);

        void SetLink(Uri link);

        Uri GetLink();
    }
}