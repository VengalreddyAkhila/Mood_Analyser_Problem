using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyser_Problem
{
    /// <summary>
    /// moodanalysisexception class for handling exceptions
    /// </summary>
    public  class MoodAnalysisException : Exception 
    {
        /// <summary>
        /// enum for exception type
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE,EMPTY_MESSAGE
        }
        //creating type variable of type exceptiontype
        private readonly ExceptionType type;

        ///<summary>
        ///parameterized  constructor sets the exception type and message
        ///</summary>
        public MoodAnalysisException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
