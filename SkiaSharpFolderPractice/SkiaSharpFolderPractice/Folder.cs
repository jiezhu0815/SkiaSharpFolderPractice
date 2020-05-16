using System;
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

        private FolderState _folderOpenCloseState;

        public FolderState FolderOpenCloseState
        {
            get { return _folderOpenCloseState; }
            set
            {
                SetProperty(ref _folderOpenCloseState, value);
            }
        }

        private bool _isAnimated;

        public bool IsAnimated
        {
            get { return _isAnimated; }
            set
            {
                SetProperty(ref _isAnimated, value);
            }
        }

        public float FrontPathDegree { get; set; } = 0f;

        public FolderControl Control { get; set; }
    }

    public enum FolderState
    {
        Close,
        Open
    }
}
