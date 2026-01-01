using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.DesignPatterns.Behavioural.State.GoodExample
{
    public class PublishedState : IState
    {
        private Document _document;
        public PublishedState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            // do nothing if already in published state
        }
    }
}
