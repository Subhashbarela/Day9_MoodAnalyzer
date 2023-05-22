using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day9_MoodAnalyzerProject.MoodAnalyserException;

namespace Day9_MoodAnalyzerProject
{
    public class MoodAnalyzerClass
    {
        string message;
        public MoodAnalyzerClass(string message)
        {
            this.message = message;
        }
        public MoodAnalyzerClass()
        {

        }
        public string AnalyseMood(string message)
        {
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
       
        public string AnalyseMood()
        {
            if (message.Equals(string.Empty))
            {
                throw new MoodAnalyserException(MoodAnalyseEnum.EMPTY_MOOD, "Empty Input");
            }
            try
            {
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException e)
            {
                throw new MoodAnalyserException(MoodAnalyseEnum.NULL_MOOD, "Null Input");
            }

        }
    }
}
