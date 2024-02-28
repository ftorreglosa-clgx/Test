using BiasWordsTestApp.Interfaces;
using BiasWordsTestApp.Utilities;
using System.Collections.Generic;

namespace BiasWordsTestApp.Classes
{
    public class BiasObserver : IErrorAndOmissionObserver
    {
        // This dictionary must be populated with the data provided in the Excel file. This words can be stored in the alaRedun.ini
        public Dictionary<string, List<BiasItem>> BiasItems { get; set; }
        // This List must be populated with alaRedun.ini key elements, is also necessary to create the key in the alaredun as well
        public List<InputTextModel> TextBoxReportFields { get; set; }

        public void Update(IErrorAndOmissionSubject subject)
        {
            var matches = BiasMatchFinder.FindMatches(TextBoxReportFields, BiasItems);

            // Develop a logic to add the review errors here
        }
    }
}
