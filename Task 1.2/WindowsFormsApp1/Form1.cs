using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        private TextBox _textbox1;
        private TextBox _textbox2;
        private Button _button;
        private Label _label;

        public Form1()
        {
            InitializeComponent();
            this.Icon = new Icon("calculator.ico");
            this.Size = new Size(600, 400);
            this.BackColor = Color.LightGray;

            _textbox1 = CreateTextBox(250, 100);
            _textbox2 = CreateTextBox(250, 150);
            _button = CreateButton("Calculate");
            _label = CreateLabel();

            _button.Click += CalculateTotal;

            this.Controls.Add(_textbox1);
            this.Controls.Add(_textbox2);
            this.Controls.Add(_button);
            this.Controls.Add(_label);
        }

        private TextBox CreateTextBox(int num1, int num2) {
            TextBox box = new TextBox {
                Location = new Point(num1,num2),
                Size = new Size(100,20)
            };

            return box;
        }

        private Button CreateButton(string text) {
            Button button = new Button {
                Location = new Point(250, 250),
                Size = new Size(100, 20),
                Text = text,
            };

            return button;
        }

        private Label CreateLabel() {
            Label label = new Label {
                Location = new Point(250, 200),
                AutoSize = true
            };

            return label;
        }

        private void CalculateTotal(object sender, EventArgs e) {
            try {
                double num1 = Convert.ToDouble(_textbox1.Text);
                double num2 = Convert.ToDouble(_textbox2.Text);
                double result = num1 + num2;
                _label.Text = $"Result:\t{result}";

            } catch (FormatException) {
                MessageBox.Show("Please enter valid number.");
            }
        }
    }
}
