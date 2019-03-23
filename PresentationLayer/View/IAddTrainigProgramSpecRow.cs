using DomainLayer.Model;
using System;
using System.Collections.Generic;

namespace PresentationLayer
{
    public interface IAddTrainigProgramSpecRow : IView
    {
        event EventHandler Ok;
        event EventHandler Cancel;
        event EventHandler Load;

        void ClearFields();
        string GetFormText();

        void SetExercise(List<Exercise> exercises);
        void SetDefaultExercise(string exercises);
        void SetSetNum(string set);
        void SetWeight(string weight);
        void SetAmount(string amount);

        int GetSetNum();
        float GetWeight();
        byte GetAmount();
        int GetExerciseId();
        string GetExercise();

        void ShowDialog();
        void SetFormText(string formName);
        void SetDataGrDisplayMember(string parametr);
        void SetDataGrValueMember(string parametr);
    }
}
