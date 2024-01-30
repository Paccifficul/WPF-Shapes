using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class TriangleModel : FigureModel
    {
        private double x2;
        private double y2;
        private double x3;
        private double y3;

        public double X2
        {
            get => x2;
            set => x2 = value;
        }

        public double Y2
        {
            get => y2;
            set => y2 = value;
        }

        public double X3
        {
            get => x3;
            set => x3 = value;
        }

        public double Y3
        {
            get => y3;
            set => y3 = value;
        }

        public TriangleModel(FigureType figureType, double x1, double y1, double x2, double y2, double x3, double y3) : base(x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            base.figureType = figureType;
        }
    }
}
