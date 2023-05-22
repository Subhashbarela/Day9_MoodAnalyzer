using Day9_MoodAnalyzerProject;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Newtonsoft.Json.Linq;

namespace MoodAnalyzerNUnitTest
{
    public class Tests
    {
        MoodAnalyzerClass moodAnalyzer = new MoodAnalyzerClass();
        // TC1.1-Given �I am in Sad  Mood� message Should Return SAD
        [Test]
        public void Return_Mood_Sad()
        {
            string result = moodAnalyzer.AnalyseMood("I am in Sad Mood");
            Assert.That(result, Is.EqualTo("Sad"));
            Console.WriteLine(result);
        }
        // TC1.2-Given �I am in Any Mood� message Should Return HAPPY
        [Test]
        public void Return_Mood_Happy()
        {
            string result = moodAnalyzer.AnalyseMood("I am in Any Mood");
            Assert.That(result, Is.EqualTo("Happy"));
            Console.WriteLine(result);
        }
        // Rectctor TC1.1-Given �I am in Sad Mood� message in Constructor Should Return SAD
        [Test]
        public void Return_Mood_Sad_Constructor()
        {
            MoodAnalyzerClass moodAnalyzer = new MoodAnalyzerClass("I am in Sad Mood");
            string result = moodAnalyzer.AnalyseMood();
            Assert.That(result, Is.EqualTo("Sad"));
            Console.WriteLine(result);
        }
        // Refactor TC1.2-Given �I am in Happy Mood� message in Constructor Should Return SAD
        [Test]
        public void Return_Mood_Happy_Constructor()
        {
            string result = moodAnalyzer.AnalyseMood("I am in Any Mood");
            Assert.That(result, Is.EqualTo("Happy"));
            Console.WriteLine(result);
        }
    }
}