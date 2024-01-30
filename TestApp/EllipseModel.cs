using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class EllipseModel : FigureModel
    {
        private double xRadius;
        private double yRadius;

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

        public EllipseModel(FigureType figureType, double xCenter, double yCenter, double xRadius, double yRadius) : base(xCenter, yCenter)
        {
            this.xRadius = xRadius;
            this.yRadius = yRadius;
            base.figureType = figureType;
        }
    }
}
