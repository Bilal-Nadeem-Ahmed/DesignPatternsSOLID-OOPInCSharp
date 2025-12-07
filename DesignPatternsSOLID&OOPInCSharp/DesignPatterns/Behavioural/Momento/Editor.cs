using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.DesignPatterns.Behavioural.Momento
{
    // originator
    public class Editor
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Title, Content);
        }

        public void RestoreState(EditorState state)
        {
            Title = state.GetTitle();
            Content = state.GetContent();
        }

    }
}
