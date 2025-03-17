using WinFormsLibrary1_Task13;
using WinFormsLibrary2_Task13;


namespace WinFormsApp1_Task13 {
    public partial class Form1 : Form {
        private TextBox _textbox1;
        private TextBox _textbox2;

        private readonly Button _buttonAdd;
        private readonly Button _buttonSub;
        private readonly Button _buttonMul;
        private readonly Button _buttonDiv;

        private Label _label;

        private Class _class = new Class();
        public Form1() {
            InitializeComponent();
            this.Icon = new Icon("calculator.ico");
            this.BackColor = Color.LightGray;
            this.Text = "Simple Calculator";
            this.Font = new Font("Arial", 11, FontStyle.Regular);
            this.Size = new Size(600, 400);

            _textbox1 = _class.CreateTextBox(250, 100);
            _textbox2 = _class.CreateTextBox(250, 150);

            _buttonAdd = _class.CreateButton("+", 80, 250);
            _buttonSub = _class.CreateButton("–", 200, 250);
            _buttonMul = _class.CreateButton("×", 320, 250);
            _buttonDiv = _class.CreateButton("÷", 440, 250);

            _label = _class.CreateLabel();

            Class1 _class1 = new Class1(_textbox1, _textbox2, _label);

            _buttonAdd.Click += (sender, e) => _class1.Calculate(sender, e, "add");
            _buttonSub.Click += (sender, e) => _class1.Calculate(sender, e, "sub");
            _buttonMul.Click += (sender, e) => _class1.Calculate(sender, e, "mul");
            _buttonDiv.Click += (sender, e) => _class1.Calculate(sender, e, "div");

            this.Controls.Add(_textbox1);
            this.Controls.Add(_textbox2);

            this.Controls.Add(_buttonAdd);
            this.Controls.Add(_buttonSub);
            this.Controls.Add(_buttonMul);
            this.Controls.Add(_buttonDiv);

            this.Controls.Add(_label);
        }

        
    }
}
