using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Text;
using Windows.UI.Xaml.Controls;

namespace Microsoft.Toolkit.Uwp.UI.Controls.TextToolbarEditors.RichEdit
{
    public class RichEditBoxEditingFrame : IEditingFrame
    {
        public RichEditBoxEditingFrame(RichEditBox Editor)
        {
            this.Editor = Editor;
        }

        public string GetText(TextFormatOptions options = TextFormatOptions.Plain)
        {
            var format = options == TextFormatOptions.Plain ? TextGetOptions.NoHidden : TextGetOptions.FormatRtf;
            string result = string.Empty;
            Editor.Document.GetText(format, out result);
            return result;
        }

        public void SetText(string text, TextFormatOptions options = TextFormatOptions.Plain)
        {
            var format = options == TextFormatOptions.Plain ? TextSetOptions.None : TextSetOptions.FormatRtf;
            Editor.Document.SetText(format, text);
        }

        public void Update()
        {
            Editor.Document.ApplyDisplayUpdates();
        }

        public ITextRange GetRange(int start, int end)
        {
            var range = Editor.Document.GetRange(start, end);
            return new RichEditRange(range);
        }

        public ITextSelection GetSelection()
        {
            var selection = Editor.Document.Selection;
            return new RichEditSelection(selection);
        }

        public void Undo()
        {
            Editor.Document.Undo();
        }

        public void Redo()
        {
            Editor.Document.Redo();
        }

        public IParagraphFormat DefaultParagraphFormat
        {
            get { return null; }
        }

        public ICharacterFormat DefaultCharacterFormat
        {
            get { return null; }
        }

        public RichEditBox Editor { get; }
    }
}