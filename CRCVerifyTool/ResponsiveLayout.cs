using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRCVerifyTool
{
    public class ResponsiveLayout
    {
        private readonly float x;//定义窗体宽度
        private readonly float y;//定义窗体高度

        public ResponsiveLayout(float initwidth,float initHeight)
        {
            x = initwidth;
            y = initHeight;
        }

        internal void SetTag(Control cons)
        {
            foreach(Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if(con.Controls.Count > 0) { SetTag(con); }
            }
        }

        internal void SetControls(float x,float y,Control cons)
        {
            foreach(Control con in cons.Controls)
            {
                if(con.Tag != null)
                {
                    var mytag = con.Tag.ToString().Split(";");
                    con.Width = Convert.ToInt32(Convert.ToSingle(mytag[0]) * x);
                    con.Height = Convert.ToInt32(Convert.ToSingle(mytag[1]) * y);
                    con.Left = Convert.ToInt32(Convert.ToSingle(mytag[2]) * x);
                    con.Top = Convert.ToInt32(Convert.ToSingle(mytag[3]) * y);
                    var currentSize = Convert.ToSingle(mytag[4]) * y;
                    if(currentSize > 0)
                    {
                        con.Font = new Font(con.Font.Name, currentSize);
                    }
                    con.Focus();
                    if (con.Controls.Count > 0) { SetControls(x,y,con); }
                }
            }
        }

        internal void ResizeWindowLayout(Control control)
        {
            var newx = control.Width / x;
            var newy = control.Height / y;

            SetControls(newx,newy,control);
        }
    }
}
