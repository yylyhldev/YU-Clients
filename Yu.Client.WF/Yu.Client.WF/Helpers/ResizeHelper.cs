using System.Linq;

namespace Yu.Client.WF.Helpers
{
    /// <summary>
    /// 控件大小随窗体大小等比例缩放
    /// </summary>
    public class ResizeHelper
    {
        public static void SetTag(bool recursion, Control controls, string[] ignoreControlNames = null)
        {
            foreach (Control control in controls.Controls)
            {
                if (ignoreControlNames != null && ignoreControlNames.Contains(control.Name)) continue;
                control.Tag = control.Width + ";" + control.Height + ";" + control.Left + ";" + control.Top + ";" + control.Font.Size;
                if (recursion && control.Controls.Count > 0)
                {
                    SetTag(recursion, control, ignoreControlNames);
                }
            }
        }
        public static void SetControls(bool recursion, float newx, float newy, Control controls, string[] ignoreControlNames = null, string[] specialControlNames = null)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control control in controls.Controls)
            {
                if (ignoreControlNames != null && ignoreControlNames.Contains(control.Name)) continue;
                //获取控件的Tag属性值，并分割后存储字符串数组
                if (control.Tag != null)
                {
                    string[] mytag = control.Tag.ToString().Split(';');
                    //根据窗体缩放的比例确定控件的值
                    control.Width = Convert.ToInt32(Convert.ToSingle(mytag[0]) * newx);//宽度
                    control.Left = Convert.ToInt32(Convert.ToSingle(mytag[2]) * newx);//左边距
                    if (specialControlNames != null && specialControlNames.Contains(control.Name))
                    {
                        control.Height = Convert.ToInt32(Convert.ToSingle(mytag[1]) * newy);//高度
                        control.Top = Convert.ToInt32(Convert.ToSingle(mytag[3]) * newy);//顶边距
                    }
                    //var currentSize = Convert.ToSingle(mytag[4]) * newy;//字体大小
                    //control.Font = new Font(control.Font.Name, currentSize, control.Font.Style, control.Font.Unit);
                    if (recursion && control.Controls.Count > 0)
                    {
                        SetControls(recursion, newx, newy, controls, specialControlNames, ignoreControlNames);
                    }
                }
            }
        }
    }
}
