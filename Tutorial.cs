using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication
{
    abstract class Tutorial
    {
        protected int tutorialID;
        protected string tutorialName;

        public Tutorial()
        {
            tutorialID = 0;
            tutorialName = "default";
        }

        public virtual void Set()
        {
            tutorialName = "SetMethodName";
        }

        public void SetTutorial( int pID, string pName)
        {
            tutorialID = pID;
            tutorialName = pName;
        }

        public void SetTutorial(string pName)
        {
            tutorialName = pName;
        }

        public string GetTutorialName()
        {
            return tutorialName;
        }

        public int GetTutorialID()
        {
            return tutorialID;
        }

        public void callTutorial(int pID, string pName)
        {
            this.SetTutorial(pID, pName);
        }
    }
}
