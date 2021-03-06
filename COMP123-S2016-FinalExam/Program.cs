﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    // Author Name Richard Elridge
    // Student number 301107264
    // modify 20/08/2020
    // This program is use to interact with different windows form
    public static class Program
    {
        public static GenerateNameForm genform;
        public static splashform splash;
        public static AbilityGeneratorForm ability;
        public static RaceAndClassForm race;
        public static FinalForm final;
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splash = new splashform();
            genform = new GenerateNameForm();
            ability = new AbilityGeneratorForm();
            race = new RaceAndClassForm();
            final = new FinalForm();
            Application.Run(new splashform());
        }
    }
}
