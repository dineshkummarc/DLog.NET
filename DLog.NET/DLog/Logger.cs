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
    /// An abstract class that defines a logger
    /// Also contains helper methods
    /// <author>Cruz Bishop</author>
    /// <version>0.9.0.0</version>
    /// </summary>
    public abstract class Logger
    {

        /// <summary>
        /// Logs the specified data with the specified severity
        /// </summary>
        /// <param name="severity">The severity to use</param>
        /// <param name="data">The data to log</param>
        public abstract void Log(LogSeverity severity, Object data);

        /// <summary>
        /// Logs the specified data as trace information
        /// </summary>
        /// <param name="data">The data to log</param>
        public void LogTrace(Object data)
        {
            this.Log(LogSeverity.Trace, data);
        }

        /// <summary>
        /// Logs the specified data as general information
        /// </summary>
        /// <param name="data">The data to log</param>
        public void LogInfo(Object data)
        {
            this.Log(LogSeverity.Info, data);
        }

        /// <summary>
        /// Logs the specified data as debugging information
        /// </summary>
        /// <param name="data">The data to log</param>
        public void LogDebug(Object data)
        {
            this.Log(LogSeverity.Debug, data);
        }

        /// <summary>
        /// Logs the specified data as normal output
        /// </summary>
        /// <param name="data">The data to log</param>
        public void LogNormal(Object data)
        {
            this.Log(LogSeverity.Normal, data);
        }

        /// <summary>
        /// Logs the specified data as a warning
        /// </summary>
        /// <param name="data">The data to log</param>
        public void LogWarning(Object data)
        {
            this.Log(LogSeverity.Warning, data);
        }

        /// <summary>
        /// Logs the specified data as an error
        /// </summary>
        /// <param name="data">The data to log</param>
        public void LogError(Object data)
        {
            this.Log(LogSeverity.Error, data);
        }

        /// <summary>
        /// Logs the specified data as a critical error
        /// </summary>
        /// <param name="data">The data to log</param>
        public void LogCritical(Object data)
        {
            this.Log(LogSeverity.Critical, data);
        }

    }
}
