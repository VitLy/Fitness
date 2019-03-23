using System;
using System.Collections;

namespace PresentationLayer
{
    public interface ITrainigProgram : IView
    {
        event EventHandler TrainigProgramIsActivated;
        event EventHandler MouseDgvHeadClick;
        event EventHandler AddTrainigProgram;
        event EventHandler ModifyTrainigProgram;
        event EventHandler DeleteTrainigProgram;

        object GetCurrentRow();
        void FillTrainingProgramHeadGrid(IEnumerable trainingProgramHead);
        void FillTrainingProgramSpecGrid(IEnumerable trainingProgramSpec);

        void Show(IView view);

    }
}
