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
                new Folder(){ DisplayColor="Blue"},
                new Folder(){ DisplayColor="Green"},
                new Folder(){ DisplayColor="LightBlue"},
                new Folder(){ DisplayColor="LightGreen"},
                new Folder(){ DisplayColor="NavyBlue"},
                new Folder(){ DisplayColor="Orange"},
                new Folder(){ DisplayColor="Pink"},
                new Folder(){ DisplayColor="Purple"},
                new Folder(){ DisplayColor="Red"},
                new Folder(){ DisplayColor="Yellow"},
                new Folder(){ DisplayColor="Black"},
                new Folder(){ DisplayColor="Gray"},
                new Folder(){ DisplayColor="Blue"},
                new Folder(){ DisplayColor="Green"},
                new Folder(){ DisplayColor="LightBlue"},
                new Folder(){ DisplayColor="LightGreen"},
                new Folder(){ DisplayColor="NavyBlue"},
                new Folder(){ DisplayColor="Orange"},
                new Folder(){ DisplayColor="Pink"},
                new Folder(){ DisplayColor="Purple"},
                new Folder(){ DisplayColor="Red"},
                new Folder(){ DisplayColor="Yellow"},
                new Folder(){ DisplayColor="Black"},
                new Folder(){ DisplayColor="Gray"}

            };
            BindingContext = this;
        }


    }
}
