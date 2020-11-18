using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Carousel
{
    public partial class MainPage : CarouselPage
    {

        int score;
        ContentPage labelContent, label2Content, label3Content, label4Content, label5Content, label6Content, label7Content;
        Label qst1, qst2, qst3, qst4, qst5, qst6, qst7, qst8, qst9, qst10, qst11, qst12, qst13, qst14, qst15,
            qst16, qst17, qst18, qst19, qst20, qst21, qst22, qst23, qst24, qst25, qst26, qst27, qst28;
        public MainPage()
        {
            score = 0;
            var tappRecon = new TapGestureRecognizer();
            tappRecon.Tapped += TappRecon_Tapped;
            var tappRecon2 = new TapGestureRecognizer();
            tappRecon2.Tapped += TappRecon2_Tapped;
            var tappRecon3 = new TapGestureRecognizer();
            tappRecon3.Tapped += TappRecon3_Tapped;
            var tappRecon4 = new TapGestureRecognizer();
            tappRecon4.Tapped += TappRecon4_Tapped;
            Label welcome = new Label
            {
                Text = "Тест на знание эстонии",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = Color.Black
            };
            qst1 = new Label
            {
                Text = "Когда день независимости эстонии?",
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
            };
            qst2 = new Label
            {
                Text = "24 февраля",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst3 = new Label
            {
                Text = "23 февраля",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst4 = new Label
            {
                Text = "24 декабря",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst5 = new Label
            {
                Text = "8 марта",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst6 = new Label
            {
                Text = "Сколько всего уездов в эстонии?",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black

            };
            qst7 = new Label
            {
                Text = "16",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst8 = new Label
            {
                Text = "10",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst9 = new Label
            {
                Text = "11",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst10 = new Label
            {
                Text = "13",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };

            qst11 = new Label
            {
                Text = "В какой части Европы расположена Эстония?",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            qst12 = new Label
            {
                Text = "В юго-западной",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst13 = new Label
            {
                Text = "В северо-восточной",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst14 = new Label
            {
                Text = "В северной",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };

            qst15 = new Label
            {
                Text = "В южной",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };

            qst16 = new Label
            {
                Text = "В каком году эстония стала частью Евросоюза?",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            qst17 = new Label
            {
                Text = "2004",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst18 = new Label
            {
                Text = "2007",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst19 = new Label
            {
                Text = "2001",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst20 = new Label
            {
                Text = "2011",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };

            qst21 = new Label
            {
                Text = "Высота церкви Олевисте в Таллинне",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = Color.Black,
                FontAttributes = FontAttributes.Bold
            };

            qst22 = new Label
            {
                Text = "214",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst23 = new Label
            {
                Text = "125",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst24 = new Label
            {
                Text = "124",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };
            qst25 = new Label
            {
                Text = "119",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            };


            labelContent = new ContentPage
            {


                Content = new StackLayout
                {

                    Children =
                    {
                       welcome
                    }
                }
            };
            label2Content = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        qst1,
                        qst2,
                        qst3,
                        qst4,
                        qst5
                    }
                }
            };
            label3Content = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        qst6, qst7, qst8, qst9, qst10
                    }
                }
            };

            label4Content = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        qst11,
                        qst12,
                        qst13,
                        qst14,
                        qst15
                    }
                }
            };

            label5Content = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        qst16,
                        qst17,
                        qst18,
                        qst19,
                        qst20
                    }
                }
            };
            label6Content = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        qst21,
                        qst22,
                        qst23,
                        qst24,
                        qst25
                    }
                }
            };

            qst2.GestureRecognizers.Add(tappRecon);
            qst3.GestureRecognizers.Add(tappRecon);
            qst4.GestureRecognizers.Add(tappRecon);
            qst5.GestureRecognizers.Add(tappRecon);

            qst7.GestureRecognizers.Add(tappRecon2);
            qst8.GestureRecognizers.Add(tappRecon2);
            qst9.GestureRecognizers.Add(tappRecon2);
            qst10.GestureRecognizers.Add(tappRecon2);

            qst12.GestureRecognizers.Add(tappRecon);
            qst13.GestureRecognizers.Add(tappRecon);
            qst14.GestureRecognizers.Add(tappRecon);
            qst15.GestureRecognizers.Add(tappRecon);

            qst17.GestureRecognizers.Add(tappRecon);
            qst18.GestureRecognizers.Add(tappRecon);
            qst19.GestureRecognizers.Add(tappRecon);
            qst20.GestureRecognizers.Add(tappRecon);

            qst22.GestureRecognizers.Add(tappRecon);
            qst23.GestureRecognizers.Add(tappRecon);
            qst24.GestureRecognizers.Add(tappRecon);
            qst25.GestureRecognizers.Add(tappRecon);



            Children.Add(labelContent);
            Children.Add(label2Content);


            void TappRecon_Tapped(object sender, EventArgs e)
            {
                Label lbl = (Label)sender;
                if (lbl.Text == "24 февраля")
                {
                    lbl.BackgroundColor = Color.Green;
                    Children.Add(label3Content);
                    label2Content.IsEnabled = false;
                    score++;
                }

                else
                {
                    lbl.BackgroundColor = Color.Red;
                    Children.Add(label3Content);

                    label3Content.IsEnabled = false;
                    label2Content.IsEnabled = false;
                }

            }
            void TappRecon2_Tapped(object sender, EventArgs e)
            {
                Label lbl = (Label)sender;
                if (lbl.Text == "13")
                {
                    lbl.BackgroundColor = Color.Green;
                    label3Content.IsEnabled = false;
                    score++;
                }
                else
                {
                    lbl.BackgroundColor = Color.Red;
                    label4Content.IsEnabled = false;

                }
                Children.Add(label4Content);

            }


            void TappRecon3_Tapped(object sender, EventArgs e)
            {
                Label lbl = (Label)sender;
                if (lbl.Text == "В северо-восточной")
                {
                    lbl.BackgroundColor = Color.Green;
                    label4Content.IsEnabled = false;
                    score++;
                }
                else
                {
                    lbl.BackgroundColor = Color.Red;
                    label4Content.IsEnabled = false;

                }
                Children.Add(label5Content);
            }

            void TappRecon4_Tapped(object sender, EventArgs e)
            {
                Label lbl = (Label)sender;
                if (lbl.Text == "2004")
                {
                    lbl.BackgroundColor = Color.Green;
                    label5Content.IsEnabled = false;
                    score++;
                }
                else
                {
                    lbl.BackgroundColor = Color.Red;
                    label5Content.IsEnabled = false;

                }
                Children.Add(label6Content);
            }
        }
    }
}
