using System;
using System.Drawing;
using System.Windows.Forms;
using EDC.UI.Theme;

namespace EDC.UI.Components
{
    public class ModernTextBox : Panel
    {
        private TextBox _textBox = null!;
        private Label _label = null!;
        private bool _isFocused = false;
        private string _placeholder = "";
        
        public new string Text
        {
            get => _textBox?.Text ?? "";
            set { if (_textBox != null) _textBox.Text = value; }
        }
        
        public string LabelText
        {
            get => _label?.Text ?? "";
            set
            {
                if (_label != null)
                {
                    _label.Text = value;
                    _label.Visible = !string.IsNullOrEmpty(value);
                }
            }
        }
        
        public string Placeholder
        {
            get => _placeholder;
            set
            {
                _placeholder = value;
                UpdatePlaceholder();
            }
        }
        
        public new event EventHandler? TextChanged;
        
        public ModernTextBox()
        {
            SetupControls();
            SetupEvents();
            UpdateAppearance();
        }
        
        private void SetupControls()
        {
            Size = new Size(250, 70);
            BackColor = Color.Transparent;
            
            _label = new Label
            {
                Text = "",
                Font = ModernFonts.CaptionFont,
                ForeColor = ModernColors.TextSecondary,
                AutoSize = true,
                Location = new Point(0, 0),
                Visible = false
            };
            
            _textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Font = ModernFonts.BodyFont,
                BackColor = Color.White,
                ForeColor = ModernColors.TextPrimary,
                Location = new Point(12, 25),
                Size = new Size(226, 25),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            
            Controls.Add(_label);
            Controls.Add(_textBox);
        }
        
        private void SetupEvents()
        {
            _textBox.GotFocus += (s, e) =>
            {
                _isFocused = true;
                UpdateAppearance();
            };
            
            _textBox.LostFocus += (s, e) =>
            {
                _isFocused = false;
                UpdateAppearance();
            };
            
            _textBox.TextChanged += (s, e) =>
            {
                UpdatePlaceholder();
                TextChanged?.Invoke(this, e);
            };
        }
        
        private void UpdateAppearance()
        {
            Invalidate();
        }
        
        private void UpdatePlaceholder()
        {
            if (string.IsNullOrEmpty(_textBox.Text) && !_isFocused && !string.IsNullOrEmpty(_placeholder))
            {
                _textBox.ForeColor = ModernColors.TextHint;
                if (_textBox.Text != _placeholder)
                    _textBox.Text = _placeholder;
            }
            else if (_textBox.Text == _placeholder)
            {
                _textBox.Text = "";
                _textBox.ForeColor = ModernColors.TextPrimary;
            }
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            var textBoxRect = new Rectangle(8, 20, Width - 16, 30);
            var borderColor = _isFocused ? ModernColors.Primary : ModernColors.Border;
            var borderWidth = _isFocused ? 2 : 1;
            
            // Background
            using (var brush = new SolidBrush(Color.White))
            {
                e.Graphics.FillRectangle(brush, textBoxRect);
            }
            
            // Border
            using (var pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, textBoxRect);
            }
        }
    }
}
