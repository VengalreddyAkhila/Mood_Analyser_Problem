using Mood_Analyser_Problem;
using NUnit.Framework;

namespace Mood_Analyser
{
    public class Tests
    {
        /// <summary>
        /// checking for sad returns the sad mood
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
        /// checking for happymood returnns happy
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
        ///If the message is null it returns happymood 
        /// </summary>
        [Test]
        public void GivenNullMoodShouldReturnHappy()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string mood = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
            
        


