using BiasWordsTestApp.Classes;
using System.Collections.Generic;
using System.Linq;

namespace BiasWordsTestApp.Utilities
{
    public static class BiasMatchFinder
    {
        public static Dictionary<InputTextModel, List<BiasItem>> FindMatches(List<InputTextModel> inputTexts, Dictionary<string, List<BiasItem>> biasItems)
        {
            var result = new Dictionary<InputTextModel, List<BiasItem>>();

            foreach (var input in inputTexts)
            {
                var matches = new List<BiasItem>();

                foreach (var words in biasItems.Values)
                {
                    matches.AddRange(words.Where(x => x.Expression == input.TextBoxValue));
                }

                if (matches.Any())
                {
                    result.Add(input, matches);
                }
            }

            return result;
        }
    }
}
