using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class OhmsLawViewModel : INotifyPropertyChanged
    {
        public List<OhmsLaw> OhmsLaws { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private OhmsLaw selectedequation { get; set; }
        public OhmsLaw SelectedEquation
        {
            get { return selectedequation; }
            set
            {
                if (selectedequation != value)
                {
                    selectedequation = value;
                    // Do whatever functionality here
                    MyEquation = selectedequation.Value;
                   

                }
            }
        }
        private string myequation;
        public string MyEquation
        {
            get { return myequation; }
            set
            {
                if (myequation != value)
                {
                    myequation = value;
                    OnPropertyChanged();
                }
            }
        }

        public OhmsLawViewModel()
        {
            OhmsLaws = GetOhmsLaws().OrderBy(t => t.Value).ToList();
        }
        public List<OhmsLaw> GetOhmsLaws()
        {
            var ohmslaws = new List<OhmsLaw>()
            {
                new OhmsLaw(){Key = 1, Value = "Volts"},
                new OhmsLaw(){Key = 2, Value = "Amps"},
                new OhmsLaw(){Key = 3, Value = "Resistance"}
            };

            return ohmslaws;
        }

        

    }

    public class OhmsLaw
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }

    
}

