namespace BiasWordsTestApp.Interfaces
{
    public interface IErrorAndOmissionSubject
    {
        void Attach(IErrorAndOmissionObserver observer);
        void Detach(IErrorAndOmissionObserver observer);
        void Notify();
    }
}
