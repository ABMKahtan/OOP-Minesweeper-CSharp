using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testapp
{
    public class Tile
    {
        //Attributes
        private bool isFlag;
        private bool isMine;
        private bool isRevealed;
        private int mineCounter;
        private string displayString;

        //Constructor
        public Tile()
        {
            this.isFlag = false;
            this.isMine = false;
            this.isRevealed = false;
            this.mineCounter = 0;
            this.displayString = "";
            findDisplayString();
        }

        public bool getIsMine()
        {
            return this.isMine;
        }

        public void setMine()
        {
            this.isMine = true;
            findDisplayString();
        }

        public void setMineCounter(int mineCounter)
        {
            this.mineCounter = mineCounter;
            findDisplayString();

        }

        public int getMineCounter()
        {
            return this.mineCounter;
        }

        public bool getIsRevealed()
        {
            return this.isRevealed;
        }

        public void setIsRevealed()
        {
            this.isRevealed = true;
            findDisplayString();

        }

        public void setFlag()
        {
            this.isFlag = !this.isFlag;
            findDisplayString();

        }

        public bool getIsFlag()
        {
            return this.isFlag;
        }

        public void findDisplayString()
        {
            if (!this.isRevealed && !this.isFlag)
            {
                setDisplayString("[ 👀 ]");
            }
            else if (!this.isRevealed && this.isFlag)
            {
                setDisplayString("[ ⛳ ]");
            }
            else if (this.isRevealed && !this.isMine)
            {
                if (this.mineCounter > 0)
                {
                    setDisplayString(@$"[ {mineCounter} ]");
                }
                else { setDisplayString("[ _ ]"); }
            }
            else
            {
                setDisplayString("{ 💣 }");
            }
        }
        public void addCounter()
        {
            this.mineCounter++;
        }

        public void setDisplayString(string dString)
        {
            this.displayString = dString;
        }

        public string getDisplayString()
        {
            return this.displayString;
        }

    }
}