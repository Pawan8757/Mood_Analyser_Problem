using MoodAnalayzer;

namespace MoodAnalyzerTest
{

    public class AnalyzerTest
    {
        public object Assert { get; private set; }

        
        public void GivenSadMoodShouldReturnSAD()
        {
            // Arrange
            string expected = "SAD";
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse();

            // Act
            string mood = moodAnalyse.AnalyseMood(message);

            // Assert
            Assert.AreEqual(expected, mood);
        }

       
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            // Arrange
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse();

            // Act
            string mood = moodAnalyse.AnalyseMood(message);

            // Assert
            Assert.AreEqual(expected, mood);
        }
    }
}