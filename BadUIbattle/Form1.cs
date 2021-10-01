using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadUIbattle
{
    public partial class Form1 : Form
    {




        private TrackBar[] _trackBars = new TrackBar[0];
        private Label[] _labels = new Label[0];
        int y = 0;
        public Form1()
        {
            InitializeComponent();
            panel1.Controls.Add(trackBar1);
            panel1.Controls.Add(txtName);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (_labels.Length != 0)
            {
                y = 0;
                for (int i = 0; i <_trackBars.Length; i++)
                {
                    panel1.Controls.Remove(_trackBars[i]);
                   
                    panel1.Controls.Remove(_labels[i]);
                  
                }
                _trackBars = new TrackBar[0];
                _labels = new Label[0];
            }
            CreateLabeledTrackBars(this, trackBar1.Value);

         
        }
 
        void CreateLabeledTrackBars(Control host, int n)
        {
            const int trackBarWidth = 150;
            const int minValue = 0;
            const int maxValue = 25;
            const int defaultValue = 0;

            _trackBars = new TrackBar[n];
            _labels = new Label[n];
            
            for (int i = 0; i < n; ++i)
            {
                var label = new Label()
                {
                    Top = y,
                    Left = trackBarWidth,
                    Text = " ",
                    Parent = host,
                    Visible = false,
                };
                var trackBar = new TrackBar()
                {
                    Top = y,
                    Width = trackBarWidth,
                    // save associated label
                    Tag = label,
                    Minimum = minValue,
                    Maximum = maxValue,
                    Value = defaultValue,
                    Parent = host,
                };
                // handle ValueChangedEvent
                trackBar.ValueChanged += OnTrackBarValueChanged;
                // apply vertical offset for next trackbar
                panel1.Controls.Add(trackBar);
                panel1.Controls.Add(label);
                y += trackBar.Height;
                _trackBars[i] = trackBar;
                _labels[i] = label;
            }
        }

        void OnTrackBarValueChanged(object sender, EventArgs e)
        {
            // get trackbar, which generated event
            var trackBar = (TrackBar)sender;
            // get associated label
            var associatedLabel = (Label)trackBar.Tag;
            if (trackBar.Value == 1)
            {
                associatedLabel.Text = "a";
            }
            else if (trackBar.Value == 2)
            {
                associatedLabel.Text = "b";
            }
            else if (trackBar.Value == 3)
            {
                associatedLabel.Text = "c";
            }
            else if (trackBar.Value == 4)
            {
                associatedLabel.Text = "d";
            }
            else if (trackBar.Value == 5)
            {
                associatedLabel.Text = "e";
            }
            else if (trackBar.Value == 6)
            {
                associatedLabel.Text = "f";
            }
            else if (trackBar.Value == 7)
            {
                associatedLabel.Text = "g";
            }
            else if (trackBar.Value == 8)
            {
                associatedLabel.Text = "h";
            }
            else if (trackBar.Value == 9)
            {
                associatedLabel.Text = "i";
            }
            else if (trackBar.Value == 10)
            {
                associatedLabel.Text = "k";
            }
            else if (trackBar.Value == 11)
            {
                associatedLabel.Text = "l";
            }
            else if (trackBar.Value == 12)
            {
                associatedLabel.Text = "m";
            }
            else if (trackBar.Value == 13)
            {
                associatedLabel.Text = "n";
            }
            else if (trackBar.Value == 14)
            {
                associatedLabel.Text = "o";
            }
            else if (trackBar.Value == 15)
            {
                associatedLabel.Text = "p";
            }
            else if (trackBar.Value == 16)
            {
                associatedLabel.Text = "r";
            }
            else if (trackBar.Value == 17)
            {
                associatedLabel.Text = "s";
            }
            else if (trackBar.Value == 18)
            {
                associatedLabel.Text = "t";
            }
            else if (trackBar.Value == 19)
            {
                associatedLabel.Text = "u";
            }
            else if (trackBar.Value == 20)
            {
                associatedLabel.Text = "v";
            }
            else if (trackBar.Value == 21)
            {
                associatedLabel.Text = "w";
            }
            else if (trackBar.Value == 22)
            {
                associatedLabel.Text = "x";
            }
            else if (trackBar.Value == 23)
            {
                associatedLabel.Text = "y";
            }
            else if(trackBar.Value == 24)
            {
                associatedLabel.Text = "z";
            }
            else if (trackBar.Value == 25)
            {
                associatedLabel.Text = " ";
            }

            

            txtName.Text = "";
            for (int i = 0; i < _labels.Length; i++)
            {
                txtName.Text += _labels[i].Text;
            }
            // recalculate sum of all values and update other label here
        } 
    
    }
}
