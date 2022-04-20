﻿using System.Windows.Shapes;
using Flowchart_Editor.Models;

namespace Flowchart_Editor
{
    public class SavingСontrols
    {
        private const int oneEntryIntoBlock = 1;
        private const int twoEntryIntoBlock = 2;
        private const int threeEntryIntoBlock = 3;
        private const int fourEntryIntoBlock = 4;

        public int GetNumberOneEntryIntoBlock() => oneEntryIntoBlock;
        public int GetNumberTwoEntryIntoBlock() => twoEntryIntoBlock;
        public int GetNumberThreeEntryIntoBlock() => threeEntryIntoBlock;
        public int GetNumberFourEntryIntoBlock() => fourEntryIntoBlock;
        public void Save(ActionBlock actionBlockFromWhichLineOriginates, ActionBlock actionBlockFromWhichLineEnters, Line lineConnection)
        {
            ActionBlock mainBlockOriginates = actionBlockFromWhichLineOriginates.GetMainBlock();
            int numberOfOccurrencesInBlockEnters = actionBlockFromWhichLineEnters.GetNumberOfOccurrencesInBlock();
            switch (numberOfOccurrencesInBlockEnters)
            {
                case oneEntryIntoBlock:
                    SetValuesForBlockWithSingleLineOccurrence(actionBlockFromWhichLineOriginates, actionBlockFromWhichLineEnters, lineConnection);
                    actionBlockFromWhichLineEnters.SetFirstBlock(mainBlockOriginates);
                    break;

                case twoEntryIntoBlock:
                    SetValuesForBlockWithTwoLineOccurrence(actionBlockFromWhichLineOriginates, actionBlockFromWhichLineEnters, lineConnection);
                    actionBlockFromWhichLineEnters.SetSecondBlock(mainBlockOriginates);
                    break;

                case threeEntryIntoBlock:
                    SetValuesForBlockWithThreeLineOccurrence(actionBlockFromWhichLineOriginates, actionBlockFromWhichLineEnters, lineConnection);
                    actionBlockFromWhichLineEnters.SetThirdBlock(mainBlockOriginates);
                    break;

                case fourEntryIntoBlock:
                    SetValuesForBlockWithFourLineOccurrence(actionBlockFromWhichLineOriginates, actionBlockFromWhichLineEnters, lineConnection);
                    actionBlockFromWhichLineEnters.SetFourthBlock(mainBlockOriginates);
                    break;
            }
        }

        private void SetValuesForBlockWithSingleLineOccurrence(ActionBlock blockFromWhichLineOriginates, ActionBlock blockFromWhichLineEnters, Line lineConnection)
        {
            ActionBlock mainBlockEnters = blockFromWhichLineEnters.GetMainBlock();
            object firstSenderMainBlockEnters = blockFromWhichLineEnters.GetFirstSenderMainBlock();
            int numberOfOccurrencesInBlockOriginates = blockFromWhichLineOriginates.GetNumberOfOccurrencesInBlock();
            switch (numberOfOccurrencesInBlockOriginates)
            {
                case oneEntryIntoBlock:
                    object firstSenderMainBlockOriginates = blockFromWhichLineOriginates.GetFirstSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithSingleLineOccurrence(mainBlockEnters, firstSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfFirstBlock(firstSenderMainBlockOriginates);
                    break;
                case twoEntryIntoBlock:
                    object secondSenderMainBlockOriginates = blockFromWhichLineOriginates.GetSecondSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithTwoLineOccurrence(mainBlockEnters, firstSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfFirstBlock(secondSenderMainBlockOriginates);
                    break;
                case threeEntryIntoBlock:
                    object thirdSenderMainBlockOriginates = blockFromWhichLineOriginates.GetThirdSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithThreeLineOccurrence(mainBlockEnters, firstSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfFirstBlock(thirdSenderMainBlockOriginates);
                    break;
                case fourEntryIntoBlock:
                    object fourthSenderMainBlockOriginates = blockFromWhichLineOriginates.GetFourthSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithFourLineOccurrence(mainBlockEnters, firstSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfFirstBlock(fourthSenderMainBlockOriginates);
                    break;
            }
        }

        private void SetValuesForBlockWithTwoLineOccurrence(ActionBlock blockFromWhichLineOriginates, ActionBlock blockFromWhichLineEnters, Line lineConnection)
        {
            ActionBlock mainBlockEnters = blockFromWhichLineEnters.GetMainBlock();
            object secondSenderMainBlockEnters = blockFromWhichLineEnters.GetSecondSenderMainBlock();
            int numberOfOccurrencesInBlockOriginates = blockFromWhichLineOriginates.GetNumberOfOccurrencesInBlock();
            switch (numberOfOccurrencesInBlockOriginates)
            {
                case oneEntryIntoBlock:
                    object firstSenderMainBlockOriginates = blockFromWhichLineOriginates.GetFirstSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithSingleLineOccurrence(mainBlockEnters, secondSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfSecondBlock(firstSenderMainBlockOriginates);
                    break;
                case twoEntryIntoBlock:
                    object secondSenderMainBlockOriginates = blockFromWhichLineOriginates.GetSecondSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithTwoLineOccurrence(mainBlockEnters, secondSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfSecondBlock(secondSenderMainBlockOriginates);
                    break;
                case threeEntryIntoBlock:
                    object thirdSenderMainBlockOriginates = blockFromWhichLineOriginates.GetThirdSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithThreeLineOccurrence(mainBlockEnters, secondSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfSecondBlock(thirdSenderMainBlockOriginates);
                    break;
                case fourEntryIntoBlock:
                    object fourthSenderMainBlockOriginates = blockFromWhichLineOriginates.GetFourthSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithFourLineOccurrence(mainBlockEnters, secondSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfSecondBlock(fourthSenderMainBlockOriginates);
                    break;
            }
        }

        private void SetValuesForBlockWithThreeLineOccurrence(ActionBlock blockFromWhichLineOriginates, ActionBlock blockFromWhichLineEnters, Line lineConnection)
        {
            ActionBlock mainBlockEnters = blockFromWhichLineEnters.GetMainBlock();
            object thirdSenderMainBlockEnters = blockFromWhichLineEnters.GetThirdSenderMainBlock();
            int numberOfOccurrencesInBlockOriginates = blockFromWhichLineOriginates.GetNumberOfOccurrencesInBlock();
            switch (numberOfOccurrencesInBlockOriginates)
            {
                case oneEntryIntoBlock:
                    object firstSenderMainBlockOriginates = blockFromWhichLineOriginates.GetFirstSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithSingleLineOccurrence(mainBlockEnters, thirdSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfThirdBlock(firstSenderMainBlockOriginates);
                    break;
                case twoEntryIntoBlock:
                    object secondSenderMainBlockOriginates = blockFromWhichLineOriginates.GetSecondSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithTwoLineOccurrence(mainBlockEnters, thirdSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfThirdBlock(secondSenderMainBlockOriginates);
                    break;
                case threeEntryIntoBlock:
                    object thirdSenderMainBlockOriginates = blockFromWhichLineOriginates.GetThirdSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithThreeLineOccurrence(mainBlockEnters, thirdSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfThirdBlock(thirdSenderMainBlockOriginates);
                    break;
                case fourEntryIntoBlock:
                    object fourthSenderMainBlockOriginates = blockFromWhichLineOriginates.GetFourthSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithFourLineOccurrence(mainBlockEnters, thirdSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfThirdBlock(fourthSenderMainBlockOriginates);
                    break;
            }
        }

        private void SetValuesForBlockWithFourLineOccurrence(ActionBlock blockFromWhichLineOriginates, ActionBlock blockFromWhichLineEnters, Line lineConnection)
        {
            ActionBlock mainBlockEnters = blockFromWhichLineEnters.GetMainBlock();
            object fourthSenderMainBlockEnters = blockFromWhichLineEnters.GetFourthSenderMainBlock();
            int numberOfOccurrencesInBlockOriginates = blockFromWhichLineOriginates.GetNumberOfOccurrencesInBlock();
            switch (numberOfOccurrencesInBlockOriginates)
            {
                case oneEntryIntoBlock:
                    object firstSenderMainBlockOriginates = blockFromWhichLineOriginates.GetFirstSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithSingleLineOccurrence(mainBlockEnters, fourthSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfFourthBlock(firstSenderMainBlockOriginates);
                    break;
                case twoEntryIntoBlock:
                    object secondSenderMainBlockOriginates = blockFromWhichLineOriginates.GetSecondSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithTwoLineOccurrence(mainBlockEnters, fourthSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfFourthBlock(secondSenderMainBlockOriginates);
                    break;
                case threeEntryIntoBlock:
                    object thirdSenderMainBlockOriginates = blockFromWhichLineOriginates.GetThirdSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithThreeLineOccurrence(mainBlockEnters, fourthSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfFourthBlock(thirdSenderMainBlockOriginates);
                    break;
                case fourEntryIntoBlock:
                    object fourthSenderMainBlockOriginates = blockFromWhichLineOriginates.GetFourthSenderMainBlock();
                    blockFromWhichLineOriginates.SetValueSenderOfBlockWithFourLineOccurrence(mainBlockEnters, fourthSenderMainBlockEnters, lineConnection);
                    blockFromWhichLineEnters.SetValueSenderOfFourthBlock(fourthSenderMainBlockOriginates);
                    break;
            }
        }
    }
}