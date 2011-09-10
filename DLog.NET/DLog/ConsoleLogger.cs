/*
 * Copyright (c) 2011 Massive Dynamics
 * 
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the
 * "Software"), to deal in the Software without restriction, including
 * without limitation the rights to use, copy, modify, merge, publish,
 * distribute, sublicense, and/or sell copies of the Software, and to
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
 * LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
 * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
 * WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace MassiveDynamics.DLog
{
    /// <summary>
    /// A basic logger that logs to the console
    /// Does not check to see if a console is available yet.
    /// Does not use console colors
    /// </summary>
    public class ConsoleLogger : Logger
    {
        /// <summary>
        /// Logs the specified data with the specified severity
        /// </summary>
        /// <param name="severity">The severity to use</param>
        /// <param name="data">The data to log</param>
        public override void Log(LogSeverity severity, object data)
        {
            //Set up the output builder
            StringBuilder outputBuilder = new StringBuilder("");
            //Add the formatted date
            outputBuilder.Append(DateTime.Now.ToString(this.Format));
            //Add the severity
            outputBuilder.Append(": [")
                    .Append(Enum.GetName(typeof(LogSeverity), severity))
                    .Append("] ");
            //And the prefix
            outputBuilder.Append(this.Prefix).Append(" - ");
            //And finally the data
            outputBuilder.Append(data);
            //Then let's log it
            Console.WriteLine(outputBuilder.ToString());
            //And destroy
            outputBuilder = null;
        }
    }
}
