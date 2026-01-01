namespace DesignPatternsSOLID_OOPInCSharp.DesignPatterns.Behavioural.State.GoodExample
{
    public class DraftState: IState
    {
        private Document _document { get; }
        public DraftState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            _document.State = new ModerationState(_document);
        }
    }
}
