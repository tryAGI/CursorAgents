
#nullable enable

namespace CursorAgents
{
    /// <summary>
    /// Icon color.<br/>
    /// Example: blue
    /// </summary>
    public enum ProjectAppearanceColor
    {
        /// <summary>
        ///
        /// </summary>
        Blue,
        /// <summary>
        ///
        /// </summary>
        Brand,
        /// <summary>
        ///
        /// </summary>
        Cyan,
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Green,
        /// <summary>
        ///
        /// </summary>
        Magenta,
        /// <summary>
        ///
        /// </summary>
        Orange,
        /// <summary>
        ///
        /// </summary>
        Purple,
        /// <summary>
        ///
        /// </summary>
        Red,
        /// <summary>
        ///
        /// </summary>
        Yellow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAppearanceColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAppearanceColor value)
        {
            return value switch
            {
                ProjectAppearanceColor.Blue => "blue",
                ProjectAppearanceColor.Brand => "brand",
                ProjectAppearanceColor.Cyan => "cyan",
                ProjectAppearanceColor.Default => "default",
                ProjectAppearanceColor.Green => "green",
                ProjectAppearanceColor.Magenta => "magenta",
                ProjectAppearanceColor.Orange => "orange",
                ProjectAppearanceColor.Purple => "purple",
                ProjectAppearanceColor.Red => "red",
                ProjectAppearanceColor.Yellow => "yellow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAppearanceColor? ToEnum(string value)
        {
            return value switch
            {
                "blue" => ProjectAppearanceColor.Blue,
                "brand" => ProjectAppearanceColor.Brand,
                "cyan" => ProjectAppearanceColor.Cyan,
                "default" => ProjectAppearanceColor.Default,
                "green" => ProjectAppearanceColor.Green,
                "magenta" => ProjectAppearanceColor.Magenta,
                "orange" => ProjectAppearanceColor.Orange,
                "purple" => ProjectAppearanceColor.Purple,
                "red" => ProjectAppearanceColor.Red,
                "yellow" => ProjectAppearanceColor.Yellow,
                _ => null,
            };
        }
    }
}