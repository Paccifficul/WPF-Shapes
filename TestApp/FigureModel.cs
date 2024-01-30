using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class FigureModel
    {
        protected FigureType figureType;
        protected double xStart;
        protected double yStart;

        //public delegate void FigureTypeChangedEventHandler(object sender, EventArgs args);
        //public event FigureTypeChangedEventHandler FigureTypeChanged;

        public double XStart
        {
            get => xStart;
            set => xStart = value;
        }

        public double YStart
        {
            get => yStart;
            set => yStart = value;
        }

        public FigureType FigureType
        {
            get => figureType;
            set => figureType = value;
        }

        public FigureModel(double xStart = 0, double yStart = 0)
        {
            this.xStart = xStart;
            this.yStart = yStart;
        }

        public void ChangeFigureType(FigureType figureType)
        {
            this.figureType = figureType;

            //OnFigureTypeChanged();
        }

       /* protected virtual void OnFigureTypeChanged()
        {
            FigureTypeChanged?.Invoke(this, EventArgs.Empty);
        }*/
    }
}
