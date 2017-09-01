using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Toolkit.Uwp.UI.Controls.TextToolbarEditors.RichEdit
{
    public class RichEditParagraphFormat : IParagraphFormat
    {
        public RichEditParagraphFormat(Windows.UI.Text.ITextParagraphFormat Paragraph)
        {
            this.Paragraph = Paragraph;
        }

        public Windows.UI.Text.ITextParagraphFormat Paragraph { get; }
    }
}