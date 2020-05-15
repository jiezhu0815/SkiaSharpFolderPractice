using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SkiaSharpFolderPractice
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Folder> FoldersCollection { get; set; }
        public MainPage()
        {
            InitializeComponent();
            FoldersCollection = new ObservableCollection<Folder>() {
                new Folder(){ DisplayColor="Blue",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Green",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="LightBlue",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="LightGreen",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="NavyBlue",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Orange",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Pink",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Purple",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Red",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Yellow",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Black",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Gray",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Blue",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Green",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="LightBlue",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="LightGreen",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="NavyBlue",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Orange",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Pink",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Purple",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Red",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Yellow",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Black",FolderOpenCloseState="Close"},
                new Folder(){ DisplayColor="Gray",FolderOpenCloseState="Close"}

            };
            BindingContext = this;
        }


    }
}
