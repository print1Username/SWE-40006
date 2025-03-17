namespace WinFormsLibrary1_Task13
{
    public class Class
    {
        public TextBox CreateTextBox(int num1, int num2) {
            TextBox box = new TextBox {
                Location = new Point(num1, num2),
                Size = new Size(100, 30)
            };

            return box;
        }

        public Button CreateButton(string text, int x, int y) {
            Button button = new Button {
                Location = new Point(x, y),
                Size = new Size(100, 30),
                Text = text,
            };

            return button;
        }

        public Label CreateLabel() {
            Label label = new Label {
                Location = new Point(230, 200),
                AutoSize = true
            };

            return label;
        }
    }

}