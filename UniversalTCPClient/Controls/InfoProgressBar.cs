﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace UniversalTCPClient.Controls
{
    public enum ProgressBarDisplayText
    {
        Percentage,
        CustomText
    }

    class InfoProgressBar : ProgressBar
    {
        public ProgressBarDisplayText DisplayStyle { get; set; }
        public string CustomText { get; set; }

        public InfoProgressBar()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            

            Rectangle rect = ClientRectangle;
            Graphics g = e.Graphics;

            ProgressBarRenderer.DrawHorizontalBar(g, rect);
            rect.Inflate(-3, -3);
            if (Value > 0)
            {
                // As we doing this ourselves we need to draw the chunks on the progress bar
                Rectangle clip = new Rectangle(rect.X, rect.Y, (int)Math.Round(((float)Value / Maximum) * rect.Width), rect.Height);
                ProgressBarRenderer.DrawHorizontalChunks(g, clip);
            }
            string text = DisplayStyle == ProgressBarDisplayText.Percentage ? ((float)Value / Maximum).ToString("0.00%") : CustomText;


            using (Font f = new Font(DefaultFont.FontFamily, 10))
            {

                SizeF len = g.MeasureString(text, f);
                // Calculate the location of the text (the middle of progress bar)
                // Point location = new Point(Convert.ToInt32((rect.Width / 2) - (len.Width / 2)), Convert.ToInt32((rect.Height / 2) - (len.Height / 2)));
                Point location = new Point(Convert.ToInt32((Width / 2) - len.Width / 2), Convert.ToInt32((Height / 2) - len.Height / 2));
                // The commented-out code will centre the text into the highlighted area only. This will centre the text regardless of the highlighted area.
                // Draw the custom text
                g.DrawString(text, f, Brushes.Black, location);
            }
        }
    }
}
