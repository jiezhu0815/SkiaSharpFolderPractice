﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SkiaSharpFolderPractice
{
    public class Folder:BaseViewModel
    {
        private string _displayColor;

        public string DisplayColor
        {
            get { return _displayColor; }
            set
            {
                SetProperty(ref _displayColor, value);
            }
        }
    }
}
