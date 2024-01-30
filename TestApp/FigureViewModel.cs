using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class FigureViewModel
    {
        private FigureModel currentFigureModel;

        public FigureModel Figure
        {
            get => currentFigureModel;
        }

        public FigureViewModel()
        {
            currentFigureModel = new FigureModel();
        }

        public void ChangeFigureModel(string newFigureName)
        {
            switch (newFigureName)
            {
                case "Triangle":
                    currentFigureModel.FigureType = FigureType.Triangle;
                    break;
                case "Rectangle":
                    currentFigureModel.FigureType = FigureType.Rectangle;
                    break;
                case "Circle":
                    currentFigureModel.FigureType = FigureType.Ellipse;
                    break;
                default:
                    break;
            }

            currentFigureModel.ChangeFigureType(currentFigureModel.FigureType);
        }
    }
}
