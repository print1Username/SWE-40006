namespace WinFormsLibrary2_Task13 {
    public class Class1 {
        private TextBox _box1;
        private TextBox _box2;
        private Label _label;

        private double _num1;
        private double _num2;
        private double _num3;

        public Class1(TextBox box1, TextBox box2, Label label) {
            _box1 = box1;
            _box2 = box2;
            _label = label;

            _num1 = 0;
            _num2 = 0;
            _num3 = 0;
        }

        public void Calculate(object sender, EventArgs e, string operation) {
            try {
                _num1 = Convert.ToDouble(_box1.Text);
                _num2 = Convert.ToDouble(_box2.Text);
                
                switch (operation.ToLower()) {
                    case "add":
                        _num3 = _num1 + _num2;
                        _label.Text = $"{_num1} + {_num2} = {_num3}";
                        break;

                    case "sub":
                        _num3 = _num1 - _num2;
                        _label.Text = $"{_num1} - {_num2} = {_num3}";
                        break;

                    case "mul":
                        _num3 = _num1 * _num2;
                        _label.Text = $"{_num1} × {_num2} = {_num3}";
                        break;

                    case "div":
                        if (_num2 == 0) {
                            MessageBox.Show("Cannot divide by zero.");
                        } else {
                            _num3 = _num1 / _num2;
                            _label.Text = $"{_num1} ÷ {_num2} = {_num3}";
                        }
                        break;
                    default:
                        throw new ArgumentException("Invalid operation.");
                }

            } catch (FormatException) {
                MessageBox.Show("Please enter valid numbers.");
            } catch (Exception ex) {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
