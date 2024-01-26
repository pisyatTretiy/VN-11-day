using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SQLite;

namespace VN
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private int history = 1;
        public Window1()
        {
            InitializeComponent();
            Prolog(history);
        }

        private void Prolog(int historytext)
        {
            switch (historytext)
            {
                case 1:
                    DisplayText("В древние времена, когда звезды еще танцевали в небесах, а магия текла как река через земли, существовали Древние Земли – место, где магия и мифы переплетались в необъятном танце. \nЗдесь, в сердце магии, росли древние деревья и таинственные храмы, хранящие в себе знания, способные изменить ход всей реальности.");
                    break;
                case 2:
                    DisplayText("Однако, со временем, в этих землях появился темный волшебник, известный как Эринор. Он жаждал власти и стремился овладеть тайнами Древних Земель, чтобы подчинить магию своей воле. \nЭринор собрал вокруг себя армию теней и проклятых существ, чтобы уничтожить все, что стояло у него на пути.");
                    break;
                case 3:
                    DisplayText("Чтобы предотвратить это зло, силы Древних Земель объединились и создали Магический Свиток – древний артефакт, способный найти того, кто сможет противостоять Эринору и спасти Древние Земли от ужаса, который им грозил.");
                    break;
                case 4:
                    DisplayText("Эларион, обычный исследователь с необычайной преданностью магии и мифам, стал тем, кто был выбран Свитком. \nСудьба сблизила его с Селеной, последней хранительницей Древних Земель, чтобы вместе остановить Эринора и сохранить мир, который они оба любили.");
                    break;
                case 5:
                    DisplayText("Так начинается их путешествие, наполненное магией, приключениями и принятием судьбы, в которой они должны сразиться со тьмой и восстановить свет в Древних Землях.");
                    AddContinueButton();
                    break;
                default:
                    MessageBox.Show("Error", "error");
                    break;
            }       
        }

        private void AddContinueButton()
        {
            Button continueButton = new Button();
            continueButton.Content = "Перейти к истории";
            continueButton.Click += ContinueButton_Click;
            Setka.Children.Add(continueButton);
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Close();
        }

        private void DisplayText(string text)
        {
            PreHistory.Text = text;
        }

        private void PreHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            history++;
            Prolog(history);
        }
    }
}
















// устал