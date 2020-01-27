using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        #region Properties
        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }
        public int CurrentVolume { get; private set; }
        #endregion

        #region Constructors
        public Television()
        {
            SetDefaultValues();
        }
        #endregion

        #region Methods

        private void SetDefaultValues()
        {
            CurrentChannel = 3;
            CurrentVolume = 2;
            IsOn = false;
        }
        public void TurnOff()
        {
            IsOn = false;
        }
        public void TurnOn()
        {
            IsOn = true;
        }

        public void ChangeChannel(int newChannel)
        {
            if(newChannel >= 3 && newChannel <= 18 && IsOn)
            {
                CurrentChannel = newChannel;
            }
        }

        public void ChannelUp()
        {
            if (IsOn)
            {
                if (CurrentChannel == 18)
                {
                    CurrentChannel = 3;
                }
                else
                {
                    CurrentChannel++;
                }
            }            
        }

        public void ChannelDown()
        {
            if (IsOn)
            {
                if (CurrentChannel == 3)
                {
                    CurrentChannel = 18;
                }
                else
                {
                    CurrentChannel--;
                }
            }            
        }

        public void RaiseVolume()
        {
            if (IsOn)
            {
                if(CurrentVolume < 10)
                {
                    CurrentVolume++;
                }
            }
        }

        public void LowerVolume()
        {
            if (IsOn)
            {
                if (CurrentVolume > 0)
                {
                    CurrentVolume--;
                }
            }
        }
        #endregion

    }
}
