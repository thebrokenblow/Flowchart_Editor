using System.Windows.Shapes;
using System.Windows.Controls;
using Flowchart_Editor.Models.Interface;
using System.Windows.Media;

namespace Flowchart_Editor.Models
{
    public class BlockForMovements : IBlockForMovements
    {
        public Block? mainBlock { get; private set; }
        public Block? firstBlock { get; private set; }
        public Block? secondBlock { get; private set; }
        public Block? thirdBlock { get; private set; }
        public Block? fourthBlock { get; private set; }

        public Line[]? firstLineConnectionBlock { get; private set; }
        public Line[]? secondLineConnectionBlock { get; private set; }
        public Line[]? thirdLineConnectionBlock { get; private set; }
        public Line[]? fourthLineConnectionBlock { get; private set; }

        private readonly object? firstSenderMainBlock;
        private readonly object? secondSenderMainBlock;
        private readonly object? thirdSenderMainBlock;
        private readonly object? fourthSenderMainBlock;

        private readonly object? firstSenderBlock;
        private readonly object? secondSenderBlock;
        private readonly object? thirdSenderBlock;
        private readonly object? fourthSenderBlock;

        private readonly object transferInformationActionBlock;

        private readonly int numberOfOccurrencesInBlock;
        const int valueOffsetOfLineFromTheBlockToSides = 20;

        public BlockForMovements(object sender, Block mainActionBlock, Block firstActionBlock, Block secondActionBlock,
            Block thirdActionBlock, Block fourthActionBlock, object firstSenderMainActionBlock, object secondSenderMainActionBlock,
            object thirdSenderMainActionBlock, object fourthSenderMainActionBlock, object senderFirstActionBlock, object senderSecondActionBlock,
            object senderThirdActionBlock, object senderFourthActionBlock, Line[] firstLineConnectionBlock, Line[] secondLineConnectionBlock,
            Line[] thirdLineConnectionBlock, Line[] fourthLineConnectionBlock, int numberOfOccurrencesInBlock)
        {
            transferInformationActionBlock = sender;
            this.mainBlock = mainActionBlock;

            this.firstBlock = firstActionBlock;
            this.secondBlock = secondActionBlock;
            this.thirdBlock = thirdActionBlock;
            this.fourthBlock = fourthActionBlock;

            this.firstSenderMainBlock = firstSenderMainActionBlock;
            this.secondSenderMainBlock = secondSenderMainActionBlock;
            this.thirdSenderMainBlock = thirdSenderMainActionBlock;
            this.fourthSenderMainBlock = fourthSenderMainActionBlock;

            this.firstSenderBlock = senderFirstActionBlock;
            this.secondSenderBlock = senderSecondActionBlock;
            this.thirdSenderBlock = senderThirdActionBlock;
            this.fourthSenderBlock = senderFourthActionBlock;

            this.firstLineConnectionBlock = firstLineConnectionBlock;
            this.secondLineConnectionBlock = secondLineConnectionBlock;
            this.thirdLineConnectionBlock = thirdLineConnectionBlock;
            this.fourthLineConnectionBlock = fourthLineConnectionBlock;

            this.numberOfOccurrencesInBlock = numberOfOccurrencesInBlock;
        }
        public object GetTransferInformationActionBlock() => transferInformationActionBlock;
        public int GetNumberOfOccurrencesInBlock() => numberOfOccurrencesInBlock;
        public double GetСoordinatesMainBlockAndFirstSenderMainBlockX() => mainBlock != null && firstSenderMainBlock != null ? Canvas.GetLeft((Ellipse)firstSenderMainBlock) + Canvas.GetLeft(mainBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesMainBlockAndFirstSenderMainBlockY() => mainBlock != null && firstSenderMainBlock != null ? Canvas.GetTop((Ellipse)firstSenderMainBlock) + Canvas.GetTop(mainBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesFirstAtionBlockAndFirstSenderBlockX() => firstBlock != null && firstSenderBlock != null ? Canvas.GetLeft((Ellipse)firstSenderBlock) + Canvas.GetLeft(firstBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesFirstAtionBlockAndFirstSenderBlockY() => firstBlock != null && firstSenderBlock != null ? Canvas.GetTop((Ellipse)firstSenderBlock) + Canvas.GetTop(firstBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesSecondBlockAndSecondSenderBlockX() => secondBlock != null && secondSenderBlock != null ? Canvas.GetLeft((Ellipse)secondSenderBlock) + Canvas.GetLeft(secondBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesSecondBlockAndSecondSenderBlockY() => secondBlock != null && secondSenderBlock != null ? Canvas.GetTop((Ellipse)secondSenderBlock) + Canvas.GetTop(secondBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesMainBlockAndSecondSenderMainBlockX() => mainBlock != null && secondSenderMainBlock != null ? Canvas.GetLeft((Ellipse)secondSenderMainBlock) + Canvas.GetLeft(mainBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesMainBlockAndSecondSenderMainBlockY() => mainBlock != null && secondSenderMainBlock != null ? Canvas.GetTop((Ellipse)secondSenderMainBlock) + Canvas.GetTop(mainBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesMainBlockAndThirdSenderMainBlockX() => mainBlock != null && thirdSenderMainBlock != null ? Canvas.GetLeft((Ellipse)thirdSenderMainBlock) + Canvas.GetLeft(mainBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesMainBlockAndThirdSenderMainBlockY() => mainBlock != null && thirdSenderMainBlock != null ? Canvas.GetTop((Ellipse)thirdSenderMainBlock) + Canvas.GetTop(mainBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesThirdBlockAndThirdSenderBlockX() => thirdBlock != null && thirdSenderBlock != null ? Canvas.GetLeft((Ellipse)thirdSenderBlock) + Canvas.GetLeft(thirdBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesThirdBlockAndThirdSenderBlockY() => thirdBlock != null && thirdSenderBlock  != null ? Canvas.GetTop((Ellipse)thirdSenderBlock) + Canvas.GetTop(thirdBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesMainBlockAndFourthSenderMainBlockX() => mainBlock != null && fourthSenderMainBlock != null ? Canvas.GetLeft((Ellipse)fourthSenderMainBlock) + Canvas.GetLeft(mainBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesMainBlockAndFourthSenderMainBlockY() => mainBlock != null && fourthSenderMainBlock != null ? Canvas.GetTop((Ellipse)fourthSenderMainBlock) + Canvas.GetTop(mainBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesFourthBlockAndFourthSenderBlockX() => fourthBlock != null && fourthSenderBlock != null ? Canvas.GetLeft((Ellipse)fourthSenderBlock) + Canvas.GetLeft(fourthBlock.FrameBlock) + 3 : 0;
        public double GetСoordinatesFourthBlockAndFourthSenderBlockY() => fourthBlock != null && fourthSenderBlock != null ? Canvas.GetTop((Ellipse)fourthSenderBlock) + Canvas.GetTop(fourthBlock.FrameBlock) + 3 : 0;

        public void ChangeLines(double x1, double y1, double x2, double y2, Line[] lines, Block firstBlock, Block secondBlock)
        {
            //if (firstBlock.flagForEnteringFirstConnectionPoint && secondBlock.flagForEnteringThirdConnectionPoint)
            //{
            //    if (x1 != x2 && y1 > y2)
            //        firstBlock.MainWindow.ChangeLine1(lines, x2, y2, x1, y1);
            //    else if (x1 != x2 && y1 < y2)
            //        firstBlock.MainWindow.ChangeLine2(lines, x1, y1, x2, y2);
            //}
            //if (firstBlock.flagForEnteringThirdConnectionPoint && secondBlock.flagForEnteringFirstConnectionPoint)
            //{
            //    if (x1 != x2 && y1 < y2)
            //        firstBlock.MainWindow.ChangeLine1(lines, x1, y1, x2, y2);
            //    else if (x1 != x2 && y1 > y2)
            //        firstBlock.MainWindow.ChangeLine2(lines, x2, y2, x1, y1);
            //}
            //else if (firstBlock.flagForEnteringFirstConnectionPoint && secondBlock.flagForEnteringFourthConnectionPoint)
            //{
            //    if (y2 < y1 && x1 - valueOffsetOfLineFromTheBlockToSides <= x2)
            //        firstBlock.MainWindow.ChangeLine3(lines, x1, y1, x2, y2);
            //    else if (y2 < y1 && x1 >= x2)
            //        firstBlock.MainWindow.ChangeLine4(lines, x1, y1, x2, y2);
            //    else if (y2 > y1 - valueOffsetOfLineFromTheBlockToSides)
            //        firstBlock.MainWindow.ChangeLine5(lines, x1, y1, x2, y2);
            //}
            //else if (firstBlock.flagForEnteringFourthConnectionPoint && secondBlock.flagForEnteringFirstConnectionPoint)
            //{
            //    if (y2 > y1 && x1 >= x2 - valueOffsetOfLineFromTheBlockToSides)
            //        firstBlock.MainWindow.ChangeLine3(lines, x2, y2, x1, y1);
            //    else if (y2 > y1 && x1 <= x2)
            //        firstBlock.MainWindow.ChangeLine4(lines, x2, y2, x1, y1);
            //    else if (y2 < y1 - valueOffsetOfLineFromTheBlockToSides)
            //        firstBlock.MainWindow.ChangeLine5(lines, x2, y2, x1, y1);
            //}
            //else if (firstBlock.flagForEnteringFirstConnectionPoint && secondBlock.flagForEnteringFirstConnectionPoint)
            //{
            //    if ((x2 + DefaultPropertyForBlock.width / 2 < x1) || (x1 + DefaultPropertyForBlock.width / 2 < x2))
            //    {
            //        if (y1 > y2)
            //            firstBlock.MainWindow.ChangeLine7(lines, x1, y1, x2, y2);
            //        else
            //            firstBlock.MainWindow.ChangeLine7(lines, x2, y2, x1, y1);
            //    }
            //    else firstBlock.MainWindow.ChangeLine6(lines, x1, y1, x2, y2);
            //}
            //else if (firstBlock.flagForEnteringFirstConnectionPoint && secondBlock.flagForEnteringSecondConnectionPoint)
            //{
            //    if (x1 <= x2 && y1 > y2)
            //        firstBlock.MainWindow.ChangeLine4(lines, x1, y1, x2, y2);
            //    else
            //        firstBlock.MainWindow.ChangeLine8(lines, x1, y1, x2, y2);
            //}
            //else if (firstBlock.flagForEnteringSecondConnectionPoint && secondBlock.flagForEnteringFirstConnectionPoint)
            //{
            //    if (x1 >= x2 && y1 < y2)
            //        firstBlock.MainWindow.ChangeLine4(lines, x2, y2, x1, y1);
            //    else
            //        firstBlock.MainWindow.ChangeLine8(lines, x2, y2, x1, y1);
            //}
            //else if (firstBlock.flagForEnteringSecondConnectionPoint && secondBlock.flagForEnteringSecondConnectionPoint)
            //{
            //    if ((y1 + DefaultPropertyForBlock.height / 2 <= y2 && y1 > y2) || (y1 <= y2 && y1 >= y2 - DefaultPropertyForBlock.height) || (y1 == y2))
            //        firstBlock.MainWindow.ChangeLine10(lines, x2, y2, x1, y1);
            //    else if (x2 < x1)
            //        firstBlock.MainWindow.ChangeLine9(lines, x2, y2, x1, y1);
            //    else if (x2 > x1)
            //        firstBlock.MainWindow.ChangeLine9(lines, x1, y1, x2, y2);
            //}
            //else if (firstBlock.flagForEnteringSecondConnectionPoint && secondBlock.flagForEnteringThirdConnectionPoint)
            //{
            //    if (x1 > x2 && y2 < y1)
            //        firstBlock.MainWindow.ChangeLine4(lines, x2, y2, x1, y1);
            //    else
            //        firstBlock.MainWindow.ChangeLine11(lines, x2, y2, x1, y1);
            //}
            //else if (firstBlock.flagForEnteringThirdConnectionPoint && secondBlock.flagForEnteringSecondConnectionPoint)
            //{
            //    if (x1 < x2 && y2 > y1)
            //        firstBlock.MainWindow.ChangeLine4(lines, x1, y1, x2, y2);
            //    else
            //        firstBlock.MainWindow.ChangeLine11(lines, x1, y1, x2, y2);
            //}
            //else if (firstBlock.flagForEnteringSecondConnectionPoint && secondBlock.flagForEnteringFourthConnectionPoint)
            //{
            //    if (x2 < x1)
            //        firstBlock.MainWindow.ChangeLine13(lines, x2, y2, x1, y1);
            //    else
            //        firstBlock.MainWindow.ChangeLine12(lines, x2, y2, x1, y1);
            //}
            //else if (firstBlock.flagForEnteringFourthConnectionPoint && secondBlock.flagForEnteringSecondConnectionPoint)
            //{
            //    if (x2 > x1)
            //        firstBlock.MainWindow.ChangeLine13(lines, x2, y2, x1, y1);
            //    else
            //        firstBlock.MainWindow.ChangeLine12(lines, x1, y1, x2, y2);
            //}
            //else if (firstBlock.flagForEnteringThirdConnectionPoint && secondBlock.flagForEnteringThirdConnectionPoint)
            //{
            //    if ((x2 + DefaultPropertyForBlock.width / 2 < x1) || (x1 + DefaultPropertyForBlock.width / 2 < x2))
            //    {
            //        if (y1 > y2)
            //            firstBlock.MainWindow.ChangeLine15(lines, x1, y1, x2, y2);
            //        else
            //            firstBlock.MainWindow.ChangeLine15(lines, x2, y2, x1, y1);
            //    }
            //    else firstBlock.MainWindow.ChangeLine14(lines, x1, y1, x2, y2);
            //}
            //else if (firstBlock.flagForEnteringThirdConnectionPoint && secondBlock.flagForEnteringFourthConnectionPoint)
            //{
            //    if (x1 > x2 && y2 > y1)
            //        firstBlock.MainWindow.ChangeLine4(lines, x1, y1, x2, y2);
            //    else
            //        firstBlock.MainWindow.ChangeLine16(lines, x1, y1, x2, y2);
            //}
            //else if (firstBlock.flagForEnteringFourthConnectionPoint && secondBlock.flagForEnteringThirdConnectionPoint)
            //{
            //    if (x1 < x2 && y2 < y1)
            //        firstBlock.MainWindow.ChangeLine4(lines, x2, y2, x1, y1);
            //    else
            //        firstBlock.MainWindow.ChangeLine16(lines, x2, y2, x1, y1);
            //}
            //else if (firstBlock.flagForEnteringFourthConnectionPoint && secondBlock.flagForEnteringFourthConnectionPoint)
            //{
            //    if ((y1 + DefaultPropertyForBlock.height / 2 <= y2 && y1 > y2) || (y1 <= y2 && y1 >= y2 - DefaultPropertyForBlock.height) || (y1 == y2))
            //        firstBlock.MainWindow.ChangeLine19(lines, x2, y2, x1, y1);
            //    else if (x2 > x1)
            //        firstBlock.MainWindow.ChangeLine17(lines, x2, y2, x1, y1);
            //    else if (x2 < x1)
            //        firstBlock.MainWindow.ChangeLine17(lines, x1, y1, x2, y2);
            //}
        }
        public void SetCoordinateForFirstLine(double x1, double y1, double x2, double y2, Line[] lines, Block firstBlock, Block secondBlock)
        {
            ChangeLines(x1, y1, x2, y2, lines, firstBlock, secondBlock);
        }
        public void SetCoordinateForSecondLine(double x1, double y1, double x2, double y2, Line[] lines, Block firstBlock, Block secondBlock)
        {
            ChangeLines(x1, y1, x2, y2, lines, firstBlock, secondBlock);
        }

        public void SetCoordinateForThirdLine(double x1, double y1, double x2, double y2, Line[] lines, Block firstBlock, Block secondBlock)
        {
            ChangeLines(x1, y1, x2, y2, lines, firstBlock, secondBlock);
        }

        public void SetCoordinateForFourthLine(double x1, double y1, double x2, double y2, Line[] lines, Block firstBlock, Block secondBlock)
        {
            ChangeLines(x1, y1, x2, y2, lines, firstBlock, secondBlock);
        }
    }
}