using BiasWordsTestApp.Classes;

namespace BiasWordsTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var biasSubject = new ErrorAndOmissionSubject();
            var biasObserver = new BiasObserver();
            biasSubject.Attach(biasObserver);

            biasSubject.ProcessErrorsAndOmissions();

            biasSubject.Detach(biasObserver);
        }
    }
}
