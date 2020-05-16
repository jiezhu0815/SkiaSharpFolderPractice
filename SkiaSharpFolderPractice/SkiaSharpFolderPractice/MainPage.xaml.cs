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
                new Folder(){ DisplayColor="Blue",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Green",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="LightBlue",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="LightGreen",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="NavyBlue",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Orange",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Pink",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Purple",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Red" ,FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Yellow",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Black",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Gray",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Blue",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Green",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="LightBlue",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="LightGreen",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="NavyBlue",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Orange",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Pink",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Purple",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Red",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Yellow",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Black",FolderOpenCloseState=FolderState.Close},
                new Folder(){ DisplayColor="Gray",FolderOpenCloseState=FolderState.Close}
                
            };
            BindingContext = this;
            //FolderCollection.SelectionChanged += FolderCollection_SelectionChanged;
        }

        //private void FolderCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    Folder folder = (Folder)(e.CurrentSelection[0]);
        //    folder.Control.AnimateFolderOpenClose();
        //    //MessagingCenter.Send<OpenFolderMessage>(new OpenFolderMessage(), string.Empty);
        //}
    }
}
