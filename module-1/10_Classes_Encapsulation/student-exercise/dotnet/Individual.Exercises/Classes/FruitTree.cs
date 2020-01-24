using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        #region Properties
        public string TypeOfFruit { get; }
        public int PiecesOfFruitLeft { get; private set; }
        #endregion

        #region Constructors
        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            TypeOfFruit = typeOfFruit;
            PiecesOfFruitLeft = startingPiecesOfFruit;
        }
        #endregion

        #region Methods
        public bool PickFruit(int numberOfPiecesToRemove)
        {
            bool output = false;
            if(PiecesOfFruitLeft >= numberOfPiecesToRemove)
            {
                PiecesOfFruitLeft -= numberOfPiecesToRemove;
                output = true;
            }
            return output;
        }
        #endregion
    }
}
