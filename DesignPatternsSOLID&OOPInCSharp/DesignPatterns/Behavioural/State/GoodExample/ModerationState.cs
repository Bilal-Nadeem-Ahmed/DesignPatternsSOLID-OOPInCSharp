using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.DesignPatterns.Behavioural.State.GoodExample
{
    internal class ModerationState:IState
    {
        private Document _document;
        public ModerationState(Document document) 
        {
        
            _document = document;
        }
        public void Publish()
        {
          if(_document.CurrentUserRole == UserRoles.Admin)
          {
              _document.State = new PublishedState(_document);
              Console.WriteLine("Document Published.");
          }
          else
          {
              Console.WriteLine("Only Admin can publish the document.");
          }
        }
    }
}
