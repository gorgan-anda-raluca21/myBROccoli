using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;

namespace myBROccoli
{
    public sealed partial class HomePage : Page
    {
        private int streakCount = 0;

        public HomePage()
        {
            this.InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            IntroStoryboard.Begin();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LoginPage));
        }

        private void DailyCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            streakCount++;
            StreakTextBlock.Text = streakCount.ToString();
            MotivationTextBlock.Text = GetMotivationalMessage();
        }

        private void DailyCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (streakCount > 0)
            {
                streakCount--;
            }

            StreakTextBlock.Text = streakCount.ToString();
            MotivationTextBlock.Text = "Progress is not about perfection. Reset, refocus and keep going.";
        }

        private string GetMotivationalMessage()
        {
            if (GoalComboBox.SelectedItem is ComboBoxItem selectedGoal)
            {
                string goal = selectedGoal.Content.ToString();

                switch (goal)
                {
                    case "Weight Loss":
                        return "Amazing job! Every healthy choice brings you closer to your weight loss goal.";
                    case "Muscle Gain":
<<<<<<< HEAD
                        return "Great work! Consistency in nutrition builds real strength.";
=======
                        return "Great work!!!!! Consistency in nutrition is what helps build real strength.";
>>>>>>> 3705b625fc15efd77c937de33dd7c6d89288a6a6
                    case "Bulking":
                        return "Well done! Smart eating and consistency make every bulking day count.";
                }
            }

            return "You're doing great. Keep showing up for yourself every day!";
        }

        private void WeightLossCard_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(WeightLossPage));
        }

        private void MuscleGainCard_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MuscleGainPage));
        }

        private void BulkingCard_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(BulkingPage));
        }

        private void Card_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            if (sender is Border border && border.RenderTransform is ScaleTransform scale)
            {
                scale.ScaleX = 1.04;
                scale.ScaleY = 1.04;
                border.BorderBrush = new SolidColorBrush(Microsoft.UI.ColorHelper.FromArgb(255, 126, 185, 117));
            }
        }

        private void Card_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (sender is Border border && border.RenderTransform is ScaleTransform scale)
            {
                scale.ScaleX = 1.0;
                scale.ScaleY = 1.0;
                border.BorderBrush = new SolidColorBrush(Microsoft.UI.ColorHelper.FromArgb(255, 221, 230, 216));
            }
        }
    }
}