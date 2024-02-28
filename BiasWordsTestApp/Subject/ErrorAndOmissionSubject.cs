using BiasWordsTestApp.Interfaces;
using System.Collections.Generic;

namespace BiasWordsTestApp
{
    public class ErrorAndOmissionSubject : IErrorAndOmissionSubject
    {
        public string State { get; set; } = string.Empty;

        private List<IErrorAndOmissionObserver> _observers = new List<IErrorAndOmissionObserver>();

        public void Attach(IErrorAndOmissionObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IErrorAndOmissionObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void ProcessErrorsAndOmissions()
        {
            // Develop some logic here to process the errors and omissions

            Notify();
        }
    }
}
