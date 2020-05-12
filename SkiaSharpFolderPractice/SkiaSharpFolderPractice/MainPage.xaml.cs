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
            FoldersCollection = new ObservableCollection<Folder>()
            {
            new Folder(),new Folder(),new Folder(),new Folder(),new Folder(),new Folder(),new Folder(),new Folder(),new Folder(),new Folder(),new Folder(),new Folder(),new Folder(),new Folder(),new Folder(),new Folder()
            };

            BindingContext = this;
        }


    }
}
