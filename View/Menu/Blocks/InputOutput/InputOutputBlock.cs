using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;

namespace Flowchart_Editor.Models
{
    [BlockName("InputOutputBlock")]
    public class InputOutputBlock : Block
    {
        private Polygon? polygon;
        private readonly int defaultWidth = DefaultPropertyForBlock.width;
        private readonly int defaulHeight = DefaultPropertyForBlock.height;
        private const int sideProjection = 20;
        private const int startingPointOfCoordinates = 0;

        public InputOutputBlock(Canvas destination)
        {
            EditField = destination;
            blockWidthCoefficient = 1;
            blockHeightCoefficient = 1;
            initialText = "Ввод/Вывод";
        }

        override public UIElement GetUIElement()
        {
            if (FrameBlock == null)
            {
                FrameBlock = new Canvas();
                polygon = new Polygon();
                TextBoxOfBlock = new TextBox();
                TextBlockOfBlock = new TextBlock();
                

                FrameBlock.Height = defaulHeight;
                FrameBlock.Width = defaultWidth;

                BrushConverter brushConverter = new();
                Brush backgroundColor = (Brush)brushConverter.ConvertFrom("#FF008080");

                polygon.Fill = backgroundColor;
                Point Point1 = new(sideProjection, startingPointOfCoordinates);
                Point Point2 = new(startingPointOfCoordinates, defaulHeight);
                Point Point3 = new(defaultWidth - sideProjection, defaulHeight);
                Point Point4 = new(defaultWidth, startingPointOfCoordinates);

                PointCollection myPointCollection = new();
                myPointCollection.Add(Point1);
                myPointCollection.Add(Point2);
                myPointCollection.Add(Point3);
                myPointCollection.Add(Point4);

                polygon.Points = myPointCollection;

                //SetPropertyForTextBox(defaultWidth - sideProjection * 3, defaulHeight - 5, initialText, sideProjection * 1.5, 5);

                //SetPropertyForTextBlock(defaultWidth - sideProjection * 3, defaulHeight - 5, sideProjection * 1.5, 5);

                //SetPropertyPointConnect(firstPointToConnect, defaultWidth / 2, -2);
                //firstPointToConnect.MouseDown += ClickOnFirstConnectionPoint;

                //SetPropertyPointConnect(secondPointToConnect, 8, defaulHeight / 2 - 5);
                //secondPointToConnect.MouseDown += ClickOnSecondConnectionPoint;

                //SetPropertyPointConnect(thirdPointToConnect, defaultWidth / 2, defaulHeight - 3);
                //thirdPointToConnect.MouseDown += ClickOnThirdConnectionPoint;

                //SetPropertyPointConnect(fourthPointToConnect, defaultWidth - 13, defaulHeight / 2 - 5);
                //fourthPointToConnect.MouseDown += ClickOnFourthConnectionPoint;

                FrameBlock.Children.Add(polygon);
                FrameBlock.Children.Add(TextBoxOfBlock);
                //FrameBlock.Children.Add(firstPointConnect);
                //FrameBlock.Children.Add(secondPointConnect);
                //FrameBlock.Children.Add(thirdPointConnect);
                //FrameBlock.Children.Add(fourthPointConnect);
                FrameBlock.MouseMove += MouseMoveBlockForMovements;
            }
            return FrameBlock;
        }

        protected override void SetСoordinatesComment(UIElement comment)
        {
            Canvas.SetTop(comment, DefaultPropertyForBlock.height / 2 - 2);
            Canvas.SetLeft(comment, DefaultPropertyForBlock.width - 8);
        }

        public override void SetWidth(int valueBlockWidth)
        {
            if (FrameBlock != null && polygon != null)
            {
                Point Point1 = new(20, 0);
                Point Point2 = new(0, DefaultPropertyForBlock.height);
                Point Point3 = new(valueBlockWidth - 20, DefaultPropertyForBlock.height);
                Point Point4 = new(valueBlockWidth, 0);

                PointCollection myPointCollection = new();
                myPointCollection.Add(Point1);
                myPointCollection.Add(Point2);
                myPointCollection.Add(Point3);
                myPointCollection.Add(Point4);

                polygon.Points = myPointCollection;
                FrameBlock.Width = valueBlockWidth;

                SetPropertyForTextBox(valueBlockWidth - sideProjection * 3, DefaultPropertyForBlock.height - 5, valueSetLeft: sideProjection * 1.5, valueSetTop: 5);
                
                SetPropertyForTextBlock(valueBlockWidth - sideProjection * 3, DefaultPropertyForBlock.height - 5, valueSetLeft: sideProjection * 1.5, valueSetTop: 5);

                //Canvas.SetLeft(firstPointConnect, valueBlockWidth / 2);
                //Canvas.SetLeft(thirdPointConnect, valueBlockWidth / 2);
                //Canvas.SetLeft(fourthPointConnect, valueBlockWidth - 13);
            }
        }

        public override void SetHeight(int valueBlockHeight)
        {
            if (FrameBlock != null && polygon != null)
            {
                Point Point1 = new(20, 0);
                Point Point2 = new(0, valueBlockHeight);
                Point Point3 = new(DefaultPropertyForBlock.width - 20, valueBlockHeight);
                Point Point4 = new(DefaultPropertyForBlock.width, 0);

                PointCollection myPointCollection = new();
                myPointCollection.Add(Point1);
                myPointCollection.Add(Point2);
                myPointCollection.Add(Point3);
                myPointCollection.Add(Point4);

                polygon.Points = myPointCollection;
                FrameBlock.Width = DefaultPropertyForBlock.width;

                SetPropertyForTextBox(DefaultPropertyForBlock.width - sideProjection * 3, valueBlockHeight - 5, valueSetLeft: sideProjection * 1.5, valueSetTop: 5);
                SetPropertyForTextBlock(DefaultPropertyForBlock.width - sideProjection * 3, valueBlockHeight - 5, valueSetLeft: sideProjection * 1.5, valueSetTop: 5);

                //Canvas.SetTop(secondPointConnect, valueBlockHeight / 2 - 5);
                //Canvas.SetTop(thirdPointConnect, valueBlockHeight - 3);
                //Canvas.SetTop(fourthPointConnect, valueBlockHeight / 2 - 5);
            }
        }
        public override double GetWidthCoefficient() => blockWidthCoefficient;

        public override double GetHeightCoefficient() => blockHeightCoefficient;

        public override void SetLeftBlockForConditionCaseSecondOption(UIElement uIElementBlock, double coordinateLeft) =>
            Canvas.SetLeft(uIElementBlock, coordinateLeft - 3);

        public override void SetTopBlockForConditionCaseSecondOption(UIElement uIElementBlock, double coordinateTop) =>
            Canvas.SetTop(uIElementBlock, coordinateTop);

        public override void SetLeftBlockForConditionCaseFirstOption(UIElement uIElementBlock, double coordinateLeft) =>
             Canvas.SetLeft(uIElementBlock, coordinateLeft - 10);

        public override void SetTopBlockForConditionCaseFirstOption(UIElement uIElementBlock, double coordinateTop) =>
            Canvas.SetTop(uIElementBlock, coordinateTop - DefaultPropertyForBlock.height / 2 + 1);
    }
}