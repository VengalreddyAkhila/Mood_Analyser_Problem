using Mood_Analyser_Problem;
using NUnit.Framework;

namespace Mood_Analyser
{
    public class Tests
    {
        /// <summary>
        /// test case 1.1 checking for sad returns the sad mood
        /// </summary>
        [Test]
        public void GivenSadMoodShouldReturnSad()
        {
            string expected = "SAD";
            string message = "I am in Sad mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string mood = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
        /// <summary>
        /// Test case 1.2 checking for happymood returnns happy
        /// </summary>
        [Test]
        public void GivenHappyMoodShouldReturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in Happy mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string mood = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
        /// <summary>
        ///Test case 3.1 GivenNullMoodShouldReturnHappy
        /// </summary>
        [Test]
        public void GivenNullMoodShouldReturnHappy()
        {
            try
            {
                //Arrange                
                string expected = "Happy";
                MoodAnalyser moodAnalyser = new MoodAnalyser(null);
                //Act
                string mood = moodAnalyser.AnalyseMood();
                Assert.AreEqual(expected, mood);
            }
            catch (MoodAnalysisException ex)
            {
                //Assert
                Assert.AreEqual("mood should not be null",ex.Message);
            }
        }
        /// <summary>
        /// Test case 3.2 GivenEmptyMoodShouldReturnHappy
        /// </summary>
        [Test]
        public void GivenEmptyMoodShouldReturnHappy()
        {
            try
            {
                //Arrange
                string expected = "HAPPY";
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string mood = moodAnalyser.AnalyseMood();
                Assert.AreEqual(expected, mood);
            }
            catch (MoodAnalysisException ex)
            {
                //Assert
                Assert.AreEqual("mood should not be empty" , ex.Message);
            }
        }
        /// <summary>
        /// Test case 4.1 given mood analyser classname should return mood analyser object
        /// </summary>
        [Test]
        public void GivenMoodAnalysisClassName_ShouldReturnMoodAnalyser_Object()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalysis("moodanalyserclass.moodanalyser", "moodanalyser");
            expected.Equals(obj);
        }
        
    }
}
            
        


