using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.DesignPatterns.Behavioural.Momento
{
    public class History
    {
        private List<EditorState> _states = new List<EditorState>();
        private Editor _editor;

        public History(Editor editor)
        {
            _editor = editor;
        }

        public void Backup()
        {
            _states.Add(_editor.CreateState());
        }

        public void Undo()
        {
            if(_states.Count == 0)
            {
                return;
            }
            
            EditorState previousState = _states.Last();

            _states.Remove(previousState);
            _editor.RestoreState(previousState);

        }
        public void ShowHistory()
        {
            foreach(var state in _states)
            {
                Console.WriteLine($"Name:{state.GetName()}");
            }
        }
    }
}
