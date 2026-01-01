using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSOLID_OOPInCSharp.DesignPatterns.Behavioural.State.GoodExample
{
    public class Document
    {
        public IState State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        public Document(UserRoles currentUserRole)
        {
            CurrentUserRole = currentUserRole;
            State = new DraftState(this);

        }
        public void Publish()
        {
            // delegate the work to concrete state object
            State.Publish();
        }
    }
}
