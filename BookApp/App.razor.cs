using MudBlazor;

namespace BookApp;

public partial class App
{
    private static MudThemeProvider Provider = new();
    private static readonly MudTheme Theme = new()
    {
        Palette = new PaletteLight
        {
            //Body background
            Background = "#FFFFFF",

            //Standard colors
            Primary = "#131212",
            PrimaryLighten = "#34383F",
            PrimaryDarken = "#34383F",
            PrimaryContrastText = "#FFFFFF",

            Secondary = "#EA4B00",
            SecondaryLighten = "#ED7137",
            SecondaryDarken = "#ED7137",
            SecondaryContrastText = "#FFFFFF",


            Tertiary = "#1EC8A5",
            TertiaryLighten = "#2ADEBA",
            TertiaryDarken = "#19A98C",
            TertiaryContrastText = "#FFFFFF",


            Success = "#3cb371",
            SuccessLighten = "#81C784",
            SuccessDarken = "#206e42",
            SuccessContrastText = "#FFFFFF",

            Warning = "#FE9700",
            WarningLighten = "#FFB74D",
            WarningDarken = "#E65100",
            WarningContrastText = "#FFFFFF",

            Error = "#F44336",
            ErrorLighten = "#F66055",
            ErrorDarken = "#C62828",
            ErrorContrastText = "#FFFFFF",

            Info = "#2196F3",
            InfoLighten = "#90CAF9",
            InfoDarken = "#0D47A1",
            InfoContrastText = "#FFFFFF",

            Dark = "#27292F",
            DarkLighten = "#212121",
            DarkDarken = "#000000",
            DarkContrastText = "#FFFFFF",

            //Shades
            White = "#FFFFFF",
            Black = "#000000",

            //Appbar
            AppbarBackground = "#FFFFFF",
            AppbarText = "#000000",

            //Drawer
            DrawerBackground = "#FFFFFF",
            DrawerIcon = "#616161ff",
            DrawerText = "#424242ff",

            //Surface
            Surface = "#FFFFFF",

            //Text
            TextPrimary = "#000000",
            TextSecondary = "#757575",
            TextDisabled = "#00000060",

            //Divider
            Divider = "#D1D1D1",
            DividerLight = "#D1D1D1",

            //Lines & table lines
            LinesDefault = "#0000001e",
            LinesInputs = "#bdbdbdff",
            TableLines = "#e0e0e0ff",
            TableStriped = "#00000005",
            TableHover = "#0000000a",

            //Gray
            GrayDefault = "#9E9E9E",
            GrayLight = "#BDBDBD",
            GrayLighter = "#E0E0E0",
            GrayDarker = "#757575",
            GrayDark = "#616161",
            BackgroundGrey = "#f5f5f5ff",

            //Action
            ActionDefault = "#00000089",
            ActionDisabled = "#00000042",
            ActionDisabledBackground = "#0000001e",

            //Overlay
            OverlayLight = "rgba(255,255,255,0.4980392156862745)",
            OverlayDark = "rgba(33,33,33,0.4980392156862745)",

            //Hover
            HoverOpacity = 0.07,
        },

        Typography = new Typography()
        {
            Default = new Default()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 400,
                FontSize = "0.875rem",

                LetterSpacing = "0.01071em",
                TextTransform = "none"
            },
            H1 = new H1()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 600,
                FontSize = "4rem",

                LetterSpacing = "-0.01562em",
                TextTransform = "none"
            },
            H2 = new H2()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 600,
                FontSize = "3.5rem",

                LetterSpacing = "-0.00833em",
                TextTransform = "none"
            },
            H3 = new H3()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 600,
                FontSize = "3em",

                LetterSpacing = "0em",
                TextTransform = "none"
            },

            H4 = new H4()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 600,
                FontSize = "2.5rem",

                LetterSpacing = "0em",
                TextTransform = "none"
            },

            H5 = new H5()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 400,
                FontSize = "1.8rem",

                LetterSpacing = "0em",
                TextTransform = "none"
            },

            H6 = new H6()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 400,
                FontSize = "1.2rem",

                LetterSpacing = "0em",
                TextTransform = "none"
            },


            Subtitle1 = new Subtitle1()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 500,
                FontSize = "1rem",
            },


            Subtitle2 = new Subtitle2()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 450,
                FontSize = "0.825rem",
            },

            Body1 = new Body1()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 400,
                FontSize = "1rem",
            },

            Body2 = new Body2()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 400,
                FontSize = "0.825rem",
            },


            Button = new Button()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 500,
                FontSize = "1rem",
            },

            Caption = new Caption()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 300,
                FontSize = "1rem",
            },

            Overline = new Overline()
            {
                FontFamily = new[] { "Poppins" },
                FontWeight = 200,
                FontSize = "1rem",
            }
        },

        LayoutProperties = new LayoutProperties()
        {
            DrawerWidthLeft = "250px",
            DrawerWidthRight = "250px",
            DrawerMiniWidthLeft = "56px",
            DrawerMiniWidthRight = "56px",
            AppbarHeight = "64px",
            DefaultBorderRadius = "4px"
        },

        ZIndex = new ZIndex()
        {
            Drawer = 1100,
            Popover = 1200,
            AppBar = 1300,
            Dialog = 1400,
            Snackbar = 1500,
            Tooltip = 1600
        }
    };
}