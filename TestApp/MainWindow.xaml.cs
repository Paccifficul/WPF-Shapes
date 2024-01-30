using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly TextBox textBoxPar1;
        private readonly TextBox textBoxPar2;
        private readonly TextBox textBoxPar3;
        private readonly TextBox textBoxPar4;
        private readonly TextBox textBoxPar5;
        private readonly TextBox textBoxPar6;

        private readonly Label labelPar1;
        private readonly Label labelPar2;
        private readonly Label labelPar3;
        private readonly Label labelPar4;
        private readonly Label labelPar5;
        private readonly Label labelPar6;

        private readonly Button createFigureButton;

        private readonly FigureViewModel figureViewModel;

        public MainWindow()
        {
            InitializeComponent();
            HideElements();

            textBoxPar1 = TextBoxPar1;
            textBoxPar2 = TextBoxPar2;
            textBoxPar3 = TextBoxPar3;
            textBoxPar4 = TextBoxPar4;
            textBoxPar5 = TextBoxPar5;
            textBoxPar6 = TextBoxPar6;

            labelPar1 = Par1;
            labelPar2 = Par2;
            labelPar3 = Par3;
            labelPar4 = Par4;
            labelPar5 = Par5;
            labelPar6 = Par6;

            createFigureButton = CreateButton;

            figureViewModel = new FigureViewModel();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
            var rb = (RadioButton)sender;
            figureViewModel.ChangeFigureModel(rb.Content.ToString());

            HideElements();

            switch (figureViewModel.Figure.FigureType)
            {
                case FigureType.Ellipse:
                    labelPar1.Content = "X center";
                    labelPar2.Content = "Y center";
                    labelPar3.Content = "X radius";
                    labelPar4.Content = "Y radius";

                    labelPar1.Visibility = Visibility.Visible;
                    labelPar2.Visibility = Visibility.Visible;
                    labelPar3.Visibility = Visibility.Visible;
                    labelPar4.Visibility = Visibility.Visible;

                    textBoxPar1.Visibility = Visibility.Visible;
                    textBoxPar2.Visibility = Visibility.Visible;
                    textBoxPar3.Visibility = Visibility.Visible;
                    textBoxPar4.Visibility = Visibility.Visible;

                    textBoxPar1.IsEnabled = true;
                    textBoxPar2.IsEnabled = true;
                    textBoxPar3.IsEnabled = true;
                    textBoxPar4.IsEnabled = true;
                    break;
                case FigureType.Rectangle:
                    labelPar1.Content = "First point x";
                    labelPar2.Content = "First poing y";
                    labelPar3.Content = "Weight";
                    labelPar4.Content = "Height";
                    labelPar5.Content = "X radius";
                    labelPar6.Content = "Y radius";

                    labelPar1.Visibility = Visibility.Visible;
                    labelPar2.Visibility = Visibility.Visible;
                    labelPar3.Visibility = Visibility.Visible;
                    labelPar4.Visibility = Visibility.Visible;
                    labelPar5.Visibility = Visibility.Visible;
                    labelPar6.Visibility = Visibility.Visible;

                    textBoxPar1.Visibility = Visibility.Visible;
                    textBoxPar2.Visibility = Visibility.Visible;
                    textBoxPar3.Visibility = Visibility.Visible;
                    textBoxPar4.Visibility = Visibility.Visible;
                    textBoxPar5.Visibility = Visibility.Visible;
                    textBoxPar6.Visibility = Visibility.Visible;

                    textBoxPar1.IsEnabled = true;
                    textBoxPar2.IsEnabled = true;
                    textBoxPar3.IsEnabled = true;
                    textBoxPar4.IsEnabled = true;
                    textBoxPar5.IsEnabled = true;
                    textBoxPar6.IsEnabled = true;
                    break;
                case FigureType.Triangle:
                    labelPar1.Content = "First point x";
                    labelPar2.Content = "First poing y";
                    labelPar3.Content = "Second point x";
                    labelPar4.Content = "Second point y";
                    labelPar5.Content = "Third point x";
                    labelPar6.Content = "Third point y";

                    labelPar1.Visibility = Visibility.Visible;
                    labelPar2.Visibility = Visibility.Visible;
                    labelPar3.Visibility = Visibility.Visible;
                    labelPar4.Visibility = Visibility.Visible;
                    labelPar5.Visibility = Visibility.Visible;
                    labelPar6.Visibility = Visibility.Visible;

                    textBoxPar1.Visibility = Visibility.Visible;
                    textBoxPar2.Visibility = Visibility.Visible;
                    textBoxPar3.Visibility = Visibility.Visible;
                    textBoxPar4.Visibility = Visibility.Visible;
                    textBoxPar5.Visibility = Visibility.Visible;
                    textBoxPar6.Visibility = Visibility.Visible;

                    textBoxPar1.IsEnabled = true;
                    textBoxPar2.IsEnabled = true;
                    textBoxPar3.IsEnabled = true;
                    textBoxPar4.IsEnabled = true;
                    textBoxPar5.IsEnabled = true;
                    textBoxPar6.IsEnabled = true;
                    break;
            }

            createFigureButton.Visibility = Visibility.Visible;
            createFigureButton.IsEnabled = true;
        }

        private void CreateFigureButtonClick(object sender, RoutedEventArgs e)
        {
            Figure.Children.Clear();
            try
            {
                switch (figureViewModel.Figure.FigureType)
                {
                    case FigureType.Ellipse:
                        CreateEllipse();
                        break;
                    case FigureType.Rectangle:
                        CreateRectangle();
                        break;
                    case FigureType.Triangle:
                        CreateTriangle();
                        break;
                }
            }
            catch (Exception)
            {
               
            }
        }

        private void HideElements()
        {
            foreach (var elem in mainGrid.Children)
            {
                if (elem is Panel)
                {
                    continue;
                }

                ((UIElement)elem).Visibility = Visibility.Hidden;
                ((UIElement)elem).IsEnabled = false;

                if (!(elem is TextBox))
                {
                    continue;
                }
                
                ((TextBox)elem).Text = "";
            }
        }

        private void CreateEllipse()
        {
            EllipseGeometry ellipse = new EllipseGeometry();

            EllipseModel ellipseModel = new EllipseModel(
                FigureType.Ellipse,
                Convert.ToDouble(textBoxPar1.Text),
                Convert.ToDouble(textBoxPar2.Text),
                Convert.ToDouble(textBoxPar3.Text),
                Convert.ToDouble(textBoxPar4.Text)
                );

            ellipse.RadiusX = ellipseModel.XRadius;
            ellipse.RadiusY = ellipseModel.YRadius;
            ellipse.Center = new Point(ellipseModel.XStart, ellipseModel.YStart);

            Path path = new Path
            {
                Stroke = Brushes.Black,
                Fill = Brushes.Gray,
                StrokeThickness = 2,
                Data = ellipse
            };

            Figure.Children.Add(path);
        }

        private void CreateRectangle()
        {
            RectangleGeometry rectangle = new RectangleGeometry();

            RectangleModel rectangleModel = new RectangleModel(
                FigureType.Rectangle,
                Convert.ToDouble(textBoxPar1.Text),
                Convert.ToDouble(textBoxPar2.Text),
                Convert.ToDouble(textBoxPar3.Text),
                Convert.ToDouble(textBoxPar4.Text),
                Convert.ToDouble(textBoxPar5.Text),
                Convert.ToDouble(textBoxPar6.Text)
                );

            rectangle.Rect = new Rect(
                rectangleModel.XStart,
                rectangleModel.YStart,
                rectangleModel.Width,
                rectangleModel.Height
                );
            rectangle.RadiusX = rectangleModel.XRadius;
            rectangle.RadiusY = rectangleModel.YRadius;

            Path path = new Path
            {
                Stroke = Brushes.Black,
                Fill = Brushes.Gray,
                StrokeThickness = 2,
                Data = rectangle
            };

            Figure.Children.Add(path);
        }

        private void CreateTriangle()
        {
            Polygon polygon = new Polygon();

            TriangleModel triangle = new TriangleModel(
                FigureType.Triangle,
                Convert.ToDouble(textBoxPar1.Text),
                Convert.ToDouble(textBoxPar2.Text),
                Convert.ToDouble(textBoxPar3.Text),
                Convert.ToDouble(textBoxPar4.Text),
                Convert.ToDouble(textBoxPar5.Text),
                Convert.ToDouble(textBoxPar6.Text)
                );

            polygon.Points = new PointCollection()
            {
                new Point(triangle.XStart, triangle.YStart),
                new Point(triangle.X2, triangle.Y2),
                new Point(triangle.X3, triangle.Y3)
            };

            polygon.Stroke = Brushes.Black;
            polygon.Fill = Brushes.Gray;
            polygon.Stretch = Stretch.Fill;
            polygon.StrokeThickness = 2;

            Figure.Children.Add(polygon);
        }
    }
}
