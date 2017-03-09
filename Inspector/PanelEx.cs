using System.Windows.Forms;

namespace LevelInspector
{
    public sealed class PanelEx : Panel
    {
        // http://stackoverflow.com/questions/7828121/shift-mouse-wheel-horizontal-scrolling/11218920#11218920

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            if (VScroll && (ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                VScroll = false;
                base.OnMouseWheel(e);
                VScroll = true;
            }
            else
            {
                base.OnMouseWheel(e);
            }
        }
    }
}