using Day9_MoodAnalyzerProject;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Newtonsoft.Json.Linq;

namespace MoodAnalyzerNUnitTest
{
    public class Tests
    {
        MoodAnalyzerClass moodAnalyzer = new MoodAnalyzerClass();
        // TC1.1-Given “I am in Sad  Mood” message Should Return SAD
        [Test]
        public void Return_Mood_Sad()
        {
            string result = moodAnalyzer.AnalyseMood("I am in Sad Mood");
            Assert.That(result, Is.EqualTo("Sad"));
            Console.WriteLine(result);
        }
        // TC1.2-Given “I am in Any Mood” message Should Return HAPPY
        [Test]
        public void Return_Mood_Happy()
        {
            string result = moodAnalyzer.AnalyseMood("I am in Any Mood");
            Assert.That(result, Is.EqualTo("Happy"));
            Console.WriteLine(result);
        }
        // Rectctor TC1.1-Given “I am in Sad Mood” message in Constructor Should Return SAD
        [Test]
        public void Return_Mood_Sad_Constructor()
        {
            MoodAnalyzerClass moodAnalyzer = new MoodAnalyzerClass("I am in Sad Mood");
            string result = moodAnalyzer.AnalyseMood();
            Assert.That(result, Is.EqualTo("Sad"));
            Console.WriteLine(result);
        }
        // Refactor TC1.2-Given “I am in Happy Mood” message in Constructor Should Return SAD
        [Test]
        public void Return_Mood_Happy_Constructor()
        {
            string result = moodAnalyzer.AnalyseMood("I am in Any Mood");
            Assert.That(result, Is.EqualTo("Happy"));
            Console.WriteLine(result);
        }
        // TC2.1-Given Null Mood Should Return Happy
        [Test]
        public void Return_Happy_If_Null_Input()
        {
            try
            {
                MoodAnalyzerClass moodAnalyzer = new MoodAnalyzerClass("");
                string result = moodAnalyzer.AnalyseMood();
                Console.WriteLine(result);
            }
            catch (NullReferenceException e)
            {
                Assert.That(e.Message, Is.EqualTo("Happy"));
            }
        }
        // TC3.1-Given NULL Mood Should Throw MoodAnalysisException
        [Test]
        public void Null_Return_Using_Custom_Exception()
        {
            MoodAnalyzerClass moodAnalyzer = new MoodAnalyzerClass(null);
            try
            {
                string result = moodAnalyzer.AnalyseMood();               
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual("Null Input", e.Message);
            }
        }
        // TC3.2-Given Empty Mood Should Throw MoodAnalysisException indicating Empty Mood
        [Test]
        public void Return_Empty_Using_Custom_Exception()
        {
            MoodAnalyzerClass moodAnalyzer = new MoodAnalyzerClass(message: "");
            try
            {
                string result = moodAnalyzer.AnalyseMood();
                //  Assert.That(result, Is.EqualTo("Happy"));
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual("Empty Input", e.Message);
            }
        }
    }
}