using System;
using System.Windows.Forms;

namespace TelefonRehberi
{
    class SlidingPanel
    {
        private Panel   span;
        private readonly Button  button;
        private Timer   tmr;
        private bool    hidden;
        private readonly int     size;

        public SlidingPanel(ref Panel pnl,ref Button btn, int with)
        {
            pnl.Width   = 0;
            this.span   = pnl;
            this.button = btn;
            hidden      = true;
            size        = with;
            btn.Click   += new EventHandler(button_clicked);
            tmr = new Timer
            {
                Interval = 1
            };
            tmr.Tick    += new EventHandler(t_tick); 
        }

        private void button_clicked(object sender, EventArgs e)
        {
            tmr.Start();
        }

        private void t_tick(object sender, EventArgs e)
        {
            if (hidden) ChangeSize(+6);
            else        ChangeSize(-6);
        }

        private void ChangeSize(int val)
        {
            span.Width += val;

            if(span.Width >= size || span.Width <= 0)
            {
                tmr.Stop();
                hidden = !hidden;
            }
        }
    }
}