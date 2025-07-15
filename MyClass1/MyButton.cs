using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyButton
{
    public class MyButton : Button
    {
        public Type UserWindowType { get; set; }

        protected override void OnClick()
        {
            base.OnClick();
            var win = Activator.CreateInstance(UserWindowType) as System.Windows.Window;
            if (win != null)
            {
                win.ShowDialog();
            }
            else
            {
                throw new InvalidOperationException("UserWindowType must be a valid Window type.");
            }
        }
    }
}
