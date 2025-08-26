using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DbdKillNumCounter
{
    public partial class MainForm : Form
    {
        public static MainForm Instance { get; private set; } = null;

        public MainForm()
        {
            InitializeComponent();

            if (Instance != null)
                throw new System.Exception("There cant be 2 instances at the same time");
            Instance = this;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            TryRegisterKey();
        }

        //KeyRegister
        #region KeyBind
        void TryRegisterKey()
        {
            RegisterKey(Keys.F1, KEYID_F1);
            RegisterKey(Keys.F2, KEYID_F2);
            RegisterKey(Keys.F3, KEYID_F3);
            RegisterKey(Keys.F4, KEYID_F4);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY)// && m.WParam.ToInt32() == MainLogic.KeyBindID)
            {
                Int32 getId = m.WParam.ToInt32();
                (Int32, Keys)[] arr =
                {
                    (KEYID_F1, Keys.F1),
                    (KEYID_F2, Keys.F2),
                    (KEYID_F3, Keys.F3),
                    (KEYID_F4, Keys.F4),
                };

                foreach (var (id, key) in arr)
                {
                    if (getId == id)
                    {
                        OnKeyDown(key);
                        break;
                    }
                }
            }
            base.WndProc(ref m);
        }

        #region KeyInfo
        const Int32 KEYID_F1 = 247696411;
        const Int32 KEYID_F2 = 247696412;
        const Int32 KEYID_F3 = 247696413;
        const Int32 KEYID_F4 = 247696414;
        #endregion
        [DllImport("user32.dll")]
        static extern UInt32 RegisterHotKey(IntPtr hWnd, UInt32 id, UInt32 fsModifiers, UInt32 vk);
        static void RegisterKey(Keys k, UInt32 id) => RegisterHotKey(Instance.Handle, id, 0, (UInt32)k);

        static void OnKeyDown(Keys key)
        {
            if (Form_Counting.Instance != null)
                Form_Counting.Instance.OnKeyInput(key);
        }
        #endregion

        //UI
        #region Button_StartCount
        private void Button_StartCount_Click(object sender, EventArgs e)
        {
            if (Form_Counting.Instance != null)
            {
                MessageBox.Show("You have started the counting windows", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form_Counting form = new Form_Counting();
            form.Show(this);
        }
        #endregion
        #region Button_ClearCount
        private void Button_ClearCount_Click(object sender, EventArgs e)
        {
            if (Form_Counting.Instance == null)
            {
                MessageBox.Show("You didn't start a couting window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form_Counting.Instance.ClearCount();
        }
        #endregion
        #region Button_SetPierce
        private void Button_SetPierce_Click(object sender, EventArgs e)
        {
            Form_Counting.Instance.SetWindownUntouchable();
        }
        #endregion
        #region Button_CloseCount
        private void Button_CloseCount_Click(object sender, EventArgs e)
        {
            if (Form_Counting.Instance == null)
            {
                MessageBox.Show("You can't do that!There is no counting window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form_Counting.Instance.Close();
        }
        #endregion
    }
}