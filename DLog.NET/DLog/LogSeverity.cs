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
    /// A basic enumeration that defines log priorities
    /// </summary>
    /// <author>Cruz Bishop</author>
    /// <version>1.0.0.0</version>
    public enum LogSeverity
    {
        /// <summary>
        /// Trace-level information. Used for extreme debugging or notifications
        /// Not recommended outside of development
        /// </summary>
        Trace,

        /// <summary>
        /// General information. Used for deeper debugging than usual, mainly
        /// when something notable happens.
        /// Not really recommended outside of development
        /// </summary>
        Info,

        /// <summary>
        /// Debugging information. Used for debugging, of course!
        /// Used when debugging a potential problem
        /// The end user doesn't usually need access to this unless a bug actually occurs.
        /// </summary>
        Debug,

        /// <summary>
        /// Normal (regular) output. Stuff you'd normally print!
        /// </summary>
        Normal,

        /// <summary>
        /// A warning, usually used if something that shouldn't happen happens, or 
        /// something else takes too long
        /// </summary>
        Warning,

        /// <summary>
        /// An error. What's it used for?
        /// ...Errors. And exceptions.
        /// </summary>
        Error,

        /// <summary>
        /// A critical error or showstopper. The program launched nuclear missiles
        /// (or simply shut down prematurely)
        /// </summary>
        Critical

    }
}
