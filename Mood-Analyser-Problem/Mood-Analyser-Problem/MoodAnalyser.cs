using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyser_Problem
{
    public class MoodAnalyser
    {
         string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// parameterised constructor
        /// checking the  mood sad or happy
        /// </summary>
        /// <returns></returns>
        public string  AnalyseMood()
        {
            if (this.message.Contains("Sad"))
                return "SAD";
           
                return "HAPPY";                    
        }

    }
}
