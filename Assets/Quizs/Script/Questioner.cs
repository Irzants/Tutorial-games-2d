using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz question", fileName = "New Question")]
public class Questioner : ScriptableObject
{
    
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question here";

    [TextArea(2, 4)]
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswersIndex;

    public string GetQuestion()
    {
        return question;
    }


    public string GetAnswer(int index)
    {
        return answers[index];
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswersIndex;
    }

}
