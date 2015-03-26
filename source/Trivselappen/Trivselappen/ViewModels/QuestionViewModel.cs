using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Trivselappen.Models;

namespace Trivselappen.ViewModels
{
    public class QuestionViewModel : INotifyPropertyChanged
    {

        public QuestionViewModel()
        {
            Question q = new Question();
            q.Text = "Dagens fråga: Mår du bra?"; //ToDo: ska hämtas från backend.
            q.QuestionId = 0; //ToDo: ska sättas till id som hämtas ihop med frågan från backend.
            TodaysQuestion = q.Text;
            TodaysQuestionId = q.QuestionId;
            _answerValue = 0;

        }

        private string _question;
        public string TodaysQuestion { get{
            return _question;
        } 
            set{
                _question = value;
                RaisePropertyChanged(TodaysQuestion);
                }
        }
        private int _questionId;
        private int TodaysQuestionId { get{
            return _questionId;
        }
            set { _questionId = value; }
        }
        private decimal _answerValue;
        private decimal TodaysAnswerValue{ get{
            return _answerValue;
        }
            set { _answerValue = value; }
        }

        string _greeting;
        public string Greeting
        {
            get { return _greeting; }
            set { _greeting = value; RaisePropertyChanged("Greeting"); }
        }

        //Kommentar till nedan ICommands: Borde man inte kunna lösa detta med switch istället? All kod är ju lika utom answer.Value..
        
        //

        public ICommand Register
        {
            get
            {
                Action<string> action = (string parameter) =>
                {
                    if (parameter == "button1")
                    {
                        _answerValue = 1;
                    }
                    else if (parameter == "button2")
                    {
                        _answerValue = 2;
                    }
                    else if (parameter == "button3")
                    {
                        _answerValue = 3;
                    }
                    else if (parameter == "button4")
                    {
                        _answerValue = 4;
                    }

                    Answer answer = new Answer();
                    answer.Value = TodaysAnswerValue;
                    answer.DeviceId = "ToDo";
                    answer.Timestamp = DateTime.Now;
                    answer.QuestionId = _questionId;
                    Greeting = String.Format("Your answer has been saved!");
                };

                
                return new Command<string>(action);
            }
        }
	

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
