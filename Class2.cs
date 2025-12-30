using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopie_Helper_GUI
{
    internal class Class2
    {
        private int level;
        List<Panel> panels;

        Class1 Klasa1;



        public Class2(int level,List <Panel> panels, Class1 Kls)
        {
            this.level = level;
            this.panels = panels;

            Klasa1 = Kls;
    
        }

        private void hidePanles0()
        {

            Klasa1.hideAllPannesl(level);
            //comp
            foreach (var panel in panels)
            { 
                if (panel.Visible == true)
                {
                    panel.Visible = false;
                }
            // ana
                if (panel.Visible == true)
                {
                    panel.Visible = false;
                }
                if (panel.Visible == true)
                {
                    panel.Visible = false;
                }
            }
        }

        public void showPanel(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                hidePanles0();
                subPanel.Visible = true;
            }
            else
            {
                subPanel.Visible = false;
            }
        }
    }
}
