using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using EDC.UI.Theme;

namespace EDC.UI.Utils
{
    public static class UIHelper
    {
        public static void ApplyModernStyle(Form form)
        {
            form.BackColor = ModernColors.Background;
            form.ForeColor = ModernColors.TextPrimary;
            form.Font = ModernFonts.BodyFont;
        }

        public static void ApplyModernStyling(Control control)
        {
            control.Font = ModernFonts.BodyFont;
            control.BackColor = ModernColors.Background;
            control.ForeColor = ModernColors.TextPrimary;
        }
        
        public static void StyleButton(Button button, bool isPrimary = true)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.Font = ModernFonts.ButtonFont;
            button.Cursor = Cursors.Hand;
            button.Height = 40;
            button.FlatAppearance.BorderSize = 0;
            
            if (isPrimary)
            {
                button.BackColor = ModernColors.Primary;
                button.ForeColor = Color.White;
                button.FlatAppearance.MouseOverBackColor = ModernColors.PrimaryHover;
            }
            else
            {
                button.BackColor = ModernColors.Surface;
                button.ForeColor = ModernColors.TextPrimary;
                button.FlatAppearance.MouseOverBackColor = ModernColors.SurfaceHover;
                button.FlatAppearance.BorderColor = ModernColors.Border;
                button.FlatAppearance.BorderSize = 1;
            }
        }
        
        public static void StyleTextBox(TextBox textBox)
        {
            textBox.Font = ModernFonts.BodyFont;
            textBox.BackColor = Color.White;
            textBox.ForeColor = ModernColors.TextPrimary;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Height = 35;
            textBox.Padding = new Padding(8);
        }
        
        public static void StyleLabel(Label label, bool isTitle = false)
        {
            if (isTitle)
            {
                label.Font = ModernFonts.TitleFont;
                label.ForeColor = ModernColors.TextPrimary;
            }
            else
            {
                label.Font = ModernFonts.BodyFont;
                label.ForeColor = ModernColors.TextSecondary;
            }
            label.BackColor = Color.Transparent;
        }
        
        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = ModernColors.Border;
            dgv.Font = ModernFonts.BodyFont;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowTemplate.Height = 40;
            
            // Header styling
            dgv.ColumnHeadersDefaultCellStyle.BackColor = ModernColors.Surface;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = ModernColors.TextPrimary;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(ModernFonts.BodyFont, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = ModernColors.Surface;
            dgv.ColumnHeadersHeight = 45;
            dgv.EnableHeadersVisualStyles = false;
            
            // Row styling
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = ModernColors.TextPrimary;
            dgv.DefaultCellStyle.SelectionBackColor = ModernColors.PrimaryLight;
            dgv.DefaultCellStyle.SelectionForeColor = ModernColors.TextPrimary;
            dgv.DefaultCellStyle.Padding = new Padding(8);
        }
        
        public static Panel CreateCard(int padding = 16)
        {
            var card = new Panel
            {
                BackColor = ModernColors.Card,
                Padding = new Padding(padding)
            };
            
            card.Paint += (sender, e) =>
            {
                var rect = new Rectangle(0, 0, card.Width - 1, card.Height - 1);
                using (var pen = new Pen(ModernColors.Border, 1))
                {
                    e.Graphics.DrawRectangle(pen, rect);
                }
            };
            
            return card;
        }
        
        public static void AddDropShadow(Control control)
        {
            control.Paint += (sender, e) =>
            {
                var shadowOffset = 2;
                var shadowRect = new Rectangle(
                    shadowOffset, shadowOffset,
                    control.Width - shadowOffset,
                    control.Height - shadowOffset
                );
                
                using (var brush = new SolidBrush(Shadows.Light))
                {
                    e.Graphics.FillRectangle(brush, shadowRect);
                }
            };
        }
    }
}
