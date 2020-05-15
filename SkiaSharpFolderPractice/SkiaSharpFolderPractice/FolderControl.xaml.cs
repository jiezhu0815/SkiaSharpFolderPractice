using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkiaSharpFolderPractice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FolderControl : ContentView
    {

        //public FolderState FolderOpenCloseState { get; set; } = FolderState.Close;

        private bool isAnimate = false;
        public float FrontPathDegree { get; set; } = 0f;


        public string Color1 { get; set; } = "#FFD445";
        public string Color2 { get; set; } = "#FF8F00";
        public string Color3 { get; set; } = "#FFDE4F";
        public string Color4 { get; set; } = "#FFCA3B";
        public string Color5 { get; set; } = "#FFD041";
        public string Color6 { get; set; } = "#FF8F00";

        public static readonly BindableProperty FolderColorProperty = BindableProperty.Create(
                                                      propertyName: "FolderColor",
                                                      returnType: typeof(string),
                                                      declaringType: typeof(FolderControl),
                                                      defaultValue: "",
                                                      defaultBindingMode: BindingMode.TwoWay,
                                                      propertyChanged: FolderColorPropertyChanged);

        public string FolderColor
        {
            get { return base.GetValue(FolderColorProperty).ToString(); }
            set { base.SetValue(FolderColorProperty, value); }
        }

        private static void FolderColorPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (FolderControl)bindable;
            var controlColor = newValue.ToString();
            switch (controlColor)
            {
                case "Blue":
                    control.Color1 = "#2E94FF";
                    control.Color2 = "#0057FF";
                    control.Color3 = "#3BA2FF";
                    control.Color4 = "#2287FF";
                    control.Color5 = "#2A8FFF";
                    control.Color6 = "#0057FF";
                    break;
                case "Green":
                    control.Color1 = "#5ECF64";
                    control.Color2 = "#198A1F";
                    control.Color3 = "#68d96e";
                    control.Color4 = "#55c55a";
                    control.Color5 = "#5bcb60";
                    control.Color6 = "#198a1f";
                    break;
                case "LightBlue":
                    control.Color1 = "#7EBDFF";
                    control.Color2 = "#4584FF";
                    control.Color3 = "#87C6FF";
                    control.Color4 = "#77B5FF";
                    control.Color5 = "#7CBAFF";
                    control.Color6 = "#4584FF";
                    break;
                case "LightGreen":
                    control.Color1 = "#A3E894";
                    control.Color2 = "#5EA34F";
                    control.Color3 = "#ADF29E";
                    control.Color4 = "#9ADE8A";
                    control.Color5 = "#A0E490";
                    control.Color6 = "#5EA34F";
                    break;
                case "NavyBlue":
                    control.Color1 = "#004A8F";
                    control.Color2 = "#00058F";
                    control.Color3 = "#08548F";
                    control.Color4 = "#00408F";
                    control.Color5 = "#00468F";
                    control.Color6 = "#00058F";
                    break;
                case "Orange":
                    control.Color1 = "#FF7C49";
                    control.Color2 = "#FF3300";
                    control.Color3 = "#FF8956";
                    control.Color4 = "#FF6E3B";
                    control.Color5 = "#FF7643";
                    control.Color6 = "#FF3300";
                    break;
                case "Purple":
                    control.Color1 = "#940060";
                    control.Color2 = "#940017";
                    control.Color3 = "#94006D";
                    control.Color4 = "#940052";
                    control.Color5 = "#94005A";
                    control.Color6 = "#940017";
                    break;
                case "Pink":
                    control.Color1 = "#FF496D";
                    control.Color2 = "#FF0024";
                    control.Color3 = "#FF567A";
                    control.Color4 = "#FF3B5F";
                    control.Color5 = "#FF4367";
                    control.Color6 = "#FF0024";
                    break;
                case "Red":
                    control.Color1 = "#FF4949";
                    control.Color2 = "#FF0000";
                    control.Color3 = "#FF5656";
                    control.Color4 = "#FF3B3B";
                    control.Color5 = "#FF4343";
                    control.Color6 = "#FF0000";
                    break;
                case "Yellow":
                    control.Color1 = "#FFD445";
                    control.Color2 = "#FF8F00";
                    control.Color3 = "#FFDE4F";
                    control.Color4 = "#FFCA3B";
                    control.Color5 = "#FFD041";
                    control.Color6 = "#FF8F00";
                    break;
                case "Black":
                    control.Color1 = "#2C2C2C";
                    control.Color2 = "#000000";
                    control.Color3 = "#363636";
                    control.Color4 = "#232222";
                    control.Color5 = "#292828";
                    control.Color6 = "#000000";
                    break;
                case "Gray":
                    control.Color1 = "#DEDEDE";
                    control.Color2 = "#999999";
                    control.Color3 = "#E8E8E8";
                    control.Color4 = "#D5D4D4";
                    control.Color5 = "#DBDADA";
                    control.Color6 = "#999999";
                    break;
                default:
                    control.Color1 = "#FFD445";
                    control.Color2 = "#FF8F00";
                    control.Color3 = "#FFDE4F";
                    control.Color4 = "#FFCA3B";
                    control.Color5 = "#FFD041";
                    control.Color6 = "#FF8F00";
                    break;
            }
            control.FolderCanvas.InvalidateSurface();
        }

        public static readonly BindableProperty FolderOpenCloseStateProperty = BindableProperty.Create(
                                                     propertyName: "FolderOpenCloseState",
                                                     returnType: typeof(string),
                                                     declaringType: typeof(FolderControl),
                                                     defaultValue: "",
                                                     defaultBindingMode: BindingMode.TwoWay,
                                                     propertyChanged: FolderOpenCloseStatePropertyChanged);

        public string FolderOpenCloseState
        {
            get { 
                return base.GetValue(FolderOpenCloseStateProperty).ToString(); 
            }
            set { base.SetValue(FolderOpenCloseStateProperty, value); }
        }

        private static void FolderOpenCloseStatePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (FolderControl)bindable;
            var folderState = newValue.ToString();
            control.FolderOpenCloseState = folderState;
            control.FolderCanvas.InvalidateSurface();
        }


        SKPaint fillPaint = new SKPaint
        {
            Style = SKPaintStyle.Fill
        };

        public FolderControl()
        {
            InitializeComponent();
        }

        private void FolderCanvas_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;

            canvas.Clear();


            float scaleFactor = 0.67f;
            float density = scaleFactor * info.Size.Height / (float)this.Height;


            canvas.Save();

            using (SKPath backPath = SKPath.ParseSvgPathData(
            "M87.909,9.917V4.02A4.032,4.032,0,0,0,83.889,0H23.72A4.032,4.032,0,0,0,19.7,4.02v5.9H13.338a4.529,4.529,0,0,0-3.822,4.02l.27,112.7a3.954,3.954,0,0,0,3.951,4.024H167.344a3.963,3.963,0,0,0,3.97-4.011l-.6-112.71a4.092,4.092,0,0,0-4.07-4.02Z"))
            {
                backPath.Transform(SKMatrix.MakeScale(density, density));
                backPath.GetTightBounds(out var backPathTightBounds);
                var translateXBackPath = info.Width * 0.5f - backPathTightBounds.MidX;
                var translateYbackPath = info.Height - backPathTightBounds.Bottom - 20f;
                canvas.Translate(translateXBackPath, translateYbackPath);
                fillPaint.Shader = SKShader.CreateLinearGradient(
                new SKPoint(info.Width * 0.5f, 0),
                new SKPoint(info.Width * 0.5f, info.Height),
                new SKColor[] { SKColor.Parse(Color1), SKColor.Parse(Color2), SKColor.Parse(Color2) },
                new float[] { 0, 0.37f, 1 },
                SKShaderTileMode.Clamp
                );
                canvas.DrawPath(backPath, fillPaint);
            }

            canvas.Restore();

            canvas.Save();
            using (SKPath backFilePath = SKPath.ParseSvgPathData("M174.079,150.908H29.155l-.4-114.144H174.481Z"))
            {
                backFilePath.Transform(SKMatrix.MakeScale(density, density));
                backFilePath.GetTightBounds(out var backFilePathTightBounds);
                var translateXBackFilePath = info.Width * 0.5f - backFilePathTightBounds.MidX;
                var translateYbackFilePath = info.Height - backFilePathTightBounds.Bottom - 20f;
                canvas.Translate(translateXBackFilePath, translateYbackFilePath);
                fillPaint.Shader = SKShader.CreateLinearGradient(
                new SKPoint(info.Width * 0.5f, 0),
                new SKPoint(info.Width * 0.5f, info.Height),
                new SKColor[] { SKColor.Parse("#e6e6e6"), SKColor.Parse("#e8e8e8"), SKColor.Parse("#f0f0f0"), SKColor.Parse("#f2f2f2") },
                new float[] { 0, 0.633f, 0.949f, 1 },
                SKShaderTileMode.Clamp
                );
                canvas.DrawPath(backFilePath, fillPaint);
            }
            canvas.Restore();

            canvas.Save();
            using (SKPath frontFilePath = SKPath.ParseSvgPathData("M170.491,158.681H25.567L22.753,49.764H173.3Z"))
            {
                frontFilePath.Transform(SKMatrix.MakeScale(density, density));
                frontFilePath.GetTightBounds(out var frontFilePathTightBounds);
                var translateXFrontFilePath = info.Width * 0.5f - frontFilePathTightBounds.MidX;
                var translateYFrontFilePath = info.Height - frontFilePathTightBounds.Bottom - 20f;
                canvas.Translate(translateXFrontFilePath, translateYFrontFilePath);
                fillPaint.Shader = SKShader.CreateLinearGradient(
                new SKPoint(info.Width * 0.5f, 0),
                new SKPoint(info.Width * 0.5f, info.Height),
                new SKColor[] { SKColor.Parse("#cccccc"), SKColor.Parse("#cecece"), SKColor.Parse("#d6d6d6"), SKColor.Parse("#e3e3e3"), SKColor.Parse("#f6f6f6"), SKColor.Parse("#ffffff") },
                new float[] { 0, 0.427f, 0.64f, 0.806f, 0.947f, 1 },
                SKShaderTileMode.Clamp
                );
                canvas.DrawPath(frontFilePath, fillPaint);
            }
            canvas.Restore();

            canvas.Save();
            using (SKPath frontPath = SKPath.ParseSvgPathData("M165.433,164.917a4.106,4.106,0,0,1-4.089,4.011H7.735a4.578,4.578,0,0,1-4.325-4.292L0,68.019A3.948,3.948,0,0,1,3.95,64H164.895a3.948,3.948,0,0,1,3.95,4.02Z"))
            {
                frontPath.Transform(SKMatrix.MakeScale(density, density));
                frontPath.GetTightBounds(out var frontPathTightBounds);

                fillPaint.Shader = SKShader.CreateLinearGradient(
                new SKPoint(info.Width * 0.5f, 0),
                new SKPoint(info.Width * 0.5f, info.Height),
                new SKColor[] { SKColor.Parse(Color3), SKColor.Parse(Color4), SKColor.Parse(Color5), SKColor.Parse(Color6) },
                new float[] { 0, 0.595f, 0.957f, 1 },
                SKShaderTileMode.Clamp
                );
                
                SKMatrix matrix = SKMatrix.MakeTranslation(-frontPathTightBounds.Right, -frontPathTightBounds.Bottom);
                SKMatrix44 matrix44 = SKMatrix44.CreateIdentity();
                if(isAnimate)
                {
                    matrix44.PostConcat(SKMatrix44.CreateRotationDegrees(1, 0, 0, -FrontPathDegree));
                    matrix44.PostConcat(SKMatrix44.CreateRotationDegrees(0, 1, 0, -0.5f * FrontPathDegree));
                }
                else
                {
                    var rotateDegree = 0f;
                    if(FolderOpenCloseState=="Close")
                    {
                        rotateDegree = 0f;
                    }
                    else
                    {
                        rotateDegree = 42f;
                    }
                    matrix44.PostConcat(SKMatrix44.CreateRotationDegrees(1, 0, 0, -rotateDegree));
                    matrix44.PostConcat(SKMatrix44.CreateRotationDegrees(0, 1, 0, -0.5f * rotateDegree));

                }

                matrix44.PostConcat(SKMatrix44.CreateRotationDegrees(0, 0, 1, 0));
                SKMatrix.PostConcat(ref matrix, matrix44.Matrix);
                SKMatrix.PostConcat(ref matrix,SKMatrix.MakeTranslation(frontPathTightBounds.Right, frontPathTightBounds.Bottom));
                canvas.SetMatrix(matrix);

                var translateXFrontPath = info.Width * 0.5f - frontPathTightBounds.MidX;
                var translateYFrontPath = info.Height - frontPathTightBounds.Bottom - 20f;
                canvas.Translate(translateXFrontPath, translateYFrontPath);
                canvas.DrawPath(frontPath, fillPaint);
            }
            canvas.Restore();

        }

        private void FolderCanvasTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            var parentAnimation = new Animation();
            parentAnimation.Add(0.00, 1, CreateFrontDegreeAnimation());
            //We need to add some other animations such jumpout a file and turn it into a canvas

            parentAnimation.Commit(this, "FolderAnimation", 16, 2000);
           
        }

        private Animation CreateFrontDegreeAnimation()
        {
            isAnimate = true;
            var folderAnimStart = FolderOpenCloseState == "Close" ? 0f: 42f;
            var folderAnimEnd = FolderOpenCloseState == "Open" ? 42f: 0f;

            var folderAnim = new Animation(
                v =>
                {

                    FrontPathDegree = (float)v;
                    FolderCanvas.InvalidateSurface();
                },
                folderAnimStart,
                folderAnimEnd,
                Easing.SinInOut,
                () =>
                {

                    if (FolderOpenCloseState == "Close")
                    {
                        FolderOpenCloseState = "Open";
                        FrontPathDegree = 42f;
                    }
                    else
                    {
                        FolderOpenCloseState = "Close";
                        FrontPathDegree = 0f;
                    }
                    isAnimate = false;
                }

                );
            return folderAnim;

        }
    }
}