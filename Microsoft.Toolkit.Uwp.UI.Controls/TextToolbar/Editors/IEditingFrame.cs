using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Toolkit.Uwp.UI.Controls.TextToolbarEditors
{
    public interface IEditingFrame
    {
        void SetText(string text, TextFormatOptions options = TextFormatOptions.Plain);

        string GetText(TextFormatOptions options = TextFormatOptions.Plain);

        void Update();

        ITextRange GetRange(int start, int end);

        ITextSelection GetSelection();

        void Undo();

        void Redo();

        //IParagraphFormat DefaultParagraphFormat { get; }

        //ICharacterFormat DefaultCharacterFormat { get; }
    }
}