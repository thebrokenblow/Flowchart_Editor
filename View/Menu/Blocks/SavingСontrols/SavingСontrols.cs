using Flowchart_Editor.Models;
using System.Windows.Shapes;

namespace Flowchart_Editor
{
    public class SavingСontrols
    {
        //private const int oneEntryIntoBlock = 1;
        //private const int twoEntryIntoBlock = 2;
        //private const int threeEntryIntoBlock = 3;
        //private const int fourEntryIntoBlock = 4;

        //public static void Save(Block actionBlockFromWhichLineOriginates, Block actionBlockFromWhichLineEnters, Line[] lineConnection)
        //{
        //    Block? mainBlockOriginates = actionBlockFromWhichLineOriginates.GetMainBlock();
        //    int numberOfOccurrencesInBlockEnters = actionBlockFromWhichLineEnters.NumberOfOccurrencesInBlock;
        //    switch (numberOfOccurrencesInBlockEnters)
        //    {
        //        case oneEntryIntoBlock:
        //            SetValuesForBlockWithSingleLineOccurrence(actionBlockFromWhichLineOriginates, actionBlockFromWhichLineEnters, lineConnection);
        //            actionBlockFromWhichLineEnters.SetFirstBlock(mainBlockOriginates);
        //            break;

        //        case twoEntryIntoBlock:
        //            SetValuesForBlockWithTwoLineOccurrence(actionBlockFromWhichLineOriginates, actionBlockFromWhichLineEnters, lineConnection);
        //            actionBlockFromWhichLineEnters.SetSecondBlock(mainBlockOriginates);
        //            break;

        //        case threeEntryIntoBlock:
        //            SetValuesForBlockWithThreeLineOccurrence(actionBlockFromWhichLineOriginates, actionBlockFromWhichLineEnters, lineConnection);
        //            actionBlockFromWhichLineEnters.SetThirdBlock(mainBlockOriginates);
        //            break;

        //        case fourEntryIntoBlock:
        //            SetValuesForBlockWithFourLineOccurrence(actionBlockFromWhichLineOriginates, actionBlockFromWhichLineEnters, lineConnection);
        //            actionBlockFromWhichLineEnters.SetFourthBlock(mainBlockOriginates);
        //            break;
        //    }
        //}

        //private static void SetValuesForBlockWithSingleLineOccurrence(Block blockFromWhichLineOriginates, Block blockFromWhichLineEnters, Line[] lineConnection)
        //{
        //    Block mainBlockEnters = blockFromWhichLineEnters.GetMainBlock();
        //    object firstSenderMainBlockEnters = blockFromWhichLineEnters.FirstSenderMainBlock;
        //    int numberOfOccurrencesInBlockOriginates = blockFromWhichLineOriginates.NumberOfOccurrencesInBlock;
        //    switch (numberOfOccurrencesInBlockOriginates)
        //    {
        //        case oneEntryIntoBlock:
        //            object firstSenderMainBlockOriginates = blockFromWhichLineOriginates.FirstSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithSingleLineOccurrence(mainBlockEnters, firstSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfFirstBlock(firstSenderMainBlockOriginates);
        //            break;
        //        case twoEntryIntoBlock:
        //            object secondSenderMainBlockOriginates = blockFromWhichLineOriginates.SecondSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithTwoLineOccurrence(mainBlockEnters, firstSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfFirstBlock(secondSenderMainBlockOriginates);
        //            break;
        //        case threeEntryIntoBlock:
        //            object thirdSenderMainBlockOriginates = blockFromWhichLineOriginates.ThirdSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithThreeLineOccurrence(mainBlockEnters, firstSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfFirstBlock(thirdSenderMainBlockOriginates);
        //            break;
        //        case fourEntryIntoBlock:
        //            object fourthSenderMainBlockOriginates = blockFromWhichLineOriginates.FourthSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithFourLineOccurrence(mainBlockEnters, firstSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfFirstBlock(fourthSenderMainBlockOriginates);
        //            break;
        //    }
        //}

        //private static void SetValuesForBlockWithTwoLineOccurrence(Block blockFromWhichLineOriginates, Block blockFromWhichLineEnters, Line[] lineConnection)
        //{
        //    Block mainBlockEnters = blockFromWhichLineEnters.GetMainBlock();
        //    object secondSenderMainBlockEnters = blockFromWhichLineEnters.SecondSenderMainBlock;
        //    int numberOfOccurrencesInBlockOriginates = blockFromWhichLineOriginates.NumberOfOccurrencesInBlock;
        //    switch (numberOfOccurrencesInBlockOriginates)
        //    {
        //        case oneEntryIntoBlock:
        //            object firstSenderMainBlockOriginates = blockFromWhichLineOriginates.FirstSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithSingleLineOccurrence(mainBlockEnters, secondSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfSecondBlock(firstSenderMainBlockOriginates);
        //            break;
        //        case twoEntryIntoBlock:
        //            object secondSenderMainBlockOriginates = blockFromWhichLineOriginates.SecondSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithTwoLineOccurrence(mainBlockEnters, secondSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfSecondBlock(secondSenderMainBlockOriginates);
        //            break;
        //        case threeEntryIntoBlock:
        //            object thirdSenderMainBlockOriginates = blockFromWhichLineOriginates.ThirdSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithThreeLineOccurrence(mainBlockEnters, secondSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfSecondBlock(thirdSenderMainBlockOriginates);
        //            break;
        //        case fourEntryIntoBlock:
        //            object fourthSenderMainBlockOriginates = blockFromWhichLineOriginates.FourthSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithFourLineOccurrence(mainBlockEnters, secondSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfSecondBlock(fourthSenderMainBlockOriginates);
        //            break;
        //    }
        //}

        //private static void SetValuesForBlockWithThreeLineOccurrence(Block blockFromWhichLineOriginates, Block blockFromWhichLineEnters, Line[] lineConnection)
        //{
        //    Block mainBlockEnters = blockFromWhichLineEnters.GetMainBlock();
        //    object thirdSenderMainBlockEnters = blockFromWhichLineEnters.ThirdSenderMainBlock;
        //    int numberOfOccurrencesInBlockOriginates = blockFromWhichLineOriginates.NumberOfOccurrencesInBlock;
        //    switch (numberOfOccurrencesInBlockOriginates)
        //    {
        //        case oneEntryIntoBlock:
        //            object firstSenderMainBlockOriginates = blockFromWhichLineOriginates.FirstSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithSingleLineOccurrence(mainBlockEnters, thirdSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfThirdBlock(firstSenderMainBlockOriginates);
        //            break;
        //        case twoEntryIntoBlock:
        //            object secondSenderMainBlockOriginates = blockFromWhichLineOriginates.SecondSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithTwoLineOccurrence(mainBlockEnters, thirdSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfThirdBlock(secondSenderMainBlockOriginates);
        //            break;
        //        case threeEntryIntoBlock:
        //            object thirdSenderMainBlockOriginates = blockFromWhichLineOriginates.ThirdSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithThreeLineOccurrence(mainBlockEnters, thirdSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfThirdBlock(thirdSenderMainBlockOriginates);
        //            break;
        //        case fourEntryIntoBlock:
        //            object fourthSenderMainBlockOriginates = blockFromWhichLineOriginates.FourthSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithFourLineOccurrence(mainBlockEnters, thirdSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfThirdBlock(fourthSenderMainBlockOriginates);
        //            break;
        //    }
        //}

        //private static void SetValuesForBlockWithFourLineOccurrence(Block blockFromWhichLineOriginates, Block blockFromWhichLineEnters, Line[] lineConnection)
        //{
        //    Block mainBlockEnters = blockFromWhichLineEnters.GetMainBlock();
        //    object fourthSenderMainBlockEnters = blockFromWhichLineEnters.FourthSenderMainBlock;
        //    int numberOfOccurrencesInBlockOriginates = blockFromWhichLineOriginates.NumberOfOccurrencesInBlock;
        //    switch (numberOfOccurrencesInBlockOriginates)
        //    {
        //        case oneEntryIntoBlock:
        //            object firstSenderMainBlockOriginates = blockFromWhichLineOriginates.FirstSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithSingleLineOccurrence(mainBlockEnters, fourthSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfFourthBlock(firstSenderMainBlockOriginates);
        //            break;
        //        case twoEntryIntoBlock:
        //            object secondSenderMainBlockOriginates = blockFromWhichLineOriginates.SecondSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithTwoLineOccurrence(mainBlockEnters, fourthSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfFourthBlock(secondSenderMainBlockOriginates);
        //            break;
        //        case threeEntryIntoBlock:
        //            object thirdSenderMainBlockOriginates = blockFromWhichLineOriginates.ThirdSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithThreeLineOccurrence(mainBlockEnters, fourthSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfFourthBlock(thirdSenderMainBlockOriginates);
        //            break;
        //        case fourEntryIntoBlock:
        //            object fourthSenderMainBlockOriginates = blockFromWhichLineOriginates.FourthSenderMainBlock;
        //            blockFromWhichLineOriginates.SetValueSenderOfBlockWithFourLineOccurrence(mainBlockEnters, fourthSenderMainBlockEnters, lineConnection);
        //            blockFromWhichLineEnters.SetValueSenderOfFourthBlock(fourthSenderMainBlockOriginates);
        //            break;
        //    }
        //}
    }
}