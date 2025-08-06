using System.Drawing;

namespace EDC.UI.Theme
{
    public static class ModernColors
    {
        // Primary Colors
        public static readonly Color Primary = Color.FromArgb(33, 150, 243);
        public static readonly Color PrimaryDark = Color.FromArgb(25, 118, 210);
        public static readonly Color PrimaryLight = Color.FromArgb(100, 181, 246);
        
        // Secondary Colors
        public static readonly Color Secondary = Color.FromArgb(255, 193, 7);
        public static readonly Color SecondaryDark = Color.FromArgb(255, 160, 0);
        public static readonly Color SecondaryLight = Color.FromArgb(255, 213, 79);
        
        // Neutral Colors
        public static readonly Color Surface = Color.FromArgb(250, 250, 250);
        public static readonly Color Background = Color.FromArgb(248, 249, 250);
        public static readonly Color Card = Color.White;
        public static readonly Color Border = Color.FromArgb(224, 224, 224);
        
        // Text Colors
        public static readonly Color TextPrimary = Color.FromArgb(33, 33, 33);
        public static readonly Color TextSecondary = Color.FromArgb(117, 117, 117);
        public static readonly Color TextHint = Color.FromArgb(158, 158, 158);
        
        // Status Colors
        public static readonly Color Success = Color.FromArgb(76, 175, 80);
        public static readonly Color Warning = Color.FromArgb(255, 152, 0);
        public static readonly Color Error = Color.FromArgb(244, 67, 54);
        public static readonly Color Info = Color.FromArgb(33, 150, 243);
        
        // Hover States
        public static readonly Color PrimaryHover = Color.FromArgb(30, 136, 229);
        public static readonly Color SecondaryHover = Color.FromArgb(245, 184, 0);
        public static readonly Color SurfaceHover = Color.FromArgb(245, 245, 245);
    }
    
    public static class ModernFonts
    {
        public static readonly Font TitleFont = new Font("Segoe UI", 18F, FontStyle.Bold);
        public static readonly Font SubtitleFont = new Font("Segoe UI", 14F, FontStyle.Regular);
        public static readonly Font BodyFont = new Font("Segoe UI", 10F, FontStyle.Regular);
        public static readonly Font CaptionFont = new Font("Segoe UI", 9F, FontStyle.Regular);
        public static readonly Font ButtonFont = new Font("Segoe UI", 10F, FontStyle.Regular);
    }
    
    public static class Shadows
    {
        public static readonly Color Light = Color.FromArgb(50, 0, 0, 0);
        public static readonly Color Medium = Color.FromArgb(80, 0, 0, 0);
        public static readonly Color Heavy = Color.FromArgb(120, 0, 0, 0);
    }
    
    public static class BorderRadius
    {
        public const int Small = 4;
        public const int Medium = 8;
        public const int Large = 12;
        public const int ExtraLarge = 16;
    }
}
