﻿using System;

namespace Shapes2D.Samples.Grid
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new GridSample())
                game.Run();
        }
    }
}
