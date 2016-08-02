using System;
using System.Windows.Forms;

namespace UniversalTCPClient.Controls
{
    class BetterSplitContainer : SplitContainer
    {
        private bool issplitterfixed = false;

        public new bool IsSplitterFixed
        {
            get
            {
                return issplitterfixed;
            }
            set
            {
                issplitterfixed = value;
                if (value == false)
                {
                    base.IsSplitterFixed = false;
                }
            }
        }

        protected override void OnEnter(EventArgs e)
        {
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (!issplitterfixed)
            {
                base.IsSplitterFixed = true;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (!issplitterfixed)
            {
                base.IsSplitterFixed = false;
                Panel1.Refresh();
                Panel2.Refresh();
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e); // Check to make sure the splitter won't be updated by the
                                 // normal move behavior also
            //mainForm.lastFocused.Focus();
            if (!issplitterfixed && base.IsSplitterFixed)
            {
                // Make sure that the button used to move the splitter
                // is the left mouse button
                if (e.Button.Equals(MouseButtons.Left))
                {
                    // Checks to see if the splitter is aligned Vertically
                    if (Orientation.Equals(Orientation.Vertical))
                    {
                        // Only move the splitter if the mouse is within
                        // the appropriate bounds
                        if (e.X > 0 && e.X < Width)
                        {
                            // Move the splitter & force a visual refresh
                            SplitterDistance = e.X;
                            Refresh();
                        }
                    }
                    // If it isn't aligned vertically then it must be
                    // horizontal
                    else
                    {
                        // Only move the splitter if the mouse is within
                        // the appropriate bounds
                        if (e.Y > 0 && e.Y < Height)
                        {
                            // Move the splitter & force a visual refresh
                            SplitterDistance = e.Y;
                            Refresh();
                        }
                    }
                }
                // If a button other than left is pressed or no button
                // at all
                else
                {
                    // This allows the splitter to be moved normally again
                    base.IsSplitterFixed = false;
                }
            }
        }
    }
}