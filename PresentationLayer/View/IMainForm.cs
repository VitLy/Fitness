using System;

namespace PresentationLayer
{
    public interface IMainForm:IView
    {
        event EventHandler FetchDayTrainigWindow;

        event EventHandler FetchExerciseWindow;

        event EventHandler FetchMainParamWindow;

        event EventHandler FetchBodyParamWindow;

        event EventHandler FetchSchedulerWindow;

        event EventHandler FetchCategoryWindow;

        event EventHandler FetchTrainingProgramWindow;

        void Show();
    }
}
