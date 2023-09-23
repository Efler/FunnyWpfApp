using System;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;


namespace ChattvariYahooo_project;

public partial class HrumkinPage
{
    public HrumkinPage()
    {
        InitializeComponent();

        var x = Application.GetResourceStream(new Uri("pack://application:,,,/ChattvariYahooo_project;component/src/hrumkin_sound.wav"));
        
        var soundPlayer = new SoundPlayer(x!.Stream);

        try
        {
            soundPlayer.Load();
            soundPlayer.Play();
        }catch (FileNotFoundException){}
        
        TextAnimation();
    }

    private async void TextAnimation()
    {
        
        var appearance = new DoubleAnimation
        {
            From = 0,
            To = 0.4,
            Duration = TimeSpan.FromSeconds(2)
        };
        
        var fastAppearance = new DoubleAnimation
        {
            From = 0,
            To = 0.25,
            Duration = TimeSpan.FromSeconds(0.6)
        };

        var disappearance = new DoubleAnimation
        {
            From = 0.4,
            To = 0,
            Duration = TimeSpan.FromSeconds(2)
        };
        
        var fastDisappearance = new DoubleAnimation
        {
            From = 0.25,
            To = 0,
            Duration = TimeSpan.FromSeconds(0.6)
        };

        await Task.Delay(500);
        
        ShivaBorder.BeginAnimation(OpacityProperty, appearance);

        await Task.Delay(4100);
        
        ShivaBorder.BeginAnimation(OpacityProperty, disappearance);
        
        await Task.Delay(2500);
        
        ShivaText.Text = "Тайная доктрина Шивы отчистит ваши грехи";
        ShivaBorder.BeginAnimation(OpacityProperty, appearance);
        
        await Task.Delay(4100);
        
        ShivaBorder.BeginAnimation(OpacityProperty, disappearance);
        
        await Task.Delay(2500);
        
        ShivaText.Text = "Не сопротивляйся";
        ShivaBorder.BeginAnimation(OpacityProperty, appearance);
        
        await Task.Delay(4000);
        
        ShivaBorder.BeginAnimation(OpacityProperty, disappearance);
        
        await Task.Delay(777);
        ShivaText.Text = "Пидорас";
        
        await Task.Delay(8000);
        
        ShivaText.Text = "Блядота";
        ShivaBorder.BeginAnimation(OpacityProperty, fastAppearance);
        await Task.Delay(610);
        ShivaBorder.BeginAnimation(OpacityProperty, fastDisappearance);

        await Task.Delay(10000);
        ShivaText.Text = "Бу! сука";
        ShivaBorder.BeginAnimation(OpacityProperty, fastAppearance);
        await Task.Delay(610);
        ShivaBorder.BeginAnimation(OpacityProperty, fastDisappearance);
        
        await Task.Delay(26000);
        Application.Current.MainWindow!.Close();

    }

}