﻿/*
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
    /// A dummy logger that just destroys any input
    /// </summary>
    /// <author>Cruz Bishop</author>
    /// <version>1.0.0.0</version>
    public class DummyLogger : Logger
    {

        /// <summary>
        /// Supposedly logs the data with the specified input
        /// </summary>
        /// <param name="severity">The severity to "use"</param>
        /// <param name="data">The data to "log"</param>
        public override void Log(LogSeverity severity, object data)
        {
            //Do nothing
        }

        /// <summary>
        /// Disposes all extra resources introduced by this class
        /// </summary>
        public override void DisposeResources()
        {
            //This is a dummy logger, so BAH!
        }
    }
}
