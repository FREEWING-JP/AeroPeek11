using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace AeroPeek11
{
    public partial class Peek : Form
    {
        [DllImport("dwmapi.dll", EntryPoint = "#113", SetLastError = true)]
        internal static extern uint DwmpActivateLivePreview(uint Switch, IntPtr Handle, IntPtr Caller, uint Method, UIntPtr Windows11SupportFlag);

        public static int DelayBeforePeek = 550;
        public static bool IsMouseDown = false;
        public static Point CursorPoint;
        public static Point FormPoint;

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr Window, int Index);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr Window, int Index, int Value);

        public bool IsInSetupMode
        {
            get;
            set;
        }

        public Peek()
        {
            InitializeComponent();
        }

        public const int ExStyle = -20;
        public const int ExToolWindow = 0x00000080;

        private void Peek_Load(object Sender, EventArgs Event)
        {
            if(IsInSetupMode == false)
            {
                int WindowStyle = GetWindowLong(Handle, ExStyle);
                SetWindowLong(Handle, ExStyle, WindowStyle | ExToolWindow);
            }

            IsMouseDown = false;
        }

        private void Peek_MouseEnter(object Sender, EventArgs Event)
        {
            if(IsInSetupMode == true)
            {
                return;
            }
            else
            {
                Thread.Sleep(DelayBeforePeek);
                DwmpActivateLivePreview(1, this.Handle, this.Handle, 1, UIntPtr.Zero);
            }
        }

        private void Peek_MouseLeave(object Sender, EventArgs Event)
        {
            if(IsInSetupMode == true)
            {
                return;
            }
            else
            {
                DwmpActivateLivePreview(0, Handle, Handle, 1, UIntPtr.Zero);
            }
        }

        private void Peek_MouseMove(object Sender, MouseEventArgs Event)
        {
            if(IsInSetupMode == true)
            {
                if(IsMouseDown == true)
                {
                    Point Difference = Point.Subtract(Cursor.Position, new Size(CursorPoint));
                    Location = Point.Add(FormPoint, new Size(Difference));
                }
            }
            else
            {
                return;
            }
        }

        private void Peek_MouseDown(object Sender, MouseEventArgs Event)
        {
            if(IsInSetupMode == true)
            {
                IsMouseDown = true;
                CursorPoint = Cursor.Position;
                FormPoint = Location;
            }
            else
            {
                return;
            }
        }

        private void Peek_MouseUp(object Sender, MouseEventArgs Event)
        {
            if(IsInSetupMode == true)
            {
                IsMouseDown = false;
            }
            else
            {
                return;
            }
        }
    }
}