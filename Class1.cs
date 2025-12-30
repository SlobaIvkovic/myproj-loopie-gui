using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopie_Helper_GUI
{

    internal class Class1
    {
        // Level TOP
        private List<Panel> panels0;
        // Level 1
        private List<Panel> panels1;
        // Level 2
        private List<Panel> panels2;

        //possible expansion

        public Class1(List <Panel> panels0, List<Panel> panels1, List<Panel> panels2)
        {
            this.panels0 = panels0;
            this.panels1 = panels1;
            this.panels2 = panels2;

        }

        private void hideAllPanles0()
        {
            hideAllPanels1();
            //set all Top level panels to false
            foreach (var panel in panels0)
            {
                panel.Visible = false;
            }

        }

        private void hideAllPanels1()
        {
            hideAllPanels2();
            //set all panels from this level visibility to false
            foreach (var panel in panels1)
            {
                panel.Visible = false;
            }

        }

        private void hideAllPanels2()
        {
            //set all panels on level 2 visibility to false
            foreach (var panel in panels2)
            {
                panel.Visible = false;
            }
        }

        public void hideAllPannesl(int level)
        {
            switch(level)
            {
                case 0:
                {
                    hideAllPanles0 ();
                        break;
                }
                case 1: 
                {
                    hideAllPanels1();
                        break;
                }
                case 2:
                    hideAllPanels2 ();
                    break;
                default:
                    hideAllPanles0();
                    break;
            }
        }
    }
}
