using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (message.Equals(null))
            {
                throw new NullReferenceException("happy");
            }
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
        //public string AnalyseMood()
        //{
        //    if (message.Equals(null))
        //    {
        //        throw new NullReferenceException("happy");                
        //    }
        //    return "Happy";
        //}
    }
}
