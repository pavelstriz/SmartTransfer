using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartBackupper
{
    public partial class CustomTabControl : TabControl
    {
        Rectangle TabBoundary;
        RectangleF TabTextBoundary;
        StringFormat format = new StringFormat(); //for tab header text

        public CustomTabControl()
        {
            //if (!this.DesignMode) this.Multiline = true;
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer, true);
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.format.Alignment = StringAlignment.Center;
            this.format.LineAlignment = StringAlignment.Center;
        }


        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            Size xSize = new Size(13, 13);
            g.FillRectangle(new SolidBrush(SystemColors.Control), 0, 0, this.Size.Width, this.Size.Height);

            foreach (TabPage tp in this.TabPages)
            {
                //drawItem
                int index = this.TabPages.IndexOf(tp);

                this.TabBoundary = this.GetTabRect(index);
                this.TabTextBoundary = (RectangleF)this.GetTabRect(index);

                g.FillRectangle(new SolidBrush(SystemColors.ControlLight), this.TabBoundary);
                g.DrawString("Preset " + (index + 1).ToString(), this.Font, new SolidBrush(Color.Black), this.TabTextBoundary, format);
                
                //g.DrawString("x", this.Font, new SolidBrush(Color.Black), this.Bounds.Right - xSize.Width, this.Bounds.Y + 4);
                // this.Bounds.Right - xSize.Width, this.Bounds.Y + 4);
            }
        }

        Rectangle closeX = Rectangle.Empty;
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Size xSize = new Size(13, 13);
            TabPage tp = this.TabPages[e.Index];
            e.DrawBackground();
            using (SolidBrush brush = new SolidBrush(e.ForeColor))
                e.Graphics.DrawString(tp.Text + "   ", e.Font, brush,
                                      e.Bounds.X + 3, e.Bounds.Y + 4);

            if (e.State == DrawItemState.Selected)
            {
                closeX = new Rectangle(
                    e.Bounds.Right - xSize.Width, e.Bounds.Top, xSize.Width, xSize.Height);
                using (SolidBrush brush = new SolidBrush(Color.White))
                    e.Graphics.DrawString("x", e.Font, brush,
                                           e.Bounds.Right - xSize.Width, e.Bounds.Y + 4);
            }
        }
        /*protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1328 && !this.DesignMode)
                m.Result = new IntPtr(1);
            else
                base.WndProc(ref m);
        }*/
    }
}
