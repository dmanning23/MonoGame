﻿// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System;
using System.Diagnostics;
//using System.Windows.Forms;
using Xwt;

namespace MonoGame.Tools.Pipeline
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

			Application.Initialize(ToolkitType.Wpf);

			var view = new XwtView();
			//var view = new MainView();

            if (args != null && args.Length > 0)
            {
                var projectFilePath = string.Join(" ", args);
                view.OpenProjectPath = projectFilePath;
            }

            var model = new PipelineProject();
            var controller = new PipelineController(view, model);   

            //Application.Run(view);

			view.Show();
            Application.Run();
        }
    }
}
