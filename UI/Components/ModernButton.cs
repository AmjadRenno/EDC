using System;
using System.Drawing;
using System.Windows.Forms;
using EDC.UI.Theme;

namespace EDC.UI.Components
{
    public class ModernButton : Button
    {
        private bool _isPrimary = true;
        private bool _isHovered = false;
        
        public bool IsPrimary
        {
            get => _isPrimary;
            set
            {
                _isPrimary = value;
                UpdateAppearance();
            }
        }
        
        public ModernButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | 
                    ControlStyles.UserPaint | 
                    ControlStyles.ResizeRedraw | 
                    ControlStyles.SupportsTransparentBackColor, true);
            
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Font = ModernFonts.ButtonFont;
            Cursor = Cursors.Hand;
            Size = new Size(120, 40);
            
            UpdateAppearance();
        }
        
        protected override void OnMouseEnter(EventArgs e)
        {
            _isHovered = true;
            UpdateAppearance();
            base.OnMouseEnter(e);
        }
        
        protected override void OnMouseLeave(EventArgs e)
        {
            _isHovered = false;
            UpdateAppearance();
            base.OnMouseLeave(e);
        }
        
        private void UpdateAppearance()
        {
            if (_isPrimary)
            {
                BackColor = _isHovered ? ModernColors.PrimaryHover : ModernColors.Primary;
                ForeColor = Color.White;
            }
            else
            {
                BackColor = _isHovered ? ModernColors.SurfaceHover : ModernColors.Surface;
                ForeColor = ModernColors.TextPrimary;
                FlatAppearance.BorderColor = ModernColors.Border;
                FlatAppearance.BorderSize = 1;
            }
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            // Add subtle shadow
            if (_isHovered)
            {
                using (var pen = new Pen(ModernColors.Primary, 2))
                {
                    var rect = new Rectangle(0, 0, Width - 1, Height - 1);
                    e.Graphics.DrawRectangle(pen, rect);
                }
            }
        }
    }
}
