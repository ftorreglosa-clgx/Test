namespace BiasWordsTestApp.Interfaces
{
    public interface IErrorAndOmissionObserver
    {
        void Update(IErrorAndOmissionSubject subject);
    }
}
