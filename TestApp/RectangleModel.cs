using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class RectangleModel : FigureModel
    {
        private double width;
        private double height;
        private double xRadius;
        private double yRadius;

        public double Width
        {
            get => width;
            set => width = value;
        }

        public double Height
        {
            get => height;
            set => height = value;
        }

        public double XRadius
        {
            get => xRadius;
            set => xRadius = value;
        }

        public double YRadius
        {
            get => yRadius;
            set => yRadius = value;
        }

        public RectangleModel(FigureType figureType, double xStart, double yStart, double width, double height, double xRadius = 0, double yRadius = 0)
            : base(xStart, yStart)
        {
            this.width = width;
            this.height = height;
            this.xRadius = xRadius;
            this.yRadius = yRadius;
            base.figureType = figureType;
        }


    }
}
