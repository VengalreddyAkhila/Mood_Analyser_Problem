using System;

namespace Mood_Analyser_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MoodAnalyser moodAnalyser = new MoodAnalyser("happy");
            Console.WriteLine(moodAnalyser.AnalyseMood());            

        }
    }
}
