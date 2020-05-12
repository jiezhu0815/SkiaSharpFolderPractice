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
        SKPaint fillPaint = new SKPaint
        {
            Style = SKPaintStyle.Fill
        };

        SKPath backPath = SKPath.ParseSvgPathData(
            "M87.909,9.917V4.02A4.032,4.032,0,0,0,83.889,0H23.72A4.032,4.032,0,0,0,19.7,4.02v5.9H13.338a4.529,4.529,0,0,0-3.822,4.02l.27,112.7a3.954,3.954,0,0,0,3.951,4.024H167.344a3.963,3.963,0,0,0,3.97-4.011l-.6-112.71a4.092,4.092,0,0,0-4.07-4.02Z");

        SKPath backFilePath = SKPath.ParseSvgPathData(
            "M174.079,150.908H29.155l-.4-114.144H174.481Z");

        SKPath frontFilePath = SKPath.ParseSvgPathData(
           "M170.491,158.681H25.567L22.753,49.764H173.3Z");

        SKPath frontPath = SKPath.ParseSvgPathData(
           "M165.433,164.917a4.106,4.106,0,0,1-4.089,4.011H7.735a4.578,4.578,0,0,1-4.325-4.292L0,68.019A3.948,3.948,0,0,1,3.95,64H164.895a3.948,3.948,0,0,1,3.95,4.02Z");


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


            backPath.Transform(SKMatrix.MakeScale(density, density));
            backPath.GetTightBounds(out var backPathTightBounds);
            var translateXBackPath = info.Width * 0.5f - backPathTightBounds.MidX;
            var translateYbackPath = info.Height - backPathTightBounds.Bottom - 20f;
            canvas.Translate(translateXBackPath, translateYbackPath);
            fillPaint.Shader = SKShader.CreateLinearGradient(
            new SKPoint(info.Width * 0.5f, 0),
            new SKPoint(info.Width * 0.5f, info.Height),
            new SKColor[] { SKColor.Parse("#5ECF64"), SKColor.Parse("#198A1F"), SKColor.Parse("#198A1F") },
            new float[] { 0, 0.37f, 1 },
            SKShaderTileMode.Clamp
            );
            canvas.DrawPath(backPath, fillPaint);
            canvas.Restore();

            canvas.Save();
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
            canvas.Restore();

            canvas.Save();
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
            canvas.Restore();

            canvas.Save();
            frontPath.Transform(SKMatrix.MakeScale(density, density));
            frontPath.GetTightBounds(out var frontPathTightBounds);
            var translateXFrontPath = info.Width * 0.5f - frontPathTightBounds.MidX;
            var translateYFrontPath = info.Height - frontPathTightBounds.Bottom - 20f;
            canvas.Translate(translateXFrontPath, translateYFrontPath);
            fillPaint.Shader = SKShader.CreateLinearGradient(
            new SKPoint(info.Width * 0.5f, 0),
            new SKPoint(info.Width * 0.5f, info.Height),
            new SKColor[] { SKColor.Parse("#68d96e"), SKColor.Parse("#55c55a"), SKColor.Parse("#5bcb60"), SKColor.Parse("#198a1f") },
            new float[] { 0, 0.595f, 0.957f, 1 },
            SKShaderTileMode.Clamp
            );
            canvas.DrawPath(frontPath, fillPaint);
            canvas.Restore();

        }
    }
}