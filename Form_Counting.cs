using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbdKillNumCounter
{
    public sealed partial class Form_Counting : Form
    {
        public static Form_Counting Instance { get; private set; } = null;

        public Form_Counting()
        {
            InitializeComponent();

            if (Instance != null)
                throw new System.Exception("There cant be 2 instances at the same time");
            Instance = this;
        }
        private void Form_Counting_Load(object sender, EventArgs e)
        {
            UpdateUI();

            this.TopMost = true;
            this.ShowInTaskbar = false;
        }

        //Datas
        #region CountNum
        public uint CountNum_1 { get; private set; } = 0;
        public uint CountNum_2 { get; private set; } = 0;
        public uint CountNum_3 { get; private set; } = 0;
        public uint CountNum_4 { get; private set; } = 0;

        #region ClearCount
        public void ClearCount()
        {
            CountNum_1 = 0;
            CountNum_2 = 0;
            CountNum_3 = 0;
            CountNum_4 = 0;
            UpdateUI();
        }
        #endregion
        #endregion

        //UiShow
        public void UpdateUI()
        {
            #region CountNumButton
            void setnbtn(Button button, int index, uint num)
            {
                string str = "<" + index + ">";
                if (num <= 0)
                    str += "O";
                else if (num == 1)
                    str += "I";
                else if (num == 2)
                    str += "II";
                else
                    str += "=DEAD=";
                button.Text = str;
            }

            setnbtn(Button_CountNum_1, 1, CountNum_1);
            setnbtn(Button_CountNum_2, 2, CountNum_2);
            setnbtn(Button_CountNum_3, 3, CountNum_3);
            setnbtn(Button_CountNum_4, 4, CountNum_4);
            #endregion
        }

        //Interact
        #region ChangeCountNum
        void ChangeCountNum(Func<uint> get, Action<uint> set)
        {
            uint num = get();
            num += 1;
            if (num > 3)
                num = 0;
            set(num);
            UpdateUI();
        }

        private void Button_CountNum_1_Click(object sender, EventArgs e)
            => ChangeCountNum(() => CountNum_1, (uint v) => CountNum_1 = v);

        private void Button_CountNum_2_Click(object sender, EventArgs e)
            => ChangeCountNum(() => CountNum_2, (uint v) => CountNum_2 = v);

        private void Button_CountNum_3_Click(object sender, EventArgs e)
            => ChangeCountNum(() => CountNum_3, (uint v) => CountNum_3 = v);

        private void Button_CountNum_4_Click(object sender, EventArgs e)
            => ChangeCountNum(() => CountNum_4, (uint v) => CountNum_4 = v);
        #endregion
        #region OnKeyDown
        public void OnKeyInput(Keys key)
        {
            (Keys, Action<object, EventArgs>)[] arr =
            {
                (Keys.F1, Button_CountNum_1_Click),
                (Keys.F2, Button_CountNum_2_Click),
                (Keys.F3, Button_CountNum_3_Click),
                (Keys.F4, Button_CountNum_4_Click),
            };

            foreach (var (k, func) in arr)
            {
                if (key != k)
                    continue;

                func(null, null);

                break;
            }
        }
        #endregion
        #region SetWindowPierce
        public void SetWindownUntouchable()
        {
            SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
            SetLayeredWindowAttributes(this.Handle, 0, 100, LWA_ALPHA);
        }

        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_STYLE = (-16);
        private const int GWL_EXSTYLE = (-20);
        private const int LWA_ALPHA = 0;

        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(
        IntPtr hwnd,
        int nIndex,
        uint dwNewLong
        );

        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(
        IntPtr hwnd,
        int nIndex
        );

        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern int SetLayeredWindowAttributes(
        IntPtr hwnd,
        int crKey,
        int bAlpha,
        int dwFlags
        );
        #endregion
    }
}
