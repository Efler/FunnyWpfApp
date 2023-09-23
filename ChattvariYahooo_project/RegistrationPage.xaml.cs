using System.Windows;
using System.Windows.Media;


namespace ChattvariYahooo_project;

public partial class RegistrationPage
{
    
    private Brush? _redoColor = null;
    private Brush? _redoColor2 = null;
    private bool _correctFlag = true;
    
    public RegistrationPage()
    {
        InitializeComponent();
    }
    
    private void RegButtonClick(object sender, RoutedEventArgs e)
    {
        _correctFlag = true;
        var login = Login.Text.Trim();
        var pass1 = Password1.Password.Trim();
        var pass2 = Password2.Password.Trim();

        _redoColor ??= MaterialDesignThemes.Wpf.TextFieldAssist.GetUnderlineBrush(Login);
        _redoColor2 ??= Login.Background;
        
        if (login.Length < 8)
        {
            MaterialDesignThemes.Wpf.HintAssist.SetHelperText(Login, "Логин меньше 5 символов");
            MaterialDesignThemes.Wpf.TextFieldAssist.SetUnderlineBrush(Login, Brushes.MediumVioletRed);
            Login.Background = Brushes.Violet;
            Login.ToolTip = "Исправляй, ебанат";
            _correctFlag = false;
        }
        else
        {
            MaterialDesignThemes.Wpf.HintAssist.SetHelperText(Login, "");
            MaterialDesignThemes.Wpf.TextFieldAssist.SetUnderlineBrush(Login, _redoColor);
            Login.Background = _redoColor2;
            Login.ToolTip = null;
        }
        
        if (pass1.Length < 8)
        {
            MaterialDesignThemes.Wpf.HintAssist.SetHelperText(Password1, "Пароль меньше 5 символов");
            MaterialDesignThemes.Wpf.TextFieldAssist.SetUnderlineBrush(Password1, Brushes.MediumVioletRed);
            Password1.Background = Brushes.Violet;
            Password1.ToolTip = "Исправляй, ебанат";
            _correctFlag = false;
        }
        else
        {
            MaterialDesignThemes.Wpf.HintAssist.SetHelperText(Password1, "");
            MaterialDesignThemes.Wpf.TextFieldAssist.SetUnderlineBrush(Password1, _redoColor);
            Password1.Background = _redoColor2;
            Password1.ToolTip = null;
        }
        
        if (pass2 != pass1)
        {
            MaterialDesignThemes.Wpf.HintAssist.SetHelperText(Password2, "Пароли не совпадают");
            MaterialDesignThemes.Wpf.TextFieldAssist.SetUnderlineBrush(Password2, Brushes.MediumVioletRed);
            Password2.Background = Brushes.Violet;
            Password2.ToolTip = "Исправляй, ебанат";
            _correctFlag = false;
        }
        else
        {
            MaterialDesignThemes.Wpf.HintAssist.SetHelperText(Password2, "");
            MaterialDesignThemes.Wpf.TextFieldAssist.SetUnderlineBrush(Password2, _redoColor);
            Password2.Background = _redoColor2;
            Password2.ToolTip = null;
        }

        if (_correctFlag)
        {
            NavigationService!.Navigate(new HrumkinPage());
        }
    }
    
}