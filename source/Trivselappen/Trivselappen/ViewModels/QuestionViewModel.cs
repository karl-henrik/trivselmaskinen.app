using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Trivselappen.ViewModels
{
    public class QuestionViewModel : INotifyPropertyChanged
    {

        public QuestionViewModel()
        {
            Question = "The Question";
        }

        private string _question;
        public string Question { get{
            return _question;
        } 
            set{
                _question = value;
                RaisePropertyChanged("Question");
                }
        }
        string _greeting;
        public string Greeting
        {
            get { return _greeting; }
            set { _greeting = value; RaisePropertyChanged("Greeting"); }
        }

        public ICommand Register
        {
            get
            {
                return new Command(
                    () =>
                    {
                        var text = Question;
                        Greeting = String.Format("Your answer has been saved");
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
