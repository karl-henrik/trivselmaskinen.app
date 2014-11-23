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
            q.Text = "The question for today! Click one of the buttons to reply."; //ToDo: ska hämtas från backend.
            q.QuestionId = 0; //ToDo: ska sättas till id som hämtas ihop med frågan från backend.
            TodaysQuestion = q.Text;
            TodaysQuestionId = q.QuestionId;

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

        string _greeting;
        public string Greeting
        {
            get { return _greeting; }
            set { _greeting = value; RaisePropertyChanged("Greeting"); }
        }

        //Kommentar till nedan ICommands: Borde man inte kunna lösa detta med switch istället? All kod är ju lika utom answer.Value..
        public ICommand Register1
        {
            get
            {
                return new Command(
                    () =>
                    {
                        Answer answer = new Answer();
                        answer.Value = 1;
                        answer.DeviceId = "ToDo";
                        answer.Timestamp = DateTime.Now;
                        answer.QuestionId = _questionId;
                        Greeting = String.Format("Your answer has been saved!");
                    });
            }

        }
        public ICommand Register2
        {
            get
            {
                return new Command(
                    () =>
                    {
                        Answer answer = new Answer();
                        answer.Value = 2;
                        answer.DeviceId = "ToDo";
                        answer.Timestamp = DateTime.Now;
                        answer.QuestionId = _questionId;
                        Greeting = String.Format("Your answer has been saved!");
                    });
            }

        }

        public ICommand Register3
        {
            get
            {
                return new Command(
                    () =>
                    {
                        Answer answer = new Answer();
                        answer.Value = 3;
                        answer.DeviceId = "ToDo";
                        answer.Timestamp = DateTime.Now;
                        answer.QuestionId = _questionId;
                        Greeting = String.Format("Your answer has been saved!");
                    });
            }

        }

        public ICommand Register4
        {
            get
            {
                return new Command(
                    () =>
                    {
                        Answer answer = new Answer();
                        answer.Value = 4;
                        answer.DeviceId = "ToDo";
                        answer.Timestamp = DateTime.Now;
                        answer.QuestionId = _questionId;
                        Greeting = String.Format("Your answer has been saved!");
                    });
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
