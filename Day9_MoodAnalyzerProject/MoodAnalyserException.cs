using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_MoodAnalyzerProject
{
    public class MoodAnalyserException:Exception
    {
       public enum MoodAnalyseEnum
        {
            NULL_MOOD,
            EMPTY_MOOD
        }
        public MoodAnalyseEnum enumObj;
        public MoodAnalyserException(MoodAnalyseEnum enumObj,string message):base(message)
        {
            this.enumObj = enumObj;
        }
    }
}
