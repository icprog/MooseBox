﻿//////////////////////////////////////////////////////////////////////////
// Copyright (C) 2015  Christopher James Cavage (cjcavage@gmail.com)    //
//                                                                      //
// This program is free software; you can redistribute it and/or        //
// modify it under the terms of the GNU General Public license          //
// as published by the Free Software Foundation; either version 2       //
// of the License, or (at your option) any later version.               //
//                                                                      //
// This program is distributed in the hope that it will be useful,      //
// but WITHOUT ANY WARRANTY; without even the implied warranty of       //
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the        //
// GNU General Public License for more details.                         //
//                                                                      //
// You should have received a copy of the GNU General Public License    //
// along with this program; if not, see <http://www.gnu.org/licenses/>. //
//////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;

namespace MooseBoxUI
{
    /// <summary>
    /// Defines main entry class for the MooseBox UI Win32 client.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
