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
        /// checking the sadmood or happymood
        /// using handle exceptions in uc2
        /// </summary>
        /// <returns></returns>
        public string  AnalyseMood()
        {
            try
            {                
                if (this.message.Contains("Sad"))
                    return "SAD";

                return "HAPPY";
            }
            catch(Exception)
            {
                return "HAPPY";
            }           
        }

    }
}
