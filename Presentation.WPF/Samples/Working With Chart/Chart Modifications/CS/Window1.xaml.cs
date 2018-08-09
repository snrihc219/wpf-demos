﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Syncfusion.Presentation;
using Syncfusion.Windows.Shared;
using Syncfusion.OfficeChart;

namespace PPTXToImage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ChromelessWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageSourceConverter img = new ImageSourceConverter();
            string file = @"..\..\..\..\..\..\..\Common\Images\Presentation\ppt_header.png";
            this.image1.Source = (ImageSource)img.ConvertFromString(file);
            this.Icon = (ImageSource)img.ConvertFromString(@"..\..\..\..\..\..\..\Common\Images\Presentation\App.ico");
        }

        private void btnCreateImage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Opens the specified presentation
                IPresentation presentation = Presentation.Open(@"..\..\..\..\..\..\..\Common\Data\Presentation\ChartInput.pptx");

                //Method call to edit slides
                CreateSlide1(presentation);
                CreateSlide2(presentation);
                CreateSlide3(presentation);
                CreateSlide4(presentation);
                    presentation.Save("ChartModificationSample.pptx");
                    if (System.Windows.MessageBox.Show("Do you want to view the generated PowerPoint Presentation?", "Chart Modification",
                            MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        System.Diagnostics.Process.Start("ChartModificationSample.pptx");
                        this.Close();
                    }
            }
            catch (Exception exception)
            {
                System.Windows.MessageBox.Show("This Presentation could not be created, please contact Syncfusion Direct-Trac system at http://www.syncfusion.com/support/default.aspx for any queries. ", "OOPS..Sorry!",
                    MessageBoxButton.OK);
                this.Close();
            }
        }
        # region Slide1
        private void CreateSlide1(IPresentation presentation)
        {
            ISlide slide1 = presentation.Slides[0];
            IPresentationChart chart = slide1.Charts[0] as IPresentationChart;
            chart.Legend.Position = OfficeLegendPosition.Top;
            chart.ChartArea.Fill.FillType = OfficeFillType.SolidColor;
            chart.ChartArea.Fill.ForeColor = System.Drawing.Color.FromArgb(251, 229, 214);
            chart.ChartArea.Border.AutoFormat = false;
            chart.ChartArea.Border.IsAutoLineColor = false;
            chart.ChartArea.Border.LinePattern = OfficeChartLinePattern.Solid;
            chart.ChartArea.Border.LineColor = System.Drawing.Color.FromArgb(32, 56, 100);
            chart.ChartArea.Border.LineWeight = OfficeChartLineWeight.Wide;
            chart.Series[0].DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
            chart.Series[1].DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
            chart.Series[2].DataPoints.DefaultDataPoint.DataLabels.IsValue = true;
        }
        #endregion

        #region Slide2
        private void CreateSlide2(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides[1];
            IPresentationChart chart = slide2.Shapes[0] as IPresentationChart;
            chart.HasDataTable = true;
            chart.DataTable.HasBorders = true;
            chart.DataTable.HasHorzBorder = true;
            chart.DataTable.HasVertBorder = true;
            chart.DataTable.ShowSeriesKeys = true;
            chart.DataTable.TextArea.FrameFormat.Border.AutoFormat = false;
            chart.DataTable.TextArea.FrameFormat.Border.IsAutoLineColor = false;
            chart.DataTable.TextArea.FrameFormat.Border.LineColor = System.Drawing.Color.FromArgb(143, 170, 220);
            chart.DataTable.TextArea.FrameFormat.Border.LinePattern = OfficeChartLinePattern.Solid;
            chart.DataTable.TextArea.FrameFormat.Border.LineWeight = OfficeChartLineWeight.Medium;


            chart.PlotArea.Fill.FillType = OfficeFillType.SolidColor;
            chart.PlotArea.Fill.ForeColor = System.Drawing.Color.FromArgb(112, 48, 160);
            chart.PlotArea.Fill.Transparency = 0.75;

            chart.PlotArea.Border.AutoFormat = false;
            chart.PlotArea.Border.IsAutoLineColor = false;
            chart.PlotArea.Border.LinePattern = OfficeChartLinePattern.Solid;
            chart.PlotArea.Border.LineWeight = OfficeChartLineWeight.Wide;
            chart.PlotArea.Border.LineColor = System.Drawing.Color.FromArgb(132, 151, 176);




        }

        #endregion

        # region Slide3
        private void CreateSlide3(IPresentation presentation)
        {
            ISlide slide2 = presentation.Slides[2];
            IPresentationChart chart = slide2.Charts[0] as IPresentationChart;
            chart.PlotArea.Fill.FillType = OfficeFillType.SolidColor;
            chart.PlotArea.Fill.ForeColor = System.Drawing.Color.FromArgb(251, 229, 214);
            chart.Series[0].DataPoints[0].DataFormat.Fill.FillType = OfficeFillType.SolidColor;
            chart.Series[0].DataPoints[0].DataFormat.Fill.ForeColor = System.Drawing.Color.FromArgb(244, 177, 131);
            chart.Series[0].DataPoints[1].DataFormat.Fill.FillType = OfficeFillType.SolidColor;
            chart.Series[0].DataPoints[1].DataFormat.Fill.ForeColor = System.Drawing.Color.FromArgb(255, 230, 153);
            chart.Series[0].DataPoints[2].DataFormat.Fill.FillType = OfficeFillType.SolidColor;
            chart.Series[0].DataPoints[2].DataFormat.Fill.ForeColor = System.Drawing.Color.FromArgb(132, 151, 176);
            chart.Series[0].DataPoints[3].DataFormat.Fill.FillType = OfficeFillType.SolidColor;
            chart.Series[0].DataPoints[3].DataFormat.Fill.ForeColor = System.Drawing.Color.FromArgb(157, 195, 230);

        }

        #endregion

        #region Slide4
        private void CreateSlide4(IPresentation presentation)
        {
            ISlide slide4 = presentation.Slides[3];
            IPresentationChart chart = slide4.Charts[0] as IPresentationChart;
            chart.Series[0].SerieFormat.CommonSerieOptions.GapWidth = 81;
            chart.PlotArea.Border.AutoFormat = false;
            chart.PlotArea.Border.IsAutoLineColor = false;
            chart.PlotArea.Border.LinePattern = OfficeChartLinePattern.Solid;
            chart.PlotArea.Border.LineWeight = OfficeChartLineWeight.Wide;
            chart.PlotArea.Border.LineColor = System.Drawing.Color.FromArgb(143, 173, 220);
        }
        #endregion
    }
}
          
