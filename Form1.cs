using Loopie_Helper_GUI.Properties;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

// Solidna Paleta https://www.color-hex.com/color-palette/96279
// Koristena Metro Paleta https://colorswall.com/palette/32915
// Solidna Paleta

namespace Loopie_Helper_GUI
{
    public partial class Form1 : Form
    {
        Class2 Panels0;
        Class2 Panels1;
        Class2 Panels2;
        Class1 Klasa1;
        /***/
        private const int WM_CTLCOLORSCROLLBAR = 0x0137;


        [DllImport("gdi32.dll", SetLastError = true)]
        private static extern nint CreateSolidBrush(int crColor);


        private nint _brush;
        /***/

        public Form1()
        {
            InitializeComponent();
            /***/
            _brush = CreateSolidBrush(ColorTranslator.ToWin32(Color.Red));
            var panelList0 = new List<Panel>
            {
                panelCompetitions,
                panelAnalyze,
                panelFavorites,
                panelPredict
            };

            var panelList1 = new List<Panel>
            {
                panelDomestic,
                panelInternational,
                panelCustomYellow,
            };

            var panelList2 = new List<Panel>
            {
                panelItaly,
                panelSpain,
            };


            Klasa1 = new Class1(panelList0, panelList1, panelList2);

            Klasa1.hideAllPannesl(0);

            Panels0 = new Class2(0, panelList0, Klasa1);
            Panels1 = new Class2(1, panelList1, Klasa1);
            Panels2 = new Class2(2, panelList2, Klasa1);
        }
        /**/

        private void buttonCompetitions_Click(object sender, EventArgs e)
        {
            Panels0.showPanel(panelCompetitions);
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            Panels0.showPanel(panelAnalyze);
        }

        private void buttonFavorites_Click(object sender, EventArgs e)
        {
            Panels0.showPanel(panelFavorites);
        }

        private void buttonDomestic_Click(object sender, EventArgs e)
        {
            Panels1.showPanel(panelDomestic);
        }

        private void buttonInternational_Click(object sender, EventArgs e)
        {
            Panels1.showPanel(panelInternational);
        }

        private void buttonItaly_Click(object sender, EventArgs e)
        {
            Panels2.showPanel(panelItaly);
        }

        private void buttonSpain_Click(object sender, EventArgs e)
        {
            Panels2.showPanel(panelSpain);
        }

        private void buttonPredict_Click(object sender, EventArgs e)
        {
            Panels0.showPanel(panelPredict);
        }

        private void Custom_Click(object sender, EventArgs e)
        {
            Panels1.showPanel(panelCustomYellow);
        }

        /********************************************* League Button Clicks *********************************************************/

        private void buttonItaly1_Click(object sender, EventArgs e)
        {
            string url = "guiita1";
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Please enter a valid URL.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Task.Run(() => StartScraper(url)); // Run the scraper in a separate thread
        }

        private void buttonItaly2_Click(object sender, EventArgs e)
        {
            string url = "guiita2";
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Please enter a valid URL.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Task.Run(() => StartScraper(url)); // Run the scraper in a separate thread
        }

        /********************************************* League Button Clicks *********************************************************/



        private void StartScraper(string arg1)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "../../../../Loopie_Backend/EXECUTABLE/Loopie_predictor.exe", // Path to your C app
                    Arguments = arg1,             // Arguments (e.g., URL)
                    RedirectStandardOutput = true,  // Redirect stdout
                    RedirectStandardInput = true,
                    RedirectStandardError = true,   // Redirect stderr (optional, for errors)
                    UseShellExecute = false,       // Must be false to redirect output
                    CreateNoWindow = true       // Prevent the console window from appearing
                }
            };

            // Attach event handlers to capture the output and errors
            process.OutputDataReceived += (sender, args) => AppendToOutput(args.Data);
            process.ErrorDataReceived += (sender, args) => AppendToOutput(args.Data); // Optional for errors

            // Start the process
            process.Start();

            //           process.BeginOutputReadLine();

            /*            using (var writer = process.StandardInput)
                        {
                            writer.WriteLine(); // Sends an "Enter" key press
                        }
            */
            using (var reader = process.StandardOutput)
            {
                while (!reader.EndOfStream)
                {
                    char c = (char)reader.Read(); // Read one character
                    AppendToOutput(c.ToString());
                }
            }

            // Wait for the process to exit
            //           await process.WaitForExitAsync();


            // Start reading the output asynchronously
            //                     process.BeginOutputReadLine();
            //           process.BeginErrorReadLine(); // Optional if you also want to capture errors

            //           process.WaitForExit(); // Optionally wait for the process to exit (blocking)
        }

        private void AppendToOutput(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                // Ensure UI updates happen on the UI thread
                Invoke((Delegate)(() => outputTextBox.AppendText(text)));
            }
        }

        private void buttonItaly1_MouseEnter(object sender, EventArgs e)
        {
            // buttonItaly1.Image = (Image)resources.GetObject(_1_);
            //    buttonItaly1.Image = (Image)Resources._1_solid;
        }

        private void buttonItaly1_MouseLeave(object sender, EventArgs e)
        {
            //   buttonItaly1.Image = (Image)Resources._1_solid__1_;
        }

        private void buttonCompetitions_MouseEnter(object sender, EventArgs e)
        {
            buttonCompetitions.Image = (Image)Resources.trophy_solid_g;
        }

        private void buttonCompetitions_MouseLeave(object sender, EventArgs e)
        {
            buttonCompetitions.Image = (Image)Resources.trophy_solid;
        }

        private void buttonAnalyze_MouseEnter(object sender, EventArgs e)
        {
            buttonAnalyze.Image = (Image)Resources.chart_line_solid_g;
        }

        private void buttonAnalyze_MouseLeave(object sender, EventArgs e)
        {
            buttonAnalyze.Image = (Image)Resources.chart_line_solid;
        }

        private void buttonFavorites_MouseEnter(object sender, EventArgs e)
        {
            buttonFavorites.Image = (Image)Resources.star_solid_g;
        }

        private void buttonFavorites_MouseLeave(object sender, EventArgs e)
        {
            buttonFavorites.Image = (Image)Resources.star_solid;
        }

        private void buttonPredict_MouseEnter(object sender, EventArgs e)
        {
            buttonPredict.Image = (Image)Resources.hat_wizard_solid_g;
        }

        private void buttonPredict_MouseLeave(object sender, EventArgs e)
        {
            buttonPredict.Image = (Image)Resources.hat_wizard_solid;
        }

        private void buttonInternational_MouseEnter(object sender, EventArgs e)
        {
            buttonInternational.Image = (Image)Resources.earth_europe_solid_g;
        }

        private void buttonInternational_MouseLeave(object sender, EventArgs e)
        {
            buttonInternational.Image = (Image)Resources.earth_europe_solid;
        }

        private void buttonDomestic_MouseEnter(object sender, EventArgs e)
        {
            buttonDomestic.Image = (Image)Resources.medal_solid_g;
        }


        private void buttonDomestic_MouseLeave(object sender, EventArgs e)
        {
            buttonDomestic.Image = (Image)Resources.medal_solid;
        }

        private void buttonItaly_MouseEnter(object sender, EventArgs e)
        {
            buttonItaly.Image = (Image)Resources.futbol_solid_g;
        }

        private void buttonItaly_MouseLeave(object sender, EventArgs e)
        {
            buttonItaly.Image = (Image)Resources.futbol_solid;
        }

        private void buttonSpain_MouseEnter(object sender, EventArgs e)
        {
            buttonSpain.Image = (Image)Resources.futbol_solid_g;
        }

        private void buttonSpain_MouseLeave(object sender, EventArgs e)
        {
            buttonSpain.Image = (Image)Resources.futbol_solid;
        }


        /**********************************************************************************
         * Title bar min max close buttons reimplementation
         *********************************************************************************/
        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picExpand_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                picExpand.Image = (Image)Resources.expand;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                picExpand.Image = (Image)Resources.compress;
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMinimize_MouseEnter(object sender, EventArgs e)
        {
            picMinimize.BackColor = Color.FromArgb(154, 236, 153);
        }

        private void picMinimize_MouseLeave(object sender, EventArgs e)
        {
            picMinimize.BackColor = Color.Transparent;
        }

        private void picExpand_MouseEnter(object sender, EventArgs e)
        {
            picExpand.BackColor = Color.FromArgb(154, 236, 153);
        }

        private void picExpand_MouseLeave(object sender, EventArgs e)
        {
            picExpand.BackColor = Color.Transparent;
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BackColor = Color.FromArgb(154, 236, 153);
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;
        }

        /***************************************************************************************************************/

        /***************************************************************************************************************
         * Reimplementing dragging the form from the title bar
         **************************************************************************************************************/

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, IntPtr.Zero);
        }

        /**************************************************************************************************************/

        /***************************************************************************************************************
         * Reimplementing resizing
         **************************************************************************************************************/

        private const int BorderThickness = 8;
        // Override WndProc to handle resizing
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                var pt = PointToClient(new Point(m.LParam.ToInt32()));
                var hitZone = m.Result.ToInt32();

                if (pt.X <= BorderThickness)
                {
                    if (pt.Y <= BorderThickness) hitZone = HTTOPLEFT;
                    else if (pt.Y >= this.ClientSize.Height - BorderThickness) hitZone = HTBOTTOMLEFT;
                    else hitZone = HTLEFT;
                }
                else if (pt.X >= this.ClientSize.Width - BorderThickness)
                {
                    if (pt.Y <= BorderThickness) hitZone = HTTOPRIGHT;
                    else if (pt.Y >= this.ClientSize.Height - BorderThickness) hitZone = HTBOTTOMRIGHT;
                    else hitZone = HTRIGHT;
                }
                else if (pt.Y <= BorderThickness)
                {
                    hitZone = HTTOP;
                }
                else if (pt.Y >= this.ClientSize.Height - BorderThickness)
                {
                    hitZone = HTBOTTOM;
                }

                m.Result = (IntPtr)hitZone;
                return;
            }
            if (m.Msg == WM_CTLCOLORSCROLLBAR)
            {
                m.Result = _brush;
                return;
            }

            base.WndProc(ref m);
        }

        /****************************************************************************/

        private Form activeForm = null;

        private void openSubForm(Form subForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
                activeForm = subForm;
                subForm.TopLevel = false;
                subForm.FormBorderStyle = FormBorderStyle.None;
                subForm.Dock = DockStyle.Fill;
                panelSubForm.Controls.Add(subForm);
                panelSubForm.Tag = subForm;
                subForm.BringToFront();
                subForm.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openSubForm(new FormPlaceholder1());
        }
    }



}
