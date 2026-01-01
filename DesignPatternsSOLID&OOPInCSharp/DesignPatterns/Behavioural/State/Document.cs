namespace DesignPatternsSOLID_OOPInCSharp.DesignPatterns.Behavioural.State
{
    public class Document
    {
        public DocumentStatuesEnum State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        public void Publish()
        {
            if (State == DocumentStatuesEnum.Draft)
            {
                State = DocumentStatuesEnum.Moderation;
                Console.WriteLine("Document moved to Moderation.");
            }
            else if (State == DocumentStatuesEnum.Moderation)
            {
                if (CurrentUserRole == UserRoles.Admin)
                {
                    State = DocumentStatuesEnum.Published;
                    Console.WriteLine("Document Published.");
                } else
                {
                    Console.WriteLine("Only Admin can publish the document.");
                }

            }
            else if (State == DocumentStatuesEnum.Published)
            {
                Console.WriteLine("Document Already Published");
            }
        }
    }
}   
