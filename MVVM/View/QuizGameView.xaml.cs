using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Climate_Science_Quiz_Game.MVVM.View
{
    /// <summary>
    /// Interaction logic for QuizGameView.xaml
    /// </summary>
    public partial class QuizGameView : System.Windows.Controls.UserControl
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestion;
        
        public QuizGameView()
        {
            InitializeComponent();

            //PictureBox picturebox1 = new PictureBox();
            //quizClues.Child = picturebox1;
            //picturebox1.Paint += new System.Windows.Forms.PaintEventHandler(picturebox1_Paint);

            displayQuestions(questionNumber);

            totalQuestion = 6;
        }

        //void picturebox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        //{
        //    System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(@"C:\Temp\test.jpg");
        //    System.Drawing.Point ulPoint = new System.Drawing.Point(0, 0);
        //    e.Graphics.DrawImage(bmp, ulPoint);
        //}

        private void selectAnswerEvent(object sender, RoutedEventArgs e)
        {
            var senderObject = (Grid)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestion)
            {
                percentage = (int)Math.Round((double)(score * 100 / totalQuestion));


                System.Windows.MessageBox.Show(
                    "The Quiz Has Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine + 
                    "You total percentage is " + percentage + "%" + Environment.NewLine + 
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                displayQuestions(questionNumber);
            }

            questionNumber++;
            displayQuestions(questionNumber);
        }

        private void displayQuestions(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    //pictureBox1.Image = Properties.Images.beartic;
                    quizClues.Source = new BitmapImage(new Uri("/Images/plasticLitter.jpg", UriKind.Relative));
                    questionShow.Text = "What Should You Do If You See Plastic On The Floor?";

                    btn1TL.Content = "Ignore It";
                    btn2TR.Content = "Pick It Up And Throw It In The Nearest Recycling Bin";
                    btn3BL.Content = "Contact Local Authority";
                    btn4BR.Content = "Start Littering Yourself";

                    correctAnswer = 2;

                    break;

                case 2:
                    quizClues.Source = new BitmapImage(new Uri("/Images/polarBearsHome.jpg", UriKind.Relative));
                    questionShow.Text = "What Is The Main Cause of Polar Bears Losing Their Homes?";

                    btn1TL.Content = "Global Warming";
                    btn2TR.Content = "Lack of Fishes";
                    btn3BL.Content = "Snow";
                    btn4BR.Content = "All of The Above";

                    correctAnswer = 1;

                    break;

                case 3:
                    quizClues.Source = new BitmapImage(new Uri("/Images/carbonEmission.jpg", UriKind.Relative));
                    questionShow.Text = "How To Cut Down On Carbon Emission?";

                    btn1TL.Content = "Insulate Homes";
                    btn2TR.Content = "Low Carbon Travel";
                    btn3BL.Content = "Reduce, Reuse, Recycle";
                    btn4BR.Content = "All of The Above";

                    correctAnswer = 4;

                    break;

                case 4:
                    quizClues.Source = new BitmapImage(new Uri("/Images/treeCutDown.jpg", UriKind.Relative));
                    questionShow.Text = "What Gas Do Trees Release When They're Cut Down?";

                    btn1TL.Content = "Fire";
                    btn2TR.Content = "Lightning";
                    btn3BL.Content = "Carbon Dioxide";
                    btn4BR.Content = "Paper";

                    correctAnswer = 3;

                    break;

                case 5:
                    quizClues.Source = new BitmapImage(new Uri("/Images/carbonEmission.jpg", UriKind.Relative));
                    questionShow.Text = "Which One Is A Greenhouse Gas?";

                    btn1TL.Content = "Carbon Dioxide";
                    btn2TR.Content = "Methane";
                    btn3BL.Content = "Nitrous Oxide";
                    btn4BR.Content = "All of The Above";

                    correctAnswer = 4;

                    break;
                case 6:
                    quizClues.Source = new BitmapImage(new Uri("/Images/climateChanging.jpg", UriKind.Relative));
                    questionShow.Text = "What Is Cimate Science?";

                    btn1TL.Content = "Different Types of Weathers";
                    btn2TR.Content = "Understanding What Causes the Change of the Climate";
                    btn3BL.Content = "Climate Changing";
                    btn4BR.Content = "All of The Above";

                    correctAnswer = 2;

                    break;
            }
        }
    }
}
